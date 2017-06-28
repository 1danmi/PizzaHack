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
using DS;
using DAL;

namespace PL_Material
{
    /// <summary>
    /// Interaction logic for AddCustomerPage.xaml
    /// </summary>
    public partial class AddCustomerPage : Page
    {
        private Customer customer = new Customer();

        public AddCustomerPage()
        {
            InitializeComponent();
            this.customerGrid.DataContext = customer;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            customer.CustID = FactoryDatabase.getDatabase().getNewCustomerID();
            FactoryDatabase.getDatabase().addCustomer(customer);
            if (FactoryDatabase.getDatabase().new_customers(customer.CustID))
                MessageBox.Show($"You are the {customer.CustID}th customer! You won an extra credit!");
            FactoryDatabase.getDatabase().loadLists();
            NavigationService?.GoBack();
        }
    }
}