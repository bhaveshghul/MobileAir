using mobileAir.report;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mobileAir.pages
{
    /// <summary>
    /// Interaction logic for BillReport.xaml
    /// </summary>
    public partial class BillReport : Page
    {
        public BillReport()
        {
            InitializeComponent();
        }

        private void Btnview_Click(object sender, RoutedEventArgs e)
        {
            rptBillnoReport a = new rptBillnoReport();
            a.Show();
        }
    }
}
