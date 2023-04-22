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

namespace WpfApp1.Forms
{
    /// <summary>
    /// Interaction logic for AddRouteForms.xaml
    /// </summary>
    public partial class AddRouteForms : Window
    {
        public AddRouteForms()
        {
            InitializeComponent();
        }

        private void Cancele_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
