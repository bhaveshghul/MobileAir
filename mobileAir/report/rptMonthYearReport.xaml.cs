using mobileAir.common;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for rptMonthYearReport.xaml
    /// </summary>
    public partial class rptMonthYearReport : Window
    {
        public rptMonthYearReport()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cryMonthYearReport objRpt = new cryMonthYearReport();
            objRpt.Load(@"cryMonthYearReport.rpt");
            objRpt.SetDataSource(variables.mdtreport);
            cryMonthYear.ViewerCore.ReportSource = objRpt;
        }
    }
}
