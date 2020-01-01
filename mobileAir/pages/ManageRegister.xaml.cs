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
    /// Interaction logic for ManageRegister.xaml
    /// </summary>
    public partial class ManageRegister : Page
    {
        static NavigationService navService = null;
        static function mfun = new function();
        static DataSet mds = null, mdsdelete = null;
        static DataGrid dataGrid = null;
        private string result;

        public ManageRegister()
        {
            InitializeComponent();
            DgBind_Users();
        }

        private void DgBind_Users()
        {
            mds = new DataSet();
            dataGrid = new DataGrid();

            mds = mfun.showData("select id,name,gender,birthdate,mobile,email from users where id = " + Application.Current.Resources["userid"] + " order by id desc");
            if (mds.Tables[0].Rows.Count > 0)
            {
                dgusers.ItemsSource = mds.Tables[0].DefaultView;
                dataGrid = dgusers;
            }
            else
            {
                dgusers.ItemsSource = null;
            }
        }

        private void Btnnewrecord_Click(object sender, RoutedEventArgs e)
        {
            navService = NavigationService.GetNavigationService(this);
            NewRegister nextPage = new NewRegister();
            navService.Navigate(nextPage);
        }

        private void Btnedit_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgusers.SelectedItem;
            int id = Convert.ToInt32(dataRow.Row["id"].ToString());

            variables.softId = id;
            navService = NavigationService.GetNavigationService(this);
            NewRegister nextPage = new NewRegister();
            navService.Navigate(nextPage);
        }

        private void Btndelete_Click(object sender, RoutedEventArgs e)
        {
            var dataRow = (DataRowView)dgusers.SelectedItem;
            int id = Convert.ToInt32(dataRow.Row["id"].ToString());

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                mdsdelete = mfun.showData("select text from setting where flag='" + "delete" + "'");
                if (mdsdelete.Tables[0].Rows[0]["text"].ToString() == "true")
                {
                    result = mfun.changeSave("delete from users where id=" + id + "");
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
            DgBind_Users();
        }
    }
}
