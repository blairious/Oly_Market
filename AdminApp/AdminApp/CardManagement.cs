using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{

    public partial class CardManagement : Form
    {

        private decimal card_amount;
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

                var con = new ConnectionInfo();
                string Coninfo = con.getCred();
                using var connection = new MySqlConnection(Coninfo);
                connection.Open();
                try
                {
                    //Retrieve gift card info.
                    using var command = new MySqlCommand($"SELECT * FROM Gift_Cards WHERE CardNum = @cardnum", connection);
                    command.Parameters.AddWithValue("@cardnum", FinalNum);
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

        private void amntAddSub_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
