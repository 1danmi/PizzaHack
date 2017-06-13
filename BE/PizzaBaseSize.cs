using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PizzaBaseSize
    {
        //Members
        private int pbsID;
        private string pdsSize;

        //Properties
        public int PbsID { get => pbsID; set => pbsID = value; }
        public string PdsSize { get => pdsSize; set => pdsSize = value; }

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

        public override string ToString()
        {
            return pbsID + "\t"
                   + pdsSize;
        }
    }
}
