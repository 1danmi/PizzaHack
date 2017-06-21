using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Collections.ObjectModel;
using System.Data;


namespace DS
{
    public class DataSource
    {
//        public static List<Customer> customers = new List<Customer>();
//        public static DataSet customers = new DataSet();
        public static DataTable customers = new DataTable();
        public static List<Dough> doughs = new List<Dough>();
        public static List<Employee> employees = new List<Employee>();
        public static List<Order> orders = new List<Order>();
        public static List<Pizza> pizzas = new List<Pizza>();
        public static List<PizzaBase> pizzasBase = new List<PizzaBase>();
        public static List<PizzaBaseSize> pbSize = new List<PizzaBaseSize>();
        public static List<Rank> ranks = new List<Rank>();
        public static List<Store> stores = new List<Store>();
        public static List<ToppingType> toppingTypes = new List<ToppingType>();

        public static List<Customer> getCustomerList()
        {
            return customers.AsEnumerable().Select(dataRow => new Customer
            {
                CustID = Convert.ToInt32(dataRow.Field<decimal>("CUSTID")),
                CustName = dataRow.Field<string>("CUSTNAME"),
                CustAddress = dataRow.Field<string>("CUSTADDRESS"),
                CustPhoneNum = dataRow.Field<string>("CUSTPHONENUM"),
                CustCc = dataRow.Field<string>("CUSTCC"),
                CustCredit = Convert.ToInt32(dataRow.Field<decimal>("CUSTCREDIT"))
            }).ToList();
            
        }
    }
}
