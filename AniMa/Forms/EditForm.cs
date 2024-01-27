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
            TitleTextBox.Text = anime.Title;
            DateTextBox.Text = anime.StartAt.ToString();
            NumberOfEpisodesTextBox.Text = anime.NumberOfEpisodes.ToString();
            ReleaseYearNumericUpDown.Value = anime.Year;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e) =>
            Result = Result with { Title = (sender as TextBox).Text };

        private void PrevDayButton_Click(object sender, EventArgs e) =>
            Result = Result with { StartAt = Result.StartAt - new TimeSpan(1, 0, 0, 0) };

        private void NextDayButton_Click(object sender, EventArgs e) =>
            Result = Result with { StartAt = Result.StartAt + new TimeSpan(1, 0, 0, 0) };

        private void PrevWeekButton_Click(object sender, EventArgs e) =>
            Result = Result with { StartAt = Result.StartAt - new TimeSpan(7, 0, 0, 0) };

        private void NextWeekButton_Click(object sender, EventArgs e) =>
            Result = Result with { StartAt = Result.StartAt + new TimeSpan(7, 0, 0, 0) };

        const int MIN_STORY = 1;
        const int MAX_STORY = 9999;

        private void ReleaseYearNumericUpDown_ValueChanged(object sender, EventArgs e) =>
            Result = Result with { Year = (int)(sender as NumericUpDown).Value };

        private void PrevSeasonButton_Click(object sender, EventArgs e) =>
            Result = Result with { NumberOfEpisodes = PreviousSeason(Result.NumberOfEpisodes) };

        private int PreviousSeason(int currentStory)
        {
            return PreviousSeason(currentStory - 1);
            static int PreviousSeason(int currentStory) => Math.Max((currentStory - 1) / 12 * 12 + 1, MIN_STORY);
        }

        private void PrevEpisodeButton_Click(object sender, EventArgs e) =>
            Result = Result with { NumberOfEpisodes = Math.Max(Result.NumberOfEpisodes - 1, MIN_STORY) };

        private void NextEpisodeButton_Click(object sender, EventArgs e) =>
            Result = Result with { NumberOfEpisodes = Math.Min(Result.NumberOfEpisodes + 1, MAX_STORY) };

        private void NextSeasonButton_Click(object sender, EventArgs e) =>
            Result = Result with { NumberOfEpisodes = NextSeason(Result.NumberOfEpisodes) };

        private int NextSeason(int currentStory)
        {
            return NextSeason(currentStory - 1);
            static int NextSeason(int currentStory) => Math.Min((((currentStory) / 12 + 1) * 12) + 1, MAX_STORY);
        }
    }
}
