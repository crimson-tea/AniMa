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
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.LatestNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LeftDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LatestNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDaysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(273, 174);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 29);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "タイトル: \" | 本編\"は自動で削除されます。";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleTextBox.Location = new System.Drawing.Point(13, 25);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(348, 19);
            this.TitleTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL: 視聴ページ（動画が再生されるページ）のURLを貼り付けてください。";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UrlTextBox.Location = new System.Drawing.Point(13, 64);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(348, 19);
            this.UrlTextBox.TabIndex = 2;
            // 
            // LatestNumberNumericUpDown
            // 
            this.LatestNumberNumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LatestNumberNumericUpDown.Location = new System.Drawing.Point(13, 103);
            this.LatestNumberNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.LatestNumberNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.LatestNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LatestNumberNumericUpDown.Name = "LatestNumberNumericUpDown";
            this.LatestNumberNumericUpDown.Size = new System.Drawing.Size(58, 19);
            this.LatestNumberNumericUpDown.TabIndex = 3;
            this.LatestNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "最新話: 最新話の話数を入力してください。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "残り日数: 最新話にて表示されている無料期間を入力してください。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "リリース年: 作品の配信年を入力してください。";
            // 
            // LeftDaysNumericUpDown
            // 
            this.LeftDaysNumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftDaysNumericUpDown.Location = new System.Drawing.Point(13, 142);
            this.LeftDaysNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.LeftDaysNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.LeftDaysNumericUpDown.Name = "LeftDaysNumericUpDown";
            this.LeftDaysNumericUpDown.Size = new System.Drawing.Size(58, 19);
            this.LeftDaysNumericUpDown.TabIndex = 5;
            this.LeftDaysNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearNumericUpDown.Location = new System.Drawing.Point(13, 180);
            this.YearNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            2300,
            0,
            0,
            0});
            this.YearNumericUpDown.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(58, 19);
            this.YearNumericUpDown.TabIndex = 6;
            this.YearNumericUpDown.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // AddAnimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 212);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.LeftDaysNumericUpDown);
            this.Controls.Add(this.LatestNumberNumericUpDown);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAnimeForm";
            this.Text = "AddAnimeForm";
            ((System.ComponentModel.ISupportInitialize)(this.LatestNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDaysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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