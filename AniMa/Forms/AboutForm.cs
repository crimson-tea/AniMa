using System;
using System.Diagnostics;
using System.IO;
using System.Reactive;
using System.Reactive.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AniMa.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            InitializeLicense();

            EscapeKeyDown.Subscribe(_ => Close());
            SelectedIndexChanged.Subscribe(SetLicense);

            LibraryListBox.SelectedIndex = 0;

            VersionLabel.Text = GetVersion();

            void InitializeLicense()
            {
                LibraryListBox.Items.AddRange(_libraries);
            }

            static string GetVersion()
            {
                var asm = Assembly.GetExecutingAssembly();
                var asmName = asm.GetName();
                return asmName.Version.ToString();
            }
        }

        private IObservable<EventPattern<KeyEventArgs>> EscapeKeyDown => Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(h => h.Invoke, h => KeyDown += h, h => KeyDown -= h)
                .Where(x => x.EventArgs.KeyCode == Keys.Escape)
                .Do(x => x.EventArgs.Handled = true);

        private void SetLicense(string library)
        {
            LibraryLinkLabel.LinkVisited = false;
            LibraryLinkLabel.Text = GetUrl(library);
            LicenseRichTextBox.Text = GetLicenseText(library);
        }

        private IObservable<string> SelectedIndexChanged => Observable.FromEventPattern<EventHandler, EventArgs>(h => h.Invoke, h => LibraryListBox.SelectedIndexChanged += h, h => LibraryListBox.SelectedIndexChanged -= h)
                 .Where(_ => LibraryListBox.SelectedIndex >= 0)
                 .Select(_ => LibraryListBox.SelectedItem as string)
                 .Do(x => LibraryLinkLabel.Text = GetUrl(x))
                 .Do(x => LicenseRichTextBox.Text = GetLicenseText(x));

        private static readonly string[] _libraries = new string[]
        {
            "MemoryPack",
            "Reactive Extensions",
        };

        private static readonly string _memoryPackLicense =
            """
                        MIT License

            Copyright (c) 2022 Cysharp, Inc.

            Permission is hereby granted, free of charge, to any person obtaining a copy
            of this software and associated documentation files (the "Software"), to deal
            in the Software without restriction, including without limitation the rights
            to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
            copies of the Software, and to permit persons to whom the Software is
            furnished to do so, subject to the following conditions:

            The above copyright notice and this permission notice shall be included in all
            copies or substantial portions of the Software.

            THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
            IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
            FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
            AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
            LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
            OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
            SOFTWARE.
            """;

        private static readonly string _reactiveExtensionsLicense =
            """
                        The MIT License (MIT)

            Copyright (c) .NET Foundation and Contributors

            All rights reserved.

            Permission is hereby granted, free of charge, to any person obtaining a copy
            of this software and associated documentation files (the "Software"), to deal
            in the Software without restriction, including without limitation the rights
            to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
            copies of the Software, and to permit persons to whom the Software is
            furnished to do so, subject to the following conditions:

            The above copyright notice and this permission notice shall be included in all
            copies or substantial portions of the Software.

            THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
            IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
            FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
            AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
            LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
            OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
            SOFTWARE.
            """;

        private static string GetUrl(string library) => library switch
        {
            "MemoryPack" => "https://github.com/Cysharp/MemoryPack",
            "Reactive Extensions" => "https://github.com/dotnet/reactive",
            _ => string.Empty,
        };

        private static string GetLicenseText(string library) => library switch
        {
            "MemoryPack" => _memoryPackLicense,
            "Reactive Extensions" => _reactiveExtensionsLicense,
            _ => string.Empty,
        };

        private readonly string _edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

        private void LibraryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            var link = linkLabel.Text;
            linkLabel.LinkVisited = true;

            if (Path.Exists(_edgePath))
            {
                Process.Start(_edgePath, link);
            }
        }
    }
}
