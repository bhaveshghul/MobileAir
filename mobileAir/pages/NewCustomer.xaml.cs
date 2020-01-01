using mobileAir.common;
using mobileAir.pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace mobileAir.Pages
{
    /// <summary>
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : Page
    {
        static NavigationService navService;
        private function mfun = new function();
        private DataSet mds = null;
        private string mquery, result;

        public NewCustomer()
        {
            InitializeComponent();
            txtname.Focus();
            if (variables.softId > 0)
                ShowData();
        }

        private void ShowData()
        {
            mds = new DataSet();
            mds = mfun.showData("select cust_id,name,address,mobile,customertype from customer where cust_id = " + variables.softId + " order by cust_id desc");
            if(mds.Tables[0].Rows.Count > 0)
            {
                txtname.Text = mds.Tables[0].Rows[0]["name"].ToString();
                txtaddress.Text = mds.Tables[0].Rows[0]["address"].ToString();
                txtphone.Text = mds.Tables[0].Rows[0]["mobile"].ToString();
                cbbcustomertype.SelectedValue = mds.Tables[0].Rows[0]["customertype"].ToString();
            }
        }

        private void Btnsubmint_Click(object sender, RoutedEventArgs e)
        {
            if (Validdata())
            {
                if(variables.softId == 0)
                {
                    mquery = "insert into customer (date,name,address,mobile,customertype) values ('" + DateTime.Now + "','" + txtname.Text.Trim().ToUpper() + "','" + txtaddress.Text.Trim().ToUpper() + "', '" + txtphone.Text.Trim() + "','" + cbbcustomertype.SelectedValue + "')";
                    result = mfun.changeSave(mquery);
                }
                else if(variables.softId > 0)
                {
                    mquery = "update customer set name = '" + txtname.Text.Trim().ToUpper() + "', address ='" + txtaddress.Text.Trim().ToUpper() + "', mobile= '" + txtphone.Text.Trim() + "', customertype='" + cbbcustomertype.SelectedValue + "' where cust_id=" + variables.softId + "";
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
                        ManageCustomer nextPage = new ManageCustomer();
                        navService.Navigate(nextPage);
                    }
                }
                else
                    MessageBox.Show(result);
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
            else if (txtaddress.Text.Trim() == string.Empty)
            {
                txtaddress.Focus();
                result = false;
            }
            else if (txtphone.Text.Trim() == string.Empty)
            {
                txtphone.Focus();
                result = false;
            }
            return result;
        }

        private void Clear()
        {
            variables.softId = 0;
            txtname.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtphone.Text = string.Empty;
        }

        //private void Txtphone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    Regex regex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{6}");
        //    e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        //}
        #endregion
    }
}
