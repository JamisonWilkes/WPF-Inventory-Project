using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CS3280_GroupProject
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Search window object
        /// </summary>
        Search.Search searchWindow;

        /// <summary>
        /// ClsMainLogic object
        /// </summary>
        Main.clsMainLogic clsMainLogic;

        /// <summary>
        /// 
        /// </summary>
        clsItemDesc clsItemDesc;

        /// <summary>
        /// collection for the items that have been added to the data grid
        /// </summary>
        ObservableCollection<clsItemDesc> ChosenItemsList;


        public MainWindow()
        {

            InitializeComponent();
            clsMainLogic = new Main.clsMainLogic();

            cbItemDesc.ItemsSource = clsMainLogic.GetItemDescs();

            ChosenItemsList = new ObservableCollection<clsItemDesc>();

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            searchWindow = new Search.Search();
            searchWindow.ShowDialog();

        }

        private void cbItemDesc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            decimal iItemCost;
            string sItemCost = cbItemDesc.SelectedItem.ToString().Split(' ').LastOrDefault();
            //iItemCost = Convert.ToDecimal(sItemCost);
            txtItemCost.Text = sItemCost + ".00";

        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            decimal dItemCost;
            string sItemCode;
            string sItemDesc;

            sItemCode = cbItemDesc.SelectedItem.ToString().Split(' ')[0];
            sItemDesc = cbItemDesc.SelectedItem.ToString().Split(':', '$')[1];
            dItemCost = Convert.ToDecimal(cbItemDesc.SelectedItem.ToString().Split('$').LastOrDefault());

            ChosenItemsList.Add(
            new clsItemDesc { sItemCode = sItemCode, sItemDesc = sItemDesc, dCost = dItemCost });

            dgChosenItems.ItemsSource = ChosenItemsList;
        }
    }
}
