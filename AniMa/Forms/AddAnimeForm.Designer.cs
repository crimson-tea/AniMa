namespace AniMa.Forms
{
    partial class AddAnimeForm
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
            AddButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            TitleTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            UrlTextBox = new System.Windows.Forms.TextBox();
            LatestNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            LeftDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)LatestNumberNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftDaysNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YearNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddButton.Location = new System.Drawing.Point(273, 174);
            AddButton.Margin = new System.Windows.Forms.Padding(4);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(88, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(207, 12);
            label1.TabIndex = 1;
            label1.Text = "タイトル: \" | 本編\"は自動で削除されます。";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TitleTextBox.Location = new System.Drawing.Point(13, 25);
            TitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new System.Drawing.Size(348, 19);
            TitleTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 48);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(348, 12);
            label2.TabIndex = 1;
            label2.Text = "URL: 視聴ページ（動画が再生されるページ）のURLを貼り付けてください。";
            // 
            // UrlTextBox
            // 
            UrlTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UrlTextBox.Location = new System.Drawing.Point(13, 64);
            UrlTextBox.Margin = new System.Windows.Forms.Padding(4);
            UrlTextBox.Name = "UrlTextBox";
            UrlTextBox.Size = new System.Drawing.Size(348, 19);
            UrlTextBox.TabIndex = 2;
            // 
            // LatestNumberNumericUpDown
            // 
            LatestNumberNumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LatestNumberNumericUpDown.Location = new System.Drawing.Point(13, 103);
            LatestNumberNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            LatestNumberNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            LatestNumberNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LatestNumberNumericUpDown.Name = "LatestNumberNumericUpDown";
            LatestNumberNumericUpDown.Size = new System.Drawing.Size(58, 19);
            LatestNumberNumericUpDown.TabIndex = 3;
            LatestNumberNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(13, 87);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(209, 12);
            label3.TabIndex = 1;
            label3.Text = "最新話: 最新話の話数を入力してください。";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(13, 126);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(320, 12);
            label4.TabIndex = 1;
            label4.Text = "残り日数: 最新話にて表示されている視聴期限を入力してください。";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(13, 165);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(218, 12);
            label5.TabIndex = 1;
            label5.Text = "リリース年: 作品の配信年を入力してください。";
            // 
            // LeftDaysNumericUpDown
            // 
            LeftDaysNumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LeftDaysNumericUpDown.Location = new System.Drawing.Point(13, 142);
            LeftDaysNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            LeftDaysNumericUpDown.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            LeftDaysNumericUpDown.Name = "LeftDaysNumericUpDown";
            LeftDaysNumericUpDown.Size = new System.Drawing.Size(58, 19);
            LeftDaysNumericUpDown.TabIndex = 5;
            LeftDaysNumericUpDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // YearNumericUpDown
            // 
            YearNumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            YearNumericUpDown.Location = new System.Drawing.Point(13, 180);
            YearNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            YearNumericUpDown.Maximum = new decimal(new int[] { 2300, 0, 0, 0 });
            YearNumericUpDown.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            YearNumericUpDown.Name = "YearNumericUpDown";
            YearNumericUpDown.Size = new System.Drawing.Size(58, 19);
            YearNumericUpDown.TabIndex = 6;
            YearNumericUpDown.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // AddAnimeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(368, 212);
            Controls.Add(YearNumericUpDown);
            Controls.Add(LeftDaysNumericUpDown);
            Controls.Add(LatestNumberNumericUpDown);
            Controls.Add(UrlTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "AddAnimeForm";
            Text = "AddAnimeForm";
            ((System.ComponentModel.ISupportInitialize)LatestNumberNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftDaysNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)YearNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.NumericUpDown LatestNumberNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LeftDaysNumericUpDown;
        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
    }
}