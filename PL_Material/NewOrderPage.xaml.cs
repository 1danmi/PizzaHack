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
        private IDatabase db = FactoryDatabase.getDatabase();
        private Customer customer = new Customer();
        public NewOrderPage()
        {
            InitializeComponent();
            var bl = FactoryDatabase.getDatabase();
            bl.loadLists();
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
                {
                    this.storesComboBox.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f44336"));
                    throw new Exception("Store doesn't exist!");
                }
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
                if (validateFields())
                {
                   
                    var store = DS.DataSource.stores.FirstOrDefault(
                        x => x.StoreName == storesComboBox.SelectedItem as string);
                    if (store == null)
                    {
                        this.storesComboBox.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f44336"));
                        throw new Exception("Store doesn't exist!");
                    }
                    customer.CustID = FactoryDatabase.getDatabase().getNewCustomerID();
                    FactoryDatabase.getDatabase().addCustomer(customer);
                    if (FactoryDatabase.getDatabase().new_customers(customer.CustID))
                        MessageBox.Show($"You are the {customer.CustID}th customer! You won an extra credit!");
                    App.currentOrder.StoreID = store.StoreID;
                    if (delivCheckBox.IsChecked != null) App.currentOrder.OrderDeliv = delivCheckBox.IsChecked.Value;
                    App.currentOrder.OrderID = FactoryDatabase.getDatabase().getNewOrderID();
                    App.currentOrder.CustID = customer.CustID;
                    DataSource.setCustomerList();
                    var p = new NewOrderDetailsPage();
                    db.addOrder(App.currentOrder);
                    NavigationService?.Navigate(p);
                }
                else
                    MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool validateFields()
        {
            bool flag = true;
            var red = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f44336"));
            var black = SystemColors.ControlDarkBrush;
            this.nameTextBox.BorderBrush = black;
            this.phoneTextBox.BorderBrush = black;
            this.ccTextBox.BorderBrush = black;
            this.creditTextBox.BorderBrush = black;
            this.addressTextBox.BorderBrush = black;


            if (customer.CustName == "")
            {
                this.nameTextBox.BorderBrush = red;
                flag = false;
            }
            if (customer.CustAddress == "")
            {
                this.addressTextBox.BorderBrush = red;
                flag = false;
            }
            if (customer.CustPhoneNum == "")
            {
                this.phoneTextBox.BorderBrush = red;
                flag = false;
            }
            if (customer.CustCc == "")
            {
                this.ccTextBox.BorderBrush = red;
                flag = false;
            }
            if (customer.CustCredit == 0)
            {
                this.creditTextBox.BorderBrush = red;
                flag = false;
            }
            return flag;

        }
    }
}
