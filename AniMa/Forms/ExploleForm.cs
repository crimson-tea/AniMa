#nullable enable
using AniMa.JsonObjects;
using AniMa.Models;
using JsonObjects;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Concurrent;
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
        private readonly ConcurrentDictionary<string, IncludeSlot> _includes = new();
        private readonly ConcurrentDictionary<string, EpisodeGroups> _episodes = new();

        private async void CoreWebView2_WebResourceResponseReceived(object? sender, CoreWebView2WebResourceResponseReceivedEventArgs e)
        {
            var (request, response) = (e.Request, e.Response);

            const string apiUrl = $"{"https"}://api.p-c3-e.abema-tv.com/v1/video";

            if (request.Uri.StartsWith(apiUrl) is false) return;

            if (!response.Headers.Contains("content-type") || response.Headers.GetHeaders("content-type").Current.Value != "application/json") return;

            Stream? content = await GetContent(response);

            if (content is null) return;

            var json = await DecodeToJsonAsync(content);

            string id = AddInfoToListOrDictionary(json);
            if (string.IsNullOrWhiteSpace(id))
            {
                return;
            }

            if (_includes.TryGetValue(id, out IncludeSlot include) is false || _episodes.TryGetValue(id, out EpisodeGroups episode) is false)
            {
                return;
            }

            AddInfoToListIfNeeded(include, episode);

            string AddInfoToListOrDictionary(string json)
            {
                if (TryJsonToObject<ProgramObject>(json) is ProgramObject programObject)
                {
                    if (programObject.programs?.FirstOrDefault()?.series is null) return string.Empty;

                    var (title, seriesCount) = GetInfo(programObject);

                    if (string.IsNullOrWhiteSpace(title) || _uniqueTitles.Contains(title)) return string.Empty;
                    var anime = ToAnime(programObject);
                    if (anime is null) return string.Empty;

                    _uniqueTitles.Add(title);
                    var item = new ListViewItem(new string[] { title, seriesCount.ToString() }) { Tag = anime };
                    AnimeListView.Items.Add(item);
                    AnimeListView.Items[^1].EnsureVisible();
                }
                else if (TryJsonToObject<IncludeSlot>(json) is IncludeSlot includeSlot)
                {
                    if (includeSlot.seasons.FirstOrDefault() is null) return string.Empty;

                    var (title, _) = GetInfo(includeSlot);

                    if (string.IsNullOrWhiteSpace(title)) return string.Empty;

                    var id = GetId(includeSlot);
                    _ = _includes.TryAdd(id, includeSlot);

                    return id;
                }
                else if (TryJsonToObject<EpisodeGroups>(json) is EpisodeGroups groups)
                {
                    if (groups?.episodeGroupContents?.FirstOrDefault() is null) return string.Empty;

                    var (_, count) = GetInfo(groups);

                    if (count == 0) return string.Empty;

                    string id = GetId(groups);
                    _ = _episodes.TryAdd(id, groups);

                    return id;
                }

                return string.Empty;
            }

            static (string? title, int seriesCount) GetInfo(object obj) => obj switch
            {
                ProgramObject p => (p.programs.First().series.title, p.programs.Length),
                IncludeSlot s => (s.seasons.LastOrDefault()?.name, s.seasons.Last().sequence),
                EpisodeGroups g => (string.Empty, g.episodeGroupContents.Length),
                _ => ("", 0)
            };
        }

        private void AddInfoToListIfNeeded(IncludeSlot include, EpisodeGroups episode)
        {
            var anime = ToAnime(include, episode);
            if (anime is null) return;
            if (_uniqueTitles.Contains(anime.Title)) return;
            _uniqueTitles.Contains(anime.Title);

            _uniqueTitles.Add(anime.Title);
            var item = new ListViewItem(new string[] { anime.Title, anime.CurrentStory.ToString() }) { Tag = anime };
            AnimeListView.Items.Add(item);
            AnimeListView.Items[^1].EnsureVisible();
        }

        private static string GetId(IncludeSlot includeSlot)
        {
            return includeSlot.seasons.Last().id;
        }

        private static string GetId(EpisodeGroups groups)
        {
            var episodeId = groups.episodeGroupContents.First().id;
            int lastP = episodeId.LastIndexOf('p');

            return episodeId[..(lastP - 1)];
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
                    EpisodeGroups x => x?.episodeGroupContents is not null && x.episodeGroupContents.Length > 0,
                    IncludeSlot x => x?.seasons is not null,
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
                Anime? anime = item.Tag as Anime;

                if (anime is not null)
                {
                    animes.Add(anime);
                }
            }

            AnimeListView.Items.Clear();
            _addAnimeAction(animes);
        }

        /// <summary>
        /// IncludeSlot と EpisodeGroups から Anime を作成します。
        /// </summary>
        /// <param name="info"></param>
        private static Anime ToAnime(IncludeSlot info, EpisodeGroups episode)
        {
            var newSeason = info.seasons.Last();
            var title = GetTitle(info.title, newSeason.name);
            var id = newSeason.id;
            var url = $"https://abema.tv/video/episode/{id}_p";

            var storiesCount = episode.episodeGroupContents.Length;
            var leftDays = CalcLeftDays(episode.episodeGroupContents.Last().video.terms.Last().endAt);
            var year = episode.episodeGroupContents.Last().video.releaseYear;

            return new Anime(title, url, storiesCount, leftDays % 7, TimeSpan.Zero, DateTime.Now.Year);

            static string GetTitle(string title, string seasonName)
            {
                var season = new string[] { "シーズン", "Season", "本編", };

                if (season.Any(seasonName.StartsWith))
                {
                    return title;
                }
                return seasonName;
            }
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
            var leftDays = CalcLeftDays(info.programs[currentStory - 1].freeEndAt);
            int year = Math.Max(1950, firstProgram.credit.released);

            return new Anime(firstProgram.series.title, url, currentStory, leftDays % 7, TimeSpan.Zero, year);
        }

        private static int CalcLeftDays(int freeEndAt)
        {
            var endAt = DateTimeOffset.FromUnixTimeSeconds(freeEndAt).LocalDateTime;
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
