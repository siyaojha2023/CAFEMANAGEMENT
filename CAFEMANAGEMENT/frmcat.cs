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
    public partial class frmcat : Form
    {
        public frmcat()
        {
            InitializeComponent();
        }
        sqlcon x = new sqlcon();
        string cid;
        private void catexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void resetfields()
        {
            txtcat.Text = "";
            txtcat.Enabled = false;
            btnaddcat.Enabled = true;
            btnsavecat.Enabled = false;
            btndeletecat.Enabled = false;
            btnupdatecat.Enabled = false;
        }
        public void loadcat()
        {
            int i = 0;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            string q = "select cat_id, cat_name from category order by cat_name";
            SqlCommand cmd = new SqlCommand(q, x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["cat_id"], dr["cat_name"].ToString());
            }
            dr.Close();
            x.con.Close();
        }

        private void frmcat_Load(object sender, EventArgs e)
        {
            loadcat();
        }

        private void btnaddcat_Click(object sender, EventArgs e)
        {
            btnsavecat.Enabled = true;
            btnaddcat.Enabled = false;
            btndeletecat.Enabled = false;
            btnupdatecat.Enabled = false;
            txtcat.Enabled = true;
            txtcat.Text = "";
        }

        private void btnsavecat_Click(object sender, EventArgs e)
        {
            if (txtcat.Text != "")
            {
                try
                {
                    if (MessageBox.Show("Are You Sure You Want to Save this Category", "Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        byte[] img = null;
                        if (x.con.State == ConnectionState.Closed)
                            x.con.Open();
                        SqlCommand cmd = new SqlCommand("Insert into category(cat_name) values('" + txtcat.Text + "')", x.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category added successfully!");
                        resetfields();
                        loadcat();
                        x.con.Close();
                    }
                }
                catch (Exception)
                {
                    x.con.Close();
                    MessageBox.Show("Unable to add category,category may exist already,");
                    resetfields();
                }
            }
            else
                MessageBox.Show("Complete the field.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            cid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            btnaddcat.Enabled = true;
            btndeletecat.Enabled = true;
            btnupdatecat.Enabled = true;
            btnsavecat.Enabled = false;
            txtcat.Enabled = false;
        }

        private void btndeletecat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Delete the Category", "Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    cid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from category where cat_id='" +cid+ "'", x.con); cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Removed Successfully.");
                    resetfields();
                    loadcat();
                    x.con.Close();
                }
            }
            catch (Exception)
            {
                x.con.Close();
                MessageBox.Show("Unable to remove category!!");
                resetfields();
            }
        }

        private void btnupdatecat_Click(object sender, EventArgs e)
        {
            if (txtcat.Enabled == true)
            {
                try
                {

                    if (MessageBox.Show("Are You Sure You Want to Update the Category", "Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (x.con.State == ConnectionState.Closed)
                            x.con.Open();
                        cid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        SqlCommand cmd = new SqlCommand("update category set cat_name='" + txtcat.Text + "' where cat_id='" + cid + "'", x.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category Updated Successfully.");
                        resetfields();
                        loadcat();
                        x.con.Close();
                    }
                }
                catch (Exception)
                {
                    x.con.Close();
                    MessageBox.Show("Unable to Update Category, Category may already exist!!");
                    resetfields();
                }
            }
            else
            {
                txtcat.Enabled = true;
            }
        }

        private void txtcatsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtcatsearch.Text.Length <= 0)
            {
                loadcat();
            }
            else
            {
                int i = 0;
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("Select cat_id, cat_name from category  where cat_name like '%" + txtcatsearch.Text + "%' order by cat_name", x.con);
                SqlDataReader dr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView1.Rows.Add(i,dr["cat_id"], dr["cat_name"].ToString());
                }
                dr.Close();
                x.con.Close();
            }
        }
    }
}
