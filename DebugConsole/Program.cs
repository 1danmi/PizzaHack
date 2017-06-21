using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using DS;


namespace DebugConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var db = FactoryDatabase.getDatabase();
                db.loadLists();
                foreach (var employee in DataSource.employees)
                {
                    Console.WriteLine(employee.Bod.Date.ToString("d"));
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
