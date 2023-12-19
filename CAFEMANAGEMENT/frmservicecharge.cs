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
    public partial class frmservicecharge : Form
    {
        public frmservicecharge()
        {
            InitializeComponent();
        }
        sqlcon x = new sqlcon();

        private void btntaxexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void initialcase()
        {
            txtinclu.Enabled = false;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from servicechrg", x.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0) 
            txtinclu.Text = dt.Rows[0]["sc_percent"].ToString();
            else
            {
                SqlCommand cnd = new SqlCommand("insert into servicechrg(sc_percent) values ('0')", x.con);
                cnd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtinclu.Text = dt.Rows[0]["sc_percent"].ToString();
            }
            x.con.Close();

        }

        private void taxform_Load(object sender, EventArgs e)
        {
            initialcase();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtinclu.Enabled == true)
            {
                if (txtinclu.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update service charge percentage", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (x.con.State == ConnectionState.Closed)
                            x.con.Open();
                        SqlCommand cmd = new SqlCommand("Update servicechrg set sc_percent='"+txtinclu.Text+"'", x.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Service Updated Successfully");

                        initialcase();
                        

                    }
                    else if (dr==DialogResult.No)
                    {
                        initialcase();
                    }
                }
                else
                {
                    MessageBox.Show("Please complete fields & try");
                }
             }
            else
            {
                txtinclu.Enabled = true;
                
                txtinclu.Text = "";
      
            }
        }
    }
}
