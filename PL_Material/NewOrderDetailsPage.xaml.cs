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
    /// Interaction logic for NewOrderDetailsPage.xaml
    /// </summary>
    public partial class NewOrderDetailsPage : Page
    {
        private IDatabase db = FactoryDatabase.getDatabase();
        private Pizza pizza = new Pizza();
        private PizzaBase pBase = new PizzaBase();

        public NewOrderDetailsPage()
        {
            InitializeComponent();
            pizza.OrderID = App.currentOrder.OrderID;
            doughComboBox.ItemsSource = DataSource.doughs.Select(x => x.Name);
            sizeComboBox.ItemsSource = DataSource.pbSize.Select(x => x.PdsSize);
            rightComboBox.ItemsSource = DataSource.toppingTypes.Select(x => x.TopTypeName);
            leftComboBox.ItemsSource = DataSource.toppingTypes.Select(x => x.TopTypeName);
        }


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (addPizza())
            {
                MessageBox.Show("Pizza added successfully!");
                this.NavigationService.Navigate(new NewOrderDetailsPage());
            }
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            if (addPizza())
            {
                var pPage = new PizzasPage(App.currentOrder.OrderID);
                db.loadLists();
                this.NavigationService?.Navigate(pPage);
                

            }
        }

        private bool addPizza()
        {
            try
            {
                pBase.BaseID = db.getNewPizzaBaseID();
                var dough = DataSource.doughs.FirstOrDefault(x => x.Name == doughComboBox.SelectedItem as string);
                if (dough == null)
                {
                    this.doughComboBox.BorderBrush = (SolidColorBrush) (new BrushConverter().ConvertFrom("#f44336"));
                    throw new Exception("Please select a valid dough!");
                }
                pBase.Dough = dough.DoughID;
                var size = DataSource.pbSize.FirstOrDefault(x => x.PdsSize == sizeComboBox.SelectedItem as string);
                if (size == null)
                {
                    this.sizeComboBox.BorderBrush = (SolidColorBrush) (new BrushConverter().ConvertFrom("#f44336"));
                    throw new Exception("Please select a valid pizza size!");
                }
                pBase.PbsID = size.PbsID;

                pizza.PizzaID = db.getNewPizzaID();
                pizza.BaseID = pBase.BaseID;

                var rTopping =
                    DataSource.toppingTypes.FirstOrDefault(x => x.TopTypeName == rightComboBox.SelectedItem as string);
                if (rTopping == null)
                {
                    this.rightComboBox.BorderBrush = (SolidColorBrush) (new BrushConverter().ConvertFrom("#f44336"));
                    throw new Exception("Please select a valid right topping!");
                }
                pizza.ToppingIdR = rTopping.TopTypeID;
                var lTopping =
                    DataSource.toppingTypes.FirstOrDefault(x => x.TopTypeName == leftComboBox.SelectedItem as string);
                if (lTopping == null)
                {
                    this.leftComboBox.BorderBrush = (SolidColorBrush) (new BrushConverter().ConvertFrom("#f44336"));
                    throw new Exception("Please select a valid left topping!");
                }
                pizza.ToppingIdL = lTopping.TopTypeID;
                db.addPizzaBase(pBase);
                db.addPizza(pizza);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}