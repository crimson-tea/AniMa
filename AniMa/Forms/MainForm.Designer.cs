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
            this.AddAnimeLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.AnimeListView = new System.Windows.Forms.ListView();
            this.UseFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.ExploreButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddAnimeLabel
            // 
            this.AddAnimeLabel.AutoSize = true;
            this.AddAnimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAnimeLabel.Location = new System.Drawing.Point(11, 28);
            this.AddAnimeLabel.Name = "AddAnimeLabel";
            this.AddAnimeLabel.Size = new System.Drawing.Size(58, 12);
            this.AddAnimeLabel.TabIndex = 1;
            this.AddAnimeLabel.Text = "AnimeList:";
            this.AddAnimeLabel.Click += new System.EventHandler(this.AddAnimeLabel_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DoneButton.Enabled = false;
            this.DoneButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoneButton.Location = new System.Drawing.Point(11, 373);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(90, 23);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "視聴済み(&N)";
            this.DoneButton.UseVisualStyleBackColor = true;
            // 
            // CompleteButton
            // 
            this.CompleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompleteButton.Location = new System.Drawing.Point(334, 373);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(89, 23);
            this.CompleteButton.TabIndex = 3;
            this.CompleteButton.Text = "削除(&D)";
            this.CompleteButton.UseVisualStyleBackColor = true;
            // 
            // AnimeListView
            // 
            this.AnimeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimeListView.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimeListView.Location = new System.Drawing.Point(11, 43);
            this.AnimeListView.Name = "AnimeListView";
            this.AnimeListView.Size = new System.Drawing.Size(412, 324);
            this.AnimeListView.TabIndex = 4;
            this.AnimeListView.UseCompatibleStateImageBehavior = false;
            // 
            // UseFilterCheckBox
            // 
            this.UseFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseFilterCheckBox.AutoSize = true;
            this.UseFilterCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UseFilterCheckBox.Location = new System.Drawing.Point(243, 27);
            this.UseFilterCheckBox.Name = "UseFilterCheckBox";
            this.UseFilterCheckBox.Size = new System.Drawing.Size(181, 16);
            this.UseFilterCheckBox.TabIndex = 7;
            this.UseFilterCheckBox.Text = "最終更新から7日間のみ表示(&H)";
            this.UseFilterCheckBox.UseVisualStyleBackColor = true;
            this.UseFilterCheckBox.CheckedChanged += new System.EventHandler(this.HideCheckBox_CheckedChanged);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(239, 373);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(89, 23);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "詳細編集(&M)...";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ExploreButton
            // 
            this.ExploreButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExploreButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExploreButton.Location = new System.Drawing.Point(10, 402);
            this.ExploreButton.Name = "ExploreButton";
            this.ExploreButton.Size = new System.Drawing.Size(413, 23);
            this.ExploreButton.TabIndex = 14;
            this.ExploreButton.Text = "アニメを探す(&O)...";
            this.ExploreButton.UseVisualStyleBackColor = true;
            this.ExploreButton.Click += new System.EventHandler(this.ExploreButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.SettingsEToolStripMenuItem,
            this.AboutAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.toolStripSeparator1,
            this.DeleteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.EditToolStripMenuItem.Text = "編集(&E)";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.UndoToolStripMenuItem.Text = "元に戻す";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Enabled = false;
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.RedoToolStripMenuItem.Text = "やり直す";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.DeleteToolStripMenuItem.Text = "削除";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SettingsEToolStripMenuItem
            // 
            this.SettingsEToolStripMenuItem.Name = "SettingsEToolStripMenuItem";
            this.SettingsEToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.SettingsEToolStripMenuItem.Text = "設定(&S)...";
            this.SettingsEToolStripMenuItem.Click += new System.EventHandler(this.SettingsEToolStripMenuItem_Click);
            // 
            // AboutAToolStripMenuItem
            // 
            this.AboutAToolStripMenuItem.Name = "AboutAToolStripMenuItem";
            this.AboutAToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.AboutAToolStripMenuItem.Text = "About(&A)...";
            this.AboutAToolStripMenuItem.Click += new System.EventHandler(this.AboutAToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 437);
            this.Controls.Add(this.ExploreButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.UseFilterCheckBox);
            this.Controls.Add(this.AnimeListView);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.AddAnimeLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AnimeManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

