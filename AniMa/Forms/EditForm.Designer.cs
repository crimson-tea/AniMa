namespace AniMa.Forms
{
    partial class EditForm
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
            PrevDayButton = new System.Windows.Forms.Button();
            NextDayButton = new System.Windows.Forms.Button();
            DateTextBox = new System.Windows.Forms.TextBox();
            PrevWeekButton = new System.Windows.Forms.Button();
            NextWeekButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            ReleaseYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            groupBox5 = new System.Windows.Forms.GroupBox();
            TitleTextBox = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            NextSeasonButton = new System.Windows.Forms.Button();
            NextEpisodeButton = new System.Windows.Forms.Button();
            PrevSeasonButton = new System.Windows.Forms.Button();
            NumberOfEpisodesTextBox = new System.Windows.Forms.TextBox();
            PrevEpisodeButton = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReleaseYearNumericUpDown).BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // PrevDayButton
            // 
            PrevDayButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            PrevDayButton.Location = new System.Drawing.Point(64, 50);
            PrevDayButton.Margin = new System.Windows.Forms.Padding(4);
            PrevDayButton.Name = "PrevDayButton";
            PrevDayButton.Size = new System.Drawing.Size(31, 29);
            PrevDayButton.TabIndex = 2;
            PrevDayButton.Text = "<";
            PrevDayButton.UseVisualStyleBackColor = true;
            PrevDayButton.Click += PrevDayButton_Click;
            // 
            // NextDayButton
            // 
            NextDayButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            NextDayButton.Location = new System.Drawing.Point(101, 50);
            NextDayButton.Margin = new System.Windows.Forms.Padding(4);
            NextDayButton.Name = "NextDayButton";
            NextDayButton.Size = new System.Drawing.Size(31, 29);
            NextDayButton.TabIndex = 3;
            NextDayButton.Text = ">";
            NextDayButton.UseVisualStyleBackColor = true;
            NextDayButton.Click += NextDayButton_Click;
            // 
            // DateTextBox
            // 
            DateTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            DateTextBox.Location = new System.Drawing.Point(7, 23);
            DateTextBox.Margin = new System.Windows.Forms.Padding(4);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.ReadOnly = true;
            DateTextBox.Size = new System.Drawing.Size(182, 19);
            DateTextBox.TabIndex = 0;
            DateTextBox.TabStop = false;
            // 
            // PrevWeekButton
            // 
            PrevWeekButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            PrevWeekButton.Location = new System.Drawing.Point(7, 50);
            PrevWeekButton.Margin = new System.Windows.Forms.Padding(4);
            PrevWeekButton.Name = "PrevWeekButton";
            PrevWeekButton.Size = new System.Drawing.Size(49, 29);
            PrevWeekButton.TabIndex = 1;
            PrevWeekButton.Text = "<<";
            PrevWeekButton.UseVisualStyleBackColor = true;
            PrevWeekButton.Click += PrevWeekButton_Click;
            // 
            // NextWeekButton
            // 
            NextWeekButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            NextWeekButton.Location = new System.Drawing.Point(140, 50);
            NextWeekButton.Margin = new System.Windows.Forms.Padding(4);
            NextWeekButton.Name = "NextWeekButton";
            NextWeekButton.Size = new System.Drawing.Size(49, 29);
            NextWeekButton.TabIndex = 4;
            NextWeekButton.Text = ">>";
            NextWeekButton.UseVisualStyleBackColor = true;
            NextWeekButton.Click += NextWeekButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DateTextBox);
            groupBox1.Controls.Add(NextWeekButton);
            groupBox1.Controls.Add(PrevDayButton);
            groupBox1.Controls.Add(PrevWeekButton);
            groupBox1.Controls.Add(NextDayButton);
            groupBox1.Location = new System.Drawing.Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(197, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "更新日時:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ReleaseYearNumericUpDown);
            groupBox2.Location = new System.Drawing.Point(12, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(197, 56);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "リリース年:";
            // 
            // ReleaseYearNumericUpDown
            // 
            ReleaseYearNumericUpDown.Location = new System.Drawing.Point(6, 22);
            ReleaseYearNumericUpDown.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            ReleaseYearNumericUpDown.Name = "ReleaseYearNumericUpDown";
            ReleaseYearNumericUpDown.Size = new System.Drawing.Size(183, 23);
            ReleaseYearNumericUpDown.TabIndex = 9;
            ReleaseYearNumericUpDown.ValueChanged += ReleaseYearNumericUpDown_ValueChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(TitleTextBox);
            groupBox5.Location = new System.Drawing.Point(12, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(197, 53);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "作品名:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            TitleTextBox.Location = new System.Drawing.Point(7, 23);
            TitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new System.Drawing.Size(182, 19);
            TitleTextBox.TabIndex = 8;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(NextSeasonButton);
            groupBox4.Controls.Add(NextEpisodeButton);
            groupBox4.Controls.Add(PrevSeasonButton);
            groupBox4.Controls.Add(NumberOfEpisodesTextBox);
            groupBox4.Controls.Add(PrevEpisodeButton);
            groupBox4.Location = new System.Drawing.Point(12, 165);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(197, 60);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "話数:";
            // 
            // NextSeasonButton
            // 
            NextSeasonButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            NextSeasonButton.Location = new System.Drawing.Point(163, 21);
            NextSeasonButton.Name = "NextSeasonButton";
            NextSeasonButton.Size = new System.Drawing.Size(27, 29);
            NextSeasonButton.TabIndex = 8;
            NextSeasonButton.Text = ">>";
            NextSeasonButton.UseVisualStyleBackColor = true;
            NextSeasonButton.Click += NextSeasonButton_Click;
            // 
            // NextEpisodeButton
            // 
            NextEpisodeButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            NextEpisodeButton.Location = new System.Drawing.Point(129, 21);
            NextEpisodeButton.Margin = new System.Windows.Forms.Padding(4);
            NextEpisodeButton.Name = "NextEpisodeButton";
            NextEpisodeButton.Size = new System.Drawing.Size(27, 29);
            NextEpisodeButton.TabIndex = 7;
            NextEpisodeButton.Text = ">";
            NextEpisodeButton.UseVisualStyleBackColor = true;
            NextEpisodeButton.Click += NextEpisodeButton_Click;
            // 
            // PrevSeasonButton
            // 
            PrevSeasonButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            PrevSeasonButton.Location = new System.Drawing.Point(7, 21);
            PrevSeasonButton.Name = "PrevSeasonButton";
            PrevSeasonButton.Size = new System.Drawing.Size(27, 29);
            PrevSeasonButton.TabIndex = 5;
            PrevSeasonButton.Text = "<<";
            PrevSeasonButton.UseVisualStyleBackColor = true;
            PrevSeasonButton.Click += PrevSeasonButton_Click;
            // 
            // NumberOfEpisodesTextBox
            // 
            NumberOfEpisodesTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            NumberOfEpisodesTextBox.Location = new System.Drawing.Point(77, 26);
            NumberOfEpisodesTextBox.Margin = new System.Windows.Forms.Padding(4);
            NumberOfEpisodesTextBox.Name = "NumberOfEpisodesTextBox";
            NumberOfEpisodesTextBox.ReadOnly = true;
            NumberOfEpisodesTextBox.Size = new System.Drawing.Size(44, 19);
            NumberOfEpisodesTextBox.TabIndex = 2;
            // 
            // PrevEpisodeButton
            // 
            PrevEpisodeButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            PrevEpisodeButton.Location = new System.Drawing.Point(41, 21);
            PrevEpisodeButton.Margin = new System.Windows.Forms.Padding(4);
            PrevEpisodeButton.Name = "PrevEpisodeButton";
            PrevEpisodeButton.Size = new System.Drawing.Size(27, 29);
            PrevEpisodeButton.TabIndex = 6;
            PrevEpisodeButton.Text = "<";
            PrevEpisodeButton.UseVisualStyleBackColor = true;
            PrevEpisodeButton.Click += PrevEpisodeButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(222, 296);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "EditForm";
            Text = "EditForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReleaseYearNumericUpDown).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button PrevDayButton;
        private System.Windows.Forms.Button NextDayButton;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button PrevWeekButton;
        private System.Windows.Forms.Button NextWeekButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ReleaseYearNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button NextSeasonButton;
        private System.Windows.Forms.Button NextEpisodeButton;
        private System.Windows.Forms.Button PrevSeasonButton;
        private System.Windows.Forms.TextBox NumberOfEpisodesTextBox;
        private System.Windows.Forms.Button PrevEpisodeButton;
    }
}