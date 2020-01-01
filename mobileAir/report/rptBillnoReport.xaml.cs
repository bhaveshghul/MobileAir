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
using System.Windows.Shapes;

namespace mobileAir.report
{
    /// <summary>
    /// Interaction logic for rptBillnoReport.xaml
    /// </summary>
    public partial class rptBillnoReport : Window
    {
        static function mfun = new function();
        DataSet mds = new DataSet();
        static DataTable mdt = null, mdtdetails = null, mdtlabourdetails = null;
        public rptBillnoReport()
        {
            InitializeComponent();
            if(variables.softbillno != "")
            {
                txtbillno.Text = variables.softbillno;
                variables.softbillno = "";
            }
        }

        private void Btnview_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbillno.Text))
            {
                cryBillnoReport objRpt = new cryBillnoReport();
                objRpt.Load(@"cryCustomer.rpt");
                mdt = mfun.dataCount("select a.name as customer, a.address, a.mobile, b.serv_id, b.billno, b.billdate, b.km, b.vehicleno, b.grandtotal, b.notes, c.name as model, d.name as technician, e.paymenttype from customer a, service b, model c, technician d, payment e where b.cust_id = a.cust_id and b.mode_id = c.mode_id and b.tech_id = d.tech_id and b.serv_id = e.serv_id and b.billno = '" + txtbillno.Text.Trim() + "' order by b.serv_id");
                if(mdt.Rows.Count > 0)
                {
                    mdt.Rows[0]["billdate"] = Convert.ToDateTime(mdt.Rows[0]["billdate"]).ToShortDateString();

                    mdtdetails = mfun.dataCount("select serv_id, a.name as labourdetails, b.amount  from labour a, labourDetails b where b.labo_id = a.labo_id and serv_id=" + mdt.Rows[0]["serv_id"] + "");
                    if(mdtdetails.Rows.Count > 0)
                    {
                        // Datatable Details Section In Report
                        DataColumn no = new DataColumn("no", typeof(int));
                        mdtdetails.Columns.Add(no);

                        for (int i = 0; i <= (mdtdetails.Rows.Count -1); i++)
                        {
                            mdtdetails.Rows[i]["no"] = i + 1;
                        }

                        // Datatable Report Header Section In Report
                        DataTable(mdtdetails.Rows.Count);
                        DataRow mdtrow = mdtlabourdetails.NewRow();
                        for (int i = 0; i <= (mdtdetails.Rows.Count - 1); i++)
                        {
                            if (i == 0)
                                mdtrow["serv_id"] = mdtdetails.Rows[i]["serv_id"].ToString();
                            mdtrow["no" + i] = i + 1;
                            mdtrow["labourdetails" + i] = mdtdetails.Rows[i]["labourdetails"].ToString();
                            mdtrow["amount"+ i] = mdtdetails.Rows[i]["amount"].ToString();
                        }
                        mdtlabourdetails.Rows.Add(mdtrow);

                        mds.Tables.AddRange(new DataTable[] { mdt, mdtdetails, mdtlabourdetails });
                        objRpt.Database.Tables["BillDetails"].SetDataSource(mds.Tables[0]);
                        objRpt.Database.Tables["LabourDataSet"].SetDataSource(mds.Tables[1]);
                        objRpt.Database.Tables["LabourDetails"].SetDataSource(mds.Tables[2]);

                        objRpt.SetDataSource(mds);
                        cryBillnoReport.ViewerCore.ReportSource = objRpt;
                    }
                    mdtlabourdetails.Clear();
                    mdtdetails.Clear();
                }
                else
                {

                    mdt = mfun.dataCount("select a.name as customer, a.address, a.mobile, b.serv_id, b.billno, b.billdate, b.km, b.vehicleno, b.grandtotal, b.notes, c.name as model, d.name as technician from customer a, service b, model c, technician d where b.cust_id = a.cust_id and b.mode_id = c.mode_id and b.tech_id = d.tech_id and b.billno = '" + txtbillno.Text.Trim() + "' order by b.serv_id");
                    if (mdt.Rows.Count > 0)
                    {
                        mdt.Rows[0]["billdate"] = Convert.ToDateTime(mdt.Rows[0]["billdate"]).ToShortDateString();

                        mdtdetails = mfun.dataCount("select serv_id, a.name as labourdetails, b.amount  from labour a, labourDetails b where b.labo_id = a.labo_id and serv_id=" + mdt.Rows[0]["serv_id"] + "");
                        if (mdtdetails.Rows.Count > 0)
                        {
                            // Datatable Details Section In Report
                            DataColumn no = new DataColumn("no", typeof(int));
                            mdtdetails.Columns.Add(no);

                            for (int i = 0; i <= (mdtdetails.Rows.Count - 1); i++)
                            {
                                mdtdetails.Rows[i]["no"] = i + 1;
                            }

                            // Datatable Report Header Section In Report
                            DataTable(mdtdetails.Rows.Count);
                            DataRow mdtrow = mdtlabourdetails.NewRow();
                            for (int i = 0; i <= (mdtdetails.Rows.Count - 1); i++)
                            {
                                if (i == 0)
                                    mdtrow["serv_id"] = mdtdetails.Rows[i]["serv_id"].ToString();
                                mdtrow["no" + i] = i + 1;
                                mdtrow["labourdetails" + i] = mdtdetails.Rows[i]["labourdetails"].ToString();
                                mdtrow["amount" + i] = mdtdetails.Rows[i]["amount"].ToString();
                            }
                            mdtlabourdetails.Rows.Add(mdtrow);

                            mds.Tables.AddRange(new DataTable[] { mdt, mdtdetails, mdtlabourdetails });
                            objRpt.Database.Tables["BillDetails"].SetDataSource(mds.Tables[0]);
                            objRpt.Database.Tables["LabourDataSet"].SetDataSource(mds.Tables[1]);
                            objRpt.Database.Tables["LabourDetails"].SetDataSource(mds.Tables[2]);

                            objRpt.SetDataSource(mds);
                            cryBillnoReport.ViewerCore.ReportSource = objRpt;
                        }
                        mdtlabourdetails.Clear();
                        mdtdetails.Clear();
                    }
                }
                mdt.Clear();
            }
        }

        private void DataTable(int count)
        {
            mdtlabourdetails = new DataTable();
            for (int i = 0; i <= (count -1); i++)
            {
                if (i == 0)
                    mdtlabourdetails.Columns.Add("serv_id", typeof(Int32));
                mdtlabourdetails.Columns.Add("no" + i, typeof(Int32));
                mdtlabourdetails.Columns.Add("labourdetails" + i, typeof(string));
                mdtlabourdetails.Columns.Add("amount" + i, typeof(decimal));
            }
        }

        #region old code
        //private void Btnview_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtbillno.Text))
        //    {
        //        cryBillnoReport objRpt = new cryBillnoReport();
        //        objRpt.Load(@"cryCustomer.rpt");
        //        mdt = mfun.dataCount("select a.name as customer, a.address, a.mobile, b.serv_id, b.billno, b.billdate, b.km, b.vehicleno, b.grandtotal, b.notes, c.name as model, d.name as technician, e.paymenttype from customer a, service b, model c, technician d, payment e where b.cust_id = a.cust_id and b.mode_id = c.mode_id and b.tech_id = d.tech_id and b.serv_id = e.serv_id and b.billno = '" + txtbillno.Text.Trim() + "' order by b.serv_id");
        //        if (mdt.Rows.Count > 0)
        //        {
        //            mdtdetails = mfun.dataCount("select serv_id, a.name as labourdetails, b.amount  from labour a, labourDetails b where b.labo_id = a.labo_id and serv_id=" + mdt.Rows[0]["serv_id"] + "");
        //            if (mdtdetails.Rows.Count > 0)
        //            {
        //                DataColumn pendingamt = new DataColumn("no", typeof(int));
        //                mdtdetails.Columns.Add(pendingamt);

        //                for (int i = 0; i <= (mdtdetails.Rows.Count - 1); i++)
        //                {
        //                    mdtdetails.Rows[i]["no"] = i + 1;
        //                }

        //                mds.Tables.AddRange(new DataTable[] { mdt, mdtdetails });
        //                objRpt.Database.Tables["BillDetails"].SetDataSource(mds.Tables[0]);
        //                objRpt.Database.Tables["LabourDataSet"].SetDataSource(mds.Tables[1]);
        //                objRpt.SetDataSource(mds);
        //                cryBillnoReport.ViewerCore.ReportSource = objRpt;
        //            }
        //            mdtdetails.Clear();
        //        }
        //        else
        //        {
        //            mdt = mfun.dataCount("select a.name as customer, a.address, a.mobile, b.serv_id, b.billno, b.billdate, b.km, b.vehicleno, b.grandtotal, b.notes, c.name as model, d.name as technician from customer a, service b, model c, technician d where b.cust_id = a.cust_id and b.mode_id = c.mode_id and b.tech_id = d.tech_id and b.billno = '" + txtbillno.Text.Trim() + "' order by b.serv_id");
        //            if (mdt.Rows.Count > 0)
        //            {
        //                mdtdetails = mfun.dataCount("select serv_id, a.name as labourdetails, b.amount  from labour a, labourDetails b where b.labo_id = a.labo_id and serv_id=" + mdt.Rows[0]["serv_id"] + "");
        //                if (mdtdetails.Rows.Count > 0)
        //                {
        //                    DataColumn pendingamt = new DataColumn("no", typeof(int));
        //                    mdtdetails.Columns.Add(pendingamt);

        //                    for (int i = 0; i <= (mdtdetails.Rows.Count - 1); i++)
        //                    {
        //                        mdtdetails.Rows[i]["no"] = i + 1;
        //                    }

        //                    mds.Tables.AddRange(new DataTable[] { mdt, mdtdetails });
        //                    objRpt.Database.Tables["BillDetails"].SetDataSource(mds.Tables[0]);
        //                    objRpt.Database.Tables["LabourDataSet"].SetDataSource(mds.Tables[1]);
        //                    objRpt.SetDataSource(mds);
        //                    cryBillnoReport.ViewerCore.ReportSource = objRpt;
        //                }
        //                mdtdetails.Clear();
        //            }
        //        }
        //        mdt.Clear();
        //    }
        //}
        #endregion

    }
}