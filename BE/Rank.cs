using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Rank
    {

        //Properties
        public int RankID { get; set; }

        public string RankDescription { get; set; }

        public int RankSalary { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="rankID"> The rank's ID </param>
        /// <param name="rankDescription">The rank's description</param>
        /// <param name="rankSalary"> The salary that an employee in this rank is being paid</param>
        public Rank(int rankID, string rankDescription, int rankSalary)
        {
            this.RankID = rankID;
            this.RankDescription = rankDescription;
            this.RankSalary = rankSalary;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Rank()
        {
            this.RankID = 0;
            this.RankDescription = null;
            this.RankSalary = 0;
        }


        /// <summary>
        /// Overide toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{RankID}\t{RankDescription}\t{RankSalary}";

        
    }
}
