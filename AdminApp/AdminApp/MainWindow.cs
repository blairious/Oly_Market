using static ConnectionInfo;
using MySqlConnector;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AdminApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FormClosed += MainWindow_FormClosed;
            LoadData("");
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Application.Restart();
        }

        //Function that selects input data from DB
        private void LoadData(string type)
        {
            var con = new ConnectionInfo();
            string Coninfo = con.getCred();
            using var connection = new MySqlConnection(Coninfo);
            connection.Open();
            try
            {
                string query = $"SELECT * FROM Main_Ledger{type}";
                using (var adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch
            {
                //no catches here.
            }
            connection.Close();

        }

        //Parses inputs and sends proper query. 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string AdminInput = ((TextBox)sender).Text;
            try
            {
                //The first conditional checks if characters that would only be used in injection attacks are present.
                if (AdminInput.Contains(';') || AdminInput.Contains(')'))
                {
                    textBox1.Clear();
                }
                else if (AdminInput.Contains('/'))
                {
                    string newdate = "";
                    foreach (char c in AdminInput)
                    {
                        if (c == '/')
                        {
                            newdate += '-';
                        }
                        else if (char.IsDigit(c))
                        {
                            newdate += c;
                        }
                    }
                    LoadData($" WHERE Date LIKE '%{newdate}%'");
                }
                //Checks to see if user wants to access a card number
                else if (AdminInput.Contains("card-"))
                {
                    int adnum = int.Parse(AdminInput[5..]);
                    LoadData($" WHERE CardID = {adnum}");
                }

                //Checks to see if user wants to access a vendor number
                else if (AdminInput.Contains("ven-"))
                {
                    int adnum = int.Parse(AdminInput[4..]);
                    LoadData($" WHERE VendorID = {adnum}");
                }
                else if (AdminInput == "sale" || AdminInput == "card_fund" || AdminInput == "vendor_debit")
                {
                    LoadData($" WHERE Tran_Type = '{AdminInput}'");
                }
                else if (AdminInput.Contains('.'))
                {
                    LoadData($" WHERE Amount = {AdminInput}");
                }
                //Assuming no other conditions are met, program assumes that user is trying to find a transaction by number.
                else
                {
                    LoadData($" WHERE TransactionID = {AdminInput}");
                }
            }
            catch
            {
                LoadData("");
            }
        }

        //Button for creating new gift card.
        private void CreateGiftCard_Click(object sender, EventArgs e)
        {
            AddCard newcard = new AddCard();
            newcard.Show();
        }

        //Refreshes table after data entry.
        private void refresh_Click(object sender, EventArgs e)
        {
            LoadData("");
        }

        //TODO: Print all info from dataGridView1
        private void Print_Click(object sender, EventArgs e)
        {

        }

        //Ensures application termination and trash collection on window close.
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }

        //Opens new window for card asset management.
        private void CardAccounts_Click(object sender, EventArgs e)
        {
            CardManagement cardManagement = new CardManagement();
            cardManagement.Show();
        }

        private void VendAcc_Click(object sender, EventArgs e)
        {
            //TODO: Open a window to pay vendor balances, suspend, add, or delete accounts.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Open a window to add, suspend, delete admin accounts. 
        }
    }
}
