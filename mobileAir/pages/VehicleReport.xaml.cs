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
    /// Interaction logic for VehicleReport.xaml
    /// </summary>
    public partial class VehicleReport : Page
    {
        function mfun = new function();
        DataTable mdt = null;

        public VehicleReport()
        {
            InitializeComponent();
            ShowData("select a.serv_id, b.name as customer, a.vehicleno, a.billno, a.billdate, a.km, a.grandtotal from service a, customer b where a.cust_id = b.cust_id and billdate = '" + DateTime.Now.ToString("yyyy/MM/dd") + "' order by a.serv_id desc ");
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
                    mdt.Rows[x++]["billdate"] = Convert.ToDateTime(mdr["billdate"]).ToShortDateString();
                }
                variables.mdtreport = mdt;

                DataRow blankrow = mdt.NewRow();
                mdt.Rows.Add(blankrow);

                DataRow row = mdt.NewRow();
                row["billdate"] = "Total";
                row["grandtotal"] = mdt.Compute("Sum(grandtotal)", string.Empty);
                mdt.Rows.Add(row);

                dgvehicleno.ItemsSource = mdt.DefaultView;
            }
            else
            {
                dgvehicleno.ItemsSource = null;
            }
        }

        private void Txtvehicle_KeyUp(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtvehicle.Text.Trim()))
                ShowData("select a.serv_id, b.name as customer, a.vehicleno, a.billno, a.billdate, a.km, a.grandtotal from service a, customer b where a.cust_id = b.cust_id and vehicleno LIKE '%" + txtvehicle.Text.Trim() + "%' order by a.serv_id desc ");
            else
                ShowData("select a.serv_id, b.name as customer, a.vehicleno, a.billno, a.billdate, a.km, a.grandtotal from service a, customer b where a.cust_id = b.cust_id and billdate = '" + DateTime.Now.ToString("yyyy/MM/dd") + "' order by a.serv_id desc ");
        }

        private void Btnview_Click(object sender, RoutedEventArgs e)
        {
            rptVehicleReport a = new rptVehicleReport();
            a.Show();
        }
    }
}
