using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_GroupProject
{
    class clsItemDesc
    {
        #region Attributes
        /// <summary>
        /// String variable to store the item code.
        /// </summary>
        //public string sItemCode;

        ///// <summary>
        ///// String variable to store the item description.
        ///// </summary>
        //public string sItemDesc;

        ///// <summary>
        ///// Decimal variable to store the item cost.
        ///// </summary>
        //public decimal dCost;
        #endregion

        #region properties
        public string sItemCode { get; set; }
        public string sItemDesc { get; set; }
        public decimal dCost { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// The Tostring method has been overridden to show that this is the default method that is called when controls are bound to collections.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return sItemCode + ": " + sItemDesc + " " + "$" + dCost.ToString();
        }
        #endregion
    }
}
