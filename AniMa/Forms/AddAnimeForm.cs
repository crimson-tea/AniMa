using AniMa.Models;
using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AniMa.Forms
{
    public partial class AddAnimeForm : Form
    {
        internal AddAnimeForm(Action<Anime> addAnime)
        {
            InitializeComponent();
            _addAnime = addAnime;

            EscapeKeyDown.Subscribe(_ => Close());
        }

        private IObservable<EventPattern<KeyEventArgs>> EscapeKeyDown => Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(h => h.Invoke, h => KeyDown += h, h => KeyDown -= h)
                .Where(x => x.EventArgs.KeyCode == Keys.Escape)
                .Do(x => x.EventArgs.Handled = true);

        internal Action<Anime> _addAnime;

        private void AddButton_Click(object sender, EventArgs e)
        {
            var res = UrlRegex().Match(UrlTextBox.Text);
            if (res.Success is false)
            {
                return;
            }

            var anime = CreateAnime(res.Value, TitleTextBox.Text);
            _addAnime(anime);

            Clear();
        }

        private Anime CreateAnime(string url, string text)
        {
            var title = text.Contains('|') ? text[..text.LastIndexOf('|')].Trim() : text.Trim();
            return new Anime(title, url, (int)LatestNumberNumericUpDown.Value, (int)LeftDaysNumericUpDown.Value, new TimeSpan(), 2023);
        }

        private void Clear()
        {
            TitleTextBox.Clear();
            UrlTextBox.Clear();
            LatestNumberNumericUpDown.Value = 1;
        }

        [GeneratedRegex("https://abema.tv/video/episode/.*_p")]
        private static partial Regex UrlRegex();
    }
}
