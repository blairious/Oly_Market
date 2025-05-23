﻿namespace AdminApp
{
    partial class CardDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDisplay));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Close = new Button();
            label6 = new Label();
            label7 = new Label();
            Print = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(43, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 242);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 47);
            label1.TabIndex = 1;
            label1.Text = "Card Code:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(339, 59);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 2;
            label2.Text = "Card Number:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(339, 184);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 3;
            label3.Text = "Amount:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(339, 100);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 4;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(339, 230);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 5;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Close
            // 
            Close.BackColor = Color.FromArgb(21, 82, 68);
            Close.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Close.ForeColor = Color.White;
            Close.Location = new Point(168, 524);
            Close.Name = "Close";
            Close.Size = new Size(198, 48);
            Close.TabIndex = 7;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(559, 230);
            label6.Name = "label6";
            label6.Size = new Size(71, 30);
            label6.TabIndex = 9;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(559, 184);
            label7.Name = "label7";
            label7.Size = new Size(80, 30);
            label7.TabIndex = 8;
            label7.Text = "Name:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // Print
            // 
            Print.BackColor = Color.FromArgb(21, 82, 68);
            Print.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Print.ForeColor = Color.White;
            Print.Location = new Point(432, 524);
            Print.Name = "Print";
            Print.Size = new Size(198, 48);
            Print.TabIndex = 10;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = false;
            Print.Click += button1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.Oly_Market_Logo;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(522, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 169);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // CardDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 584);
            Controls.Add(pictureBox2);
            Controls.Add(Print);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(Close);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "CardDisplay";
            Text = "CardDisplay";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Close;
        private Label label6;
        private Label label7;
        private Button Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox2;
    }
}