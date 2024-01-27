using AniMa;
using AniMa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniMa.Forms
{
    public partial class NewAnimeListForm : Form
    {
        private static readonly HttpClient s_client = new();
        private readonly AnimeManager _manager;
        private readonly Action _refreshList;

        public NewAnimeListForm(AnimeManager manager, Action refreshList)
        {
            _manager = manager;
            _refreshList = refreshList;

            InitializeComponent();
            AdditionalInitializeComponent();
            InitializeObserver();
        }

        private IObservable<ListView> SelectedIndexChanged => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => NewAnimeListView.SelectedIndexChanged += h, h => NewAnimeListView.SelectedIndexChanged -= h)
            .Select(_ => NewAnimeListView);
        private IObservable<CheckBox> HideOldEpisodeCheckedChanged => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => HideAnimeWithSpend7DaysCheckBox.CheckedChanged += h, h => HideAnimeWithSpend7DaysCheckBox.CheckedChanged -= h)
            .Select(_ => HideAnimeWithSpend7DaysCheckBox);
        private IObservable<CheckBox> HideRegisteredCheckedChanged => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => HideRegisteredWatchIdCheckBox.CheckedChanged += h, h => HideRegisteredWatchIdCheckBox.CheckedChanged -= h)
            .Select(_ => HideAnimeWithSpend7DaysCheckBox);
        private IObservable<CheckBox> DuplicateCheckedChanged => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => ShowMinNumberIfDuplicateWatchIdCheckBox.CheckedChanged += h, h => ShowMinNumberIfDuplicateWatchIdCheckBox.CheckedChanged -= h)
            .Select(_ => ShowMinNumberIfDuplicateWatchIdCheckBox);

        private IObservable<ListView> RegisteredListSelectedIndexChanged => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => RegisteredAnimeListView.SelectedIndexChanged += h, h => RegisteredAnimeListView.SelectedIndexChanged -= h)
            .Select(_ => RegisteredAnimeListView);

        private void InitializeObserver()
        {
            _ = SelectedIndexChanged
                .Select(x => x.SelectedIndices.Count != 0)
                .Subscribe(x => AddAnimeButton.Enabled = x);

            _ = HideOldEpisodeCheckedChanged.Subscribe(x => RefreshList());

            _ = HideRegisteredCheckedChanged.Subscribe(x => RefreshList());

            _ = RegisteredListSelectedIndexChanged
                .Select(x => x.SelectedIndices.Count != 0)
                .Subscribe(x => UpdateDateTimeButton.Enabled = x);

            _ = DuplicateCheckedChanged.Subscribe(x => RefreshList());
        }

        private void AdditionalInitializeComponent()
        {
            InitializeListView(NewAnimeListView);
            InitializeListView(RegisteredAnimeListView);

            void InitializeListView(ListView listView)
            {
                listView.FullRowSelect = true;
                listView.GridLines = true;
                listView.MultiSelect = true;
                listView.View = View.Details;

                listView.ListViewItemSorter = new ListViewItemComparer();

                listView.Columns.Add("作品名", 250);
                listView.Columns.Add("話", 30);
                listView.Columns.Add("配信開始日時", 120);
            }
        }

        private readonly List<ListViewItem> _list = new();

        private void RefreshNewListView()
        {
            RefreshListView(HideAnimeWithSpend7DaysCheckBox.Checked, HideRegisteredWatchIdCheckBox.Checked, ShowMinNumberIfDuplicateWatchIdCheckBox.Checked);

            void RefreshListView(bool hiddenSpent7Days, bool hideRegistered, bool showMinNumberIfDuplicate)
            {
                NewAnimeListView.Items.Clear();
                var query = _list
                    .Where(x => hiddenSpent7Days is false || ((Anime)x.Tag).StartAt > DateTime.Now - new TimeSpan(7, 0, 0, 0))
                    .Where(x => hideRegistered is false || IsUnregisteredAnime((Anime)x.Tag))
                    .Where(x => IsNewAnime(x.Tag as Anime));
                if (showMinNumberIfDuplicate)
                {
                    query = query.DistinctBy(x => ((Anime)x.Tag).WatchId);
                }
                query.ToList().ForEach(x => NewAnimeListView.Items.Add(x));
            }
        }

        private bool IsUnregisteredAnime(Anime anime) => _manager.ExistByWatchId(anime) is false;

        private bool IsNewAnime(Anime anime) => _manager.Exist(anime) is false && _manager.ExistMoreThanNumberOfEpisodes(anime) is false;

        private void RefreshRegisteredListView()
        {
            RefreshListView(HideAnimeWithSpend7DaysCheckBox.Checked);

            void RefreshListView(bool hiddenSpent7Days)
            {
                RegisteredAnimeListView.Items.Clear();
                _list
                    .Where(x => hiddenSpent7Days is false || ((Anime)x.Tag).StartAt > DateTime.Now - new TimeSpan(7, 0, 0, 0))
                    .Where(x => _manager.Exist(x.Tag as Anime))
                    .Where(x => _manager.IsSameDateTime(x.Tag as Anime) is false)
                    .ToList()
                    .ForEach(x => RegisteredAnimeListView.Items.Add(x));
            }
        }

        private async void NewAnimeListForm_Load(object sender, EventArgs e)
        {
            (bool success, AnimeData[] animesData) = await GetAnimesData();
            if (success)
            {
                tabControl1.Enabled = true;
                Text += $" - 取得成功";
                _list.AddRange(animesData.Select(animeData =>
                {
                    var anime = new Anime(animeData.DisplayName, animeData.WatchId, DateTime.UnixEpoch.AddMilliseconds(animeData.StartAt * 1000).ToLocalTime(), animeData.NumberOfEpisodes);
                    return new ListViewItem(new string[] { anime.Title, anime.NumberOfEpisodes.ToString(), anime.StartAt.ToString() }) { Tag = anime };
                }));
                RefreshList();
            }
            else
            {
                tabControl1.Enabled = false;

                Stopwatch sw = Stopwatch.StartNew();
                double timeLimitSeconds = 3.0;

                while (sw.Elapsed.TotalSeconds < timeLimitSeconds)
                {
                    Text = $"情報を取得できませんでした。 {timeLimitSeconds - sw.Elapsed.Seconds:0}秒後に閉じます。";
                    await Task.Delay(34);
                }

                Close();
            }

            async Task<(bool success, AnimeData[])> GetAnimesData()
            {
                try
                {
                    var animesData = await s_client.GetFromJsonAsync<AnimeData[]>("https://webapplicationanimeapi20240127122823.azurewebsites.net/Anime/");
                    return (true, animesData);
                }
                catch (Exception)
                {
                    return (false, Array.Empty<AnimeData>());
                }
            }
        }

        private void AddAnimeButton_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list = [];
            foreach (ListViewItem item in NewAnimeListView.SelectedItems)
            {
                var anime = (Anime)item.Tag;
                _manager.AddAnime(anime);
                list.Add(item);
            }

            list.ForEach(x => _list.Remove(x));

            RefreshList();
            _refreshList();
        }

        private void RefreshList()
        {
            RefreshNewListView();
            RefreshRegisteredListView();
        }

        private void UpdateDateTimeButton_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list = [];
            foreach (ListViewItem item in RegisteredAnimeListView.SelectedItems)
            {
                var anime = (Anime)item.Tag;
                _manager.UpdateDateTime(anime);
                list.Add(item);
            }

            list.ForEach(x => _list.Remove(x));

            RefreshList();
            _refreshList();
        }
    }

    public record AnimeData(string DisplayName, string WatchId, string WatchUrl, long StartAt, int NumberOfEpisodes);
}
