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
    /// Interaction logic for rptVehicleReport.xaml
    /// </summary>
    public partial class rptVehicleReport : Window
    {
        public rptVehicleReport()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cryVehicle objRpt = new cryVehicle();
            objRpt.Load(@"cryVehicle.rpt");
            objRpt.SetDataSource(variables.mdtreport);
            cryVehcleReport.ViewerCore.ReportSource = objRpt;
        }
    }
}
