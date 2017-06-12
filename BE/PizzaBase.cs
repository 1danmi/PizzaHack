using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PizzaBase
    {
        //Members
        private int baseID;
        private int pbsID;
        private int dough;

        //Properties
        public int BaseID { get => baseID; set => baseID = value; }
        public int PbsID { get => pbsID; set => pbsID = value; }
        public int Dough { get => dough; set => dough = value; }

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

    }
}
