using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Dough
    {
        //Members
        private int doughID;
        private string name;

        //Properties
        public int DoughID { get => doughID; set => doughID = value; }
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="doughID"> The dough's ID number</param>
        /// <param name="name">The dough's name</param>
        public Dough(int doughID, string name)
        {
            this.doughID = doughID;
            this.name = name;
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Dough()
        {
            this.doughID = 0;
            this.name = "";
        }

        public override string ToString()
        {
            return doughID + "\t" + name;
        }
    }
}
