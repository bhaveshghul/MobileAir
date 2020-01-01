using mobileAir.common;
using mobileAir.report;
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
    /// Interaction logic for ManagePayment.xaml
    /// </summary>
    public partial class ManagePayment : Page
    {
        static NavigationService navService = null;
        static function mfun = new function();
        static DataSet mds = null;
        static DataGrid dataGrid = null;
        private string result;

        public ManagePayment()
        {
            InitializeComponent();
            DgBind_Payment();
        }

        private void DgBind_Payment()
        {
            mds = new DataSet();
            dataGrid = new DataGrid();

            mds = mfun.showData("select a.name as customer, b.paym_id, b.paydate, b.amount from customer a, payment b where a.cust_id = b.cust_id order by b.paym_id desc");
            if (mds.Tables[0].Rows.Count > 0)
            {
                dgpayment.ItemsSource = mds.Tables[0].DefaultView;
                dataGrid = dgpayment;
            }
            else
            {
                dgpayment.ItemsSource = null;
            }
        }

        private void Btnnewrecord_Click(object sender, RoutedEventArgs e)
        {
            navService = NavigationService.GetNavigationService(this);
            Payment nextPage = new Payment();
            navService.Navigate(nextPage);
        }

        private void btnnewrecordcustomer_Click(object sender, RoutedEventArgs e)
        {
            navService = NavigationService.GetNavigationService(this);
            NewPaymentCustomer nextPage = new NewPaymentCustomer();
            navService.Navigate(nextPage);
        }

        private void Btnedit_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgpayment.SelectedItem;
            int paym_id = Convert.ToInt32(dataRow.Row["paym_id"].ToString());

            variables.softId = paym_id;
            navService = NavigationService.GetNavigationService(this);
            Payment nextPage = new Payment();
            navService.Navigate(nextPage);
        }

        private void Btndelete_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgpayment.SelectedItem;
            int paym_id = Convert.ToInt32(dataRow.Row["paym_id"].ToString());

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                result = mfun.changeSave("delete from payment where paym_id=" + paym_id + "");
                if (result == "success")
                {
                    MessageBox.Show(result);
                }
            }
            DgBind_Payment();
        }

        private void Btnbillnoreport_Click(object sender, RoutedEventArgs e)
        {
            rptBillnoReport a = new rptBillnoReport();
            a.Show();
        }
    }
}
