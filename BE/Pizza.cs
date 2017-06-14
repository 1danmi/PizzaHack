using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pizza
    {
     
        //Properties
        public int BaseID { get; set; }

        public int OrderID { get; set; }

        public int ToppingIdL { get; set; }

        public int ToppingIdR { get; set; }

        public int PizzaID { get; set; }

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

        /// <summary>
        /// Overide toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{PizzaID}\t{BaseID}\t{OrderID}\t{ToppingIdL}\tToppingIdR";
        
    }
}
