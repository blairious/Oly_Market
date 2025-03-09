using static ConnectionInfo;
using MySqlConnector;


namespace AdminApp
{
    public partial class AddCard : Form
    {
        public float Card_Amount;
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
            Card_Amount = (float)((NumericUpDown)sender).Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Cust_Name = ((TextBox)sender).Text;
        }

        private void CreateCard_Click(object sender, EventArgs e)
        {
            string NameOnCard = Cust_Name; 
            if (NameOnCard is null || NameOnCard == "" || NameOnCard.Contains(' '))
            {
                MessageBox.Show("Enter a single validation name with no spaces.");
                return;
            }

            ConnectionInfo con = new ConnectionInfo();
            string ConInfo = con.getCred();
            using var connection = new MySqlConnection(ConInfo);

        }
    }
}
