namespace AdminApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            Uname = new TextBox();
            Pword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(21, 82, 68);
            LoginButton.FlatAppearance.BorderColor = Color.FromArgb(21, 82, 68);
            LoginButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(58, 575);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(235, 53);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(79, 360);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 2;
            label1.Text = "Admin User ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(109, 462);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // Uname
            // 
            Uname.BorderStyle = BorderStyle.FixedSingle;
            Uname.Font = new Font("Segoe UI", 16F);
            Uname.Location = new Point(58, 400);
            Uname.Name = "Uname";
            Uname.Size = new Size(235, 36);
            Uname.TabIndex = 4;
            Uname.TextAlign = HorizontalAlignment.Center;
            Uname.TextChanged += Uname_TextChanged;
            // 
            // Pword
            // 
            Pword.BorderStyle = BorderStyle.FixedSingle;
            Pword.Font = new Font("Segoe UI", 16F);
            Pword.Location = new Point(58, 502);
            Pword.Name = "Pword";
            Pword.Size = new Size(235, 36);
            Pword.TabIndex = 5;
            Pword.TextAlign = HorizontalAlignment.Center;
            Pword.UseSystemPasswordChar = true;
            Pword.TextChanged += Pword_TextChanged;
            // 
            // Form1
            // 
            AcceptButton = LoginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 682);
            Controls.Add(Pword);
            Controls.Add(Uname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ",";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button LoginButton;
        private Label label1;
        private Label label2;
        private TextBox Uname;
        private TextBox Pword;
    }
}
