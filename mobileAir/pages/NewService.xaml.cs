using mobileAir.common;
using mobileAir.window;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace mobileAir.pages
{
    /// <summary>
    /// Interaction logic for NewService.xaml
    /// </summary>
    public partial class NewService : Page
    {
        ObservableCollection<Labour> col;
        static NavigationService navService;
        private function mfun = new function();
        private DataSet mds, mdscustomer, mdsmodel, mdstechnician, mdslabour = null;
        private string mquery, result;

        public NewService()
        {
            InitializeComponent();
            cbbcustomer.Focus();
            Load();
            txtdate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtdiscount.Text = "0";
            col = new ObservableCollection<Labour>();
            dglabour.ItemsSource = col;
            
            if (variables.softId > 0)
                ShowData();
        }

        public void Load()
        {
            mdscustomer = new DataSet();
            mdscustomer = mfun.showData("select cust_id, name from customer order by name asc");
            var customertable = mdscustomer.Tables[0];
            var customerrow = customertable.NewRow();
            customerrow["cust_id"] = -1;
            customerrow["name"] = "--Select Customer--";
            customertable.Rows.InsertAt(customerrow, 0);
            cbbcustomer.ItemsSource = customertable.DefaultView;
            cbbcustomer.DisplayMemberPath = "name";
            cbbcustomer.SelectedValuePath = "cust_id";

            mdsmodel = new DataSet();
            mdsmodel = mfun.showData("select mode_id, name from model order by name asc");
            var modeltable = mdsmodel.Tables[0];
            var modelrow = modeltable.NewRow();
            modelrow["mode_id"] = -1;
            modelrow["name"] = "--Select Model--";
            modeltable.Rows.InsertAt(modelrow, 0);
            cbbmodel.ItemsSource = modeltable.DefaultView;
            cbbmodel.DisplayMemberPath = "name";
            cbbmodel.SelectedValuePath = "mode_id";

            mdstechnician = new DataSet();
            mdstechnician = mfun.showData("select tech_id, name from technician order by name asc");
            var techniciantable = mdstechnician.Tables[0];
            var technicianrow = techniciantable.NewRow();
            technicianrow["tech_id"] = -1;
            technicianrow["name"] = "--Select Technician--";
            techniciantable.Rows.InsertAt(technicianrow, 0);
            cbbtechnician.ItemsSource = techniciantable.DefaultView;
            cbbtechnician.DisplayMemberPath = "name";
            cbbtechnician.SelectedValuePath = "tech_id";

            mdslabour = new DataSet();
            mdslabour = mfun.showData("select labo_id, name from labour order by name asc");
            var labourtable = mdslabour.Tables[0];
            var labourrow = labourtable.NewRow();
            labourrow["labo_id"] = -1;
            labourrow["name"] = "--Select Labour--";
            labourtable.Rows.InsertAt(labourrow, 0);
            cbblabour.ItemsSource = labourtable.DefaultView;
            cbblabour.DisplayMemberPath = "name";
            cbblabour.SelectedValuePath = "labo_id";
        }

        private void ShowData()
        {
            mds = new DataSet();
            mds = mfun.showData("select serv_id, cust_id, billno, vehicleno, billdate, mode_id, tech_id, km, total, discount, grandtotal, notes from service where serv_id = " + variables.softId + " order by serv_id desc");
            if (mds.Tables[0].Rows.Count > 0)
            {
                textservid.Text = mds.Tables[0].Rows[0]["serv_id"].ToString();
                cbbcustomer.SelectedValue = mds.Tables[0].Rows[0]["cust_id"].ToString();
                txtbillno.Text = mds.Tables[0].Rows[0]["billno"].ToString();
                txtvehicalno.Text = mds.Tables[0].Rows[0]["vehicleno"].ToString();
                txtdate.Text = mds.Tables[0].Rows[0]["billdate"].ToString();
                cbbmodel.SelectedValue = mds.Tables[0].Rows[0]["mode_id"].ToString();
                cbbtechnician.SelectedValue = mds.Tables[0].Rows[0]["tech_id"].ToString();
                txtkm.Text = mds.Tables[0].Rows[0]["km"].ToString();
                txttotal.Text = mds.Tables[0].Rows[0]["total"].ToString();
                txtdiscount.Text = mds.Tables[0].Rows[0]["discount"].ToString();
                txtgrandtotal.Text = mds.Tables[0].Rows[0]["grandtotal"].ToString();
                txtnotes.Text = mds.Tables[0].Rows[0]["notes"].ToString();

                if (!string.IsNullOrEmpty(textservid.Text.Trim()))
                    ShowLabourDetails(Convert.ToInt32(textservid.Text.Trim()));
            }
            mds.Clear();
            variables.softId = 0;
        }

        protected void ShowLabourDetails(int servId)
        {
            mds = new DataSet();
            mds = mfun.showData("select b.labodete_id, b.labo_id, a.name as labourdetails, b.amount from labour a, labourDetails b where a.labo_id = b.labo_id and b.serv_id = " + servId + " order by b.serv_id, b.labodete_id asc");
            if (mds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i <= (mds.Tables[0].Rows.Count - 1); i++)
                {
                    col.Add(new Labour() { labodete_id = Convert.ToInt32(mds.Tables[0].Rows[i]["labodete_id"].ToString()), labo_id = Convert.ToInt32(mds.Tables[0].Rows[i]["labo_id"].ToString()), labourdetails = mds.Tables[0].Rows[i]["labourdetails"].ToString(), amount = Convert.ToDouble(mds.Tables[0].Rows[i]["amount"].ToString()) });
                }
            }
            dglabour.ItemsSource = col;
            mds.Clear();
        }

        private void Btnsubmint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Validdata())
                {
                    labour_totalamount();
                    if (textservid.Text.Trim() == "")
                    {
                        textservid.Text = mfun.generateSrno("select serv_id from service order by serv_id desc").ToString();
                        txtbillno.Text = mfun.generateSrnoFinancial("service", "billno").ToString();

                        mquery = "insert into service (serv_id,cust_id,billno,vehicleno,billdate,mode_id,tech_id,km,total,discount,grandtotal,notes,finacial) values (" +
                            "" + textservid.Text.Trim() + "," +
                            "" + cbbcustomer.SelectedValue + "," +
                            "'" + txtbillno.Text.Trim() + "'," +
                            "'" + txtvehicalno.Text.Trim().ToUpper() + "'," +
                            "'" + Convert.ToDateTime(txtdate.Text.Trim()).ToString("yyyy/MM/dd") + "'," +
                            "" + cbbmodel.SelectedValue + "," +
                            "" + cbbtechnician.SelectedValue + "," +
                            "'" + txtkm.Text.Trim() + "'," +
                            "" + txttotal.Text.Trim() + "," +
                            "" + txtdiscount.Text.Trim() + "," +
                            "" + txtgrandtotal.Text.Trim() + "," +
                            "'" + txtnotes.Text.Trim().ToUpper() + "'," +
                            "" + variables.finacial + ")";
                        result = mfun.changeSave(mquery);
                    }
                    else if (!string.IsNullOrEmpty(textservid.Text.Trim()))
                    {
                        mquery = "update service set cust_id =" + cbbcustomer.SelectedValue + "," +
                                                        " billno = '" + txtbillno.Text.Trim() + "'," +
                                                        " vehicleno='" + txtvehicalno.Text.Trim().ToUpper() + "'," +
                                                        " billdate='" + Convert.ToDateTime(txtdate.Text.Trim()).ToString("yyyy/MM/dd") + "'," +
                                                        " mode_id=" + cbbmodel.SelectedValue + "," +
                                                        " tech_id=" + cbbtechnician.SelectedValue + "," +
                                                        " km='" + txtkm.Text.Trim() + "'," +
                                                        " total=" + txttotal.Text.Trim() + "," +
                                                        " discount=" + txtdiscount.Text.Trim() + "," +
                                                        " grandtotal=" + txtgrandtotal.Text.Trim() + "," +
                                                        " notes='" + txtnotes.Text.Trim().ToUpper() + "'" +
                                                        " Where serv_id=" + textservid.Text.Trim() + "";
                        result = mfun.changeSave(mquery);  
                    }

                    if (!string.IsNullOrEmpty(textservid.Text))
                    {
                        saveLabourDetails();
                    }

                    if (result == "true")
                    {
                        MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Add Successfully." + Environment.NewLine + Environment.NewLine + " Yes - Add Payment  |  No - Manage Bill  |  Cancel - Add Bill", "Added Confirmation", System.Windows.MessageBoxButton.YesNoCancel);
                        if (messageBoxResult == MessageBoxResult.Yes)
                        {
                            variables.formchange = "NewService";
                            variables.softbillcode = Convert.ToInt32(textservid.Text.Trim());
                            navService = NavigationService.GetNavigationService(this);
                            Payment YesnextPage = new Payment();
                            navService.Navigate(YesnextPage);
                        }
                        else if(messageBoxResult == MessageBoxResult.No)
                        {
                            navService = NavigationService.GetNavigationService(this);
                            ManageService NonextPage = new ManageService();
                            navService.Navigate(NonextPage);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Added Unsuccessfully");
                    }

                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("page: newservice, mehtod: Btnsubmint_Click, error: " + ex);
            }
        }

        protected void saveLabourDetails()
        {
            try
            {
                if (dglabour.Items.Count > 0)
                {
                    for (int i = 0; i <= (dglabour.Items.Count - 1); i++)
                    {
                        dglabour.SelectedIndex = i; object item = dglabour.SelectedItem;

                        if ((dglabour.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text == "0")
                        {
                            textlaboid.Text = mfun.generateSrno("select labodete_id from labourDetails order by labodete_id desc").ToString();
                            textlabono.Text = mfun.generateSrnoFinancial("labourDetails", "labodete_id").ToString();

                            mquery = "insert into labourDetails (labodete_id,labono,serv_id,labo_id,amount,finacial) values (" +
                            "" + textlaboid.Text.Trim() + "," +
                            "'" + textlabono.Text.Trim() + "'," +
                            "" + textservid.Text.Trim() + "," +
                            "" + (dglabour.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text + "," +
                            "'" + (dglabour.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text + "'," +
                            "" + variables.finacial + ")";
                            result = mfun.changeSave(mquery);

                        }
                        else if (((dglabour.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text == "1"))
                        {
                            mquery = "update labourDetails set labo_id =" + (dglabour.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text + "," +
                                                        " amount = " + (dglabour.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text + "" +
                                                        " Where serv_id=" + textservid.Text.Trim() + " And labodete_id= " + (dglabour.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text + "";
                            result = mfun.changeSave(mquery);
                        }
                    }
                }
                col.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("page: newservice, mehtod: saveLabourDetails, error: " + ex.ToString());
            }
        }

        private void Btnreset_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void labour_totalamount()
        {
            if (dglabour.Items.Count > 0)
            {
                decimal total = 0, grandtotal = 0;

                for (int i = 0; i <= (col.Count -1); ++i)
                    total += (decimal.Parse((dglabour.Columns[4].GetCellContent(dglabour.Items[i]) as TextBlock).Text));

                txttotal.Text = total.ToString();

                if (!string.IsNullOrEmpty(txtdiscount.Text))
                {
                    grandtotal = Convert.ToDecimal(txttotal.Text) - Convert.ToDecimal(txtdiscount.Text);
                    txtgrandtotal.Text = grandtotal.ToString();
                }
                else
                {
                    grandtotal = Convert.ToDecimal(txttotal.Text);
                    txtgrandtotal.Text = grandtotal.ToString();
                }
            }
            else
            {
                txttotal.Text = "0";
                txtdiscount.Text = "0";
                txtgrandtotal.Text = "0";
            }
        }

        private void btnaddmodel_Click(object sender, RoutedEventArgs e)
        {
            addModel addmodel = new addModel();
            addmodel.Show();
        }

        private void Btnaddlabour_Click(object sender, RoutedEventArgs e)
        {
            addLabour addlabour = new addLabour();
            addlabour.Show();
        }

        #region Labour Details
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Validlabour())
                {
                    if (dglabour.SelectedIndex < 0)
                    {
                        int id = 0;
                        if (txtlabodeteid.Text.Trim() != string.Empty)
                            id = int.Parse(txtlabodeteid.Text.Trim());

                        col.Add(new Labour() { editrowindex = "0", labodete_id = id, labo_id = Convert.ToInt32(cbblabour.SelectedValue), labourdetails = cbblabour.Text, amount = double.Parse(txtlabouramount.Text.Trim()) });
                    }
                    else if (dglabour.SelectedIndex >= 0)
                    {
                        int SelectRowIndex = dglabour.SelectedIndex;
                        Labour labour = dglabour.SelectedItem as Labour;

                        if (labour.editrowindex == null)
                            labour.editrowindex = "1";

                        labour.labodete_id = int.Parse(txtlabodeteid.Text);
                        labour.labo_id = Convert.ToInt32(cbblabour.SelectedValue);
                        labour.labourdetails = cbblabour.Text;
                        labour.amount = double.Parse(txtlabouramount.Text.Trim());
                        col.RemoveAt(SelectRowIndex);
                        col.Insert(SelectRowIndex, labour);
                    }
                    ClearLabour();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("page: newservice, mehtod: btnadd_Click, error: " + ex);
            }
        }
        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dglabour.SelectedIndex >= 0)
                {
                    object item = dglabour.SelectedItem;
                    if ((dglabour.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text != "0")
                    {
                        MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                        if (messageBoxResult == MessageBoxResult.Yes)
                        {
                            if (!string.IsNullOrEmpty(txtlabodeteid.Text.Trim()))
                            {
                                int labodeteId = Convert.ToInt32(txtlabodeteid.Text.Trim());
                                int servId = Convert.ToInt32(textservid.Text.Trim());
                                mquery = "delete from labourDetails where labodete_id = " + labodeteId + " and serv_id = " + servId + "";
                                result = mfun.changeSave(mquery);

                                if (result == "true")
                                    col.RemoveAt(dglabour.SelectedIndex);
                            }
                        }
                    }
                    else
                    {
                        MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                        if (messageBoxResult == MessageBoxResult.Yes)
                        {
                            col.RemoveAt(dglabour.SelectedIndex);
                        }
                    }
                    ClearLabour();
                }
                else
                {
                    MessageBox.Show("Please Select Record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("page: newservice, mehtod: btndelete_Click, error: " + ex);
            }
        }

        private void Txtdiscount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void Txtdiscount_KeyUp(object sender, KeyEventArgs e)
        {
            if(txttotal.Text != "" && txtgrandtotal.Text != "")
            {
                if(txtdiscount.Text != "")
                {
                    decimal gtotal = Convert.ToDecimal(txttotal.Text) - Convert.ToDecimal(txtdiscount.Text);
                    txtgrandtotal.Text = gtotal.ToString();
                }
                else
                {
                    decimal gtotal = Convert.ToDecimal(txttotal.Text) - 0;
                    txtgrandtotal.Text = gtotal.ToString();
                }
            }
        }

        private void Btngettotal_Click(object sender, RoutedEventArgs e)
        {
            labour_totalamount();
        }

        private void Btngetmodel_Click(object sender, RoutedEventArgs e)
        {
            mdsmodel = new DataSet();
            mdsmodel = mfun.showData("select mode_id, name from model order by name asc");
            var modeltable = mdsmodel.Tables[0];
            var modelrow = modeltable.NewRow();
            modelrow["mode_id"] = -1;
            modelrow["name"] = "--Select Model--";
            modeltable.Rows.InsertAt(modelrow, 0);
            cbbmodel.ItemsSource = modeltable.DefaultView;
            cbbmodel.DisplayMemberPath = "name";
            cbbmodel.SelectedValuePath = "mode_id";
        }

        private void Btngetlabour_Click(object sender, RoutedEventArgs e)
        {
            mdslabour = new DataSet();
            mdslabour = mfun.showData("select labo_id, name from labour order by name asc");
            var labourtable = mdslabour.Tables[0];
            var labourrow = labourtable.NewRow();
            labourrow["labo_id"] = -1;
            labourrow["name"] = "--Select Labour--";
            labourtable.Rows.InsertAt(labourrow, 0);
            cbblabour.ItemsSource = labourtable.DefaultView;
            cbblabour.DisplayMemberPath = "name";
            cbblabour.SelectedValuePath = "labo_id";
        }

        private void dglabour_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.Column.Header.ToString())
            {
                case "editrowindex":
                    e.Column.MaxWidth = 0;
                    break;
                case "labodete_id":
                    e.Column.MaxWidth = 0;
                    break;
                case "labo_id":
                    e.Column.MaxWidth = 0;
                    break;
                case "labourdetails":
                    e.Column.Width = 350;
                    e.Column.Header = "Labour Details";
                    break;
                case "amount":
                    e.Column.Width = 125;
                    e.Column.Header = "Amount";
                    break;
            }
        }
        #endregion

        #region Custom_Method
        private Boolean Validdata()
        {
            Boolean result = true;
            if (cbbcustomer.SelectedValue == null || Convert.ToInt32(cbbcustomer.SelectedValue) == -1)
            {
                cbbcustomer.Focus();
                result = false;
            }
            else if (txtvehicalno.Text.Trim() == string.Empty)
            {
                txtvehicalno.Focus();
                result = false;
            }
            else if (txtdate.Text.Trim() == string.Empty)
            {
                txtdate.Focus();
                result = false;
            }
            else if (cbbmodel.SelectedValue == null || Convert.ToInt32(cbbmodel.SelectedValue) == -1)
            {
                cbbmodel.Focus();
                result = false;
            }
            else if (cbbtechnician.SelectedValue == null || Convert.ToInt32(cbbtechnician.SelectedValue) == -1)
            {
                cbbtechnician.Focus();
                result = false;
            }
            else if (txtkm.Text.Trim() == string.Empty)
            {
                txtkm.Focus();
                result = false;
            }
            else if (txtnotes.Text.Trim() == string.Empty)
            {
                txtnotes.Focus();
                result = false;
            }
            return result;
        }
        private Boolean Validlabour()
        {
            Boolean result = true;
            if (cbblabour.SelectedValue == null)
            {
                cbblabour.Focus();
                result = false;
            }
            else if (Convert.ToInt32(cbblabour.SelectedValue) == -1)
            {
                cbblabour.Focus();
                result = false;
            }
            else if (txtlabouramount.Text.Trim() == string.Empty)
            {
                txtlabouramount.Focus();
                result = false;
            }
            return result;
        }
        private void Clear()
        {
            textservid.Text = string.Empty;
            textlaboid.Text = string.Empty;
            textlabono.Text = string.Empty;
            variables.softId = 0;
            cbbcustomer.SelectedValue = "-1";
            txtbillno.Text = string.Empty;
            txtvehicalno.Text = string.Empty;
            txtdate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            cbbmodel.SelectedValue = "-1";
            cbbtechnician.SelectedValue = "-1";
            txtkm.Text = string.Empty;
            txttotal.Text = string.Empty;
            txtdiscount.Text = string.Empty;
            txtgrandtotal.Text = string.Empty;
            txtnotes.Text = "-";
            col.Clear();
            ClearLabour();
        }
        private void ClearLabour()
        {
            txtlabodeteid.Text = string.Empty;
            cbblabour.SelectedValue = "-1";
            txtlabouramount.Text = string.Empty;
            cbblabour.Focus();
        }
        #endregion
    }

    public class Labour
    {
        public string editrowindex { get; set; }
        public int labodete_id { get; set; }
        public int labo_id { get; set; }
        public string labourdetails { get; set; }
        public double amount { get; set; }
    }
}
