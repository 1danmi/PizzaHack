using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {

        //Properties
        public int OrderID { get; set; }

        public bool OrderDeliv { get; set; }

        public int CustID { get; set; }

        public int StoreID { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="orderID"> The order's ID number </param>
        /// <param name="orderDeliv"> Boolean represents whether the order needs delivery or not </param>
        /// <param name="custID"> The ID of the customer who placed the order</param>
        /// <param name="storeID"> The ID of the store in which the order had placed</param>
        public Order(int orderID, bool orderDeliv, int custID, int storeID)
        {
            this.OrderID = orderID;
            this.OrderDeliv = orderDeliv;
            this.CustID = custID;
            this.StoreID = storeID;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Order()
        {
            this.OrderID = 0;
            this.OrderDeliv = false;
            this.CustID = 0;
            this.StoreID = 0;
        }

        /// <summary>
        /// Overide toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{OrderID}\t{OrderDeliv}\t{CustID}\t{StoreID}";
    

        
    }
}
