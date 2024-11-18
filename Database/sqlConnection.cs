using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSYS.Database
{
    class sqlConnection
    {
        public void connect_db(OracleConnection conStr)
        {
            conStr.Open();
        }

        public void close_db(OracleConnection conStr)
        {
            conStr.Close();
        }

        public static string get_db_status(OracleConnection constr)
        {
            string message;

            if (constr.State == ConnectionState.Open)
            {
                message = "Open";
            }
            else if (constr.State == ConnectionState.Closed)
            {
                message = "Closed";
            }
            else
            {
                message = "Unavailable Currently";
            }

            return message;
        }
    }
}
