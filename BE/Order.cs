using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Order
    {
        //Members
        private int orderID;
        private bool orderDeliv;
        private int custID;
        private int storeID;

        //Properties
        public int OrderID { get => orderID; set => orderID = value; }
        public bool OrderDeliv { get => orderDeliv; set => orderDeliv = value; }
        public int CustID { get => custID; set => custID = value; }
        public int StoreID { get => storeID; set => storeID = value; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="orderID"> The order's ID number </param>
        /// <param name="orderDeliv"> Boolean represents whether the order needs delivery or not </param>
        /// <param name="custID"> The ID of the customer who placed the order</param>
        /// <param name="storeID"> The ID of the store in which the order had placed</param>
        public Order(int orderID, bool orderDeliv, int custID, int storeID)
        {
            this.orderID = orderID;
            this.orderDeliv = orderDeliv;
            this.custID = custID;
            this.storeID = storeID;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Order()
        {
            this.orderID = 0;
            this.orderDeliv = false;
            this.custID = 0;
            this.storeID = 0;
        }

    }
}
