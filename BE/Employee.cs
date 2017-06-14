using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace BE
{
    public class Employee
    {

        //Properties
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public DateTime Bod { get; set; }

        public bool ShomerShabat { get; set; }

        public int StoreID { get; set; }

        public int RankID { get; set; }

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
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.Bod = bod;
            this.ShomerShabat = shomerShabat;
            this.StoreID = storeID;
            this.RankID = rankID;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Employee()
        {
            this.EmployeeID = 0;
            this.EmployeeName = null;
            this.ShomerShabat = false;
            this.StoreID = 0;
            this.RankID = 0;
        }

        /// <summary>
        /// Overide toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{EmployeeID}\t{EmployeeName}\t{Bod.Date}\t{ShomerShabat}\t{StoreID}\t{RankID}";



}
}
