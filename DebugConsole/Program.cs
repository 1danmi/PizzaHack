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
                var toppingTypes = database.getToppingTypes();
                foreach (var toppingType in toppingTypes.OrderBy(x => x.TopTypeID))
                {
                    Console.WriteLine(toppingType.ToString());
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
