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
    public partial class frmtables : Form
    {
        sqlcon x = new sqlcon();
        string fid;
        public frmtables()
        {
            InitializeComponent();
        }

        private void btntableexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void resetfields()
        {
            txttablenumber.Text = "";
            txttablechairs.SelectedIndex = -1;
            txttfloorid.SelectedIndex = -1;
            txttablenumber.Enabled = false;
            txttablechairs.Enabled = false;
            txttfloorid.Enabled =false;
            btnaddtable.Enabled = true;
            btnsavetable.Enabled = false;
            btndeletetable.Enabled = false;
            btnupdatetable.Enabled = false;
         }

        private void btnaddtable_Click(object sender, EventArgs e)
        {
            btnsavetable.Enabled = true;
            btnaddtable.Enabled = false;
            btndeletetable.Enabled = false;
            btnupdatetable.Enabled = false;
            txttablenumber.Enabled = true;
            txttablenumber.Enabled = true;
            txttablechairs.Enabled = true;
            txttablenumber.Text = "";

            txttablechairs.SelectedIndex = -1;
            txttfloorid.SelectedIndex = -1;
            txttfloorid.Enabled = true;
        }
        public void loadtable()
        {
            int i = 0;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("Select t.t_id as [ID],t.t_number as [NUMBER],  t.t_chairs as [CHAIRS], f.f_name as [FLOOR] from floors f inner join tables t on f.f_id=t.t_floorid order by t_number", x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["ID"], dr["NUMBER"], dr["CHAIRS"], dr["FLOOR"]);
            }
            dr.Close();
            x.con.Close();
        }

        private void btnsavetable_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Add Table", "Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into tables(t_number,t_chairs,t_floorid) values('" + txttablenumber.Text + "', '" + txttablechairs.Text + "', " +fid+ ")", x.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Table added successfully!");
                    resetfields();
                    loadtable();
                    x.con.Close();
                }
            }
            catch (Exception)
            {
                x.con.Close();
                MessageBox.Show("Unable to add table,table may exist already,");
                resetfields();
            }
          
        }
        public void loadfloors()
        {
            if (x.con.State==ConnectionState.Closed)
            x.con.Open();
            string q = "select f_name, f_id from floors";
            SqlCommand cmd = new SqlCommand(q, x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txttfloorid.Items.Add(dr["f_name"].ToString());
                txttfloorid.DisplayMember = (dr["f_name"].ToString());
                txttfloorid.ValueMember = (dr["f_id"].ToString());
            }
            dr.Close();
            x.con.Close();

        }
       
        private void frmtables_Load(object sender, EventArgs e)
        {
            
                loadfloors();
            loadtable();

          
        }

        private void txttfloorid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("Select f_id from floors where f_name='" + txttfloorid.SelectedItem + "'", x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                fid = dr[0].ToString();
            }
            
            dr.Close();
            x.con.Close();
            
        }

        private void txttablesearch_TextChanged(object sender, EventArgs e)
        {
            if (txttablesearch.Text.Length <= 0)
            {
                loadtable();
            }
            else
            {
                int i = 0;
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("Select t.t_id as [ID],t.t_number as [NUMBER],  t.t_chairs as [CHAIRS], f.f_name as [FLOOR] from floors f inner join tables t on f.f_id=t.t_floorid where t.t_number like '" + txttablesearch.Text + "'", x.con);
                SqlDataReader dr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView1.Rows.Add(i, dr["ID"], dr["NUMBER"], dr["CHAIRS"], dr["FLOOR"]);
                }
                dr.Close();
                x.con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttfloorid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txttablenumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttablechairs.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            btnaddtable.Enabled = true;
            btndeletetable.Enabled = true;
            btnupdatetable.Enabled = true;
            btnsavetable.Enabled = false;
            txttablenumber.Enabled = false;
            txttablechairs.Enabled = false;
            txttfloorid.Enabled = false;

        }

        private void btndeletetable_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Delete the Table", "Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    string a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from tables where t_id='" + a + "'", x.con); cmd.ExecuteNonQuery();
                    MessageBox.Show("Table Deleted Successfully.");
                    resetfields();
                    loadtable();
                    x.con.Close();
                }
            }
            catch (Exception)
            {
                x.con.Close();
                MessageBox.Show("Unable to delete floor!!");
                resetfields();
            }
        }

        private void btnupdatetable_Click(object sender, EventArgs e)
        {
            if (txttablenumber.Enabled == true)
            {
                try
                {
                    if (MessageBox.Show("Are You Sure You Want to Update the Table", "Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (x.con.State == ConnectionState.Closed)
                           x.con.Open();
                        string a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        SqlCommand cmd = new SqlCommand("update tables set t_number='" + txttablenumber.Text + "', t_chairs='" + txttablechairs + "',t_floorid='"+fid+"' where t_id='" + a + "'", x.con); cmd.ExecuteNonQuery();
                        MessageBox.Show("Floor Updated Successfully.");
                        resetfields();
                        loadtable();
                        x.con.Close();
                    }
                }
                catch (Exception)
                {
                    x.con.Close();
                    MessageBox.Show("Unable to Update Table, Table may already exist!!");                                                                
                    resetfields();
                }
            }
            else                                     
            {                                                                                                                                                      
                txttablenumber.Enabled = true;
                txttablechairs.Enabled = true;
                txttfloorid.Enabled = true;
            }
        }
    }
}
