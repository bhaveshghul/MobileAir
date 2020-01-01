using mobileAir.common;
using mobileAir.master;
using mobileAir.Pages;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace mobileAir.pages
{
    /// <summary>
    /// Interaction logic for ManageCustomer.xaml
    /// </summary>
    public partial class ManageCustomer : Page
    {
        static NavigationService navService = null;
        static function mfun = new function();
        static DataSet mds = null, mdsdelete= null;
        static DataGrid dataGrid = null;
        private string result;

        public ManageCustomer()
        {
            InitializeComponent();
            DgBind_Customer();
        }

        private void DgBind_Customer()
        {
            mds = new DataSet();
            dataGrid = new DataGrid();

            mds = mfun.showData("select cust_id, name, customertype, mobile from customer order by cust_id desc");
            if(mds.Tables[0].Rows.Count > 0)
            {
                dgcustomer.ItemsSource = mds.Tables[0].DefaultView;
                dataGrid = dgcustomer;
            }
            else
            {
                dgcustomer.ItemsSource = null;
            }
        }

        private void Btnedit_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgcustomer.SelectedItem;  
            int cust_id = Convert.ToInt32(dataRow.Row["cust_id"].ToString());

            variables.softId = cust_id;
            navService = NavigationService.GetNavigationService(this);
            NewCustomer nextPage = new NewCustomer();
            navService.Navigate(nextPage);
        }

        private void Btndelete_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgcustomer.SelectedItem;
            int cust_id = Convert.ToInt32(dataRow.Row["cust_id"].ToString());

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                mdsdelete = mfun.showData("select text from setting where flag='" + "delete" + "'");
                if(mdsdelete.Tables[0].Rows[0]["text"].ToString() == "true")
                {
                    result = mfun.changeSave("delete from customer where cust_id=" + cust_id + "");
                    if (result == "success")
                    {
                        MessageBox.Show(result);
                    }
                }
                else
                {
                    MessageBox.Show("Delete permission not available");
                }
                mdsdelete.Clear();
            }
            DgBind_Customer();
        }

        private void Btnnewrecord_Click(object sender, RoutedEventArgs e)
        {
            navService = NavigationService.GetNavigationService(this);
            NewCustomer nextPage = new NewCustomer();
            navService.Navigate(nextPage);
        }
    }
}
