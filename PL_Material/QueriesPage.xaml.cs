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
    /// Interaction logic for QueriesPage.xaml
    /// </summary>
    public partial class QueriesPage : Page
    {
        private IDatabase db = FactoryDatabase.getDatabase();

        public QueriesPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            firstText.Text = db.promotion_average_credit().ToString();
        }
        
    }
}
