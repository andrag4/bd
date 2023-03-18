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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (Model1 context = new Model1())
            {
                dataGrid1.ItemsSource = context.Ticket.ToArray();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Model1 context = new Model1();
            context.Ticket.Add(new Ticket() { FirstNameP = textBox1.Text.ToString(), LastNameP = textBox2.Text.ToString() });
            context.SaveChanges();
        }
    }

   
}
