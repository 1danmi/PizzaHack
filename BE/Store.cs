using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Store
    {
        //Members

        //Properties
        public int StoreID { get; set; }

        public string StoreName { get; set; }

        public string StoreURL { get; set; }

        public string PhoneNumber { get; set; }

        public bool Kosher { get; set; }

        /// <summary>
        /// Class constaructor
        /// </summary>
        /// <param name="storeID">The store's ID number</param>
        /// <param name="storeName">The store's name</param>
        /// <param name="storeURL">The store's website</param>
        /// <param name="phoneNumber">The store's phone number</param>
        /// <param name="kosher">Boolean represents whether the store is kosher or not</param>
        public Store(int storeID, string storeName, string storeURL, string phoneNumber, bool kosher)
        {
            this.StoreID = storeID;
            this.StoreName = storeName;
            this.StoreURL = storeURL;
            this.PhoneNumber = phoneNumber;
            this.Kosher = kosher;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Store()
        {
            this.StoreID = 0;
            this.StoreName = null;
            this.StoreURL = null;
            this.PhoneNumber = null;
            this.Kosher = false;
        }

        /// <summary>
        /// Overides toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{StoreID}\t{StoreName}\t{StoreURL}\t{PhoneNumber}\t{Kosher}";
        
    }
}