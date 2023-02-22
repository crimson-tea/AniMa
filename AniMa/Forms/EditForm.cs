using AniMa.Models;
using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace AniMa.Forms
{
    public partial class EditForm : Form
    {
        public EditForm(Anime anime)
        {
            InitializeComponent();
            Result = anime;

            EscapeKeyDown.Subscribe(_ => Close());
        }

        private IObservable<EventPattern<KeyEventArgs>> EscapeKeyDown => Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(h => h.Invoke, h => KeyDown += h, h => KeyDown -= h)
                .Where(x => x.EventArgs.KeyCode == Keys.Escape)
                .Do(x => x.EventArgs.Handled = true);

        private Anime _result;
        public Anime Result
        {
            get => _result;
            set => Update(_result = value);
        }

        private void Update(Anime anime)
        {
            DateTextBox.Text = anime.FirstEpisodeRelease.ToString();
            LatestEpisodeTextBox.Text = anime.CurrentStory.ToString();
            ReleaseYearNumericUpDown.Value = anime.Year;
        }

        private void PrevDayButton_Click(object sender, EventArgs e) =>
            Result = Result with { FirstEpisodeRelease = Result.FirstEpisodeRelease - new TimeSpan(1, 0, 0, 0) };

        private void NextDayButton_Click(object sender, EventArgs e) =>
            Result = Result with { FirstEpisodeRelease = Result.FirstEpisodeRelease + new TimeSpan(1, 0, 0, 0) };

        private void PrevWeekButton_Click(object sender, EventArgs e) =>
            Result = Result with { FirstEpisodeRelease = Result.FirstEpisodeRelease - new TimeSpan(7, 0, 0, 0) };

        private void NextWeekButton_Click(object sender, EventArgs e) =>
            Result = Result with { FirstEpisodeRelease = Result.FirstEpisodeRelease + new TimeSpan(7, 0, 0, 0) };

        const int MIN_STORY = 1;
        const int MAX_STORY = 9999;

        private void EPNumPrevButton_Click(object sender, EventArgs e) =>
            Result = Result with { CurrentStory = Math.Max(Result.CurrentStory - 1, MIN_STORY) };

        private void EPNumNextButton_Click(object sender, EventArgs e) =>
            Result = Result with { CurrentStory = Math.Min(Result.CurrentStory + 1, MAX_STORY) };

        private void SetOneButton_Click(object sender, EventArgs e) =>
            Result = Result with { CurrentStory = 1 };

        private void Set12Button_Click(object sender, EventArgs e) =>
            Result = Result with { CurrentStory = 12 };

        private void ReleaseYearNumericUpDown_ValueChanged(object sender, EventArgs e) =>
            Result = Result with { Year = (int)(sender as NumericUpDown).Value };
    }
}
