using MySqlConnector;


namespace AdminApp
{

    public partial class CardManagement : Form
    {

        private decimal card_amount;
        private decimal change_amount;
        private int card_id = 0;
        private string cust_name;
        private bool card_active = false;

        public CardManagement()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        //Checks to see if a card has been found.
        private void ReprintCard_Click(object sender, EventArgs e)
        {
            if (!card_active)
            {
                MessageBox.Show("No card selected");
            }
            else
            {
                CardDisplay foundCard = new CardDisplay(cust_name, card_amount, card_id);
                foundCard.Show();
            }
        }

        //Method for handling card number input.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string CardNum = ((TextBox)sender).Text;
            if (CardNum.Contains(';') || CardNum.Contains(')'))
            {
                textBox1.Clear();
            }
            else if (CardNum.Length == 10)
            {
                int FinalNum = int.Parse(CardNum);
                screenUpdate(FinalNum);
            }
            else
            {
                cust_name = "";
                card_amount = 0;
                card_id = 0;
                screenUpdate(card_id);
            }

        }

        //Changes the amount to add or subtract from the gift card. 
        private void amntAddSub_ValueChanged(object sender, EventArgs e)
        {
            change_amount = (decimal)((NumericUpDown)sender).Value;
        }

        private void changeAmntBtn_Click(object sender, EventArgs e)
        {
            if (card_active && card_amount + change_amount >= 0)
            {
                //Connects to Gift Card DB and changes ammount.
                ConnectionInfo con = new ConnectionInfo();
                string ConInfo = con.getCred();
                using (var connection = new MySqlConnection(ConInfo))
                {
                    connection.Open();
                    using var cmd = new MySqlCommand("UPDATE Gift_Cards SET Balance = Balance + @chamount WHERE CardNum = @cardnum", connection);
                    cmd.Parameters.AddWithValue("@chamount", change_amount);
                    cmd.Parameters.AddWithValue("@cardnum", card_id);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                //Writes the transaction to the main ledger and updates screen.
                Ledg_Update Writer = new Ledg_Update();
                Writer.Rebalance(card_id, (double)change_amount);

                //Confirmation of change message. A messure to stop accidental double-clicking. 
                MessageBox.Show("Rebalance complete.");

                screenUpdate(card_id);
            }
            else if (card_amount + change_amount < 0)
            {
                MessageBox.Show("Cannot adjust funds below zero.");
            }
            else
            {
                MessageBox.Show("No card selected.");
            }
        }

        private void screenUpdate(int cardnum)
        {
            //Checks if the call is for updating a bad entry before completing method.
            if (cardnum == 0)
            {
                custBalance.Text = "";
                custName.Text = "";
                card_active = false;
                return;
            }

            //Sets up a connection
            var con = new ConnectionInfo();
            string Coninfo = con.getCred();
            using var connection = new MySqlConnection(Coninfo);
            connection.Open();
            try
            {
                //Retrieve gift card info.
                using var command = new MySqlCommand("SELECT * FROM Gift_Cards WHERE CardNum = @cardnum", connection);
                command.Parameters.AddWithValue("@cardnum", cardnum);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    card_id = reader.GetInt32("CardNum");
                    cust_name = reader.GetString("VerifyName");
                    card_amount = reader.GetDecimal("Balance");
                }
            }
            catch
            {
                //no catches here.
            }
            connection.Close();

            //Refresh displayed form info. 
            if (card_id != 0)
            {
                custBalance.Text = $"${card_amount}";
                custName.Text = cust_name.ToString();
                card_active = true;
            }

        }
    }
}
