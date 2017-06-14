using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PizzaBaseSize
    {

        //Properties
        public int PbsID { get; set; }

        public string PdsSize { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="pbsID"></param>
        /// <param name="pdsSize"></param>
        public PizzaBaseSize(int pbsID, string pdsSize)
        {
            this.PbsID = pbsID;
            this.PdsSize = pdsSize;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public PizzaBaseSize()
        {
            this.PbsID = 0;
            this.PdsSize = null;
        }

        /// <summary>
        /// Overides toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{PbsID}\t{PdsSize}";
        
    }
}
