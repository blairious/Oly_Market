namespace AdminApp
{
    partial class CardManagement
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
            cardnumlabel = new Label();
            textBox1 = new TextBox();
            balLabel = new Label();
            verName = new Label();
            custBallance = new Label();
            custName = new Label();
            amntAddSub = new NumericUpDown();
            button1 = new Button();
            ReprintCard = new Button();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)amntAddSub).BeginInit();
            SuspendLayout();
            // 
            // cardnumlabel
            // 
            cardnumlabel.AutoSize = true;
            cardnumlabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            cardnumlabel.Location = new Point(139, 32);
            cardnumlabel.Name = "cardnumlabel";
            cardnumlabel.Size = new Size(221, 30);
            cardnumlabel.TabIndex = 0;
            cardnumlabel.Text = "Enter Card Number:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // balLabel
            // 
            balLabel.AutoSize = true;
            balLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            balLabel.Location = new Point(80, 220);
            balLabel.Name = "balLabel";
            balLabel.Size = new Size(99, 30);
            balLabel.TabIndex = 2;
            balLabel.Text = "Balance:";
            // 
            // verName
            // 
            verName.AutoSize = true;
            verName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            verName.Location = new Point(12, 144);
            verName.Name = "verName";
            verName.Size = new Size(167, 30);
            verName.TabIndex = 3;
            verName.Text = "Name on Card:";
            // 
            // custBallance
            // 
            custBallance.AutoSize = true;
            custBallance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custBallance.Location = new Point(205, 220);
            custBallance.Name = "custBallance";
            custBallance.Size = new Size(0, 30);
            custBallance.TabIndex = 4;
            // 
            // custName
            // 
            custName.AutoSize = true;
            custName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custName.Location = new Point(205, 144);
            custName.Name = "custName";
            custName.Size = new Size(0, 30);
            custName.TabIndex = 5;
            // 
            // amntAddSub
            // 
            amntAddSub.DecimalPlaces = 2;
            amntAddSub.Location = new Point(313, 227);
            amntAddSub.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            amntAddSub.Minimum = new decimal(new int[] { 2000, 0, 0, int.MinValue });
            amntAddSub.Name = "amntAddSub";
            amntAddSub.Size = new Size(120, 23);
            amntAddSub.TabIndex = 6;
            amntAddSub.TextAlign = HorizontalAlignment.Center;
            amntAddSub.ValueChanged += amntAddSub_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(313, 256);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 7;
            button1.Text = "Change Amount";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReprintCard
            // 
            ReprintCard.BackColor = Color.FromArgb(21, 82, 68);
            ReprintCard.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ReprintCard.ForeColor = Color.White;
            ReprintCard.Location = new Point(150, 331);
            ReprintCard.Name = "ReprintCard";
            ReprintCard.Size = new Size(198, 48);
            ReprintCard.TabIndex = 8;
            ReprintCard.Text = "Reprint";
            ReprintCard.UseVisualStyleBackColor = false;
            ReprintCard.Click += ReprintCard_Click;
            // 
            // Close
            // 
            Close.BackColor = Color.FromArgb(21, 82, 68);
            Close.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Close.ForeColor = Color.White;
            Close.Location = new Point(150, 406);
            Close.Name = "Close";
            Close.Size = new Size(198, 48);
            Close.TabIndex = 9;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // CardManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 473);
            Controls.Add(Close);
            Controls.Add(ReprintCard);
            Controls.Add(button1);
            Controls.Add(amntAddSub);
            Controls.Add(custName);
            Controls.Add(custBallance);
            Controls.Add(verName);
            Controls.Add(balLabel);
            Controls.Add(textBox1);
            Controls.Add(cardnumlabel);
            Name = "CardManagement";
            Text = "Card Management";
            ((System.ComponentModel.ISupportInitialize)amntAddSub).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cardnumlabel;
        private TextBox textBox1;
        private Label balLabel;
        private Label verName;
        private Label custBallance;
        private Label custName;
        private NumericUpDown amntAddSub;
        private Button button1;
        private Button ReprintCard;
        private Button Close;
    }
}