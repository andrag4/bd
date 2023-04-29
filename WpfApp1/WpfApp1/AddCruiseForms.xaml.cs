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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddCruiseForms.xaml
    /// </summary>
    public partial class AddCruiseForms : Window
    {
        public AddCruiseForms()
        {
            InitializeComponent();
            using (Model1 context = new Model1())
            {

                if(context != null)
                {
                    context.Cruise.Add(new Cruise() { CruiseName = "СПБ-МСК" });
                    context.Cruise.Add(new Cruise() { CruiseName = "НСК-МСК" });
                    context.SaveChanges();
                }


                SelectRouteCB.ItemsSource = context.Cruise.ToArray();
            }
        }

        private void CancelCruise_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddCruise_Click(object sender, RoutedEventArgs e)
        {
            Model1 context = new Model1();
            context.Cruise.Add(new Cruise()
            {
                CruiseDate = CruiseDateDP.SelectedDate,
                CruiseName = SelectRouteCB.SelectedItem.ToString(),
            }); 
            context.SaveChanges();
        }
    }
}

