using CozyHasher;
using MySqlConnector;

namespace AdminApp
{
    public partial class Form1 : Form
    {
        private string userName;
        private string passWord;
        Hasher hasher = new Hasher();


        public Form1()
        {
            InitializeComponent();
        }

        private void Uname_TextChanged(object sender, EventArgs e)
        {
            userName = ((TextBox)sender).Text;
        }

        private void Pword_TextChanged(object sender, EventArgs e)
        {
            passWord = ((TextBox)sender).Text;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userName == null || userName == "" || userName.Contains(' '))
            {
                MessageBox.Show("Username missing or invalid.");
                return;
            }
            else if (passWord == null || passWord == "" || passWord.Contains(' '))
            {
                MessageBox.Show("Password missing or invalid.");
                return;
            }

            string HashedWords = hasher.MakeHash(userName, passWord);
        }
    }
}
