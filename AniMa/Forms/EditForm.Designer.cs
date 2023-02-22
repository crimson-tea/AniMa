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
            this.PrevDayButton = new System.Windows.Forms.Button();
            this.NextDayButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.EPNumPrevButton = new System.Windows.Forms.Button();
            this.LatestEpisodeTextBox = new System.Windows.Forms.TextBox();
            this.EPNumNextButton = new System.Windows.Forms.Button();
            this.PrevWeekButton = new System.Windows.Forms.Button();
            this.NextWeekButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Set12Button = new System.Windows.Forms.Button();
            this.Set1Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReleaseYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseYearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PrevDayButton
            // 
            this.PrevDayButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrevDayButton.Location = new System.Drawing.Point(64, 50);
            this.PrevDayButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrevDayButton.Name = "PrevDayButton";
            this.PrevDayButton.Size = new System.Drawing.Size(31, 29);
            this.PrevDayButton.TabIndex = 2;
            this.PrevDayButton.Text = "<";
            this.PrevDayButton.UseVisualStyleBackColor = true;
            this.PrevDayButton.Click += new System.EventHandler(this.PrevDayButton_Click);
            // 
            // NextDayButton
            // 
            this.NextDayButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextDayButton.Location = new System.Drawing.Point(101, 50);
            this.NextDayButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextDayButton.Name = "NextDayButton";
            this.NextDayButton.Size = new System.Drawing.Size(31, 29);
            this.NextDayButton.TabIndex = 3;
            this.NextDayButton.Text = ">";
            this.NextDayButton.UseVisualStyleBackColor = true;
            this.NextDayButton.Click += new System.EventHandler(this.NextDayButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(16, 432);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(111, 432);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 414);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day:";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTextBox.Location = new System.Drawing.Point(7, 23);
            this.DateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.ReadOnly = true;
            this.DateTextBox.Size = new System.Drawing.Size(182, 19);
            this.DateTextBox.TabIndex = 0;
            this.DateTextBox.TabStop = false;
            // 
            // EPNumPrevButton
            // 
            this.EPNumPrevButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EPNumPrevButton.Location = new System.Drawing.Point(7, 50);
            this.EPNumPrevButton.Margin = new System.Windows.Forms.Padding(4);
            this.EPNumPrevButton.Name = "EPNumPrevButton";
            this.EPNumPrevButton.Size = new System.Drawing.Size(88, 29);
            this.EPNumPrevButton.TabIndex = 7;
            this.EPNumPrevButton.Text = "戻す";
            this.EPNumPrevButton.UseVisualStyleBackColor = true;
            this.EPNumPrevButton.Click += new System.EventHandler(this.EPNumPrevButton_Click);
            // 
            // LatestEpisodeTextBox
            // 
            this.LatestEpisodeTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LatestEpisodeTextBox.Location = new System.Drawing.Point(63, 25);
            this.LatestEpisodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LatestEpisodeTextBox.Name = "LatestEpisodeTextBox";
            this.LatestEpisodeTextBox.ReadOnly = true;
            this.LatestEpisodeTextBox.Size = new System.Drawing.Size(70, 19);
            this.LatestEpisodeTextBox.TabIndex = 2;
            this.LatestEpisodeTextBox.TabStop = false;
            // 
            // EPNumNextButton
            // 
            this.EPNumNextButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EPNumNextButton.Location = new System.Drawing.Point(101, 50);
            this.EPNumNextButton.Margin = new System.Windows.Forms.Padding(4);
            this.EPNumNextButton.Name = "EPNumNextButton";
            this.EPNumNextButton.Size = new System.Drawing.Size(88, 29);
            this.EPNumNextButton.TabIndex = 8;
            this.EPNumNextButton.Text = "進める";
            this.EPNumNextButton.UseVisualStyleBackColor = true;
            this.EPNumNextButton.Click += new System.EventHandler(this.EPNumNextButton_Click);
            // 
            // PrevWeekButton
            // 
            this.PrevWeekButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrevWeekButton.Location = new System.Drawing.Point(7, 50);
            this.PrevWeekButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrevWeekButton.Name = "PrevWeekButton";
            this.PrevWeekButton.Size = new System.Drawing.Size(49, 29);
            this.PrevWeekButton.TabIndex = 1;
            this.PrevWeekButton.Text = "<<";
            this.PrevWeekButton.UseVisualStyleBackColor = true;
            this.PrevWeekButton.Click += new System.EventHandler(this.PrevWeekButton_Click);
            // 
            // NextWeekButton
            // 
            this.NextWeekButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextWeekButton.Location = new System.Drawing.Point(140, 50);
            this.NextWeekButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextWeekButton.Name = "NextWeekButton";
            this.NextWeekButton.Size = new System.Drawing.Size(49, 29);
            this.NextWeekButton.TabIndex = 4;
            this.NextWeekButton.Text = ">>";
            this.NextWeekButton.UseVisualStyleBackColor = true;
            this.NextWeekButton.Click += new System.EventHandler(this.NextWeekButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateTextBox);
            this.groupBox1.Controls.Add(this.NextWeekButton);
            this.groupBox1.Controls.Add(this.PrevDayButton);
            this.groupBox1.Controls.Add(this.PrevWeekButton);
            this.groupBox1.Controls.Add(this.NextDayButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1話更新日:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Set12Button);
            this.groupBox3.Controls.Add(this.Set1Button);
            this.groupBox3.Controls.Add(this.LatestEpisodeTextBox);
            this.groupBox3.Controls.Add(this.EPNumPrevButton);
            this.groupBox3.Controls.Add(this.EPNumNextButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 89);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "現在の話数:";
            // 
            // Set12Button
            // 
            this.Set12Button.Location = new System.Drawing.Point(140, 22);
            this.Set12Button.Name = "Set12Button";
            this.Set12Button.Size = new System.Drawing.Size(49, 23);
            this.Set12Button.TabIndex = 6;
            this.Set12Button.Text = "12";
            this.Set12Button.UseVisualStyleBackColor = true;
            this.Set12Button.Click += new System.EventHandler(this.Set12Button_Click);
            // 
            // Set1Button
            // 
            this.Set1Button.Location = new System.Drawing.Point(7, 22);
            this.Set1Button.Name = "Set1Button";
            this.Set1Button.Size = new System.Drawing.Size(49, 23);
            this.Set1Button.TabIndex = 5;
            this.Set1Button.Text = "1";
            this.Set1Button.UseVisualStyleBackColor = true;
            this.Set1Button.Click += new System.EventHandler(this.SetOneButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReleaseYearNumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "リリース年:";
            // 
            // ReleaseYearNumericUpDown
            // 
            this.ReleaseYearNumericUpDown.Location = new System.Drawing.Point(6, 22);
            this.ReleaseYearNumericUpDown.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.ReleaseYearNumericUpDown.Name = "ReleaseYearNumericUpDown";
            this.ReleaseYearNumericUpDown.Size = new System.Drawing.Size(188, 23);
            this.ReleaseYearNumericUpDown.TabIndex = 9;
            this.ReleaseYearNumericUpDown.ValueChanged += new System.EventHandler(this.ReleaseYearNumericUpDown_ValueChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseYearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrevDayButton;
        private System.Windows.Forms.Button NextDayButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button EPNumPrevButton;
        private System.Windows.Forms.TextBox LatestEpisodeTextBox;
        private System.Windows.Forms.Button EPNumNextButton;
        private System.Windows.Forms.Button PrevWeekButton;
        private System.Windows.Forms.Button NextWeekButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Set1Button;
        private System.Windows.Forms.Button Set12Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ReleaseYearNumericUpDown;
    }
}