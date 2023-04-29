using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            using (Model1 context = new Model1())
            {


                {
                    context.Route.Add(new Route() { RouteName = "СПБ-МСК" });
                    context.Route.Add(new Route() { RouteName = "НСК-МСК" });
                    context.SaveChanges();
                }


                RouteCB.ItemsSource = context.Category.ToArray();
            }
        }

        private void Cancele_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Model1 context = new Model1();
            context.Route.Add(new Route()
            {
                RouteName = RouteNameTB.Text.ToString(),
            });
            context.SaveChanges();
        }
    }
}
