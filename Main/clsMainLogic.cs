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
        /// Integer variable used to store the invoice Num
        /// </summary>
        public string sInvoiceNum;

        /// <summary>
        /// Integer variable used to store the number invoice date.
        /// </summary>
        public string sInvoiceDate;

        /// <summary>
        /// Integer variable used to store the total cost of the invoice.
        /// </summary>
        public string sTotalCost;

        /// <summary>
        /// List of clsInvoice objects to store and interact with the list of invoices returned from the database.
        /// </summary>

        public ObservableCollection<clsItemDesc> ItemDescriptionList { get; set; }

        public ObservableCollection<clsInvoice> InvoiceList { get; set; }

        #endregion

        #region Methods

        public ObservableCollection<clsInvoice> getAllInvoices()
        {
            try
            {
                int iRet = 0;
                DataSet ds = new DataSet();
                clsMainSQL = new clsMainSQL();

                ds = db.ExecuteSQLStatement(clsMainSQL.getInvoices(), ref iRet);

                InvoiceList = new ObservableCollection<clsInvoice>();

                for (int i = 0; i < iRet; i++)
                {
                    InvoiceList.Add(
                    new clsInvoice
                    { SInvoiceNum = ds.Tables[0].Rows[i]["InvoiceNum"].ToString(), SInvoiceDate = ds.Tables[0].Rows[i]["InvoiceDate"].ToString(), STotalCost = ds.Tables[0].Rows[i]["TotalCost"].ToString()}
                    );
                }

                return InvoiceList;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
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
                string sSQL = clsMainSQL.InsertInvoice(sInvoiceDate, sTotalCost);
                db.ExecuteNonQuery(sSQL);
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

        /// <summary>
        /// Method to get the newest invoice number from the database
        /// </summary>
        public string getNewestInvoiceNum()
        {
            try
            {
                sInvoiceNum = db.ExecuteScalarSQL(clsMainSQL.getNewestInvoice());
                return sInvoiceNum;
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