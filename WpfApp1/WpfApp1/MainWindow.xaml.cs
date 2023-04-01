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
                if (context.Category.Any() == false)
                {
                    context.Category.Add(new Category() { CategoryName = "Бизнес" });
                    context.Category.Add(new Category() { CategoryName = "Эконом" });
                }

                context.SaveChanges();

                cbCategories.ItemsSource = context.Category.ToArray();
                if (context.Route.Any() == false)
                {
                    context.Route.Add(new Route() { RouteName = "Новосибирск - Москва" });
                    context.Route.Add(new Route() { RouteName = "Москва - СПБ" });
                }
                context.SaveChanges() ;
                cbRoute.ItemsSource = context.Route.ToArray();
            }
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Model1 context = new Model1();
            var selectedCategory = (int) cbCategories.SelectedValue;

            var selectedRoute = (int) cbRoute.SelectedValue;

            //context.Ticket.Add(new Ticket() { FirstNameP = textBox1.Text.ToString(), LastNameP = textBox2.Text.ToString(), CategoryId = selectedCategory });
            context.SaveChanges();
        }
    }

   
}
