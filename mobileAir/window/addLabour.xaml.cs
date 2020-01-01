using mobileAir.common;
using mobileAir.pages;
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

namespace mobileAir.window
{
    /// <summary>
    /// Interaction logic for addLabour.xaml
    /// </summary>
    public partial class addLabour : Window
    {
        private function mfun = new function();
        private string mquery, result;

        public addLabour()
        {
            InitializeComponent();
        }
        private void btnsubmint_Click(object sender, RoutedEventArgs e)
        {
            if (Validdata())
            {
                mquery = "insert into labour (name) values ('" + txtname.Text.Trim().ToUpper() + "')";
                result = mfun.changeSave(mquery);

                Clear();

                if (result == "true")
                {
                    NewService newService = new NewService();
                    newService.Load();
                    this.Hide();
                }
            }
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            this.Close();
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
            txtname.Text = string.Empty;
        }
        #endregion
    }
}
