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
using System.Windows.Shapes;

namespace mobileAir.master
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();

            //if(Convert.ToInt32(Application.Current.Resources["userid"]) > 0)
            //    lblUser.Text = Application.Current.Resources["username"].ToString();
            //else
            //    SessionClear();
        }

        private void GoToPageExecuteHandler(object sender, ExecutedRoutedEventArgs e)
        {
            frmContent.NavigationService.Navigate(new Uri((string)e.Parameter, UriKind.Relative));
        }

        private void GoToPageCanExecuteHandler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            SessionClear();
        }

        private void SessionClear()
        {
            Application.Current.Resources["userid"] = 0;
            Application.Current.Resources["username"] = string.Empty;

            this.Hide();
            MainWindow login = new MainWindow();
            login.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //rptBillnoReport a = new rptBillnoReport();
            //a.Show();
        }
    }
}
