using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written by Randi Weston
namespace CS3280_GroupProject.Search
{
    /// <summary>
    /// Class to hold functions that construct SQL queries for use in the clsSearchLogic class.
    /// </summary>
    class clsSearchSQL
    {
        /// <summary>
        /// This SQL gets all data for all invoices.
        /// </summary>
        /// <returns>All data for all invoices.</returns>
        public string SelectAllInvoices()
        {
            string sSQL = "SELECT * FROM Invoices";
            return sSQL;
        }

        /// <summary>
        /// This SQL gets a descending list of TotalCosts.
        /// </summary>
        /// <returns>A descending list of TotalCosts</returns>
        public string SetOfCosts()
        {
            string sSQL = "SELECT DISTINCT TotalCost FROM Invoices ORDER BY TotalCost DESC";
            return sSQL;
        }

        /// <summary>
        /// This SQL gets a descending list of InvoiceDates.
        /// </summary>
        /// <returns>A descending list of TotalCosts</returns>
        public string SetOfDates()
        {
            string sSQL = "SELECT DISTINCT InvoiceDate FROM Invoices ORDER BY InvoiceDate DESC";
            return sSQL;
        }

        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID.
        /// </summary>
        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceById(string sInvoiceID)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID;
            return sSQL;
        }

        /// <summary>
        /// This SQL gets all data on invoices for a given InvoiceDate.
        /// </summary>
        /// <param name="sInvoiceDate">The InvoiceDate for the invoices to retrieve all data.</param>
        /// <returns>All data for invoices with a given date.</returns>
        public string SelectInvoiceByDate(string sInvoiceDate)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = #" + sInvoiceDate + "#";
            return sSQL;
        }

        /// <summary>
        /// This SQL gets all data on invoices for a given InvoiceTotal.
        /// </summary>
        /// <param name="sInvoiceTotal">The InvoiceTotal for the invoices to retrieve all data.</param>
        /// <returns>All data for invoices with a given date.</returns>
        public string SelectInvoiceByTotal(string sInvoiceTotal)
        {
            string sSQL = "SELECT * FROM Invoices WHERE TotalCost = " + sInvoiceTotal;
            return sSQL;
        }

        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID and InvoiceDate.
        /// </summary>
        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>
        /// <param name="sInvoiceDate">The InvoiceDate for the invoice to retrieve all data.</param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceByIdAndDate(string sInvoiceID, string sInvoiceDate)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID + " AND InvoiceDate = #" + sInvoiceDate + "#";
            return sSQL;
        }

        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID and InvoiceTotal.
        /// </summary>
        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>
        /// <param name="sInvoiceTotal">The InvoiceTotal for the invoice to retrieve all data.</param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceByIdAndTotal(string sInvoiceID, string sInvoiceTotal)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID + " AND TotalCost = " + sInvoiceTotal;
            return sSQL;
        }

        /// <summary>
        /// This SQL gets all data on invoices for a given InvoiceDate and InvoiceTotal.
        /// </summary>
        /// <param name="sInvoiceDate">The InvoiceDate for the invoice to retrieve all data.</param>
        /// <param name="sInvoiceTotal">The InvoiceTotal for the invoice to retrieve all data.</param>
        /// <returns>All data for the given set of invoices.</returns>
        public string SelectInvoiceByDateAndTotal(string sInvoiceDate, string sInvoiceTotal)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = #" + sInvoiceDate + "# AND TotalCost = " + sInvoiceTotal;
            return sSQL;
        }

        /// <summary>
        /// This SQL gets all data on an invoice for a given InvoiceID, InvoiceDate, and InvoiceTotal.
        /// </summary>
        /// <param name="sInvoiceID">The InvoiceID for the invoice to retrieve all data.</param>
        /// <param name="sInvoiceDate">The InvoiceDate for the invoice to retrieve all data.</param>
        /// <param name="sInvoiceTotal">The InvoiceTotal for the invoice to retrieve all data.</param>
        /// <returns>All data for the given invoice.</returns>
        public string SelectInvoiceByAll(string sInvoiceID, string sInvoiceDate, string sInvoiceTotal)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID + " AND InvoiceDate = #" + sInvoiceDate + "# AND TotalCost = " + sInvoiceTotal;
            return sSQL;
        }
    }
}
