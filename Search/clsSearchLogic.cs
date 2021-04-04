using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// Written by Randi Weston
namespace CS3280_GroupProject.Search
{
    /// <summary>
    /// Class to manage the business logic for the search window.
    /// </summary>
    class clsSearchLogic
    {
        #region Attributes
        /// <summary>
        /// Data Access variable used to access the database
        /// </summary>
        private clsDataAccess db;

        /// <summary>
        /// clsSearchSQL variable to hold the instantiation of the clsSearchSQL class.
        /// </summary>
        private clsSearchSQL clsSearchSQLObj;

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
        /// This list is used by the dgInvoices data grid in the Search Window.
        /// </summary>
        public BindingList<clsInvoice> lstInvoiceList;

        /// <summary>
        /// List of integers to store and interact with the list of invoice IDs returned from the database.
        /// This list is used by the cboInvoiceID combo box in the Search Window.
        /// </summary>
        public ObservableCollection<string> lstInvoiceIDList;

        /// <summary>
        /// List of DateTimes to store and interact with the list of invoice dates returned from the database.
        /// This list is used by the cboInvoiceDate combo box in the Search Window.
        /// </summary>
        public ObservableCollection<string> lstInvoiceDateList;

        /// <summary>
        /// List of decimals to store and interact with the list of invoice total costs returned from the database.
        /// This list is used by the cboInvoiceTotal combo box in the Search Window.
        /// </summary>
        public ObservableCollection<string> lstInvoiceTotalList;
        #endregion

        #region Properties
        #endregion

        #region Methods
        /// <summary>
        /// Constructor method for the clsSearchLogic class. The constructor instantiates the clsDataAccess class to 
        /// provice access to the database. It also retrieves the dsInvoices dataset and instantiates the lstInvoiceIDList,
        /// the lstInvoiceDateList, and the lstInvoiceTotalList and populates them.
        /// </summary>
        public clsSearchLogic()
        {
            try
            {
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

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

        // Method to update Invoice list for DataGrid - 3 params
        public void UpdateInvoices(string sID, string sDate, string sTotal)
        {
            try
            {
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to return the InvoiceID of an invoice given the invoice's index in the lstInvoiceList.
        /// </summary>
        /// <param name="iIndex">Integer value representing an invoice's index in the lstInvoiceList</param>
        /// <returns>The given invoice's InvoiceID</returns>
        public int GetSelectedInvoiceID(int iIndex)
        {
            try
            {
                return 0;
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to reset the lstInvoiceList.
        /// </summary>
        public void Reset()
        {
            try
            {
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to populate the lstInvoiceIDList.
        /// </summary>
        /// <returns>The populated lstInvoideIDList</returns>
        public ObservableCollection<string> GetInvoiceIDs()
        {
            try
            {
                return lstInvoiceIDList;
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to populate the lstInvoiceDatesList.
        /// </summary>
        /// <returns>The populated lstInvoideDatesList</returns>
        public ObservableCollection<string> GetInvoiceDates()
        {
            try
            {
                return lstInvoiceDateList;
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to populate the lstInvoiceTotalsList.
        /// </summary>
        /// <returns>The populated lstInvoideTotalsList</returns>
        public ObservableCollection<string> GetInvoiceTotals()
        {
            try
            {
                return lstInvoiceTotalList;
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        #endregion
    }
}
