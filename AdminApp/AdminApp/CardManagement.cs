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
        private int card_id;
        private string cust_name;
        private bool card_active = false;

        public CardManagement()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReprintCard_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string CardNum = (string)sender;
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
                    string query = $"SELECT * FROM Gift_Cards WHERE CardNum = {FinalNum}";
                    //TODO Retrieve and parse gift card info.
                }
                catch
                {
                    //no catches here.
                }
                connection.Close();

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
