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
    /// Interaction logic for AddForms.xaml
    /// </summary>
    public partial class AddTicketForms : Window
    {
        public AddTicketForms()
        {
            InitializeComponent();
            using (Model1 context = new Model1())
            {

                if(context.Category.Any()==false)
                {
                    context.Category.Add(new Category() { CategoryName = "Бизнес" });
                    context.Category.Add(new Category() { CategoryName = "Эконом" });
                    Route route = context.Route.First(t => t.RouteName == "Новосибирск - Москва");
                    context.Cruise.Add(new Cruise() { CruiseName = "НСК-СПБ", Route = route });

                    context.SaveChanges();
                }

                
                CategoryCB.ItemsSource = context.Category.ToArray();
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddOnFormButton_Click(object sender, RoutedEventArgs e)
        {
            Model1 context = new Model1();
            context.Ticket.Add(new Ticket() { LastNameP = SNameTB.Text.ToString(),
                FirstNameP = FNameTB.Text.ToString(),
               // Category = CategoryCB.SelectedItem as Category,
                CategoryId = (int)CategoryCB.SelectedValue,
                CruiseId = (int)CruiseCB.SelectedValue,
                Price = Convert.ToDouble(PriceTB) }); ;
            context.SaveChanges();
        }
    }
}
