using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAL
{
    public class Database
    {
        private static string constr = "Data Source=XE;Persist Security Info=True;User ID=PizzaHack;Password=123";
        public static List<Customer> getCustomer()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT CUSTOMERS.* FROM CUSTOMERS";
            List<Customer> customers = new List<Customer>();
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
        public static IEnumerable<Customer> getCustomerStored()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "tables.getcustomertable";
            cmd.CommandType = CommandType.StoredProcedure;

            var reader = cmd.ExecuteNonQuery();

            return null;
        }
    }

    public class FactoryDatabase
    {
        static Database database = null;
        public static Database getDatabase()
        {
            if (database == null)
                database = new Database();
            return database;
        }
    }
}

