using CrystalDecisions.CrystalReports.Engine;
using mobileAir.common;
using mobileAir.report;
using SAPBusinessObjects.WPF.Viewer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
using System.Windows.Shapes;

namespace mobileAir.window
{
    /// <summary>
    /// Interaction logic for RptCustomer.xaml
    /// </summary>
    public partial class RptCustomer : Window
    {
        DataSet mds = new DataSet();
        public RptCustomer()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //cryCustomer objRpt = new cryCustomer();
            //objRpt.Load(@"crystalReport.rpt");
            //objRpt.SetDataSource(variables.mdtreport);
            //cryReport.ViewerCore.ReportSource = objRpt;

            cryCustomer objRpt = new cryCustomer();
            objRpt.Load(@"cryCustomer.rpt");
            mds.Tables.AddRange(new DataTable[] { variables.mdtreportheader, variables.mdtreport });
            objRpt.Database.Tables["CustomerDetails"].SetDataSource(mds.Tables[0]);
            objRpt.Database.Tables["CustmorDataSet"].SetDataSource(mds.Tables[1]);
            objRpt.SetDataSource(mds);
            cryCustomerReport.ViewerCore.ReportSource = objRpt;
        }
    }
}
