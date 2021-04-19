using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_GroupProject.Main
{
    class clsMainLogic
    {
        #region Attributes
        /// <summary>
        /// Data Access variable used to access the database
        /// </summary>
        private clsDataAccess db;

        /// <summary>
        /// clsSearchSQL variable to hold the instantiation of the clsSearchSQL class.
        /// </summary>
        private clsMainSQL clsMainSQLObj;

        /// <summary>
        /// DataSet variable used to store the set of invoices returned from the database.
        /// </summary>
        private InvoiceDataSet dsInvoices;

        /// <summary>
        /// DataSet variable used to store the set of distinct invoice dates returned from the database.
        /// </summary>
        private InvoiceDataSet dsInvoiceDates;

        /// <summary>
        /// DataSet variable used to store the set of distinct invoice totals returned from the database.
        /// </summary>
        private InvoiceDataSet dsInvoiceTotals;

        /// <summary>
        /// Integer variable used to store the number of invoices returned from the database.
        /// </summary>
        private int iInvoiceRet = 0;

        /// <summary>
        /// Integer variable used to store the number of invoice dates returned from the database.
        /// </summary>
        private int iDatesRet = 0;

        /// <summary>
        /// Integer variable used to store the number of invoice totals returned from the database.
        /// </summary>
        private int iTotalsRet = 0;

        /// <summary>
        /// List of clsInvoice objects to store and interact with the list of invoices returned from the database.
        /// </summary>
        public BindingList<clsInvoice> lstInvoiceList;


        #endregion

        #region Methods

        /// <summary>
        /// Method to retrieve a list of invoices from the database for use in the dgInvoices data grid.
        /// </summary>
        public BindingList<clsInvoice> GetInvoices()
        {
            try
            {
                return lstInvoiceList;
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to create an invoicce by inserting the new data into the database
        /// </summary>
        public void CreateInvoice()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to delete an invoice that has been saved in the database
        /// </summary>
        public void DeleteInvoice()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }



        #endregion

    }
}