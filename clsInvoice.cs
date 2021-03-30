using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_GroupProject
{
    class clsInvoice
    {
        #region Attributes
        /// <summary>
        /// Integer variable to store the invoice number.
        /// </summary>
        private int iInvoiceNum;

        /// <summary>
        /// DateTime variable to store the invoice date;
        /// </summary>
        private DateTime dtInvoiceDate;

        /// <summary>
        /// Decimal variable to store the invoice cost;
        /// </summary>
        private decimal dTotalCost;

        /// <summary>
        /// List of clsLineItems objects to store the invoice's line items.
        /// </summary>
        List<clsLineItem> clsLineItemsInvoice;
        #endregion

        #region Properties
        public int IInvoiceNum { get; set; }
        public DateTime DTInvoiceDate { get; set; }
        public decimal DTotalCost { get; set; }
        public List<clsLineItem> CLSLineItemsInvoice { get; }
        #endregion

        #region Methods
        #endregion
    }
}
