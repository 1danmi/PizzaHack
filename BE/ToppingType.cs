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
        private int topTypeID;
        private String topTypeName;
        private String topTypeType;

        //Properties
        public int TopTypeID { get => topTypeID; set => topTypeID = value; }
        public string TopTypeName { get => topTypeName; set => topTypeName = value; }
        public string TopTypeType { get => topTypeType; set => topTypeType = value; }

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


    }
}
