﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Customer
    {
        //Members
        private int custID;
        private String custName;
        private String custAddress;
        private String custCc;
        private int custCredit;

        //Properties
        public int CustID { get => custID; set => custID = value; }
        public String CustName { get => custName; set => custName = value; }
        public String CustAddress { get => custAddress; set => custAddress = value; }
        public String CustCc { get => custCc; set => custCc = value; }
        public int CustCredit { get => custCredit; set => custCredit = value; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="custID">The coustomer's ID</param>
        /// <param name="custName">The customer's name</param>
        /// <param name="custAddress"> The customer's address</param>
        /// <param name="custCc">The 4 last digits og the customer's credit card</param>
        /// <param name="custCredit">The credit the customer had gained</param>
        public Customer(int custID, String custName, String custAddress, String custCc, int custCredit)
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

        public override string ToString()
        {
            return this.CustID.ToString() + "\t" 
                + this.CustName + "\t" 
                + this.CustAddress + "\t"
                + this.CustCc + "\t"
                + this.CustCredit;
        }
    }
}
