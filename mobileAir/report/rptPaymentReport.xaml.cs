using mobileAir.common;
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
using System.Windows.Shapes;

namespace mobileAir.report
{
    /// <summary>
    /// Interaction logic for rptPaymentReport.xaml
    /// </summary>
    public partial class rptPaymentReport : Window
    {
        DataSet mds = new DataSet();
        public rptPaymentReport()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cryPaymentReport objRpt = new cryPaymentReport();
            objRpt.Load(@"cryPaymentReport.rpt");
            mds.Tables.AddRange(new DataTable[] { variables.mdtreportheader, variables.mdtreport });
            objRpt.Database.Tables["CustomerDetails"].SetDataSource(mds.Tables[0]);
            objRpt.Database.Tables["Payment"].SetDataSource(mds.Tables[1]);
            objRpt.SetDataSource(mds);
            cryPaymentReport.ViewerCore.ReportSource = objRpt;
        }
    }
}
