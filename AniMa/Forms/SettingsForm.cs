using AniMa.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace AniMa.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(Settings settings)
        {
            InitializeComponent();

            BrowserPathTextBox.Text = settings.BrowserPath;
            ArgumentTextBox.Text = settings.Argument;

            EscapeKeyDown.Subscribe(_ => Close());
        }

        private IObservable<EventPattern<KeyEventArgs>> EscapeKeyDown => Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(h => h.Invoke, h => KeyDown += h, h => KeyDown -= h)
                .Where(x => x.EventArgs.KeyCode == Keys.Escape)
                .Do(x => x.EventArgs.Handled = true);

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var settings = new Settings() { BrowserPath = BrowserPathTextBox.Text, Argument = ArgumentTextBox.Text };
            Settings.Save(Settings.SettingsPath, settings);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Multiselect = false,
                AddExtension = true,
                Filter = "実行ファイル|*.exe",
                Title = "使用するブラウザを選択してください。",
                SelectReadOnly = true,
                InitialDirectory = Directory.Exists(Path.GetDirectoryName(BrowserPathTextBox.Text)) ? Path.GetDirectoryName(BrowserPathTextBox.Text) : string.Empty,
            };

            if (ofd.ShowDialog() is DialogResult.OK)
            {
                BrowserPathTextBox.Text = ofd.FileName;
            }
        }
    }
}
