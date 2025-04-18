﻿using System.Data;

namespace AdminApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            LogoMain = new PictureBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            TransNum = new DataGridViewTextBoxColumn();
            CardNum = new DataGridViewTextBoxColumn();
            VendNum = new DataGridViewTextBoxColumn();
            TransDate = new DataGridViewTextBoxColumn();
            TransType = new DataGridViewTextBoxColumn();
            TransAmount = new DataGridViewTextBoxColumn();
            CreateGiftCard = new Button();
            CardAccounts = new Button();
            VendAcc = new Button();
            SignOut = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            refresh = new Button();
            Print = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LogoMain
            // 
            LogoMain.Image = (Image)resources.GetObject("LogoMain.Image");
            LogoMain.Location = new Point(23, 1);
            LogoMain.Name = "LogoMain";
            LogoMain.Size = new Size(241, 232);
            LogoMain.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoMain.TabIndex = 0;
            LogoMain.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(763, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(297, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(907, 590);
            dataGridView1.TabIndex = 2;
            // 
            // TransNum
            // 
            TransNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TransNum.HeaderText = "Transaction #";
            TransNum.Name = "TransNum";
            TransNum.ReadOnly = true;
            TransNum.Resizable = DataGridViewTriState.True;
            // 
            // CardNum
            // 
            CardNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CardNum.HeaderText = "Card #";
            CardNum.Name = "CardNum";
            CardNum.ReadOnly = true;
            // 
            // VendNum
            // 
            VendNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VendNum.HeaderText = "Vendor #";
            VendNum.Name = "VendNum";
            VendNum.ReadOnly = true;
            // 
            // TransDate
            // 
            TransDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TransDate.HeaderText = "Transaction Date";
            TransDate.Name = "TransDate";
            TransDate.ReadOnly = true;
            // 
            // TransType
            // 
            TransType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TransType.HeaderText = "Transaction Type";
            TransType.Name = "TransType";
            TransType.ReadOnly = true;
            // 
            // TransAmount
            // 
            TransAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TransAmount.HeaderText = "Amount";
            TransAmount.Name = "TransAmount";
            TransAmount.ReadOnly = true;
            // 
            // CreateGiftCard
            // 
            CreateGiftCard.BackColor = Color.FromArgb(21, 82, 68);
            CreateGiftCard.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            CreateGiftCard.ForeColor = Color.White;
            CreateGiftCard.Location = new Point(23, 253);
            CreateGiftCard.Name = "CreateGiftCard";
            CreateGiftCard.Size = new Size(241, 50);
            CreateGiftCard.TabIndex = 3;
            CreateGiftCard.Text = "Create Gift Card";
            CreateGiftCard.UseVisualStyleBackColor = false;
            CreateGiftCard.Click += CreateGiftCard_Click;
            // 
            // CardAccounts
            // 
            CardAccounts.BackColor = Color.FromArgb(21, 82, 68);
            CardAccounts.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            CardAccounts.ForeColor = Color.White;
            CardAccounts.Location = new Point(23, 324);
            CardAccounts.Name = "CardAccounts";
            CardAccounts.Size = new Size(241, 50);
            CardAccounts.TabIndex = 4;
            CardAccounts.Text = "Card Accounts";
            CardAccounts.UseVisualStyleBackColor = false;
            CardAccounts.Click += CardAccounts_Click;
            // 
            // VendAcc
            // 
            VendAcc.BackColor = Color.FromArgb(21, 82, 68);
            VendAcc.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            VendAcc.ForeColor = Color.White;
            VendAcc.Location = new Point(23, 396);
            VendAcc.Name = "VendAcc";
            VendAcc.Size = new Size(241, 50);
            VendAcc.TabIndex = 5;
            VendAcc.Text = "Vendor Accounts";
            VendAcc.UseVisualStyleBackColor = false;
            VendAcc.Click += VendAcc_Click;
            // 
            // SignOut
            // 
            SignOut.BackColor = Color.FromArgb(21, 82, 68);
            SignOut.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            SignOut.ForeColor = Color.White;
            SignOut.Location = new Point(23, 687);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(241, 50);
            SignOut.TabIndex = 6;
            SignOut.Text = "Sign Out";
            SignOut.UseVisualStyleBackColor = false;
            SignOut.Click += SignOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(626, 57);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 7;
            label1.Text = "Lookup Transaction:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(297, 9);
            label2.Name = "label2";
            label2.Size = new Size(261, 37);
            label2.TabIndex = 8;
            label2.Text = "Transaction Ledger";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(21, 82, 68);
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 470);
            button1.Name = "button1";
            button1.Size = new Size(241, 50);
            button1.TabIndex = 9;
            button1.Text = "Admin Accounts";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(1129, 53);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 10;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // Print
            // 
            Print.Location = new Point(1129, 708);
            Print.Name = "Print";
            Print.Size = new Size(75, 23);
            Print.TabIndex = 11;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = true;
            Print.Click += Print_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 749);
            Controls.Add(Print);
            Controls.Add(refresh);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SignOut);
            Controls.Add(VendAcc);
            Controls.Add(CardAccounts);
            Controls.Add(CreateGiftCard);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(LogoMain);
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)LogoMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoMain;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TransNum;
        private DataGridViewTextBoxColumn CardNum;
        private DataGridViewTextBoxColumn VendNum;
        private DataGridViewTextBoxColumn TransDate;
        private DataGridViewTextBoxColumn TransType;
        private DataGridViewTextBoxColumn TransAmount;
        private Button CreateGiftCard;
        private Button CardAccounts;
        private Button VendAcc;
        private Button SignOut;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button refresh;
        private Button Print;
    }
}