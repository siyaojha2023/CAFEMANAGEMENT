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
using System.IO;
using System.Drawing.Imaging;

namespace CafeManagement
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }
        sqlcon x= new sqlcon();
        string cid;
        string imgLoc;
      
        private void btnmenuexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void resetfields()
        {
            txtitem.Text = "";
            txtprice.Text = "";
            txtcategory.SelectedIndex = -1;
            txtstatus.SelectedIndex = -1;
            txtitem.Enabled = false;
            txtprice.Enabled = false;
            txtcategory.Enabled = false;
            txtstatus.Enabled = false;
            btnaddmenu.Enabled = true;
            btnsavemenu.Enabled = false;
            btndeletemenu.Enabled = false;
            btnupdatemenu.Enabled = false;
            picitem.Image = picitem.InitialImage; 
        }
        public void loadcategory()
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            string q = "select cat_id, cat_name from category";
            SqlCommand cmd = new SqlCommand(q, x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtcategory.Items.Add(dr["cat_name"].ToString());
                txtcategory.DisplayMember = (dr["cat_name"].ToString());
                txtcategory.ValueMember = (dr["cat_id"].ToString());
            }
            dr.Close();
            x.con.Close();
        }
        public void loadmenu()
        {
            int i = 0;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("Select m.m_id as [ID], m.m_name as [NAME],m.m_catID as [CATID], m.m_price as [PRICE], m.m_status as [STATUS], c.cat_name as [CATNAME] from menu m inner join category c on m.m_catID=c.cat_ID order by m_name", x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["ID"], dr["NAME"], dr["PRICE"], dr["STATUS"], dr["CATID"], dr["CATNAME"]);
            }
            dr.Close();
            x.con.Close();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            loadcategory();
            loadmenu();
            picitem.Image = picitem.InitialImage;
        }

        private void btnaddmenu_Click(object sender, EventArgs e)
        {
            btnsavemenu.Enabled = true;
            btnaddmenu.Enabled = false;
            btndeletemenu.Enabled = false;
            btnupdatemenu.Enabled = false;
            txtitem.Enabled = true;
            txtprice.Enabled = true;
            txtcategory.Enabled = true;
            txtstatus.Enabled = true;
            txtitem.Text = "";
            txtprice.Text = "";
            txtcategory.SelectedIndex = -1;
            txtstatus.SelectedIndex = -1;
            picitem.Image=picitem.InitialImage;


        }
        public byte[] bytephoto()
        {
            MemoryStream ms = new MemoryStream();
            picitem.Image.Save(ms, picitem.Image.RawFormat);
            return ms.GetBuffer();
        }
        private void btnsavemenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcategory.Text != "" && txtprice.Text != "" && txtitem.Text != "" && txtstatus.Text != "")
                {
                    if (MessageBox.Show("Are You Sure You Want to Save this Item", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        if (x.con.State == ConnectionState.Closed)
                            x.con.Open();
                        SqlCommand cmd = new SqlCommand("Insert into menu(m_name,m_catID,m_price,m_status,m_image) values('" + txtitem.Text + "', '" + cid + "', '" + txtprice.Text + "', '" + txtstatus.Text + "', @img)", x.con);
                        cmd.Parameters.Add(new SqlParameter("@img", bytephoto()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item added successfully!");
                        resetfields();
                        loadmenu();
                        x.con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Complete All The Fields!");
                }
            }
            catch (Exception)
            {
                x.con.Close();
                MessageBox.Show("Unable to add item,item may exist already,");
                resetfields();
            }
        }

        //private void txtstatus_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (x.con.State == ConnectionState.Closed)
        //        x.con.Open();
        //    SqlCommand cmd = new SqlCommand("Select cat_id from category where cat_name='" + txtcategory.SelectedItem + "'", x.con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        cid = dr[0].ToString();
        //    }
            
        //    dr.Close();
        //    x.con.Close();
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            string a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SqlCommand cmd = new SqlCommand("Select m_image from menu where m_id='" + a + "'", x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            byte[] img = (byte[])dr[0];
            if (img == null)
            {
                picitem.Image = null;
                MessageBox.Show("Item pic is not available.");
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);
                picitem.Image = Image.FromStream(ms);
            }
            x.con.Close();
            dr.Close();
            txtitem.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcategory.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtprice.Text = (Convert.ToSingle(dataGridView1.CurrentRow.Cells[3].Value.ToString())).ToString();
            txtstatus.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            btnaddmenu.Enabled = true;
            btndeletemenu.Enabled = true;
            btnupdatemenu.Enabled = true;
            btnsavemenu.Enabled = false;
            txtitem.Enabled = false;
            txtcategory.Enabled = false;
            txtprice.Enabled = false;
            txtstatus.Enabled = false;
        }

        private void btndeletemenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Delete the Item", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    string a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from menu where m_id='" + a + "'", x.con); cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully.");
                    resetfields();
                    loadmenu();
                    x.con.Close();
                }
            }
            catch (Exception)
            {
                x.con.Close();
                MessageBox.Show("Unable to delete item!!");
                resetfields();
            }
        }

        private void btnupdatemenu_Click(object sender, EventArgs e)
        {
            if (txtitem.Enabled == true)
            {
                try
                {
                    if (txtcategory.Text != "" && txtprice.Text != "" && txtitem.Text != "" && txtstatus.Text != "")
                    {
                        if (MessageBox.Show("Are You Sure You Want to Update the Item", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                            if (x.con.State == ConnectionState.Closed)
                                x.con.Open();
                            string a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            SqlCommand cmd = new SqlCommand("update menu set m_name='" + txtitem.Text + "', m_catID='" + cid + "', m_price='" + txtprice.Text + "', m_status='" + txtstatus.Text + "',m_image=@img where m_id='" + a + "'", x.con);
                            cmd.Parameters.Add(new SqlParameter("@img", bytephoto()));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Item Updated Successfully.");
                            resetfields();
                            loadmenu();
                            x.con.Close();
                  
                        }
                    }
                    }
                catch (Exception)
                {
                    x.con.Close();
                    MessageBox.Show("Unable to Update Item, Item may already exist!!");
                    resetfields();
                }
            }
            else
            {
                txtitem.Enabled = true;
                txtprice.Enabled = true;
                txtcategory.Enabled = true;
                txtstatus.Enabled = true;
            }
        }

        private void txtmenusearch_TextChanged(object sender, EventArgs e)
        {
            if (txtmenusearch.Text.Length <= 0)
            {
                loadmenu();
            }
            else
            {
                int i = 0;
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("Select m.m_id as [ID], m.m_name as [NAME],m.m_catID as [CATID], m.m_price as [PRICE], m.m_status as [STATUS], c.cat_name as [CATNAME] from menu m inner join category c on m.m_catID=c.cat_ID where m_name like '%"+txtmenusearch.Text+"%' order by m_name", x.con);
                SqlDataReader dr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView1.Rows.Add(i, dr["ID"], dr["NAME"], dr["PRICE"], dr["STATUS"], dr["CATID"], dr["CATNAME"]);
                }
                dr.Close();
                x.con.Close();
            }
        }

        private void picitem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Jpeg Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png";
            dlg.Title = "Select Staff Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                picitem.ImageLocation = imgLoc;
                picitem.SizeMode = PictureBoxSizeMode.StretchImage;
              
            }
        }

        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("Select cat_id from category where cat_name='" + txtcategory.SelectedItem + "'", x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cid = dr[0].ToString();
            }

            dr.Close();
            x.con.Close();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            }
        }
    }
}
