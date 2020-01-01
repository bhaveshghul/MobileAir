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
    /// Interaction logic for PaymentReport.xaml
    /// </summary>
    public partial class PaymentReport : Page
    {

        function mfun = new function();
        DataSet mdscustomer = null;
        DataTable mdt = null, mdtreportheader = null;

        public PaymentReport()
        {
            InitializeComponent();
            Load();
            ShowData("select paym_id, paydate, amount, paymenttype from payment where paydate = '" + DateTime.Now.ToString("yyyy/MM/dd") + "' order by paym_id desc ");
        }

        private void Load()
        {
            mdscustomer = new DataSet();
            mdscustomer = mfun.showData("select cust_id, name from customer order by name asc");
            var customertable = mdscustomer.Tables[0];
            var customerrow = customertable.NewRow();
            customerrow["cust_id"] = -1;
            customerrow["name"] = "--Select Customer--";
            customertable.Rows.InsertAt(customerrow, 0);
            cbbcustomer.ItemsSource = customertable.DefaultView;
            cbbcustomer.DisplayMemberPath = "name";
            cbbcustomer.SelectedValuePath = "cust_id";
        }

        private void ShowData(string mquery)
        {
            variables.mdtreport = null;
            mdt = new DataTable();
            mdt = mfun.dataCount(mquery);

            if (mdt.Rows.Count > 0)
            {
                int x = 0;
                foreach (DataRow mdr in mdt.Rows)
                {
                    mdt.Rows[x++]["paydate"] = Convert.ToDateTime(mdr["paydate"]).ToShortDateString();
                }
                variables.mdtreport = mdt;

                DataRow blankrow = mdt.NewRow();
                mdt.Rows.Add(blankrow);

                DataRow row = mdt.NewRow();
                row["paydate"] = "Total";
                row["amount"] = mdt.Compute("Sum(amount)", string.Empty);
                mdt.Rows.Add(row);

                dgpayment.ItemsSource = mdt.DefaultView;
            }
            else
            {
                dgpayment.ItemsSource = null;
            }
        }

        private void cbbcustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!filter())
                MessageBox.Show("Data not match please try again..");
        }

        private void txtedate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!filter())
                MessageBox.Show("Data not match please try again..");
        }

        private void txtsdate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!filter())
                MessageBox.Show("Data not match please try again..");
        }

        private Boolean filter()
        {
            Boolean result = false;
            try
            {
                if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where cust_id = " + cbbcustomer.SelectedValue + " order by paym_id desc");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where cust_id = " + cbbcustomer.SelectedValue + " and paydate='" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by paym_id desc");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where cust_id = " + cbbcustomer.SelectedValue + " and paydate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and paydate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by paym_id desc ");

                else if (cbbcustomer.SelectedValue == null && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where paydate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and paydate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by paym_id desc ");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) == -1 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where paydate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and paydate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by paym_id desc ");

                else if (cbbcustomer.SelectedValue == null && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where paydate = '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by paym_id desc ");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) == -1 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where paydate = '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by paym_id desc ");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where cust_id = " + cbbcustomer.SelectedValue + " order by paym_id desc");

                else
                    ShowData("select paym_id, paydate, amount, paymenttype from payment where paydate = '" + DateTime.Now.ToString("yyyy/MM/dd") + "' order by paym_id desc ");

                return result = true;
            }
            catch (Exception)
            {
                return result;
            }
        }

        private void Btnview_Click(object sender, RoutedEventArgs e)
        {
            mdtreportheader = new DataTable();
            if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0)
            {
                mdtreportheader = mfun.dataCount("select name as CustomerName, address, mobile from customer where cust_id = " + cbbcustomer.SelectedValue + "");
                if (mdtreportheader.Rows.Count > 0)
                {
                    DataColumn sdate = new DataColumn("sdate", typeof(string));
                    mdtreportheader.Columns.Add(sdate);
                    DataColumn edate = new DataColumn("edate", typeof(string));
                    mdtreportheader.Columns.Add(edate);

                    if (!string.IsNullOrEmpty(txtsdate.Text.Trim()))
                    {
                        mdtreportheader.Rows[0]["sdate"] = Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd");
                    }

                    if (!string.IsNullOrEmpty(txtedate.Text.Trim()))
                    {
                        mdtreportheader.Rows[0]["edate"] = Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd");
                    }

                    variables.mdtreportheader = mdtreportheader;
                    rptPaymentReport a = new rptPaymentReport();
                    a.Show();
                }
            }
        }
    }
}
