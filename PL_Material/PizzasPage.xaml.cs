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
    /// Interaction logic for PizzasPage.xaml
    /// </summary>
    public partial class PizzasPage : Page
    {
        private IDatabase db = FactoryDatabase.getDatabase();
        public int orderid;

        public PizzasPage(int orderID)
        {
            orderid = orderID;
            InitializeComponent();
            this.pizzaDataGrid.ItemsSource = DataSource.pizzas.Where(x => x.OrderID == orderid);
        }

        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Order completed successfully!");
            while (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
    }
}