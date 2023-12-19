using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class frmrole : Form
    {
        sqlcon x = new sqlcon();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string dgvselect;
        public frmrole()
        {
            InitializeComponent();
        }

        private void btnaddrole_Click(object sender, EventArgs e)
        {
            txtrole.Enabled = true; ;
            txtrole.Focus();
            btnaddrole.Enabled = false;
            btnsaverole.Enabled = true;
        }

        private void btnsaverole_Click(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            cmd = x.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Role (Role_name) values('" + txtrole.Text + "')";
            cmd.ExecuteNonQuery();
            x.con.Close();
            MessageBox.Show("Role Added Successfully.");
            btnaddrole.Enabled = true;
            btnsaverole.Enabled = false;
            txtrole.Text = null; txtrole.Enabled = false;
            loadrole();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadrole()
        {
            int i = 0;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            cmd = new SqlCommand("Select * from Role order by Role_name", x.con);
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["Id"], dr["Role_name"].ToString()); 
            }
            dr.Close();

        }

        private void frmrole_Load(object sender, EventArgs e)
        {
            loadrole();
        }

        private void txtrolesearch_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            cmd = new SqlCommand("Select * from Role where Role_name like '%"+txtrolesearch.Text+"%' order by Role_name", x.con);
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["Id"], dr["Role_name"].ToString());
            }
            dr.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvselect = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtrole.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtrole.Enabled = true;
            btnaddrole.Enabled = false;
            btndeleterole.Enabled = true;
            btnupdaterole.Enabled = true;
 
        }

        private void btndeleterole_Click(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            cmd = x.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Role where Id='"+dgvselect+"'";
            cmd.ExecuteNonQuery();
            x.con.Close();
            MessageBox.Show("Role Deleted Successfully.");
            txtrole.Text = null; txtrole.Enabled = false;
            loadrole();
            btnaddrole.Enabled = true;
        }

        private void btnupdaterole_Click(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            cmd = x.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Role set Role_name='"+txtrole.Text+ "' where Id='" + dgvselect + "'";
            cmd.ExecuteNonQuery();
            x.con.Close();
            MessageBox.Show("Role Updated Successfully.");
            txtrole.Text = null; txtrole.Enabled = false;
            btnupdaterole.Enabled = false;
            btnaddrole.Enabled = true;
            loadrole();
        }
    }

}
