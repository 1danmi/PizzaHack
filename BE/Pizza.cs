using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pizza
    {
        //Members
        private int baseID;
        private int orderID;
        private int toppingIdL;
        private int toppingIdR;
        private int pizzaID;

        //Properties
        public int BaseID { get => baseID; set => baseID = value; }
        public int OrderID { get => orderID; set => orderID = value; }
        public int ToppingIdL { get => toppingIdL; set => toppingIdL = value; }
        public int ToppingIdR { get => toppingIdR; set => toppingIdR = value; }
        public int PizzaID { get => pizzaID; set => pizzaID = value; } 

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="baseID"></param>
        /// <param name="orderID"></param>
        /// <param name="toppingIdL"></param>
        /// <param name="toppingIdR"></param>
        /// <param name="pizzaID"></param>
        public Pizza(int baseID, int orderID, int toppingIdL, int toppingIdR, int pizzaID)
        {
            this.BaseID = baseID;
            this.OrderID = orderID;
            this.ToppingIdL = toppingIdL;
            this.ToppingIdR = toppingIdR;
            this.PizzaID = pizzaID;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Pizza()
        {
            this.BaseID = 0;
            this.OrderID = 0;
            this.ToppingIdL = 0;
            this.ToppingIdR = 0;
            this.PizzaID = 0;
        }

        public override string ToString()
        {
            return pizzaID + "\t"
                + baseID + "\t"
                + orderID + "\t"
                + toppingIdL + "\t"
                + toppingIdR;
        }
    }
}
