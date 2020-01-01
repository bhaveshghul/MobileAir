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
    /// Interaction logic for NewRegister.xaml
    /// </summary>
    public partial class NewRegister : Page
    {
        static NavigationService navService;
        private function mfun = new function();
        private DataSet mds = null;
        private string mquery, result;

        public NewRegister()
        {
            InitializeComponent();
            txtname.Focus();
            Load();
            if (variables.softId > 0)
                ShowData();
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

        private void ShowData()
        {
            mds = new DataSet();
            mds = mfun.showData("select name,gender,birthdate,mobile,email,username,password,security,answare from users where id = " + variables.softId + " order by id desc");
            if (mds.Tables[0].Rows.Count > 0)
            {
                txtname.Text = mds.Tables[0].Rows[0]["name"].ToString();
                cbbgender.Text = mds.Tables[0].Rows[0]["gender"].ToString();
                txtbirthdate.Text = mds.Tables[0].Rows[0]["birthdate"].ToString();
                txtphone.Text = mds.Tables[0].Rows[0]["mobile"].ToString();
                txtemail.Text = mds.Tables[0].Rows[0]["email"].ToString();
                txtuname.Text = mds.Tables[0].Rows[0]["username"].ToString();
                txtpass.Password = mds.Tables[0].Rows[0]["password"].ToString();
                cbbsecurity.SelectedValue = mds.Tables[0].Rows[0]["security"].ToString();
                txtansware.Text = mds.Tables[0].Rows[0]["answare"].ToString();
            }
        }

        private void Btnsubmint_Click(object sender, RoutedEventArgs e)
        {
            if (Validdata())
            {
                if (variables.softId == 0)
                {
                    mquery = "insert into users (name,gender,birthdate,mobile,email,username,password,security,answare) values ('" + txtname.Text.Trim() + "', '" + cbbgender.Text.Trim() + "', '" + Convert.ToDateTime(txtbirthdate.Text.Trim()).ToString("yyyy/MM/dd") + "', '" + txtphone.Text.Trim() + "', '" + txtemail.Text.Trim() + "', '" + txtuname.Text.Trim() + "', '" + txtpass.Password.Trim() + "', '" + cbbsecurity.SelectedValue + "', '" + txtansware.Text.Trim() + "')";
                    result = mfun.changeSave(mquery);
                }
                else
                {
                    mquery = "update users set name = '" + txtname.Text.Trim() + "', gender = '" + cbbgender.Text.Trim() + "', birthdate = '" + Convert.ToDateTime(txtbirthdate.Text.Trim()).ToString("yyyy/MM/dd") + "', mobile = '" + txtphone.Text.Trim() + "', email = '" + txtemail.Text.Trim() + "', username = '" + txtuname.Text.Trim() + "', password = '" + txtpass.Password.Trim() + "', security = " + cbbsecurity.SelectedValue + ", answare = '" + txtansware.Text.Trim() + "'  where id=" + variables.softId + "";
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
                        ManageRegister nextPage = new ManageRegister();
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
            else if (txtbirthdate.Text.Trim() == string.Empty)
            {
                txtbirthdate.Focus();
                result = false;
            }
            else if (txtphone.Text.Trim() == string.Empty)
            {
                txtphone.Focus();
                result = false;
            }
            else if (txtemail.Text.Trim() == string.Empty)
            {
                txtemail.Focus();
                result = false;
            }
            else if (txtuname.Text.Trim() == string.Empty)
            {
                txtuname.Focus();
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
            variables.softId = 0;
            txtname.Text = string.Empty;
            txtbirthdate.Text = string.Empty;
            cbbgender.Text = "MALE";
            txtphone.Text = string.Empty;
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

    // PasswordBox Placeholder
    internal class PasswordBoxMonitor : DependencyObject
    {
        public static bool GetIsMonitoring(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsMonitoringProperty);
        }

        public static void SetIsMonitoring(DependencyObject obj, bool value)
        {
            obj.SetValue(IsMonitoringProperty, value);
        }

        public static readonly DependencyProperty IsMonitoringProperty =
            DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(PasswordBoxMonitor), new UIPropertyMetadata(false, OnIsMonitoringChanged));

        public static int GetPasswordLength(DependencyObject obj)
        {
            return (int)obj.GetValue(PasswordLengthProperty);
        }

        public static void SetPasswordLength(DependencyObject obj, int value)
        {
            obj.SetValue(PasswordLengthProperty, value);
        }

        public static readonly DependencyProperty PasswordLengthProperty =
            DependencyProperty.RegisterAttached("PasswordLength", typeof(int), typeof(PasswordBoxMonitor), new UIPropertyMetadata(0));

        private static void OnIsMonitoringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var pb = d as PasswordBox;
            if (pb == null)
            {
                return;
            }
            if ((bool)e.NewValue)
            {
                pb.PasswordChanged += PasswordChanged;
            }
            else
            {
                pb.PasswordChanged -= PasswordChanged;
            }
        }

        static void PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pb = sender as PasswordBox;
            if (pb == null)
            {
                return;
            }
            SetPasswordLength(pb, pb.Password.Length);
        }
    }
}
