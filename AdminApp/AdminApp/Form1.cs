using CozyHasher;
using MySqlConnector;
using static ConnectionInfo;

namespace AdminApp
{
    public partial class Form1 : Form
    {
        public string userName;
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

            // Login syntax check. 
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


            // Connection and data fetch for login.
            ConnectionInfo con = new ConnectionInfo();
            string ConInfo = con.getCred();
            using var connection = new MySqlConnection(ConInfo);

            connection.Open();

            using var command = new MySqlCommand($"SELECT Password FROM Admin_Accounts WHERE AdminID = @AdminID;", connection);
            command.Parameters.AddWithValue("@AdminID", userName);
            using var reader = command.ExecuteReader();
            string hashedWord = "";
            bool AccessNow = false;
            while (reader.Read())
            {
                hashedWord = reader.GetString(0);
            }
            connection.Close();

            // Get boolean based on checking aquired hash and existence of user.
            try
            {
                AccessNow = hasher.CheckHash(userName, passWord, hashedWord);
            }
            catch
            {
                AccessNow = false;
            }
            
            if (AccessNow)
            {
                this.Hide();
                MainWindow mainwin = new MainWindow();
                mainwin.Show();
            }
            else
            {
                MessageBox.Show("Login credentials incorrect.");
            }
        }
    }
}
