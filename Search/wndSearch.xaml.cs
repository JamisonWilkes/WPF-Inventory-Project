using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// Written by Randi Weston
namespace CS3280_GroupProject.Search
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        #region Attributes
        /// <summary>
        /// Integer variable to hold the IntegerID of the selected invoice that is passed to the Main Window.
        /// </summary>
        private int iSelectedInvoice;

        /// <summary>
        /// clsSearchLogic variable to hold the instantiation of the clsSearchLogic class.
        /// </summary>
        private clsSearchLogic clsSearchLogicObj;
        #endregion

        #region Methods
        /// <summary>
        /// Method to construct and initialize/manage the Search Window. Method will instantiate the clsSearchLogicObj variable,
        /// bind lists to the cboInvoiceID, cboInvoiceDate, and cboInvoiceTotal combo boxes by setting their item sources equal 
        /// to the respective methods of the clsSearchLogicObj object, and bind a list to the dgInvoices data grid by setting its
        /// item source equal to the clsSearchLogicObj.GetInvoices method.
        /// </summary>
        public Search()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                // This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name,
                            ex.Message);
            }
        }

        /// <summary>
        /// Method to reset Search Window to its original state. Method will clear any selections in the cboInvoiceID, 
        /// cboInvoiceDate, and cboInvoiceTotal combo boxes. It will also call the function ______ from clsSearchLogic 
        /// to restore the dgInvoices data grid to its original state.
        /// </summary>
        private void Reset()
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
        /// Method that will call the clsSearchLogic.UpdateInvoices() method and pass in string values for the selected
        /// values from the cboInvoiceID, cboInvoiceDate, and cboInvoiceTotal combo boxes in order to update the dgInvoices
        /// data grid.
        /// </summary>
        /// <param name="sInvoiceID">Selected value from the cboInvoiceID combo box.</param>
        /// <param name="sInvoiceDate">Selected value from the cboInvoiceDate combo box.</param>
        /// <param name="sInvoiceTotal">Selected value from the cboInvoiceTotal combo box.</param>
        private void UpdateDataGrid(string sInvoiceID, string sInvoiceDate, string sInvoiceTotal )
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
        /// Method to handle the SelectionChanged event on the cboInvoiceID combo box. Method will call the UpdateDataGrid()
        /// method.
        /// </summary>
        /// <param name="sender">Variable from click event.</param>
        /// <param name="e">Variable from click event.</param>
        private void cboInvoiceID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                // This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name,
                            ex.Message);
            }
        }

        /// <summary>
        /// Method to handle the SelectionChanged event on the cboInvoiceDate combo box. Method will call the UpdateDataGrid()
        /// method.
        /// </summary>
        /// <param name="sender">Variable from click event.</param>
        /// <param name="e">Variable from click event.</param>
        private void cboInvoiceDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                // This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name,
                            ex.Message);
            }
        }

        /// <summary>
        /// Method to handle the SelectionChanged event on the cboInvoiceTotal combo box. Method will call the UpdateDataGrid()
        /// method.
        /// </summary>
        /// <param name="sender">Variable from click event.</param>
        /// <param name="e">Variable from click event.</param>
        private void cboInvoiceTotal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                // This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name,
                            ex.Message);
            }
        }

        /// <summary>
        /// Method to handle the click event on the Clear button. Method will call the Reset() function.
        /// <param name="sender">Variable from click event.</param>
        /// <param name="e">Variable from click event.</param>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                // This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name,
                            ex.Message);
            }
        }

        /// <summary>
        /// Method to handle closing the Search Window if either the btnSelectInvoice or btnCancel buttons are clicked
        /// or if the "X" in the corner of the Search Window is clicked. Method calls the Reset() method and then closes 
        /// the Search Window.
        /// </summary>
        private void CloseSearchWindow()
        {
            try
            {
                Reset();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to handle the click event on the Select button. Method will set the Main Window's static variable
        /// iSearchResult to the InvoiceID of the selected invoice by setting it equal to the return value of the 
        /// clsSearchLogicObj.____ method. This will allow the selected invoice to be passed back to the Main Window. 
        /// Method will then call the Close() function to close the Search Window.
        /// </summary>
        /// <param name="sender">Variable from click event.</param>
        /// <param name="e">Variable from click event.</param>
        private void btnSelectInvoice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // btnSelectInvoice will set clsMainLogic.iSearchResult to the return value of clsSearchLogicObj.GetSelectedInvoiceID()
                // after passing it the selected index from the dgInvoices data grid in order to pass the selected InvoiceID back to
                // the Main Window.
                // clsMainLogic.iSearchResult = clsSearchLogicObj.GetSelectedInvoiceID(dgInvoices.SelectedIndex);
                CloseSearchWindow();
            }
            catch (Exception ex)
            {
                // This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name,
                            ex.Message);
            }
        }

        /// <summary>
        /// Method to handle the click event on the Cancel button. Method will close the Search Window and return to the
        /// Main Window without setting the Main Window's static variable iSearchResult.
        /// </summary>
        /// <param name="sender">Variable from click event.</param>
        /// <param name="e">Variable from click event.</param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CloseSearchWindow();
            }
            catch (Exception ex)
            {
                // This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name,
                            ex.Message);
            }

        }

        /// <summary>
        /// Method to safely handle the event that the user closes the window with the corner X so that the Add Passenger
        /// window object doesn't get destroyed.
        /// </summary>
        /// <param name="sender">Variable from click event.</param>
        /// <param name="e">Variable from click event.</param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                CloseSearchWindow();
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                // This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name,
                            ex.Message);
            }
        }

        /// <summary>
        /// Method to handle top level errors.
        /// </summary>
        /// <param name="sClass">Parameter holding the class in which the error occurred.</param>
        /// <param name="sMethod">Parameter holding the method in which the error occurred.</param>
        /// <param name="sMessage">Parameter holding the error message.</param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                // Would write to a file or database here.
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                                "HandelError Exception: " + ex.Message);
            }
        }
        #endregion
    }
}
