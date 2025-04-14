using static ConnectionInfo;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static AdminApp.Ledg_Update;

namespace AdminApp
{
    public partial class AddCard : Form
    {
        public decimal Card_Amount = (decimal)10.00;
        public string Cust_Name = null;
        public int Card_Num;

        public AddCard()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CardAmount_ValueChanged(object sender, EventArgs e)
        {
            Card_Amount = (decimal)((NumericUpDown)sender).Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Cust_Name = ((TextBox)sender).Text;
        }

        private void CreateCard_Click(object sender, EventArgs e)
        {
            //Tests to ensure name is entered.
            string NameOnCard = Cust_Name;
            if (NameOnCard is null || NameOnCard == "" || NameOnCard.Contains(' '))
            {
                MessageBox.Show("Enter a single validation name with no spaces.");
                return;
            }

            //Connects to Gift Card DB and writes credentials.
            ConnectionInfo con = new ConnectionInfo();
            string ConInfo = con.getCred();
            using (var connection = new MySqlConnection(ConInfo))
            {

                connection.Open();
                using var cmd = new MySqlCommand($"INSERT INTO Gift_Cards (Balance, VerifyName) VALUES (@Balance, @VerifyName);", connection);
                cmd.Parameters.AddWithValue("@Balance", Card_Amount);
                cmd.Parameters.AddWithValue("@VerifyName", Cust_Name);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            //Writes the transaction to the main ledger.
            Ledg_Update Writer = new Ledg_Update();
            Card_Num = Writer.NewCard((double)Card_Amount);

            //Create new form with code, card info, and option to print.
            CardDisplay createdCard = new CardDisplay(Cust_Name, Card_Amount, Card_Num);
            createdCard.Show();
            this.Close();
        }
    }
}
