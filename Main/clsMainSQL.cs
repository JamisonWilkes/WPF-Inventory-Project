using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_GroupProject.Main
{
    class clsMainSQL
    {
        clsDataAccess db = new clsDataAccess();

        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID.
        /// </summary>
        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>
        /// <returns>All data for the given invoice.</returns>
        public string getInvoices()

        {
            string sSQL = "SELECT InvoiceNum, InvoiceDate, TotalCost FROM Invoices";
            return sSQL;
        }

        /// <summary>
        /// This SQK gets all of the Item Descriptions
        /// </summary>
        /// <returns></returns>
        public string SelectItemsData()
        {

            string sSQL = "SELECT ItemCode, ItemDesc, Cost FROM ItemDesc";
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


        public string InsertInvoice(string sInvoiceDate, string sTotalCost)
        {
            string sSQL = "INSERT INTO Invoices(InvoiceDate, TotalCost) " +
            "VALUES('" + sInvoiceDate + "' ,'" + sTotalCost + "') ";
            
            return sSQL;
        }

        public string getNewestInvoice()
        {
            string sSQL = "SELECT MAX(InvoiceNum) FROM Invoices";
            return sSQL;
        }
    }
}
