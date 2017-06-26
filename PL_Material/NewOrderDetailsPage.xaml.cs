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
       public NewOrderDetailsPage()
        {
            
            InitializeComponent();
            doughComboBox.ItemsSource = DataSource.doughs.Select(x => x.Name);
            sizeComboBox.ItemsSource = DataSource.pbSize.Select(x => x.PdsSize);
            rightComboBox.ItemsSource = DataSource.toppingTypes.Select(x => x.TopTypeName);
            leftComboBox.ItemsSource = DataSource.toppingTypes.Select(x => x.TopTypeName);

        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
