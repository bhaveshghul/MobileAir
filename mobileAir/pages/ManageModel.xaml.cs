using mobileAir.common;
using mobileAir.Pages;
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
    /// Interaction logic for ManageModel.xaml
    /// </summary>
    public partial class ManageModel : Page
    {
        static NavigationService navService = null;
        static function mfun = new function();
        static DataSet mds = null, mdsdelete = null;
        static DataGrid dataGrid = null;
        private string result;

        public ManageModel()
        {
            InitializeComponent();
            DgBind_Model();
        }

        private void DgBind_Model()
        {
            mds = new DataSet();
            dataGrid = new DataGrid();

            mds = mfun.showData("select mode_id, name from model order by mode_id desc");
            if (mds.Tables[0].Rows.Count > 0)
            {
                dgmodel.ItemsSource = mds.Tables[0].DefaultView;
                dataGrid = dgmodel;
            }
            else
            {
                dgmodel.ItemsSource = null;
            }
        }

        private void Btnnewrecord_Click(object sender, RoutedEventArgs e)
        {
            navService = NavigationService.GetNavigationService(this);
            NewModel nextPage = new NewModel();
            navService.Navigate(nextPage);
        }

        private void Btnedit_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgmodel.SelectedItem;
            int mode_id = Convert.ToInt32(dataRow.Row["mode_id"].ToString());

            variables.softId = mode_id;
            navService = NavigationService.GetNavigationService(this);
            NewModel nextPage = new NewModel();
            navService.Navigate(nextPage);
        }

        private void Btndelete_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgmodel.SelectedItem;
            int mode_id = Convert.ToInt32(dataRow.Row["mode_id"].ToString());

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                mdsdelete = mfun.showData("select text from setting where flag='" + "delete" + "'");
                if (mdsdelete.Tables[0].Rows[0]["text"].ToString() == "true")
                {
                    result = mfun.changeSave("delete from model where mode_id=" + mode_id + "");
                    if (result == "success")
                    {
                        MessageBox.Show(result);
                    }
                }
                else
                {
                    MessageBox.Show("Delete permission not available");
                }
                mdsdelete.Clear();
            }
            DgBind_Model();
        }
    }
}
