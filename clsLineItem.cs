using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_GroupProject
{
    class clsLineItem
    {
        #region Attributes
        /// <summary>
        /// Integer variable to store the invoice number.
        /// </summary>
        private int iInvoiceNum;

        /// <summary>
        /// Integer variable to store the line item number.
        /// </summary>
        private int iLineItemNum;

        /// <summary>
        /// String variable to store the item code.
        /// </summary>
        private string sItemCode;
        #endregion

        #region Properties
        public int IInvoiceNum { get; set; }
        public int ILineItemNum { get; set; }
        public string SItemCode { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
