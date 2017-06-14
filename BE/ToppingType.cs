using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ToppingType
    {
        //Members

        //Properties
        public int TopTypeID { get; set; }

        public string TopTypeName { get; set; }

        public string TopTypeType { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="topTypeID"></param>
        /// <param name="topTypeName"></param>
        /// <param name="topTypeType"></param>
        public ToppingType(int topTypeID, string topTypeName, string topTypeType)
        {
            this.TopTypeID = topTypeID;
            this.TopTypeName = topTypeName;
            this.TopTypeType = topTypeType;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ToppingType()
        {
            this.TopTypeID = 0;
            this.TopTypeName = null;
            this.TopTypeType = null;
        }


        /// <summary>
        /// Overides toString function
        /// </summary>
        /// <returns> A string representation of the class</returns>
        public override string ToString() => $"{TopTypeID}\t{TopTypeName}\t{TopTypeType}";
        

        
    }
}
