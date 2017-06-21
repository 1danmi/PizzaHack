using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Security.Cryptography;
using DS;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
//using System.Data.OracleClient;




namespace DAL
{
    public class Database : IDatabase
    {
        
        private const string constr = "Data Source=XE;Persist Security Info=True;User ID=PizzaHack;Password=123";
        private static readonly OracleDataAdapter customerAdapter = new OracleDataAdapter();
        private static OracleConnection objConn = new OracleConnection(constr);
        public static IEnumerable<Customer> getCustomerStored()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "tables.getcustomertable",
                CommandType = CommandType.StoredProcedure
            };


            var reader = cmd.ExecuteNonQuery();

            return null;
        }

        public void loadLists()
        {
            setCustomerFunctions();
            getCustomers2();
            DataSource.doughs = getDoughs();
            DataSource.employees = getEmployees();
            DataSource.orders = getOrders();
            DataSource.pizzas = getPizzas();
            DataSource.pizzasBase = getPizzaBases();
            DataSource.pbSize = getPizzaBaseSizes();
            DataSource.ranks = getRanks();
            DataSource.stores = getStores();
            DataSource.toppingTypes = getToppingTypes();
        }
        


        #region Customer

        public void addCustomer(Customer d)
        {
            throw new NotImplementedException();
        }

        public bool delCustomer(int custID)
        {
            throw new NotImplementedException();
        }

        public void updateCustomer(int custID, Customer s)
        {
            throw new NotImplementedException();
        }

        public Customer getCustomer(int custID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Dough

        public void addDough(Dough d)
        {
            throw new NotImplementedException();
        }

        public bool delDough(int doughID)
        {
            throw new NotImplementedException();
        }

        public void updateDough(int doughID, Dough s)
        {
            throw new NotImplementedException();
        }

        public Dough getDough(int doughID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Empolyee

        public void addEmployee(Employee d)
        {
            throw new NotImplementedException();
        }

        public bool delEmployee(int empID)
        {
            throw new NotImplementedException();
        }

        public void updateEmployee(int empID, Employee s)
        {
            throw new NotImplementedException();
        }

        public Employee getEmployee(int empID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Order

        public void addOrder(Order d)
        {
            throw new NotImplementedException();
        }

        public bool delOrder(int orderID)
        {
            throw new NotImplementedException();
        }

        public void updateOrder(int orderID, Order s)
        {
            throw new NotImplementedException();
        }

        public Order getOrder(int orderID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Pizza

        public void addPizza(Pizza d)
        {
            throw new NotImplementedException();
        }

        public bool delPizza(int pizzaID)
        {
            throw new NotImplementedException();
        }

        public void updatePizza(int pizzaID, Pizza s)
        {
            throw new NotImplementedException();
        }

        public Pizza getPizza(int pizzaID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region PizzaBase

        public void addPizzaBase(PizzaBase d)
        {
            throw new NotImplementedException();
        }

        public bool delPizzaBase(int PBID)
        {
            throw new NotImplementedException();
        }

        public void updatePizzaBase(int PBID, PizzaBase s)
        {
            throw new NotImplementedException();
        }

        public PizzaBase getPizzaBase(int PBID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region PizzaBaseSize

        public void addPizzaBaseSize(PizzaBaseSize d)
        {
            throw new NotImplementedException();
        }

        public bool delPizzaBaseSize(int PBSID)
        {
            throw new NotImplementedException();
        }

        public void updatePizzaBaseSize(int PBSID, PizzaBaseSize s)
        {
            throw new NotImplementedException();
        }

        public PizzaBaseSize getPizzaBaseSize(int PBSID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Rank

        public void addRank(Rank d)
        {
            throw new NotImplementedException();
        }

        public bool delRank(int rankID)
        {
            throw new NotImplementedException();
        }

        public void updateRank(int rankID, Rank s)
        {
            throw new NotImplementedException();
        }

        public Rank getRank(int rankID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Store

        public void addStore(Store d)
        {
            throw new NotImplementedException();
        }

        public bool delStore(int storeID)
        {
            throw new NotImplementedException();
        }

        public void updateStore(int storeID, Store s)
        {
            throw new NotImplementedException();
        }

        public Store getStore(int storeID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ToppingType

        public void addToppingType(ToppingType d)
        {
            throw new NotImplementedException();
        }

        public bool delToppingType(int TTID)
        {
            throw new NotImplementedException();
        }

        public void updateToppingType(int TTID, ToppingType s)
        {
            throw new NotImplementedException();
        }

        public ToppingType getToppingType(int TTID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region getLists

        public List<Customer> getCustomers()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT CUSTOMERS.* FROM CUSTOMERS"
            };
            var customers = new List<Customer>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    CustID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("CUSTID"))),
                    CustName = reader.GetString(reader.GetOrdinal("CUSTNAME")),
                    CustAddress = reader.GetString(reader.GetOrdinal("CUSTADDRESS")),
                    CustCc = reader.GetString(reader.GetOrdinal("CUSTCC")),
                    CustCredit = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("CUSTCREDIT")))

                });
            }
            return customers;
        }

        public void setCustomerFunctions()
        {
//            using (var objConn = new OracleConnection(constr))
//            {


                var objCmd = new OracleCommand
                {
                    Connection = objConn,
                    CommandText = "Tables.getCustomerTable",
                    CommandType = CommandType.StoredProcedure
                };
                objCmd.Parameters.Add("table_out", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                customerAdapter.SelectCommand = objCmd;

                var objInsertCmd = new OracleCommand
                {
                    Connection = objConn,
                    CommandText = "Tables.insert_customer",
                    CommandType = CommandType.StoredProcedure
                };
                objInsertCmd.Parameters.Add("p_CUSTID", OracleDbType.Decimal).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CUSTNAME", OracleDbType.Varchar2).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CUSTADDRESS", OracleDbType.Varchar2).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CUSTPHONENUM", OracleDbType.Varchar2).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CUSTCC", OracleDbType.Varchar2).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CREDIT", OracleDbType.Decimal).Direction = ParameterDirection.Input;
                customerAdapter.InsertCommand = objInsertCmd;

                var objUpdateCmd = new OracleCommand
                {
                    Connection = objConn,
                    CommandText = "Tables.update_customer",
                    CommandType = CommandType.StoredProcedure
                };
                objInsertCmd.Parameters.Add("p_CUSTID", OracleDbType.Decimal).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CUSTNAME", OracleDbType.Varchar2).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CUSTADDRESS", OracleDbType.Varchar2).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CUSTPHONENUM", OracleDbType.Varchar2).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CUSTCC", OracleDbType.Varchar2).Direction = ParameterDirection.Input;
                objInsertCmd.Parameters.Add("p_CREDIT", OracleDbType.Decimal).Direction = ParameterDirection.Input;
                customerAdapter.UpdateCommand = objUpdateCmd;

                var objDeleteCmd = new OracleCommand
                {
                    Connection = objConn,
                    CommandText = "human_resources.delete_employee",
                    CommandType = CommandType.StoredProcedure
                };
                objDeleteCmd.Parameters.Add("p_CUSTID", OracleDbType.Decimal).Direction = ParameterDirection.Input;
                customerAdapter.DeleteCommand = objDeleteCmd;

//                try
//                {
//                    DataTable dtEmp = new DataTable();
//                    customerAdapter.Fill(dtEmp);
//
//                    System.Console.WriteLine("Employee count = {0}", dtEmp.Rows.Count);
//                    dtEmp.Rows.Add(7935, "John", "Manager", 7782, DateTime.Now, 1300, 0, 10);
//
//                    customerAdapter.Update(dtEmp);
//
//                }
//                catch (Exception ex)
//                {
//                    System.Console.WriteLine("Exception: {0}", ex.ToString());
//                }
//
//                objConn.Close();
//            }
        }

        public void getCustomers2()
        {
//            using (var objConn = new OracleConnection(constr))
//            {
//                var objCmd = new OracleCommand
//                {
//                    Connection = objConn,
//                    CommandText = "Tables.getCustomerTable",
//                    CommandType = CommandType.StoredProcedure
//                };
//                
//                objCmd.Parameters.Add("table_out", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
//                customerAdapter.SelectCommand = objCmd;

                try
                {
                    //                    objConn.Open();
                    //                    objCmd.ExecuteNonQuery();
                    //                    var da = new OracleDataAdapter(objCmd);
                    customerAdapter.Fill(DataSource.customers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
//                objConn.Close();
                
//            }
        }

        public List<Dough> getDoughs()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT DOUGH.* FROM DOUGH"
            };
            var doughs = new List<Dough>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                doughs.Add(new Dough
                {
                    DoughID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("DOUGHID"))),
                    Name = reader.GetString(reader.GetOrdinal("NAME"))

                });
            }
            return doughs;
        }

        public List<Employee> getEmployees()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT EMPLOYEE.* FROM EMPLOYEE"
            };
            var employees = new List<Employee>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                employees.Add(new Employee
                {
                    EmployeeID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("EMPLOYEEID"))),
                    EmployeeName = reader.GetString(reader.GetOrdinal("EMPLOYEENAME")),
                    Bod = reader.GetDateTime(reader.GetOrdinal("BOD")),
                    ShomerShabat = reader.GetString(reader.GetOrdinal("SHOMERSHABAT")) == "1",
                    StoreID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("STOREID"))),
                    RankID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("RANKID")))
                });
            }
            return employees;

        }

        public List<Order> getOrders()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT ORDERS.* FROM ORDERS"
            };
            var orders = new List<Order>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                orders.Add(new Order
                {
                    OrderID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("ORDERID"))),
                    OrderDeliv = reader.GetString(reader.GetOrdinal("ORDERDELIV")) == "1",
                    CustID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("CUSTID"))),
                    StoreID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("STOREID")))
                });
            }
            return orders;
        }

        public List<Pizza> getPizzas()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT Pizza.* FROM Pizza"
            };
            var pizzas = new List<Pizza>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pizzas.Add(new Pizza
                {
                    BaseID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("BASEID"))),
                    OrderID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("ORDERID"))),
                    ToppingIdL = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("TOPPINGIDL"))),
                    ToppingIdR = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("TOPPINGIDR"))),
                    PizzaID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("PIZZAID")))
                });
            }
            return pizzas;
        }

        public List<PizzaBase> getPizzaBases()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT PIZZABASE.* FROM PIZZABASE"
            };
            var pizzaBases = new List<PizzaBase>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pizzaBases.Add(new PizzaBase
                {
                    BaseID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("BASEID"))),
                    PbsID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("PBSID"))),
                    Dough = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("DOUGH")))

                });
            }
            return pizzaBases;
        }

        public List<PizzaBaseSize> getPizzaBaseSizes()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT PIZZABASESIZE.* FROM PIZZABASESIZE"
            };
            var pizzaBaseSizes = new List<PizzaBaseSize>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pizzaBaseSizes.Add(new PizzaBaseSize()
                {
                    
                    PbsID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("PBSID"))),
                    PdsSize = reader.GetString(reader.GetOrdinal("PDSSIZE"))

                });
            }
            return pizzaBaseSizes;
        }

        public List<Rank> getRanks()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT RANKS.* FROM RANKS"
            };
            var ranks = new List<Rank>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ranks.Add(new Rank()
                {

                    RankID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("RANKID"))),
                    RankDescription = reader.GetString(reader.GetOrdinal("RANKDESCRIPTION")),
                    RankSalary = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("RANKSALARY")))

                });
            }
            return ranks;
        }

        public List<Store> getStores()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT STORE.* FROM STORE"
            };
            var stores = new List<Store>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                stores.Add(new Store()
                {

                    StoreID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("STOREID"))),
                    StoreName = reader.GetString(reader.GetOrdinal("STORENAME")),
                    StoreURL = reader.GetString(reader.GetOrdinal("STOREURL")),
                    PhoneNumber = reader.GetString(reader.GetOrdinal("PHONENUMBER")),
                    Kosher = reader.GetString(reader.GetOrdinal("KOSHER")) == "T",

                });
            }
            return stores;
        }

        public List<ToppingType> getToppingTypes()
        {
            var con = new OracleConnection(constr);
            con.Open();
            var cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT TOPPINGTYPE.* FROM TOPPINGTYPE"
            };
            var toppingTypes = new List<ToppingType>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                toppingTypes.Add(new ToppingType()
                {

                    TopTypeID = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("TOPTYPEID"))),
                    TopTypeName = reader.GetString(reader.GetOrdinal("TOPTYPENAME")),
                    TopTypeType = reader.GetString(reader.GetOrdinal("TOPTYPETYPE"))
                });
            }
            return toppingTypes;
        }

        public int getNewCustomerID()
        {
            bool flag;
            int i;
            for (i = 1; i < 100000; i++)
            {
                flag = true;
                foreach (var customer in DataSource.getCustomerList())
                {
                    if (i == customer.CustID)
                    {
                        flag =false;
                        break;
                    }
                }
                if (flag)
                    return i;
            }
            return i;
        }
        #endregion


    }
}



