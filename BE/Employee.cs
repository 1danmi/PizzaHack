using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace BE
{
    class Employee
    {
        //Members
        private int employeeID;
        private String employeeName;
        private DateTime bod;
        private bool shomerShabat;
        private int storeID;
        private int rankID;

        //Properties
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public DateTime Bod { get => bod; set => bod = value; }
        public bool ShomerShabat { get => shomerShabat; set => shomerShabat = value; }
        public int StoreID { get => storeID; set => storeID = value; }
        public int intID { get => rankID; set => rankID = value; }

        /// <summary>
        /// Class constructors
        /// </summary>
        /// <param name="employeeID"> The employees' ID number </param>
        /// <param name="employeeName"> The employee's name </param>
        /// <param name="bod"> The employee's birth date </param>
        /// <param name="shomerShabat"> Boolean represents whether the employee is "shomer shabat" or not </param>
        /// <param name="storeID"> The store in which the employee works /param>
        /// <param name="rankID"> The employee's rank </param>
        public Employee(int employeeID, string employeeName, DateTime bod, bool shomerShabat, int storeID, int rankID)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.bod = bod;
            this.shomerShabat = shomerShabat;
            this.storeID = storeID;
            this.rankID = rankID;
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Employee()
        {
            this.employeeID = 0;
            this.employeeName = null;
            this.shomerShabat = false;
            this.storeID = 0;
            this.rankID = null;
        }

       
    }
}
