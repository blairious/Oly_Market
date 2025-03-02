namespace AdminApp
{
    partial class AddCard
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
            textBox2 = new TextBox();
            label1 = new Label();
            CardAmount = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            CreateCard = new Button();
            Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)CardAmount).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(98, 22);
            label1.Name = "label1";
            label1.Size = new Size(214, 47);
            label1.TabIndex = 2;
            label1.Text = "Create Card";
            // 
            // CardAmount
            // 
            CardAmount.DecimalPlaces = 2;
            CardAmount.Location = new Point(135, 135);
            CardAmount.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            CardAmount.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            CardAmount.Name = "CardAmount";
            CardAmount.Size = new Size(141, 23);
            CardAmount.TabIndex = 3;
            CardAmount.TextAlign = HorizontalAlignment.Center;
            CardAmount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(154, 102);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 4;
            label2.Text = "Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(165, 182);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            // 
            // CreateCard
            // 
            CreateCard.BackColor = Color.FromArgb(21, 82, 68);
            CreateCard.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CreateCard.ForeColor = Color.White;
            CreateCard.Location = new Point(106, 277);
            CreateCard.Name = "CreateCard";
            CreateCard.Size = new Size(198, 48);
            CreateCard.TabIndex = 6;
            CreateCard.Text = "Create Card";
            CreateCard.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(21, 82, 68);
            Cancel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Cancel.ForeColor = Color.White;
            Cancel.Location = new Point(106, 349);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(198, 48);
            Cancel.TabIndex = 7;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // AddCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 425);
            Controls.Add(Cancel);
            Controls.Add(CreateCard);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CardAmount);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Name = "AddCard";
            ((System.ComponentModel.ISupportInitialize)CardAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox textBox2;
        private Label label1;
        private NumericUpDown CardAmount;
        private Label label2;
        private Label label3;
        private Button CreateCard;
        private Button Cancel;
    }
}