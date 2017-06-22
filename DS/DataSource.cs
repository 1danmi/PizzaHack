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
//        public static List<Customer> customers_dt = new List<Customer>();
//        public static DataSet customers_dt = new DataSet();
        public static DataSet customers_dt = new DataSet();
        public static ObservableCollection<Customer> customers= new ObservableCollection<Customer>();
        public static List<Dough> doughs = new List<Dough>();
        public static List<Employee> employees = new List<Employee>();
        public static List<Order> orders = new List<Order>();
        public static List<Pizza> pizzas = new List<Pizza>();
        public static List<PizzaBase> pizzasBase = new List<PizzaBase>();
        public static List<PizzaBaseSize> pbSize = new List<PizzaBaseSize>();
        public static List<Rank> ranks = new List<Rank>();
        public static List<Store> stores = new List<Store>();
        public static List<ToppingType> toppingTypes = new List<ToppingType>();

        public static void setCustomerList()
        {
           RemoveAllCustomers();
            foreach (DataRow row in customers_dt.Tables[0].Rows)
            {
                if (!(row["CUSTID"] is DBNull)  && !(row["CUSTNAME"] is DBNull))
                    customers.Add(new Customer
                    {
                        CustID = Convert.ToInt32(row["CUSTID"]),
                        CustName = row["CUSTNAME"].ToString(),
                        CustAddress = row["CUSTADDRESS"].ToString(),
                        CustPhoneNum = row["CUSTPHONENUM"].ToString(),
                        CustCc = row["CUSTCC"].ToString(),
                        CustCredit = Convert.ToInt32(row["CUSTCREDIT"])
                    });
                
            }
            
        }

        public static void RemoveAllCustomers()
        {
            for (var i = customers.Count - 1; i >= 0; i--)
            {
                customers.RemoveAt(i);
                
            }
        }
    }
}
