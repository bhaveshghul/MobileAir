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
    /// Interaction logic for NewTechnician.xaml
    /// </summary>
    public partial class NewTechnician : Page
    {
        static NavigationService navService;
        private function mfun = new function();
        private DataSet mds = null;
        private string mquery, result;

        public NewTechnician()
        {
            InitializeComponent();
            txtname.Focus();
            if (variables.softId > 0)
                ShowData();
        }

        private void ShowData()
        {
            mds = new DataSet();
            mds = mfun.showData("select name from technician where tech_id = " + variables.softId + " order by tech_id desc");
            if (mds.Tables[0].Rows.Count > 0)
            {
                txtname.Text = mds.Tables[0].Rows[0]["name"].ToString();
            }
        }

        private void Btnsubmint_Click(object sender, RoutedEventArgs e)
        {
            if (Validdata())
            {
                if (variables.softId == 0)
                {
                    mquery = "insert into technician (name) values ('" + txtname.Text.Trim().ToUpper() + "')";
                    result = mfun.changeSave(mquery);
                }
                else
                {
                    mquery = "update technician set name = '" + txtname.Text.Trim().ToUpper() + "' where tech_id=" + variables.softId + "";
                    result = mfun.changeSave(mquery);
                    variables.softId = 0;
                }

                Clear();

                if (result == "true")
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Add Successfully", "Added Confirmation", System.Windows.MessageBoxButton.OKCancel);
                    if (messageBoxResult == MessageBoxResult.OK)
                    {
                        navService = NavigationService.GetNavigationService(this);
                        ManageTechnician nextPage = new ManageTechnician();
                        navService.Navigate(nextPage);
                    }
                }
                else
                {
                    MessageBox.Show(result);

                }
            }
        }

        private void Btnreset_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        #region Custom_Method
        private Boolean Validdata()
        {
            Boolean result = true;
            if (txtname.Text.Trim() == string.Empty)
            {
                txtname.Focus();
                result = false;
            }
            return result;
        }

        private void Clear()
        {
            variables.softId = 0;
            txtname.Text = string.Empty;
        }
        #endregion
    }
}
