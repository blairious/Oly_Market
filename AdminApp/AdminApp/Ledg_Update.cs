using MySqlConnector;

namespace AdminApp
{
    class Ledg_Update
    {
        //Writes a new ledger entry reflecting the creation of a new card. 
        public int NewCard(double amount)
        {
            int cardnum = 0;
            ConnectionInfo con = new ConnectionInfo();
            string ConInfo = con.getCred();
            using var connection = new MySqlConnection(ConInfo);

            connection.Open();

            using (var command = new MySqlCommand("SELECT MAX(CardNum) FROM Gift_Cards;", connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                    cardnum = reader.GetInt32(0);
            }
            using var cmd = new MySqlCommand($"INSERT INTO Main_Ledger (CardID, Amount, Tran_Type) VALUES ({cardnum}, {amount}, 'New Card');", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return cardnum;
        }
        //Writes a ledger entry to reflect a non-transaction balance change.
        public void Rebalance(int cardnum, double amount) 
        {
            ConnectionInfo con = new ConnectionInfo();
            string ConInfo = con.getCred();
            using var connection = new MySqlConnection(ConInfo);
            string adminNum = Form1.userName;
            connection.Open();
         
            using var cmd = new MySqlCommand($"INSERT INTO Main_Ledger (CardID, Amount, Tran_Type) VALUES ({cardnum}, {amount}, 'Rebalance Admin: {adminNum}');", connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
