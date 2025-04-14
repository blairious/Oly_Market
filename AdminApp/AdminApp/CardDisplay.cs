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
        private decimal _amount;
        private int _cardnum;
        public CardDisplay(string name, decimal amount, int cardnum)
        {
            InitializeComponent();
            _name = name;
            _amount = amount;
            _cardnum = cardnum;
            label4.Text = $"{_cardnum}";
            label5.Text = $"${_amount}";
            label6.Text = $"{_name}";
            GenerateCode(_cardnum);
        }

        //Generates QR code Bitmap based on entered info
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
            GC.Collect();
            this.Close();
        }

        //Print button functionality
        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics f = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width - 50, this.Size.Height - 300, f);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(this.Location.X + 10, this.Location.Y + 30, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }

        //Setup for print dialog and page layout.
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 25, 10);
        }

    }
}
