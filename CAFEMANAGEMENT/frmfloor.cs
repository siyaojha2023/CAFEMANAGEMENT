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
    public partial class frmfloor : Form
    {
        sqlcon x = new sqlcon();
        public frmfloor()
        {
            InitializeComponent();
        }
        public void resetfields()
        {
            txtfloorname.Text = "";
            txtfloornumber.SelectedIndex = -1;
            btnaddrole.Enabled = true;
            btnsavefloor.Enabled = false;
            btndeletefloor.Enabled = false;
            btnupdatefloor.Enabled = false;
            txtfloorname.Enabled = false;
            txtfloornumber.Enabled = false;

        }
        public void loadfloor()
        {
            int i = 0;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Floors order by f_number", x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["f_id"], dr["f_name"].ToString(), dr["f_number"]);
            }
            dr.Close();
            x.con.Close();
        }

        private void btnfloorexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnaddrole_Click(object sender, EventArgs e)
        {
            resetfields();
            btnsavefloor.Enabled = true;
            btnaddrole.Enabled = false;
            txtfloorname.Enabled = true;
            txtfloornumber.Enabled = true;

        }

        private void frmfloor_Load(object sender, EventArgs e)
        {
            try
            {
                loadfloor();

            }
            catch (Exception)
            {
                x.con.Close();
                MessageBox.Show("Unable to Load Floors!!");
                resetfields();
            }
        }

        private void btnsavefloor_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Add Floor", "Floor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into floors(f_name,f_number) values('" + txtfloorname.Text + "', '" + txtfloornumber.Text + "')", x.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Floor Saved Successfully.");
                    resetfields();
                    loadfloor();
                    x.con.Close();
                }
            }
            catch (Exception)
            {
                x.con.Close();
                MessageBox.Show("Unable to save floor,floor may exist already,");
                resetfields();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtfloorname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtfloornumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            btnaddrole.Enabled = true;
            btndeletefloor.Enabled = true;
            btnupdatefloor.Enabled = true;
            btnsavefloor.Enabled = false;
            txtfloorname.Enabled = false;
            txtfloornumber.Enabled = false;
        }

        private void btndeletefloor_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Delete the Floor", "Floor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    string a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from floors where f_id='"+a+"'", x.con);                   cmd.ExecuteNonQuery();
                    MessageBox.Show("Floor Deleted Successfully.");
                    resetfields();
                    loadfloor();
                    x.con.Close();
                }
            }
            catch (Exception)
            {
                x.con.Close();
                MessageBox.Show("Unable to delete floor, release tables of floor");
                resetfields();
            }
        }

        private void btnupdatefloor_Click(object sender, EventArgs e)
        {
            if (txtfloorname.Enabled == true)
            {
                try
                {
                    if (MessageBox.Show("Are You Sure You Want to Update the Floor", "Floor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (x.con.State == ConnectionState.Closed)
                            x.con.Open();
                        string a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        SqlCommand cmd = new SqlCommand("update floors set f_name='" + txtfloorname.Text + "', f_number='" + txtfloornumber.Text + "' where f_id='" + a + "'", x.con); cmd.ExecuteNonQuery();
                        MessageBox.Show("Floor Updated Successfully.");
                        resetfields();
                        loadfloor();
                        x.con.Close();
                    }
                }
                catch (Exception)
                {
                    x.con.Close();
                    MessageBox.Show("Unable to Update floor, floor may already exist!!");
                    resetfields();
                }
            }
           else
            {
                txtfloorname.Enabled = true;
                txtfloornumber.Enabled = true;
            }
        }

        private void txtrolesearch_TextChanged(object sender, EventArgs e)
        {
            if(txtfloorsearch.Text.Length<=0)
            {
                loadfloor();
            }
            int i = 0;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Floors where f_name like '%"+txtfloorsearch.Text+"%' order by f_number", x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["f_id"], dr["f_name"].ToString(), dr["f_number"]);
            }
            dr.Close();
            x.con.Close();
        }
    }
}
