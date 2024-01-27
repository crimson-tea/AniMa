namespace AniMa.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            AddAnimeLabel = new System.Windows.Forms.Label();
            DoneButton = new System.Windows.Forms.Button();
            CompleteButton = new System.Windows.Forms.Button();
            AnimeListView = new System.Windows.Forms.ListView();
            UseFilterCheckBox = new System.Windows.Forms.CheckBox();
            EditButton = new System.Windows.Forms.Button();
            ExploreButton = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SettingsEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            OpenNewAnimeListButton = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // AddAnimeLabel
            // 
            AddAnimeLabel.AutoSize = true;
            AddAnimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            AddAnimeLabel.Location = new System.Drawing.Point(11, 28);
            AddAnimeLabel.Name = "AddAnimeLabel";
            AddAnimeLabel.Size = new System.Drawing.Size(58, 12);
            AddAnimeLabel.TabIndex = 1;
            AddAnimeLabel.Text = "AnimeList:";
            AddAnimeLabel.Click += AddAnimeLabel_Click;
            // 
            // DoneButton
            // 
            DoneButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            DoneButton.Enabled = false;
            DoneButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            DoneButton.Location = new System.Drawing.Point(10, 373);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new System.Drawing.Size(98, 23);
            DoneButton.TabIndex = 2;
            DoneButton.Text = "視聴済み(&N)";
            DoneButton.UseVisualStyleBackColor = true;
            // 
            // CompleteButton
            // 
            CompleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            CompleteButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            CompleteButton.Location = new System.Drawing.Point(325, 373);
            CompleteButton.Name = "CompleteButton";
            CompleteButton.Size = new System.Drawing.Size(98, 23);
            CompleteButton.TabIndex = 3;
            CompleteButton.Text = "削除(&D)";
            CompleteButton.UseVisualStyleBackColor = true;
            // 
            // AnimeListView
            // 
            AnimeListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            AnimeListView.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            AnimeListView.Location = new System.Drawing.Point(11, 43);
            AnimeListView.Name = "AnimeListView";
            AnimeListView.Size = new System.Drawing.Size(412, 324);
            AnimeListView.TabIndex = 4;
            AnimeListView.UseCompatibleStateImageBehavior = false;
            // 
            // UseFilterCheckBox
            // 
            UseFilterCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            UseFilterCheckBox.AutoSize = true;
            UseFilterCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            UseFilterCheckBox.Location = new System.Drawing.Point(243, 27);
            UseFilterCheckBox.Name = "UseFilterCheckBox";
            UseFilterCheckBox.Size = new System.Drawing.Size(181, 16);
            UseFilterCheckBox.TabIndex = 7;
            UseFilterCheckBox.Text = "最終更新から7日間のみ表示(&H)";
            UseFilterCheckBox.UseVisualStyleBackColor = true;
            UseFilterCheckBox.CheckedChanged += HideCheckBox_CheckedChanged;
            // 
            // EditButton
            // 
            EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            EditButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            EditButton.Location = new System.Drawing.Point(220, 373);
            EditButton.Name = "EditButton";
            EditButton.Size = new System.Drawing.Size(98, 23);
            EditButton.TabIndex = 11;
            EditButton.Text = "詳細編集(&M)...";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ExploreButton
            // 
            ExploreButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ExploreButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            ExploreButton.Location = new System.Drawing.Point(10, 402);
            ExploreButton.Name = "ExploreButton";
            ExploreButton.Size = new System.Drawing.Size(203, 23);
            ExploreButton.TabIndex = 14;
            ExploreButton.Text = "ブラウザでアニメを探す(&O)...";
            ExploreButton.UseVisualStyleBackColor = true;
            ExploreButton.Click += ExploreButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { EditToolStripMenuItem, SettingsEToolStripMenuItem, AboutAToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(434, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { UndoToolStripMenuItem, RedoToolStripMenuItem, toolStripSeparator1, DeleteToolStripMenuItem });
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            EditToolStripMenuItem.Text = "編集(&E)";
            // 
            // UndoToolStripMenuItem
            // 
            UndoToolStripMenuItem.Enabled = false;
            UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            UndoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            UndoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            UndoToolStripMenuItem.Text = "元に戻す";
            UndoToolStripMenuItem.Click += UndoToolStripMenuItem_Click;
            // 
            // RedoToolStripMenuItem
            // 
            RedoToolStripMenuItem.Enabled = false;
            RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            RedoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y;
            RedoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            RedoToolStripMenuItem.Text = "やり直す";
            RedoToolStripMenuItem.Click += RedoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            DeleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            DeleteToolStripMenuItem.Text = "削除";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // SettingsEToolStripMenuItem
            // 
            SettingsEToolStripMenuItem.Name = "SettingsEToolStripMenuItem";
            SettingsEToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            SettingsEToolStripMenuItem.Text = "設定(&S)...";
            SettingsEToolStripMenuItem.Click += SettingsEToolStripMenuItem_Click;
            // 
            // AboutAToolStripMenuItem
            // 
            AboutAToolStripMenuItem.Name = "AboutAToolStripMenuItem";
            AboutAToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            AboutAToolStripMenuItem.Text = "About(&A)...";
            AboutAToolStripMenuItem.Click += AboutAToolStripMenuItem_Click;
            // 
            // OpenNewAnimeListButton
            // 
            OpenNewAnimeListButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            OpenNewAnimeListButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            OpenNewAnimeListButton.Location = new System.Drawing.Point(220, 402);
            OpenNewAnimeListButton.Name = "OpenNewAnimeListButton";
            OpenNewAnimeListButton.Size = new System.Drawing.Size(203, 23);
            OpenNewAnimeListButton.TabIndex = 17;
            OpenNewAnimeListButton.Text = "新作アニメを探す(&F)...";
            OpenNewAnimeListButton.UseVisualStyleBackColor = true;
            OpenNewAnimeListButton.Click += OpenNewAnimeListButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 437);
            Controls.Add(OpenNewAnimeListButton);
            Controls.Add(ExploreButton);
            Controls.Add(EditButton);
            Controls.Add(UseFilterCheckBox);
            Controls.Add(AnimeListView);
            Controls.Add(CompleteButton);
            Controls.Add(DoneButton);
            Controls.Add(AddAnimeLabel);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("MS UI Gothic", 9F);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "AniMa";
            FormClosing += Form1_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label AddAnimeLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.ListView AnimeListView;
        private System.Windows.Forms.CheckBox UseFilterCheckBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ExploreButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button OpenNewAnimeListButton;
    }
}

