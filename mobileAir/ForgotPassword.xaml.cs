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

namespace mobileAir
{
    /// <summary>
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Window
    {
        private function mfun = new function();
        private DataSet mds = null;
        private DataTable mdtvaliduser = null;
        private string mquery, result;
        private int userId = 0;

        public ForgotPassword()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            mds = new DataSet();
            mds = mfun.showData("select secu_id, question from security order by secu_id asc");

            var table = mds.Tables[0];
            var row = table.NewRow();
            row["secu_id"] = -1;
            row["question"] = "--Select Question--";
            table.Rows.InsertAt(row, 0);

            cbbsecurity.ItemsSource = table.DefaultView;
            cbbsecurity.DisplayMemberPath = "question";
            cbbsecurity.SelectedValuePath = "secu_id";
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if (Validdata())
            {
                if (ValidUser() > 0)
                {
                    mquery = "update users set password = '" + txtpass.Password.Trim() + "' where id = " + userId + "";
                    result = mfun.changeSave(mquery);
                }
                else
                {
                    lblerror.Content = "Please Eneter Valid Details";
                }
                Clear();

                if (result == "true")
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Successfully", "Added Confirmation", System.Windows.MessageBoxButton.OKCancel);
                    if (messageBoxResult == MessageBoxResult.OK)
                    {
                        this.Hide();
                        MainWindow login = new MainWindow();
                        login.Show();
                    }
                }
            }
        }

        private int ValidUser()
        {
            mdtvaliduser = mfun.dataCount("select id from users where username = '" + txtuname.Text.Trim() + "' and email = '" + txtemail.Text.Trim() + "' and security = " + cbbsecurity.SelectedValue + " and answare = '" + txtansware.Text.Trim() + "' order by id desc");
            if(mdtvaliduser.Rows.Count > 0)
            {
                userId = Convert.ToInt32(mdtvaliduser.Rows[0]["id"].ToString());
            }

            return userId;
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow login = new MainWindow();
            login.Show();
        }

        #region Custom_Method
        private Boolean Validdata()
        {
            Boolean result = true;
            if (txtuname.Text.Trim() == string.Empty)
            {
                txtuname.Focus();
                result = false;
            }
            else if (txtemail.Text.Trim() == string.Empty)
            {
                txtemail.Focus();
                result = false;
            }
            else if (txtpass.Password.Trim() == string.Empty)
            {
                txtpass.Focus();
                result = false;
            }
            else if (txtcpass.Password.Trim() == string.Empty)
            {
                txtcpass.Focus();
                result = false;
            }
            else if (txtpass.Password.Trim() != txtcpass.Password.Trim())
            {
                lblerror.Content = "Password & Confirm Password Not Match";
                result = false;
            }
            else if (cbbsecurity.SelectedValue == null || Convert.ToInt32(cbbsecurity.SelectedValue) == -1)
            {
                cbbsecurity.Focus();
                result = false;
            }
            else if (txtansware.Text.Trim() == string.Empty)
            {
                txtansware.Focus();
                result = false;
            }
            return result;
        }

        private void Clear()
        {
            txtemail.Text = string.Empty;
            txtuname.Text = string.Empty;
            txtpass.Password = string.Empty;
            txtcpass.Password = string.Empty;
            cbbsecurity.SelectedValue = "-1";
            txtansware.Text = string.Empty;
            lblerror.Content = string.Empty;
        }
        #endregion
    }
}
