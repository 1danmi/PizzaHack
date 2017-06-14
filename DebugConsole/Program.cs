using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace DebugConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var database = FactoryDatabase.getDatabase();
                var customers = database.getCustomers();
                foreach (var customer in customers.OrderBy(x => x.CustID))
                {
                    Console.WriteLine(customer.ToString());
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
