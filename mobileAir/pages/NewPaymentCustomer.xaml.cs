using mobileAir.common;
using mobileAir.report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for NewPaymentCustomer.xaml
    /// </summary>
    public partial class NewPaymentCustomer : Page
    {
        static NavigationService navService;
        private function mfun = new function();
        private DataSet mds = null, mdsshodata = null, mdsoutstanding = null, mdsbillno = null, mdsbilldata = null;
        private string mquery, result;
        private decimal outstanding = 0;

        public NewPaymentCustomer()
        {
            InitializeComponent();
            cbbpayment.Focus();
            Load();
            txtpaydate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            if (variables.softId > 0)
                ShowData();

            if (variables.formchange == "NewService")
                if (variables.softbillcode > 0)
                    ShowBillData();
        }

        private void ShowBillData()
        {
            mdsbilldata = new DataSet();
            mdsbilldata = mfun.showData("select cust_id, serv_id, grandtotal, billno from service where serv_id = " + variables.softbillcode + " order by serv_id desc");
            if (mdsbilldata.Tables[0].Rows.Count > 0)
            {
                cbbcustomer.SelectedValue = mdsbilldata.Tables[0].Rows[0]["cust_id"].ToString();
                if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0)
                {
                    txtamount.Text = "0";
                    variables.softbillno = mdsbilldata.Tables[0].Rows[0]["billno"].ToString();
                }
            }
            mdsbilldata.Clear();
            variables.softbillcode = 0;
        }

        private void Load()
        {
            mds = new DataSet();
            mds = mfun.showData("select cust_id, name from customer order by name asc");

            var table = mds.Tables[0];
            var row = table.NewRow();
            row["cust_id"] = -1;
            row["name"] = "--Select Customer--";
            table.Rows.InsertAt(row, 0);

            cbbcustomer.ItemsSource = table.DefaultView;
            cbbcustomer.DisplayMemberPath = "name";
            cbbcustomer.SelectedValuePath = "cust_id";
        }

        private void ShowData()
        {
            mdsshodata = new DataSet();
            mdsshodata = mfun.showData("select paym_id, cust_id, serv_id, paydate, paymenttype, amount from payment where paym_id = " + variables.softId + " order by paym_id desc");
            if (mdsshodata.Tables[0].Rows.Count > 0)
            {
                textpaymid.Text = mdsshodata.Tables[0].Rows[0]["paym_id"].ToString();
                cbbcustomer.SelectedValue = mdsshodata.Tables[0].Rows[0]["cust_id"].ToString();
                if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0)
                {
                    GetOutStanding();
                    cbbpayment.Text = mdsshodata.Tables[0].Rows[0]["paymenttype"].ToString();
                    txtpaydate.Text = mdsshodata.Tables[0].Rows[0]["paydate"].ToString();
                    txtamount.Text = mdsshodata.Tables[0].Rows[0]["amount"].ToString();
                }
            }
            mdsshodata.Clear();
        }

        private void Btnsubmint_Click(object sender, RoutedEventArgs e)
        {
            if (Validdata())
            {
                if (variables.softId == 0)
                {
                    textpaymid.Text = mfun.generateSrno("select paym_id from payment order by paym_id desc").ToString();
                    textpaymno.Text = mfun.generateSrnoFinancial("payment", "payno").ToString();

                    mquery = "";
                    result = mfun.changeSave(mquery);
                }
                else
                {
                    mquery = "";
                    result = mfun.changeSave(mquery);
                    variables.softId = 0;
                }

                Clear();

                if (result == "true")
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Add Successfully." + Environment.NewLine + Environment.NewLine + " Yes - Bill Print | No - Add Bill/Add Payment | Cancel - Add Payment ", "Added Confirmation", System.Windows.MessageBoxButton.YesNoCancel);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        rptBillnoReport a = new rptBillnoReport();
                        a.Show();
                    }
                    else if (messageBoxResult == MessageBoxResult.No)
                    {
                        navService = NavigationService.GetNavigationService(this);
                        if (variables.formchange == "NewService")
                        {
                            NewService nextPage = new NewService();
                            navService.Navigate(nextPage);
                        }
                        else
                        {
                            ManagePayment nextPage = new ManagePayment();
                            navService.Navigate(nextPage);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Added Unsuccessfully");
                }
                variables.formchange = "";
            }
        }

        private void Btnreset_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void cbbcustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get OutStanding Amount 
            GetOutStanding();
        }

        private void Txtamount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void GetOutStanding()
        {

        }

        #region Custom_Method
        private Boolean Validdata()
        {
            Boolean result = true;
            if (txtpaydate.Text.Trim() == string.Empty)
            {
                txtpaydate.Focus();
                result = false;
            }
            else if (cbbcustomer.SelectedValue == null || Convert.ToInt32(cbbcustomer.SelectedValue) == -1)
            {
                cbbcustomer.Focus();
                result = false;
            }
            //else if (txtoutstanding.Text.Trim() == string.Empty)
            //{
            //    txtoutstanding.Focus();
            //    result = false;
            //}
            else if (txtamount.Text.Trim() == string.Empty)
            {
                txtamount.Focus();
                result = false;
            }
            return result;
        }

        private void Clear()
        {
            variables.softId = 0;
            txtpaydate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            cbbcustomer.SelectedValue = "-1";
            cbbpayment.Text = "CREDIT";
            txtoutstanding.Text = string.Empty;
            txtamount.Text = string.Empty;
        }
        #endregion
    }
}
