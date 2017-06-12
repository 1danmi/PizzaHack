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
        private int storeID;
        private String storeName;
        private String storeURL;
        private String phoneNumber;
        private bool kosher;

        //Properties
        public int StoreID { get => storeID; set => storeID = value; }
        public String StoreName { get => storeName; set => storeName = value; }
        public String StoreURL { get => storeURL; set => storeURL = value; }
        public String PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public bool Kosher { get => kosher; set => kosher = value; }

        /// <summary>
        /// Class constaructor
        /// </summary>
        /// <param name="storeID">The store's ID number</param>
        /// <param name="storeName">The store's name</param>
        /// <param name="storeURL">The store's website</param>
        /// <param name="phoneNumber">The store's phone number</param>
        /// <param name="kosher">Boolean represents whether the store is kosher or not</param>
        public Store(int storeID, String storeName, String storeURL, String phoneNumber, bool kosher)
        {
            this.storeID = storeID;
            this.storeName = storeName;
            this.storeURL = storeURL;
            this.phoneNumber = phoneNumber;
            this.kosher = kosher;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Store()
        {
            this.storeID = 0;
            this.storeName = null;
            this.storeURL = null;
            this.phoneNumber = null;
            this.kosher = false;
        }

        


    }
}
