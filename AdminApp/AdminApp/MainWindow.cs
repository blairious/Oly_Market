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
            LoadData("");
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

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
                }
            }
            catch
            {
                //no catches here.
            }
            connection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string AdminInput = ((TextBox)sender).Text;
            try
            {
                if (AdminInput.Contains('-'))
                {
                    LoadData($" WHERE Date = '{AdminInput}'");
                }
                else if (AdminInput.Length == 10 && AdminInput[0] == '1')
                {
                    LoadData($" WHERE CardID = {AdminInput}");
                }
                else if (AdminInput.Length == 8 && AdminInput[0] == '4')
                {
                    LoadData($" WHERE VendorID = {AdminInput}");
                }
                else if (AdminInput == "sale" || AdminInput == "card_fund" || AdminInput == "vendor_debit")
                {
                    LoadData($" WHERE Tran_Type = '{AdminInput}'");
                }
                else if (AdminInput.Contains('.'))
                {
                    LoadData($" WHERE Amount = {AdminInput}");
                }
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

        private void CreateGiftCard_Click(object sender, EventArgs e)
        {
            AddCard newcard = new AddCard();
            newcard.Show();
        }
    }
}
