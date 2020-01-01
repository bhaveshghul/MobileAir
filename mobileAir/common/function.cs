using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Controls;
using System.Net.NetworkInformation;

namespace mobileAir.common
{
    public class function
    {
        connection mconnection = new connection();
        private DataSet mdsShowData = null, mdsCombo = null, mdsSrno = null;
        private DataTable mdtDataCount = null;

        private int msrno = 1, mno, mdate, mmonth, currentyear, previousyear, nextyear;
        private string mquery, mvalue, myear, myear1, mfiancyear = "", mfiancyear1, mfcode, words, dd, mm, yyyy, mdtfrom, finyear, preyear, nexyear, curyear, smacaddress, result;

        public string changeSave(string msquery)
        {
            try
            {
                mconnection.mcmd = new SQLiteCommand(msquery, mconnection.mcon);
                if (mconnection.mcon.State == ConnectionState.Closed)
                {
                    mconnection.mcon.Open();
                    mconnection.mcmd.ExecuteNonQuery();
                    result = "true";
                }
                mconnection.mcmd.Dispose();
                mconnection.mcon.Close();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            return result;
        }
        public DataSet showData(string msquery)
        {
            mconnection.madpt = new SQLiteDataAdapter(msquery, mconnection.mcon);
            if (mconnection.mcon.State == ConnectionState.Closed)
            {
                mconnection.mcon.Open();
            }
            mdsShowData = new DataSet();
            mconnection.madpt.Fill(mdsShowData);
            mconnection.madpt.Dispose();
            mconnection.mcon.Close();
            return mdsShowData;
        }
        public DataTable dataCount(string msquery)
        {           
            mconnection.madpt = new SQLiteDataAdapter(msquery, mconnection.mcon);
            if (mconnection.mcon.State == ConnectionState.Closed)
            {
                mconnection.mcon.Open();
            }
            mdtDataCount = new DataTable();
            mconnection.madpt.Fill(mdtDataCount);
            mconnection.madpt.Dispose();
            mconnection.mcon.Close();
            return mdtDataCount;
        }
        public void comboBindWithValue(string mvalue, string mtext, string msquery, ComboBox mcombobox, Boolean mflag)
        {
            try
            {
                mdsCombo = new DataSet();
                mdsCombo = showData(msquery);

                if (mdsCombo.Tables[0].Rows.Count > 0)
                {
                    mcombobox.ItemsSource = mdsCombo.DefaultViewManager;
                    mcombobox.SelectedValuePath = mvalue;
                    mcombobox.DisplayMemberPath = mtext;
                    if (mflag == true)
                    {
                        mcombobox.Items.Add(new KeyValuePair<int, string>(0, "--Select--"));
                    }
                }
                else
                {
                    mcombobox.ItemsSource = mdsCombo.DefaultViewManager;
                    mcombobox.SelectedValuePath = mvalue;
                    mcombobox.DisplayMemberPath = mtext;
                }
                mdsCombo.Clear();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public string textsaveNull(string mtext)
        {
            mvalue = "NULL";
            if (!string.IsNullOrEmpty(mtext.Trim()))
            {
                mvalue = mtext;
            }
            return mvalue;
        }
        public string replaceQuotes(string values)
        {
            return values.Replace("\"", string.Empty).Replace("'", string.Empty);
        }
        public int generateSrno(string msquery)
        {
            mdsSrno = new DataSet();
            mdsSrno = showData(msquery);
            if (mdsSrno.Tables[0].Rows.Count > 0)
            {
                if (mdsSrno.Tables[0].Rows[0][0].ToString().Trim().Length == 11 || mdsSrno.Tables[0].Rows[0][0].ToString().Trim().Length == 10)
                {
                    if (mdsSrno.Tables[0].Rows[0][0].ToString().Trim().Length == 11)
                    {
                        mno = int.Parse(mdsSrno.Tables[0].Rows[0][0].ToString().Substring(0, 6));
                        msrno = mno + 1;
                    }
                    else if (mdsSrno.Tables[0].Rows[0][0].ToString().Trim().Length == 10)
                    {
                        mno = int.Parse(mdsSrno.Tables[0].Rows[0][0].ToString().Substring(0, 5));
                        msrno = mno + 1;
                    }
                }
                else
                {
                    msrno = int.Parse(mdsSrno.Tables[0].Rows[0][0].ToString()) + 1;
                }
            }
            mdsSrno.Clear();
            return msrno;
        }
        public string generateSrnoFinancial(string mtable, string mfield)
        {
            try
            {
                mmonth = DateTime.Today.Month;
                mdate = DateTime.Today.Day;
                if (mmonth >= 04)
                {
                    myear1 = (DateTime.Today.Year + 1).ToString();
                    myear = (DateTime.Now.Year).ToString().Substring(2, 2);
                    mfiancyear = myear + myear1.Substring(2, 2);
                    mfiancyear1 = myear + "-" + (myear1).Substring(2, 2);
                }
                else if (mmonth <= 04)
                {
                    myear1 = (DateTime.Today.Year - 1).ToString();

                    myear = (DateTime.Now.Year).ToString().Substring(2, 2);
                    mfiancyear = myear1.Substring(2, 2) + myear;
                    mfiancyear1 = (myear1).Substring(2, 2) + "-" + myear;
                }
                mquery = "select " + mfield + " from " + mtable + " where  finacial='" + mfiancyear + "' order by " + mfield + " desc";
                mfcode = (generateSrno(mquery)).ToString();
                mfcode = (int.Parse(mfcode)).ToString("0000");
                return mfcode;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string numberToWords(int mnumber)
        {
            if (mnumber == 0)
                return "zero";

            if (mnumber < 0)
                return "minus " + numberToWords(Math.Abs(mnumber));

            words = "";

            if ((mnumber / 1000000000) > 0)
            {
                words += numberToWords(mnumber / 1000000000) + " Billion ";
                mnumber %= 1000000000;
            }

            if ((mnumber / 10000000) > 0)
            {
                words += numberToWords(mnumber / 10000000) + " Crore ";
                mnumber %= 10000000;
            }

            if ((mnumber / 1000000) > 0)
            {
                words += numberToWords(mnumber / 1000000) + " Lakh "; //
                mnumber %= 1000000;
            }


            if ((mnumber / 1000000) > 0)
            {
                words += numberToWords(mnumber / 100000) + " Lakh ";
                mnumber %= 100000;
            }

            if ((mnumber / 1000) > 0)
            {
                words += numberToWords(mnumber / 1000) + " Thousand ";
                mnumber %= 1000;
            }

            if ((mnumber / 100) > 0)
            {
                words += numberToWords(mnumber / 100) + " Hundred ";
                mnumber %= 100;
            }

            if (mnumber > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (mnumber < 20)

                    words += unitsMap[mnumber];
                else
                {
                    words += tensMap[mnumber / 10];
                    if ((mnumber % 10) > 0)
                        words += "-" + unitsMap[mnumber % 10];
                }
            }

            return words;
        }
        public string queryDateFormat(string mdate)
        {
            dd = mdate.Substring(0, 2);
            mm = mdate.Substring(3, 2);
            yyyy = mdate.Substring(6, 4);
            mdtfrom = yyyy + "-" + mm + "-" + dd;
            return mdtfrom;
        }
        public string getFinancial()
        {
            finyear = "0000";

            currentyear = DateTime.Today.Year;
            previousyear = DateTime.Today.Year - 1;
            nextyear = DateTime.Today.Year + 1;
            preyear = previousyear.ToString();
            nexyear = nextyear.ToString();
            curyear = currentyear.ToString();

            if (DateTime.Today.Month > 3)
            {
                finyear = curyear.Substring(curyear.Length - 2) + nexyear.Substring(nexyear.Length - 2);
            }
            else
            {
                finyear = preyear.Substring(preyear.Length - 2) + curyear.Substring(curyear.Length - 2);
            }
            return finyear;
        }
        public string getMacAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            smacaddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (smacaddress == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    smacaddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return smacaddress;
        }
    }
}
