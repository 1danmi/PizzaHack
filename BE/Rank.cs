using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Rank
    {
        //Members
        private int rankID;
        private String rankDescription;
        private int rankSalary;

        //Properties
        public int RankID { get => rankID; set => rankID = value; }
        public string RankDescription { get => rankDescription; set => rankDescription = value; }
        public int RankSalary { get => rankSalary; set => rankSalary = value; }

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



    }
}
