using System;
using System.Collections.Generic;
using System.Data;

namespace mobileAir.common
{
    public class variables
    {
        static int msoftId = 0;
        public static int softId
        {
            get
            {
                return msoftId;
            }
            set
            {
                msoftId = value;
            }
        }

        static int msoftbillcode = 0;
        public static int softbillcode
        {
            get
            {
                return msoftbillcode;
            }
            set
            {
                msoftbillcode = value;
            }
        }

        static string msoftbillno = "";
        public static string softbillno
        {
            get
            {
                return msoftbillno;
            }
            set
            {
                msoftbillno = value;
            }
        }

        static string mfinacial = "0000";
        public static string finacial
        {
            get
            {
                return mfinacial;
            }
            set
            {
                mfinacial = value;
            }
        }

        static string mformchange = "";
        public static string formchange
        {
            get
            {
                return mformchange;
            }
            set
            {
                mformchange = value;
            }
        }

        // Print Report
        static DataTable mdthead = new DataTable();
        public static DataTable mdtreportheader
        {
            get
            {
                return mdthead;
            }
            set
            {
                mdthead = value;
            }
        }

        static DataTable mdt = new DataTable();
        public static DataTable mdtreport
        {
            get
            {
                return mdt;
            }
            set
            {
                mdt = value;
            }
        }
    }
}
