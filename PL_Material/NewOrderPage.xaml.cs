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
using DS;
using BE;
using DAL;

namespace PL_Material
{
    /// <summary>
    /// Interaction logic for NewOrderPage.xaml
    /// </summary>
    public partial class NewOrderPage : Page
    {
        private Customer customer = new Customer();
        public NewOrderPage()
        {
            InitializeComponent();
            App.currentOrder = new Order();
            customerGrid.DataContext = customer;
            this.storesComboBox.ItemsSource = DataSource.stores.Where(x => x.StoreID < 50).Select(x => x.StoreName);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var w1 = Window.GetWindow(this) as MainWindow;
                var w2 = new GetCustomerIDWindow {Owner = w1};
                var store = DS.DataSource.stores.FirstOrDefault(
                    x => x.StoreName == storesComboBox.SelectedItem as string);
                if (store == null)
                    throw new Exception("Please choose a store first!");
                App.currentOrder.StoreID = store.StoreID;
                if (delivCheckBox.IsChecked != null) App.currentOrder.OrderDeliv = delivCheckBox.IsChecked.Value;
                App.currentOrder.OrderID = FactoryDatabase.getDatabase().getNewOrderID();
                w2.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                customer.CustID = FactoryDatabase.getDatabase().getNewCustomerID();
                FactoryDatabase.getDatabase().addCustomer(customer);
                var store = DS.DataSource.stores.FirstOrDefault(
                    x => x.StoreName == storesComboBox.SelectionBoxItem as string);
                if (store == null)
                    throw new Exception("Store doesn't exist!");
                App.currentOrder.StoreID = store.StoreID;
                if (delivCheckBox.IsChecked != null) App.currentOrder.OrderDeliv = delivCheckBox.IsChecked.Value;
                App.currentOrder.OrderID = FactoryDatabase.getDatabase().getNewOrderID();
                App.currentOrder.CustID = customer.CustID;
                DataSource.setCustomerList();
                var p = new NewOrderDetailsPage();
                NavigationService?.Navigate(p);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
