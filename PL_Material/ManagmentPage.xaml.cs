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
using DAL;

namespace PL_Material
{
    /// <summary>
    /// Interaction logic for ManagmentPage.xaml
    /// </summary>
    public partial class ManagementPage : Page
    {
        public ManagementPage()
        {
            InitializeComponent();
            var bl = FactoryDatabase.getDatabase();
            bl.loadLists();
        }

        private void customersCard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new CustomerPage());
        }

        private void ordesCard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new OrdersPage());
        }


        private void employeesCard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeesPage());

        }

        private void storesCard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new StoresPage());
        }
    }
}
