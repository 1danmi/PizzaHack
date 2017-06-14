using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PizzaBase
    {
        
        //Properties
        public int BaseID { get; set; }

        public int PbsID { get; set; }

        public int Dough { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="baseID"></param>
        /// <param name="pbsID"></param>
        /// <param name="dough"></param>
        public PizzaBase(int baseID, int pbsID, int dough)
        {
            this.BaseID = baseID;
            this.PbsID = pbsID;
            this.Dough = dough;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public PizzaBase()
        {
            this.BaseID = 0;
            this.PbsID = 0;
            this.Dough = 0;
        }

        /// <summary>
        /// Overide toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{BaseID}\t{PbsID}\t{Dough}";
        
    }
}
