using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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
        private clsDataAccess db = new clsDataAccess();

        /// <summary>
        /// clsSearchSQL variable to hold the instantiation of the clsSearchSQL class.
        /// </summary>
        private clsMainSQL clsMainSQL;

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

        public ObservableCollection<clsItemDesc> ItemDescriptionList { get; set; }


        #endregion

        #region Methods

        /// <summary>
        /// Method to retrieve a list of Items from the database for use in the dgItems data grid.
        /// </summary>
        public ObservableCollection<clsItemDesc> GetItemDescs()
        {
            try
            {
                int iRet = 0;
                DataSet ds = new DataSet();
                clsMainSQL = new clsMainSQL();
                ds = db.ExecuteSQLStatement(clsMainSQL.SelectItemsData(), ref iRet);
                ItemDescriptionList = new ObservableCollection<clsItemDesc>() ;
                for (int i = 0; i < iRet; i++)
                {
                    ItemDescriptionList.Add(
                    new clsItemDesc
                    { sItemCode = ds.Tables[0].Rows[i]["ItemCode"].ToString(), sItemDesc = ds.Tables[0].Rows[i]["ItemDesc"].ToString(), dCost = (decimal)ds.Tables[0].Rows[i]["Cost"]}
                    );
                }

                return ItemDescriptionList;
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