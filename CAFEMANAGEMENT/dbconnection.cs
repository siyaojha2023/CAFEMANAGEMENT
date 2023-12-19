using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeManagement
{
    class dbconnection
    {
        public SqlConnection con;
        public void connectsql()
        {
            con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MANOJBACKUP\repos\WindowsFormsApp3\WindowsFormsApp3\loginsec.mdf;Integrated Security=True");
            if (con.State==ConnectionState.Closed)
                con.Open();
        }
        public void sqldisconnect()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
