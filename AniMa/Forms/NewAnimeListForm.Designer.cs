namespace AniMa.Forms
{
    partial class NewAnimeListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewAnimeListView = new System.Windows.Forms.ListView();
            AddAnimeButton = new System.Windows.Forms.Button();
            HideAnimeWithSpend7DaysCheckBox = new System.Windows.Forms.CheckBox();
            ShowMinNumberIfDuplicateWatchIdCheckBox = new System.Windows.Forms.CheckBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            UpdateDateTimeButton = new System.Windows.Forms.Button();
            RegisteredAnimeListView = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            HideRegisteredWatchIdCheckBox = new System.Windows.Forms.CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // NewAnimeListView
            // 
            NewAnimeListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            NewAnimeListView.Location = new System.Drawing.Point(0, 0);
            NewAnimeListView.Name = "NewAnimeListView";
            NewAnimeListView.Size = new System.Drawing.Size(427, 353);
            NewAnimeListView.TabIndex = 0;
            NewAnimeListView.UseCompatibleStateImageBehavior = false;
            NewAnimeListView.View = System.Windows.Forms.View.Details;
            // 
            // AddAnimeButton
            // 
            AddAnimeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            AddAnimeButton.Enabled = false;
            AddAnimeButton.Location = new System.Drawing.Point(3, 359);
            AddAnimeButton.Name = "AddAnimeButton";
            AddAnimeButton.Size = new System.Drawing.Size(421, 23);
            AddAnimeButton.TabIndex = 2;
            AddAnimeButton.Text = "追加";
            AddAnimeButton.UseVisualStyleBackColor = true;
            AddAnimeButton.Click += AddAnimeButton_Click;
            // 
            // HideAnimeWithSpend7DaysCheckBox
            // 
            HideAnimeWithSpend7DaysCheckBox.AutoSize = true;
            HideAnimeWithSpend7DaysCheckBox.Checked = true;
            HideAnimeWithSpend7DaysCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            HideAnimeWithSpend7DaysCheckBox.Location = new System.Drawing.Point(104, 8);
            HideAnimeWithSpend7DaysCheckBox.Name = "HideAnimeWithSpend7DaysCheckBox";
            HideAnimeWithSpend7DaysCheckBox.Size = new System.Drawing.Size(259, 19);
            HideAnimeWithSpend7DaysCheckBox.TabIndex = 3;
            HideAnimeWithSpend7DaysCheckBox.Text = "配信開始から1週間以上経過したアニメを非表示";
            HideAnimeWithSpend7DaysCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowMinNumberIfDuplicateWatchIdCheckBox
            // 
            ShowMinNumberIfDuplicateWatchIdCheckBox.AutoSize = true;
            ShowMinNumberIfDuplicateWatchIdCheckBox.Checked = true;
            ShowMinNumberIfDuplicateWatchIdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            ShowMinNumberIfDuplicateWatchIdCheckBox.Location = new System.Drawing.Point(104, 46);
            ShowMinNumberIfDuplicateWatchIdCheckBox.Name = "ShowMinNumberIfDuplicateWatchIdCheckBox";
            ShowMinNumberIfDuplicateWatchIdCheckBox.Size = new System.Drawing.Size(320, 19);
            ShowMinNumberIfDuplicateWatchIdCheckBox.TabIndex = 4;
            ShowMinNumberIfDuplicateWatchIdCheckBox.Text = "同作品情報が複数がある場合は話数が最も小さいものを表示";
            ShowMinNumberIfDuplicateWatchIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Enabled = false;
            tabControl1.Location = new System.Drawing.Point(12, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(435, 413);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.SystemColors.Control;
            tabPage1.Controls.Add(AddAnimeButton);
            tabPage1.Controls.Add(NewAnimeListView);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(427, 385);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "新規追加";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.SystemColors.Control;
            tabPage2.Controls.Add(UpdateDateTimeButton);
            tabPage2.Controls.Add(RegisteredAnimeListView);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(427, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "日時更新";
            // 
            // UpdateDateTimeButton
            // 
            UpdateDateTimeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            UpdateDateTimeButton.Enabled = false;
            UpdateDateTimeButton.Location = new System.Drawing.Point(3, 376);
            UpdateDateTimeButton.Name = "UpdateDateTimeButton";
            UpdateDateTimeButton.Size = new System.Drawing.Size(421, 23);
            UpdateDateTimeButton.TabIndex = 4;
            UpdateDateTimeButton.Text = "日時情報更新";
            UpdateDateTimeButton.UseVisualStyleBackColor = true;
            UpdateDateTimeButton.Click += UpdateDateTimeButton_Click;
            // 
            // RegisteredAnimeListView
            // 
            RegisteredAnimeListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RegisteredAnimeListView.Location = new System.Drawing.Point(0, 0);
            RegisteredAnimeListView.Name = "RegisteredAnimeListView";
            RegisteredAnimeListView.Size = new System.Drawing.Size(427, 370);
            RegisteredAnimeListView.TabIndex = 3;
            RegisteredAnimeListView.UseCompatibleStateImageBehavior = false;
            RegisteredAnimeListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "NewAnimeList:";
            // 
            // HideRegisteredWatchIdCheckBox
            // 
            HideRegisteredWatchIdCheckBox.AutoSize = true;
            HideRegisteredWatchIdCheckBox.Checked = true;
            HideRegisteredWatchIdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            HideRegisteredWatchIdCheckBox.Location = new System.Drawing.Point(104, 27);
            HideRegisteredWatchIdCheckBox.Name = "HideRegisteredWatchIdCheckBox";
            HideRegisteredWatchIdCheckBox.Size = new System.Drawing.Size(198, 19);
            HideRegisteredWatchIdCheckBox.TabIndex = 6;
            HideRegisteredWatchIdCheckBox.Text = "登録済み作品の話数違いを非表示";
            HideRegisteredWatchIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewAnimeListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(456, 496);
            Controls.Add(HideRegisteredWatchIdCheckBox);
            Controls.Add(tabControl1);
            Controls.Add(ShowMinNumberIfDuplicateWatchIdCheckBox);
            Controls.Add(HideAnimeWithSpend7DaysCheckBox);
            Controls.Add(label1);
            Name = "NewAnimeListForm";
            Text = "NewAnimeListForm";
            Load += NewAnimeListForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView NewAnimeListView;
        private System.Windows.Forms.Button AddAnimeButton;
        private System.Windows.Forms.CheckBox HideAnimeWithSpend7DaysCheckBox;
        private System.Windows.Forms.CheckBox ShowMinNumberIfDuplicateWatchIdCheckBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateDateTimeButton;
        private System.Windows.Forms.ListView RegisteredAnimeListView;
        private System.Windows.Forms.CheckBox HideRegisteredWatchIdCheckBox;
    }
}