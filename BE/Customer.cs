using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Customer
    {
      
        //Properties
        public int CustID { get; set; }

        public string CustName { get; set; }

        public string CustAddress { get; set; }

        public string CustCc { get; set; }

        public int CustCredit { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="custID">The coustomer's ID</param>
        /// <param name="custName">The customer's name</param>
        /// <param name="custAddress"> The customer's address</param>
        /// <param name="custCc">The 4 last digits og the customer's credit card</param>
        /// <param name="custCredit">The credit the customer had gained</param>
        public Customer(int custID, string custName, string custAddress, string custCc, int custCredit)
        {
            this.CustID = custID;
            this.CustName = custName;
            CustAddress = custAddress;
            this.CustCc = custCc;
            this.CustCredit = custCredit;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Customer()
        {
            this.CustID = 0;
            this.CustName = null;
            this.CustAddress = null;
            this.CustCc = null;
            this.CustCredit = 0;
        }

        /// <summary>
        /// Overide toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{CustID}\t{CustName}\t{CustAddress}\t{CustCc}\t{CustCredit}";



    }
}
