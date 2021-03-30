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
        private string sItemCode;

        /// <summary>
        /// String variable to store the item description.
        /// </summary>
        private string sItemDesc;

        /// <summary>
        /// Decimal variable to store the item cost.
        /// </summary>
        private decimal dCost;
        #endregion

        #region Properties
        public string SItemCode { get; set; }
        public string SItemDesc { get; set; }
        public decimal DCost { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
