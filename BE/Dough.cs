using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Dough
    {
        
        //Properties
        public int DoughID { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="doughID"> The dough's ID number</param>
        /// <param name="name">The dough's name</param>
        public Dough(int doughID, string name)
        {
            this.DoughID = doughID;
            this.Name = name;
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Dough()
        {
            this.DoughID = 0;
            this.Name = "";
        }

        /// <summary>
        /// Overide toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{DoughID}\t{Name}";
        
    }
}
