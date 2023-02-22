#nullable enable
using AniMa.JsonObjects;
using AniMa.Models;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniMa.Forms
{
    public partial class ExploleForm : Form
    {
        public static void ShowForm(Action<List<Anime>> addAnimeAction)
        {
            var form = new ExploleForm(addAnimeAction);
            form.Show();
        }

        private readonly Action<List<Anime>> _addAnimeAction;
        private IObservable<(ListBox?, object?)> UrlListBoxSelectedIndexChanged => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => UrlListBox.SelectedIndexChanged += h, h => UrlListBox.SelectedIndexChanged += h)
                .Sample(TimeSpan.FromSeconds(2.5))
                .Select(x => x.Sender as ListBox)
                .Where(x => x is not null)
                .ObserveOn(SynchronizationContext.Current) // メインスレッドに処理を戻す。
                .Select(x => (Listbox: x, x?.SelectedItem))
                .Where(x => x.Listbox?.SelectedItem is not null);

        private ExploleForm(Action<List<Anime>> addAnimeAction)
        {
            InitializeComponent();
            InitAnimeListView();

            _addAnimeAction = addAnimeAction;

            WebView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            UrlListBoxSelectedIndexChanged.Subscribe(Sub);

            void Sub((ListBox? listBox, object? item) a)
            {
                if (a.listBox is null || a.item is null)
                {
                    return;
                }

                var (list, item) = a;
                list.Items.Remove(item);

                WebView.CoreWebView2.Navigate(item as string);
            }
        }

        private void InitAnimeListView()
        {
            AnimeListView.AllowDrop = true;
            AnimeListView.FullRowSelect = true;
            AnimeListView.GridLines = true;
            AnimeListView.MultiSelect = true;
            AnimeListView.View = View.Details;

            AnimeListView.Columns.Add("Title");
            AnimeListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            WebView.CoreWebView2.WebResourceResponseReceived += CoreWebView2_WebResourceResponseReceived;
            WebView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private readonly HashSet<string> _urls = new();
        private void CoreWebView2_NewWindowRequested(object? sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
            if (_urls.Contains(e.Uri) is false)
            {
                _urls.Add(e.Uri);
                UrlListBox.Items.Add(e.Uri);
            }
        }

        private readonly HashSet<string> _uniqueTitles = new();

        async void CoreWebView2_WebResourceResponseReceived(object? sender, CoreWebView2WebResourceResponseReceivedEventArgs e)
        {
            var (request, response) = (e.Request, e.Response);

            const string apiUrl = $"{"https"}://api.p-c3-e.abema-tv.com/v1/video";

            if (request.Uri.StartsWith(apiUrl) is false) return;

            if (!response.Headers.Contains("content-type") || response.Headers.GetHeaders("content-type").Current.Value != "application/json") return;

            Stream? content = await GetContent(response);

            if (content is null) return;

            var json = await DecodeToJsonAsync(content);

            var programObject = TryJsonToObject<ProgramObject>(json);

            if (programObject is null) return;
            if (programObject.programs?.FirstOrDefault()?.series is null) return;

            var (title, seriesCount) = GetInfo(programObject);

            if (title == "" || _uniqueTitles.Contains(title)) return;

            _uniqueTitles.Add(title);
            var item = new ListViewItem(new string[] { title, seriesCount.ToString() }) { Tag = programObject };
            AnimeListView.Items.Add(item);
            AnimeListView.Items[^1].EnsureVisible();

            static (string title, int seriesCount) GetInfo(object obj) => obj switch
            {
                ProgramObject p => (p.programs.First().series.title, p.programs.Length),
                _ => ("", 0)
            };
        }

        private static async Task<Stream?> GetContent(CoreWebView2WebResourceResponseView response)
        {
            try
            {
                return await response.GetContentAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// デシリアライズに成功したときのみnullでないオブジェクトを返します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static T? TryJsonToObject<T>(string json) where T : class
        {
            try
            {
                var des = JsonSerializer.Deserialize<T>(json);
                var success = des switch
                {
                    ProgramObject x => x?.programs is not null,
                    _ => false
                };
                return success ? des : null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static async Task<string> DecodeToJsonAsync(Stream content)
        {
            MemoryStream ms = new();
            await content.CopyToAsync(ms);
            var json = Encoding.UTF8.GetString(ms.ToArray());
            return json;
        }

        private void AnimeListView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data?.GetData(DataFormats.Text) is string dropped)
            {
                WebView.CoreWebView2.Navigate(dropped);
            }
        }

        private void AnimeListView_DragEnter(object sender, DragEventArgs e) =>
            e.Effect = e.Data?.GetDataPresent(DataFormats.Text) is true ? DragDropEffects.Copy : DragDropEffects.None;

        private void AnimeListView_SizeChanged(object sender, EventArgs e)
        {
            var view = (ListView)sender;
            // 縮めてから伸ばすことで水平方向のスクロールバーが出ることを防ぐ。
            // 垂直方向のスクロールバーが出ても水平方向のスクロールバーが出ない幅に調整する。
            view.Columns[0].Width = view.Size.Width - 21 - 1;
            view.Columns[0].Width = view.Size.Width - 21;
        }

        private void AddAnimeButton_Click(object sender, EventArgs e)
        {
            List<Anime> animes = new();

            foreach (ListViewItem item in AnimeListView.Items)
            {
                Anime? anime = item.Tag switch
                {
                    ProgramObject info => ToAnime(info),
                    _ => null,
                };

                if (anime is not null)
                {
                    animes.Add(anime);
                }
            }

            AnimeListView.Items.Clear();
            _addAnimeAction(animes);
        }

        /// <summary>
        /// jsonObjectからAnimeを作成します。
        /// </summary>
        /// <param name="info"></param>
        /// <returns>必要な情報が得られなかった場合はnullを返します。</returns>
        private static Anime? ToAnime(ProgramObject info)
        {
            if (info.programs.Length == 0)
            {
                return null;
            }

            var firstProgram = info.programs.First();
            var idBase = IdNumberPattern().Match(firstProgram.id).Groups["Id"]?.Value;
            if (string.IsNullOrWhiteSpace(idBase))
            {
                return null;
            }

            var numbers = info.programs.Select(x => x.id)
                .Select(x => IdNumberPattern().Match(x).Groups["Number"].Value)
                .Select(int.Parse)
                .ToArray();

            // PVのみのときも1を保証しておく
            var currentStory = numbers.Prepend(1).Zip(numbers.Prepend(0).Prepend(0))
                .Where(x => Math.Abs(x.First - x.Second) == 1)
                .Select(x => x.First).Max();

            if (currentStory - 1 >= info.programs.Length)
            {
                return null;
            }

            var url = $"https://abema.tv/video/episode/{idBase}";
            var leftDays = CalcLeftDays(info.programs[currentStory - 1]);
            int year = Math.Max(1950, firstProgram.credit.released);

            return new Anime(firstProgram.series.title, url, currentStory, leftDays % 7, TimeSpan.Zero, year);
        }

        private static int CalcLeftDays(JsonObjects.Program latestProgram)
        {
            var endAt = DateTimeOffset.FromUnixTimeSeconds(latestProgram.freeEndAt).LocalDateTime;
            return Math.Max((endAt - DateTime.Now).Days, -1);
        }

        private void ClearUrlsButton_Click(object sender, EventArgs e) => UrlListBox.Items.Clear();

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in AnimeListView.SelectedItems)
            {
                AnimeListView.Items.Remove(item);
            }
        }

        [GeneratedRegex("(?<Id>.*_p)(?<Number>\\d*)")]
        private static partial Regex IdNumberPattern();
    }
}
