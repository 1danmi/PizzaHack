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
using BE;
using DAL;
using DS;

namespace PL_Material
{
    /// <summary>
    /// Interaction logic for GetOrderIDWindow.xaml
    /// </summary>
    public partial class GetCustomerIDWindow : Window
    {
        IDatabase db;
        Customer customer;
        public GetCustomerIDWindow()
        {
            db = FactoryDatabase.getDatabase();
            InitializeComponent();
            customer = new Customer();
            this.DataContext = customer;

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else
                this.WindowState = WindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var c = DataSource.customers.FirstOrDefault(x => x.CustID == customer.CustID);
                if ( c== null)
                    throw new Exception("Order doesn't exist!");
                //if (db.getOrder(customer.OrderID).Time.Date != DateTime.Now.Date)
                //    throw new Exception("You can change only customer from today!");
                var w = this.Owner as MainWindow;
                var t = w.MainFrame.Content as NewOrderPage;
                var p = new NewOrderDetailsPage();
                App.currentOrder.CustID = c.CustID;
                t.NavigationService.Navigate(p);
                var w2 = Window.GetWindow(this) as GetCustomerIDWindow;
                w2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            GetCustomerIDWindow w = Window.GetWindow(this) as GetCustomerIDWindow;
            w.Close();
        }
    }
}
