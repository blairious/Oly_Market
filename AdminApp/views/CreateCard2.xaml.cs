using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AdminApp.views
{
    /// <summary>
    /// Interaction logic for CreateCard2.xaml
    /// </summary>
    public partial class CreateCard2 : Window
    {
        public CreateCard2()
        {
            DataContext = this;
            InitializeComponent();
        }

        private ulong _CardNum;
        public ulong CardNum
        {
            get { return _CardNum; }
            set
            {
                CardNum = 0;
            }
        }
    }
}
