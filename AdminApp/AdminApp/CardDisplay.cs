using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Net.Codecrete.QrCodeGenerator;

namespace AdminApp
{
    public partial class CardDisplay : Form
    {
        private string _name;
        private double _amount;
        private int _cardnum;
        public CardDisplay(string name, double amount, int cardnum)
        {
            InitializeComponent();
            _name = name;
            _amount = amount;
            _cardnum = cardnum;
            label4.Text = $"{_cardnum}";
            label5.Text = $"{_amount}";
            label6.Text = $"{_name}";
            GenerateCode(_cardnum);
        }

        private void GenerateCode(int CardNum)
        {
            QrCode qr = QrCode.EncodeText($"{CardNum}", QrCode.Ecc.Medium);
            int fcolor = qr.RgbColor(0, 0, 0);
            int bcolor = qr.RgbColor(255, 255, 255);
            Byte[] qrImage = qr.ToBmpBitmap(0, 10, fcolor, bcolor);

            using (MemoryStream ms = new MemoryStream(qrImage))
            {
                Bitmap FinalQR = new Bitmap(ms);
                pictureBox1.Image = FinalQR;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
