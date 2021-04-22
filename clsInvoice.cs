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
        private string sInvoiceNum;

        /// <summary>
        /// DateTime variable to store the invoice date;
        /// </summary>
        private DateTime sInvoiceDate;

        /// <summary>
        /// Decimal variable to store the invoice cost;
        /// </summary>
        private decimal sTotalCost;
        #endregion

        #region Properties
        public string SInvoiceNum { get; set; }
        public string SInvoiceDate { get; set; }
        public string STotalCost { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
