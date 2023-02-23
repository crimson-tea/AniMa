using System.Windows.Forms;

namespace AniMa.Forms
{
    partial class AboutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LibraryListBox = new System.Windows.Forms.ListBox();
            this.LibraryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LicenseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "AniMa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "© 2023 crimson-tea";
            // 
            // LibraryListBox
            // 
            this.LibraryListBox.FormattingEnabled = true;
            this.LibraryListBox.ItemHeight = 15;
            this.LibraryListBox.Location = new System.Drawing.Point(12, 106);
            this.LibraryListBox.Name = "LibraryListBox";
            this.LibraryListBox.Size = new System.Drawing.Size(537, 34);
            this.LibraryListBox.TabIndex = 2;
            // 
            // LibraryLinkLabel
            // 
            this.LibraryLinkLabel.AutoSize = true;
            this.LibraryLinkLabel.Location = new System.Drawing.Point(12, 143);
            this.LibraryLinkLabel.Name = "LibraryLinkLabel";
            this.LibraryLinkLabel.Size = new System.Drawing.Size(0, 15);
            this.LibraryLinkLabel.TabIndex = 3;
            this.LibraryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LibraryLinkLabel_LinkClicked);
            // 
            // LicenseRichTextBox
            // 
            this.LicenseRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseRichTextBox.Location = new System.Drawing.Point(12, 161);
            this.LicenseRichTextBox.Name = "LicenseRichTextBox";
            this.LicenseRichTextBox.Size = new System.Drawing.Size(537, 202);
            this.LicenseRichTextBox.TabIndex = 5;
            this.LicenseRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ライセンス:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "version:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(175, 33);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(40, 15);
            this.VersionLabel.TabIndex = 8;
            this.VersionLabel.Text = "0.0.0.0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(130, 54);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(216, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/crimson-tea/AniMa";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LibraryLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 375);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LicenseRichTextBox);
            this.Controls.Add(this.LibraryLinkLabel);
            this.Controls.Add(this.LibraryListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(577, 800);
            this.MinimumSize = new System.Drawing.Size(577, 200);
            this.Name = "AboutForm";
            this.Text = "AniMaについて";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox LibraryListBox;
        private LinkLabel LibraryLinkLabel;
        private RichTextBox LicenseRichTextBox;
        private Label label3;
        private Label label4;
        private Label VersionLabel;
        private LinkLabel linkLabel1;
    }
}