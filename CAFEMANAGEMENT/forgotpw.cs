using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CafeManagement
{
    public partial class pwforgot : Form
    {
        dbconnection d = new dbconnection();
        public pwforgot()
        {
            InitializeComponent();
        }
        sqlcon x = new sqlcon();

        private void btnfrgtapply_Click(object sender, EventArgs e)
        {
            if (txt_cafeid.Text == "" || txtuserfrgt.Text == "" || txtnpw.Text == "" || txtcnpw.Text == "")
            {
                MessageBox.Show("All Fields are Mandatory");
            }
            else
            {
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = x.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from Connect where CAFEID='" + txt_cafeid.Text + "' and Username='" + txtuserfrgt.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    if (txtnpw.Text == txtcnpw.Text)
                    {
                        if (x.con.State == ConnectionState.Closed)
                            x.con.Open();
                        SqlCommand cmd1 = x.con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "Update Connect set password='" + txtnpw.Text + "' where CAFEID='" + txt_cafeid.Text + "' and Username='" + txtuserfrgt.Text + "'";
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Password Changed Successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Confirmation Error");
                        txtnpw.Text = "";
                        txtcnpw.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Cafe Id and Username not valid!");
                }
                x.con.Close();
            }
        }
    }
}
