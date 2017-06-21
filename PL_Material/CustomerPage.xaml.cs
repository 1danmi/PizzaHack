﻿using System;
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
        public CustomerPage()
        {
            InitializeComponent();
            //this.customerDataGrid.ItemsSource = Database.customerDataSet.Tables[0].DefaultView;
            this.customerDataGrid.ItemsSource = DataSource.getCustomerList();
            
        }

        private void customerDataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                var newItem = e.Row.DataContext as Customer;
                newItem.CustID = FactoryDatabase.getDatabase().getNewCustomerID();
                
            }
        }
    }
}