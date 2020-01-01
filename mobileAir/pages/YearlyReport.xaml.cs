using mobileAir.common;
using mobileAir.report;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for YearlyReport.xaml
    /// </summary>
    /// RDLC Report in WPF Application (C# code)
    public partial class YearlyReport : Page
    {
        function mfun = new function();
        DataTable mdt = null, mdtbilltotal = null, mdtpaymenttotal = null;

        public YearlyReport()
        {
            InitializeComponent();
        }

        private void ShowData(string mquery)
        {
            variables.mdtreport = null;

            mdt = new DataTable();
            mdt = mfun.dataCount(mquery);

            if (mdt.Rows.Count > 0)
            {

                DataColumn sdate = new DataColumn("sdate", typeof(string));
                mdt.Columns.Add(sdate);
                DataColumn edate = new DataColumn("edate", typeof(string));
                mdt.Columns.Add(edate);

                if (!string.IsNullOrEmpty(txtsdate.Text.Trim()))
                {
                    mdt.Rows[0]["sdate"] = Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd");
                }

                if (!string.IsNullOrEmpty(txtedate.Text.Trim()))
                {
                    mdt.Rows[0]["edate"] = Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd");
                }

                DataColumn pendingamt = new DataColumn("outstanding", typeof(decimal));
                mdt.Columns.Add(pendingamt);
                DataColumn paidamt = new DataColumn("grandtotal", typeof(decimal));
                mdt.Columns.Add(paidamt);

                int current_record = 0;
                int next_record = 1;

                for (int i = 0; i <= (mdt.Rows.Count - 1); i++)
                {
                    current_record = mdt.Select("cust_id = " + Convert.ToInt32(mdt.Rows[i]["cust_id"]) + "").Count();

                    if (current_record == next_record)
                    {
                        #region calculate oustanding & grandtotal

                        if(!string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                        {
                            mdtbilltotal = mfun.dataCount("select sum(grandtotal) as grandtotal from service where cust_id = " + mdt.Rows[i]["cust_id"] + " and billdate='" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' Order by cust_id");
                            mdtpaymenttotal = mfun.dataCount("select sum(a.amount) as grandpayment from payment a, service b where a.serv_id = b.serv_id and a.cust_id = " + mdt.Rows[i]["cust_id"] + " and b.billdate='" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' Order by a.cust_id");
                            if (mdtbilltotal.Rows[0]["grandtotal"].ToString() != "" && mdtpaymenttotal.Rows[0]["grandpayment"].ToString() != "")
                            {
                                mdt.Rows[i]["outstanding"] = Convert.ToDecimal(mdtbilltotal.Rows[0]["grandtotal"]) - Convert.ToDecimal(mdtpaymenttotal.Rows[0]["grandpayment"]);
                                mdt.Rows[i]["grandtotal"] = Convert.ToDecimal(mdtbilltotal.Rows[0]["grandtotal"]);

                            }
                            else if (mdtbilltotal.Rows[0]["grandtotal"].ToString() != "" && mdtpaymenttotal.Rows[0]["grandpayment"].ToString() == "")
                            {
                                mdt.Rows[i]["outstanding"] = Convert.ToDecimal(mdtbilltotal.Rows[0]["grandtotal"]);
                                mdt.Rows[i]["grandtotal"] = Convert.ToDecimal(mdtbilltotal.Rows[0]["grandtotal"]);
                            }
                            else
                            {
                                mdt.Rows[i]["outstanding"] = "0.00";
                                mdt.Rows[i]["grandtotal"] = "0.00";
                            }
                            mdtbilltotal.Clear();
                            mdtpaymenttotal.Clear();
                        }
                        else if (!string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                        {
                            mdtbilltotal = mfun.dataCount("select sum(grandtotal) as grandtotal from service where cust_id = " + mdt.Rows[i]["cust_id"] + " and billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' Order by cust_id");
                            mdtpaymenttotal = mfun.dataCount("select sum(a.amount) as grandpayment from payment a, service b where a.serv_id = b.serv_id and a.cust_id = " + mdt.Rows[i]["cust_id"] + " and b.billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and b.billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' Order by a.cust_id");
                            if (mdtbilltotal.Rows[0]["grandtotal"].ToString() != "" && mdtpaymenttotal.Rows[0]["grandpayment"].ToString() != "")
                            {
                                mdt.Rows[i]["outstanding"] = Convert.ToDecimal(mdtbilltotal.Rows[0]["grandtotal"]) - Convert.ToDecimal(mdtpaymenttotal.Rows[0]["grandpayment"]);
                                mdt.Rows[i]["grandtotal"] = Convert.ToDecimal(mdtbilltotal.Rows[0]["grandtotal"]);

                            }
                            else if (mdtbilltotal.Rows[0]["grandtotal"].ToString() != "" && mdtpaymenttotal.Rows[0]["grandpayment"].ToString() == "")
                            {
                                mdt.Rows[i]["outstanding"] = Convert.ToDecimal(mdtbilltotal.Rows[0]["grandtotal"]);
                                mdt.Rows[i]["grandtotal"] = Convert.ToDecimal(mdtbilltotal.Rows[0]["grandtotal"]);
                            }
                            else
                            {
                                mdt.Rows[i]["outstanding"] = "0.00";
                                mdt.Rows[i]["grandtotal"] = "0.00";
                            }
                            mdtbilltotal.Clear();
                            mdtpaymenttotal.Clear();
                        }
                        #endregion
                        next_record = 1;
                    }
                    else
                    {
                        next_record += 1;
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
                row["amount"] = mdt.Compute("Sum(amount)", string.Empty);
                row["outstanding"] = mdt.Compute("Sum(outstanding)", string.Empty);
                row["grandtotal"] = mdt.Compute("Sum(grandtotal)", string.Empty);
                mdt.Rows.Add(row);

                dgyearly.ItemsSource = mdt.DefaultView;
            }
            else
            {
                dgyearly.ItemsSource = null;
            }
        }

        private void Txtsdate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!filter())
                MessageBox.Show("Data not match please try again..");
        }

        private void Txtedate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!filter())
                MessageBox.Show("Data not match please try again..");
        }

        private void Btnview_Click(object sender, RoutedEventArgs e)
        {
            rptMonthYearReport a = new rptMonthYearReport();
            a.Show();
        }

        private Boolean filter()
        {
            Boolean result = false;
            try
            {
                if (!string.IsNullOrEmpty(txtsdate.Text.Trim()) && string.IsNullOrEmpty(txtedate.Text.Trim()))
                {
                    ShowData("select a.serv_id, a.cust_id, b.name as customer, a.billno, a.billdate, c.name as model, a.vehicleno, a.grandtotal as amount from service a, customer b, model c where a.cust_id = b.cust_id and a.mode_id = c.mode_id and a.billdate='" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.cust_id");
                }
                else if (!string.IsNullOrEmpty(txtsdate.Text.Trim()) && !string.IsNullOrEmpty(txtedate.Text.Trim()))
                {
                    ShowData("select a.serv_id, a.cust_id, b.name as customer, a.billno, a.billdate, c.name as model, a.vehicleno, a.grandtotal as amount from service a, customer b, model c where a.cust_id = b.cust_id and a.mode_id = c.mode_id and a.billdate >= '" + Convert.ToDateTime(txtsdate.Text.Trim()).ToString("yyyy/MM/dd") + "' and a.billdate <= '" + Convert.ToDateTime(txtedate.Text.Trim()).ToString("yyyy/MM/dd") + "' order by a.cust_id");
                }
                return result = true;
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}
