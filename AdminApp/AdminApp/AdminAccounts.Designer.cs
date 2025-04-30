namespace AdminApp
{
    partial class AdminAccounts
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
            CloseButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(21, 82, 68);
            CloseButton.FlatAppearance.BorderColor = Color.FromArgb(21, 82, 68);
            CloseButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(282, 749);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(235, 53);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 23);
            textBox1.TabIndex = 3;
            // 
            // AdminAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 814);
            Controls.Add(textBox1);
            Controls.Add(CloseButton);
            Name = "AdminAccounts";
            Text = "AdminAccounts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private TextBox textBox1;
    }
}