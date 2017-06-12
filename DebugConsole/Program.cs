using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace DebugConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Customer> customers = Database.getCustomer();
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
            Console.ReadLine();

        }
    }
}
