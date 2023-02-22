using System.Windows.Forms;

namespace AniMa.Forms
{   
    partial class ExploleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.AnimeListView = new System.Windows.Forms.ListView();
            this.UrlListBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.AddAnimeButton = new System.Windows.Forms.Button();
            this.ClearUrlsButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebView
            // 
            this.WebView.AllowExternalDrop = true;
            this.WebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebView.CreationProperties = null;
            this.WebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebView.Location = new System.Drawing.Point(0, 188);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(1144, 563);
            this.WebView.Source = new System.Uri("https://abema.tv/video/genre/animation", System.UriKind.Absolute);
            this.WebView.TabIndex = 0;
            this.WebView.ZoomFactor = 1D;
            this.WebView.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.WebView_CoreWebView2InitializationCompleted);
            this.WebView.DragDrop += new System.Windows.Forms.DragEventHandler(this.AnimeListView_DragDrop);
            this.WebView.DragEnter += new System.Windows.Forms.DragEventHandler(this.AnimeListView_DragEnter);
            // 
            // AnimeListView
            // 
            this.AnimeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimeListView.Location = new System.Drawing.Point(0, 0);
            this.AnimeListView.Name = "AnimeListView";
            this.AnimeListView.Size = new System.Drawing.Size(653, 154);
            this.AnimeListView.TabIndex = 1;
            this.AnimeListView.UseCompatibleStateImageBehavior = false;
            this.AnimeListView.SizeChanged += new System.EventHandler(this.AnimeListView_SizeChanged);
            this.AnimeListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.AnimeListView_DragDrop);
            this.AnimeListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.AnimeListView_DragEnter);
            // 
            // UrlListBox
            // 
            this.UrlListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlListBox.FormattingEnabled = true;
            this.UrlListBox.ItemHeight = 15;
            this.UrlListBox.Location = new System.Drawing.Point(0, 0);
            this.UrlListBox.Name = "UrlListBox";
            this.UrlListBox.Size = new System.Drawing.Size(483, 154);
            this.UrlListBox.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.splitContainer1.Panel1.Controls.Add(this.AnimeListView);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.splitContainer1.Panel2.Controls.Add(this.UrlListBox);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1144, 154);
            this.splitContainer1.SplitterDistance = 653;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 154);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 597);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // AddAnimeButton
            // 
            this.AddAnimeButton.Location = new System.Drawing.Point(12, 160);
            this.AddAnimeButton.Name = "AddAnimeButton";
            this.AddAnimeButton.Size = new System.Drawing.Size(122, 22);
            this.AddAnimeButton.TabIndex = 6;
            this.AddAnimeButton.Text = "すべてのアニメを追加";
            this.AddAnimeButton.UseVisualStyleBackColor = true;
            this.AddAnimeButton.Click += new System.EventHandler(this.AddAnimeButton_Click);
            // 
            // ClearUrlsButton
            // 
            this.ClearUrlsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearUrlsButton.Location = new System.Drawing.Point(1002, 160);
            this.ClearUrlsButton.Name = "ClearUrlsButton";
            this.ClearUrlsButton.Size = new System.Drawing.Size(130, 22);
            this.ClearUrlsButton.TabIndex = 7;
            this.ClearUrlsButton.Text = "すべてのUrlを削除";
            this.ClearUrlsButton.UseVisualStyleBackColor = true;
            this.ClearUrlsButton.Click += new System.EventHandler(this.ClearUrlsButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(140, 160);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(122, 22);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "選択したアニメを削除";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ExploleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 751);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ClearUrlsButton);
            this.Controls.Add(this.AddAnimeButton);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.WebView);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "ExploleForm";
            this.Text = "ExploreForm";
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
        private ListView AnimeListView;
        private ListBox UrlListBox;
        private SplitContainer splitContainer1;
        private Splitter splitter1;
        private Button AddAnimeButton;
        private Button ClearUrlsButton;
        private Button RemoveButton;
    }
}