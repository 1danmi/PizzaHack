using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
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
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        private IDatabase db = FactoryDatabase.getDatabase();
        public CustomerPage()
        {
            InitializeComponent();
            this.customerDataGrid.ItemsSource = DataSource.customers;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService?.Navigate(new AddCustomerPage());
        }

        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var obj = ((FrameworkElement)sender).DataContext as Customer;
                if (obj != null) FactoryDatabase.getDatabase().delCustomer(obj.CustID);
                DataSource.setCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void customerDataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            var row = (e.Row).DataContext as Customer;
            FactoryDatabase.getDatabase().updateCustomer(row.CustID, row);
            DataSource.setCustomerList();
        }
    }
}