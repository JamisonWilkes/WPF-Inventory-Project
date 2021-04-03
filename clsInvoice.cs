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
        #endregion

        #region Properties
        public int IInvoiceNum { get; set; }
        public DateTime DTInvoiceDate { get; set; }
        public decimal DTotalCost { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
