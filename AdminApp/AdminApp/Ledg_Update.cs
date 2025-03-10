using MySqlConnector;
using static ConnectionInfo;

namespace AdminApp
{
    class Ledg_Update
    {
        public int Write_Ledger(string Type, double amount)
        {
            if (Type == "New Card")
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
            return 0;
        }
    }
}
