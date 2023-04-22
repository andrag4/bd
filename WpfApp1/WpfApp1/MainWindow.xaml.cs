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
using WpfApp1.Forms;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (Model1 context = new Model1())
            { 
                
            } 
            
        }


        private void TicketItem_Click(object sender, RoutedEventArgs e)
        {
           TicketWindow ticketWindow = new TicketWindow();
            ticketWindow.ShowDialog();
            
        }

        private void CruiseItem_Click(object sender, RoutedEventArgs e)
        {
           CruiseWindow CruiseWindow = new CruiseWindow();
            CruiseWindow.ShowDialog();
        }

        private void RouteItem_Click(object sender, RoutedEventArgs e)
        {
            RouteWindow routeWindow = new RouteWindow();
            routeWindow.ShowDialog();
        }

        private void CategoryItem_Click(object sender, RoutedEventArgs e)
        {
            CategoryWindow categoryWindow = new CategoryWindow();
            categoryWindow.ShowDialog();
        }

        private void DestinationItem_Click_1(object sender, RoutedEventArgs e)
        {
            DestinationWindow destinationWindow = new DestinationWindow();
            destinationWindow.ShowDialog();
        }
    }

   
}
