using AniMa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace AniMa.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AdditionalInitializeComponent();

            InitializeObservableEvent();
        }

        private Settings _settings;

        private void AdditionalInitializeComponent()
        {
            AnimeListView.FullRowSelect = true;
            AnimeListView.GridLines = true;
            AnimeListView.MultiSelect = false;
            AnimeListView.View = View.Details;

            AnimeListView.ListViewItemSorter = new ListViewItemComparer();

            AnimeListView.Columns.Add("タイトル", 156);
            AnimeListView.Columns.Add("話", 36);
            AnimeListView.Columns.Add("最終更新日", 96);
            AnimeListView.Columns.Add("次回更新まで", 80);
            AnimeListView.Columns.Add("年", 40);
        }

        private IObservable<EventPattern<MouseEventArgs>> AnimeListViewMouseLeftDoubleClick => Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => h.Invoke, h => AnimeListView.MouseDoubleClick += h, h => AnimeListView.MouseDoubleClick -= h)
                .Where(x => x.EventArgs.Button == MouseButtons.Left);

        private IObservable<EventPattern<MouseEventArgs>> AnimeListViewMouseLeftClick => Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => h.Invoke, h => AnimeListView.MouseClick += h, h => AnimeListView.MouseClick -= h)
                .Where(x => x.EventArgs.Button == MouseButtons.Left)
                .Where(x => ModifierKeys == Keys.Control);

        private IObservable<ListView> AnimeListViewMouseRightDoubleClick => Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => h.Invoke, h => AnimeListView.MouseDoubleClick += h, h => AnimeListView.MouseDoubleClick -= h)
                .Where(x => x.EventArgs.Button == MouseButtons.Right)
                .Select(_ => AnimeListView);

        private IObservable<ListView> AnimeListViewMouseRightClick => Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => h.Invoke, h => AnimeListView.MouseClick += h, h => AnimeListView.MouseClick -= h)
                .Where(x => x.EventArgs.Button == MouseButtons.Right)
                .Where(x => ModifierKeys == Keys.Control)
                .Select(_ => AnimeListView);

        private IObservable<(Action<int> sorterFunc, int column, ListView view)> ColumnClick => Observable.FromEventPattern<ColumnClickEventHandler, ColumnClickEventArgs>(h => h.Invoke, h => AnimeListView.ColumnClick += h, h => AnimeListView.ColumnClick += h)
                .Select(x => (x.EventArgs.Column, View: x.Sender as ListView))
                .Select(x => (Sorter: x.View.ListViewItemSorter as ListViewItemComparer, x.Column, x.View))
                .Select(x => (SorterFunc: (ModifierKeys == Keys.Control)
                                ? (Action<int>)x.Sorter.AddOrChangePredicate
                                : x.Sorter.NewPredicateOrReverse, x.Column, x.View));

        private IObservable<Anime> SelectedIndexChanged => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => AnimeListView.SelectedIndexChanged += h, h => AnimeListView.SelectedIndexChanged -= h)
                .Select(_ => AnimeListView)
                .Where(x => x.SelectedItems.Count == 1)
                .Select(x => x.SelectedItems[0].Tag as Anime);

        private IObservable<ListView> DoneButtonClick => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => DoneButton.Click += h, h => DoneButton.Click -= h)
                .Select(_ => AnimeListView);

        private IObservable<Operation> CompleteButtonClick => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => CompleteButton.Click += h, h => CompleteButton.Click -= h)
                .Where(_ => AnimeListView.SelectedItems.Count == 1)
                .Select(_ => AnimeListView.SelectedItems[0].Tag as Anime)
                .Select(x => new Operation(OperationType.Complete, x, Anime.Complete(x)));

        private void InitializeObservableEvent()
        {
            var openPageSource = Observable.Merge(AnimeListViewMouseLeftClick, AnimeListViewMouseLeftDoubleClick)
                .Where(_ => _settings.CanOpenBrowser)
                .Select(x => x.Sender as ListView)
                .Select(x => x.SelectedItems)
                .Select(x => x[0].Tag as Anime)
                .Select(x => _settings.CreateArgument(x.URL))
                .Select(x => (Action<string>)(path => Process.Start(path, x)));

            // 視聴ページをブラウザで開く。
            openPageSource.Subscribe(x => x(_settings.OpenableBrowserPath));

            var nextStorySource = Observable.Merge(AnimeListViewMouseRightClick, AnimeListViewMouseRightDoubleClick, DoneButtonClick)
                    .Where(x => x.SelectedItems.Count == 1)
                    .Select(x => (Index: x.SelectedIndices[0], Anime: x.SelectedItems[0].Tag as Anime))
                    .Where(x => AnimeManager.CanDone(x.Anime))
                    .Select(x => (x.Index, new Operation(OperationType.Next, x.Anime, Anime.NextStory(x.Anime))));

            // 選択中のアニメを1話進める。
            nextStorySource.Subscribe(NextStory);

            void NextStory((int index, Operation op) e)
            {
                var (index, operation) = e;
                UIState = _manager.Execute(operation);

                RefreshAnimeListView();
                SelectItemIfSameTitle(index, operation.NewAnime.Title);
                DoneButton.Enabled = Models.AnimeManager.CanDone(operation.NewAnime);

                void SelectItemIfSameTitle(int index, string prevItemTitle)
                {
                    if (index >= AnimeListView.Items.Count) return;
                    // indexが有効な値であればitemを取得する。
                    var item = AnimeListView.Items[index];
                    // 同じアニメなら選択された状態にする。
                    item.Selected = item.Tag is Anime anime && anime.Title == prevItemTitle;
                }
            }

            // AnimeListViewのColumnClickイベントでAnimeListViewを押された項目でソートする。
            ColumnClick.Subscribe(SortByColumn);

            static void SortByColumn((Action<int> sorterFunc, int column, ListView view) input)
            {
                var (sorterFunc, column, view) = input;
                sorterFunc(column);
                view.Sort();
            }

            // AnimeListViewのSelectedIndexChangedイベントでDoneButtonが有効か無効かを変える
            SelectedIndexChanged.Subscribe(x => DoneButton.Enabled = Models.AnimeManager.CanDone(x));

            // AnimeListViewのSelectedIndexChangedイベントでDeleteMenuItemとCompleteButtonが有効か無効かを変える
            SelectedIndexChanged.Subscribe(x => DeleteToolStripMenuItem.Enabled = CompleteButton.Enabled = true);

            // AnimeListViewのSelectedIndexChangedイベントでEditButtonが有効か無効かを変える
            SelectedIndexChanged.Subscribe(x => EditButton.Enabled = true);

            // アニメをリストから削除する
            CompleteButtonClick.Subscribe(DeleteAnime);

            void DeleteAnime(Operation op)
            {
                UIState = _manager.Execute(op);
                RefreshAnimeListView();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _settings = Settings.Load(Settings.SettingsPath);
            UseFilterCheckBox.Checked = _settings.UseFilter;
            RefreshAnimeListView();
        }

        private readonly AnimeManager _manager = new();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settings.UseFilter = UseFilterCheckBox.Checked;
            Settings.Save(Settings.SettingsPath, _settings);
            _manager.Save();
        }

        private void HideCheckBox_CheckedChanged(object sender, EventArgs e) => RefreshAnimeListView();

        private void RefreshAnimeListView()
        {
            RefreshAnimeListView(UseFilterCheckBox.Checked);

            void RefreshAnimeListView(bool useFilter)
            {
                var animes = useFilter
                    ? _manager.Animes.Where(a => a.IsStreamingNow)
                    : _manager.Animes;

                RefreshListView(animes);
                AdjustHeight();

                UnableDelete();
                UnableDone();
                UnableEdit();

                void RefreshListView(IEnumerable<Anime> animes)
                {
                    AnimeListView.Items.Clear();
                    AnimeListView.Items.AddRange(animes.Select(CreateListViewItemFromAnime).ToArray());
                    AnimeListView.Sort();

                    // Capture this.
                    ListViewItem CreateListViewItemFromAnime(Anime anime)
                    {
                        var item = new ListViewItem { Tag = anime, Text = anime.Title };
                        item.SubItems.AddRange(Enumerable.Range(1, AnimeListView.Columns.Count).Select(anime.GetSubItemString).ToArray());
                        return item;
                    }
                }

                void AdjustHeight()
                {
                    var diff = AnimeListView.Items.Count * 16 + 28 - AnimeListView.Height;
                    Height += diff;
                }

                void UnableDelete() => (DeleteToolStripMenuItem.Enabled, CompleteButton.Enabled) = (false, false);
                void UnableDone() => DoneButton.Enabled = false;
                void UnableEdit() => EditButton.Enabled = false;
            }
        }

        private void AddAnimeLabel_Click(object sender, EventArgs e)
        {
            using AddAnimeForm addAnimeForm = new(AddNewAnime);
            addAnimeForm.ShowDialog();

            void AddNewAnime(Anime anime)
            {
                _manager.AddAnime(anime);
                RefreshAnimeListView();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (AnimeListView.SelectedItems.Count != 1)
            {
                return;
            }

            var oldAnime = AnimeListView.SelectedItems[0].Tag as Anime;
            using EditForm editForm = new(oldAnime)
            {
                StartPosition = FormStartPosition.CenterParent,
            };
            editForm.ShowDialog();
            var newAnime = editForm.Result;

            UIState = _manager.Execute(new Operation(OperationType.Edit, oldAnime, newAnime));

            RefreshAnimeListView();
        }

        private void ExploreButton_Click(object sender, EventArgs e)
        {
            ExploleForm.ShowForm(AddAnimeAction);

            void AddAnimeAction(List<Anime> animes)
            {
                animes.ForEach(_manager.AddAnime);
                RefreshAnimeListView();
            }
        }

        private void SettingsEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SettingsForm form = new(_settings);
            form.ShowDialog();

            _settings = Settings.Load(Settings.SettingsPath);
        }

        private void AboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using AboutForm form = new();
            form.ShowDialog();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIState = _manager.Undo();
            RefreshAnimeListView();
        }

        Models.AnimeManager.UIState UIState
        {
            set => (UndoToolStripMenuItem.Enabled, RedoToolStripMenuItem.Enabled) = value;
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIState = _manager.Redo();
            RefreshAnimeListView();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AnimeListView.SelectedItems.Count != 1)
            {
                return;
            }

            var anime = AnimeListView.SelectedItems[0].Tag as Anime;
            UIState = _manager.Execute(new(OperationType.Complete, anime, Anime.Complete(anime)));
            RefreshAnimeListView();
        }

        private void OpenNewAnimeListButton_Click(object sender, EventArgs e)
        {
            NewAnimeListForm form = new(_manager, RefreshAnimeListView);
            form.Show();
        }
    }
}
