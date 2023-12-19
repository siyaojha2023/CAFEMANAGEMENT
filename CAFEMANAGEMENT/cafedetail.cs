using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagement
{
    public partial class cafedetail : Form
    {
        public cafedetail()
        {
            InitializeComponent();
        }
        sqlcon x = new sqlcon();
        public void fetchdetail()
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("select * from aboutcafe where id='1'", x.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtcafename.Text = dt.Rows[0]["cafename"].ToString();
                txtcafeaddress.Text = dt.Rows[0]["cafeaddress"].ToString();
            }
            x.con.Close();
        }
        public void controlreset()
        {
            txtcafename.Enabled = false;
            txtcafeaddress.Enabled = false;
            fetchdetail();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cafedetail_Load(object sender, EventArgs e)
        {
            fetchdetail();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtcafename.Enabled == true)
            {
                if (txtcafename.Text != "" && txtcafeaddress.Text != "")
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    SqlCommand cmd = new SqlCommand("update aboutcafe set cafename='" + txtcafename.Text + "', cafeaddress='" + txtcafeaddress.Text + "' where id='1'", x.con);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Successfully updated.");
                        x.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Complete the filled & try");
                    }
                    controlreset();
                }
               

            }
            else
            {
                txtcafename.Text = "";
                txtcafeaddress.Text = "";
                txtcafeaddress.Enabled = true;
                txtcafename.Enabled = true;
            }
        }
    }
}
