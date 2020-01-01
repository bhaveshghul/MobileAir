using mobileAir.common;
using mobileAir.master;
using mobileAir.report;
using mobileAir.window;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace mobileAir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private function mfun = new function();
        private cryptography mcry = new cryptography();

        private DataTable mdt = null;
        private string mmac, systemmac, validmac = "false";
        DataSet mds = new DataSet();

        public MainWindow()
        {
            InitializeComponent();
            GetMacAddress();
        }
        private void GetMacAddress()
        {
            try
            {
                mdt = new DataTable();
                mdt = mfun.dataCount("select * from setting where flag='" + "mac" + "'");
                if (mdt.Rows.Count > 0)
                {
                    for (int i = 0; i <= (mdt.Rows.Count - 1); i++)
                    {
                        mmac = mdt.Rows[i]["text"].ToString();

                        if (systemmac == null)
                            systemmac = mfun.getMacAddress();

                        if (mmac == systemmac)
                        {
                            validmac = "true";
                            if(systemmac == "68F728B5FCC2")
                            {
                                // admin system
                                variables.finacial = mfun.getFinancial();
                                this.Hide();
                                Home home = new Home();
                                home.Show();
                            }
                        }
                    }
                    mdt.Clear();
                }
                else
                {
                    validmac = "false";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("page: login, mehtod: GetMacAddress, error: " + ex);
            }
        }

        private void Btnlogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (validmac == "true")
                {
                    mdt = mfun.dataCount("select id,username from users where username ='" + this.txtuname.Text.Trim() + "' and password = '" + this.txtpass.Password.Trim() + "'");
                    if (mdt.Rows.Count == 1)
                    {
                        Application.Current.Resources["username"] = this.txtuname.Text.Trim();
                        Application.Current.Resources["userid"] = mdt.Rows[0]["id"].ToString();
                        mdt.Clear();
                        variables.finacial = mfun.getFinancial();
                        this.Hide();
                        Home home = new Home();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("please enter valid username and password");
                    }
                }
                else
                {
                    MessageBox.Show("your system is not valid system, please contact software person");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("page: login, mehtod: Btnlogin_Click, error: " + ex);
            }
        }

        private void hlinkforgot_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }

        private void Btnclose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }

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
