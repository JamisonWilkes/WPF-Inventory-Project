using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_GroupProject.Main
{
    class clsMainSQL
    {
        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID.
        /// </summary>
        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceData(string sInvoiceID)

        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID;
            return sSQL;
        }

        /// <summary>
        /// This SQK gets all of the Item Descriptions
        /// </summary>
        /// <returns></returns>
        public string SelectItemsData()
        {
            string sSQL = "SELECT * FROM ItemDesc";
            return sSQL;
        }

        /// <summary>
        /// This SQL gets the Cost of an item given it's item code
        /// </summary>
        /// <param name="sItemCode"></param>
        /// <returns></returns>
        public string SelectItemCost(string sItemCode)
        {
            string sSQL = "SELECT Cost FROM ItemDesc WHERE ItemCode = " + sItemCode;
            return sSQL;
        }

        /// <summary>
        /// this SQK returns the total cost of an invoice given the invoice number
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>
        public string GetTotalCost(string sInvoiceID)
        {
            string sSQL = "SELECT TotalCost FROM Invoices WHERE InvoiceNum = " + sInvoiceID;
            return sSQL;
        }


        public string InsertInvoice()
        {
            string sSQL = " ";
            return sSQL;
        }
    }
}
