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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mobileAir.pages
{
    /// <summary>
    /// Interaction logic for ManageService.xaml
    /// </summary>
    public partial class ManageService : Page
    {
        static NavigationService navService = null;
        static function mfun = new function();
        static DataSet mds = null;
        static DataGrid dataGrid = null;
        private string result;

        public ManageService()
        {
            InitializeComponent();
            DgBind_Service();
        }

        private void DgBind_Service()
        {
            mds = new DataSet();
            dataGrid = new DataGrid();

            mds = mfun.showData("select a.serv_id, a.billno, b.name as customer, a.billdate, a.vehicleno, c.name as model, a.grandtotal from service a, customer b, model c where a.cust_id = b.cust_id and a.mode_id = c.mode_id order by a.serv_id desc");
            if (mds.Tables[0].Rows.Count > 0)
            {
                dgservice.ItemsSource = mds.Tables[0].DefaultView;
                dataGrid = dgservice;
            }
            else
            {
                dgservice.ItemsSource = null;
            }
        }

        private void Btnnewrecord_Click(object sender, RoutedEventArgs e)
        {
            navService = NavigationService.GetNavigationService(this);
            NewService nextPage = new NewService();
            navService.Navigate(nextPage);
        }

        private void Btnedit_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgservice.SelectedItem;
            int serv_id = Convert.ToInt32(dataRow.Row["serv_id"].ToString());

            variables.softId = serv_id;
            navService = NavigationService.GetNavigationService(this);
            NewService nextPage = new NewService();
            navService.Navigate(nextPage);
        }

        private void Btndelete_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgservice.SelectedItem;
            int serv_id = Convert.ToInt32(dataRow.Row["serv_id"].ToString());

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                mfun.changeSave("delete from payment where serv_id=" + serv_id + "");
                mfun.changeSave("delete from labourDetails where serv_id=" + serv_id + "");
                result = mfun.changeSave("delete from service where serv_id=" + serv_id + "");
                if (result == "success")
                {
                    MessageBox.Show(result);
                }
            }
            DgBind_Service();
        }
    }
}
