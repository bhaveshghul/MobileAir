using mobileAir.common;
using mobileAir.report;
using mobileAir.window;
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
    /// Interaction logic for CustomerReport.xaml
    /// </summary>
    public partial class CustomerReport : Page
    {
        function mfun = new function();
        DataSet mdscustomer = null;
        DataTable mdt = null, mdtpendingamt = null, mdtreportheader = null;

        public CustomerReport()
        {
            InitializeComponent();
            Load();
            // ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as pendingamt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and billdate = '" + DateTime.Now.ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");
            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and billdate = '" + DateTime.Now.ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");
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
                DataColumn pendingamt = new DataColumn("pendingamt", typeof(decimal));
                mdt.Columns.Add(pendingamt);
                DataColumn paidamt = new DataColumn("paidamt", typeof(decimal));
                mdt.Columns.Add(paidamt);

                for (int i = 0; i <= (mdt.Rows.Count -1); i++)
                {
                    mdtpendingamt = mfun.dataCount("select sum(amount) as paidamt from payment where serv_id = " + mdt.Rows[i]["serv_id"] + " Order by serv_id");
                    if(mdtpendingamt.Rows[0]["paidamt"].ToString() != "")
                    {
                        mdt.Rows[i]["pendingamt"] = Convert.ToDecimal(mdt.Rows[i]["grandtotal"]) - Convert.ToDecimal(mdtpendingamt.Rows[0]["paidamt"]);
                        mdt.Rows[i]["paidamt"] = Convert.ToDecimal(mdtpendingamt.Rows[0]["paidamt"]);
                    }
                    else
                    {
                        mdt.Rows[i]["pendingamt"] = Convert.ToDecimal(mdt.Rows[i]["grandtotal"]);
                        mdt.Rows[i]["paidamt"] = 0;
                    }
                   
                }

                int x = 0;
                foreach (DataRow mdr in mdt.Rows)
                {
                    mdt.Rows[x++]["billdate"] = Convert.ToDateTime(mdr["billdate"]).ToShortDateString();
                }
                variables.mdtreport = mdt;

                DataRow blankrow = mdt.NewRow();
                mdt.Rows.Add(blankrow);

                DataRow row = mdt.NewRow();
                row["model"] = "Total";
                row["grandtotal"] = mdt.Compute("Sum(grandtotal)", string.Empty);
                row["pendingamt"] = mdt.Compute("Sum(pendingamt)", string.Empty);
                row["paidamt"] = mdt.Compute("Sum(paidamt)", string.Empty);
                mdt.Rows.Add(row);

                dgcustomer.ItemsSource = mdt.DefaultView;
            }
            else
            {
                dgcustomer.ItemsSource = null;
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
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and a.cust_id = " + cbbcustomer.SelectedValue + " order by a.serv_id, a.cust_id desc ");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and a.cust_id = " + cbbcustomer.SelectedValue + " and a.billdate = '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and a.cust_id = " + cbbcustomer.SelectedValue + " and a.billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and a.billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

                else if (cbbcustomer.SelectedValue == null && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and a.billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and a.billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) == -1 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and a.billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and a.billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

                else if (cbbcustomer.SelectedValue == null && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and a.billdate = '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) == -1 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and a.billdate = '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

                else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and cust_id=" + cbbcustomer.SelectedValue + " order by a.serv_id, a.cust_id desc ");

                else
                    ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal from service a, model b where a.mode_id = b.mode_id and billdate = '" + DateTime.Now.ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

                return result = true;
            }
            catch (Exception)
            {
                return result;
            }
        }

        //private Boolean filter()
        //{
        //    Boolean result = false;
        //    try
        //    {
        //        if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and a.cust_id = " + cbbcustomer.SelectedValue + " order by a.serv_id, a.cust_id desc ");

        //        else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and a.cust_id = " + cbbcustomer.SelectedValue + " and a.billdate = '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

        //        else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and a.cust_id = " + cbbcustomer.SelectedValue + " and a.billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and a.billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

        //        else if (cbbcustomer.SelectedValue == null && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and a.billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and a.billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

        //        else if (Convert.ToInt32(cbbcustomer.SelectedValue) == -1 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and a.billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and a.billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

        //        else if (cbbcustomer.SelectedValue == null && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and a.billdate = '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

        //        else if (Convert.ToInt32(cbbcustomer.SelectedValue) == -1 && !string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and a.billdate = '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

        //        else if (Convert.ToInt32(cbbcustomer.SelectedValue) > 0 && string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and cust_id=" + cbbcustomer.SelectedValue + " order by a.serv_id, a.cust_id desc ");

        //        else
        //            ShowData("select a.serv_id, a.billno, a.billdate, a.vehicleno, b.name as model, a.grandtotal, (a.grandtotal - sum(c.amount)) as PendingAmt, sum(c.amount) as paidamt from service a, model b, payment c where a.mode_id = b.mode_id and a.serv_id = c.serv_id and billdate = '" + DateTime.Now.ToString("yyyy/MM/dd") + "' order by a.serv_id, a.cust_id desc ");

        //        return result = true;
        //    }
        //    catch (Exception)
        //    {
        //        return result;
        //    }
        //}

        private void Btnview_Click(object sender, RoutedEventArgs e)
        {
            mdtreportheader = new DataTable();
            if(Convert.ToInt32(cbbcustomer.SelectedValue) > 0)
            {
                mdtreportheader = mfun.dataCount("select name as CustomerName, address, mobile from customer where cust_id = " + cbbcustomer.SelectedValue + "");
                if(mdtreportheader.Rows.Count > 0)
                {
                    DataColumn sdate = new DataColumn("sdate", typeof(string));
                    mdtreportheader.Columns.Add(sdate);
                    DataColumn edate = new DataColumn("edate", typeof(string));
                    mdtreportheader.Columns.Add(edate);

                    if(!string.IsNullOrEmpty(txtsdate.Text.Trim()))
                    {
                        mdtreportheader.Rows[0]["sdate"] = Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd");
                    }
                   
                    if(!string.IsNullOrEmpty(txtedate.Text.Trim()))
                    {
                        mdtreportheader.Rows[0]["edate"] = Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd");
                    }
                    variables.mdtreportheader = mdtreportheader;
                    RptCustomer a = new RptCustomer();
                    a.Show();
                }
            }
        }
    }
}
