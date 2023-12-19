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

namespace CafeManagement
{
    public partial class frmstaff : Form
    {
        sqlcon x = new sqlcon();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string imgLoc;
        //string dgvselect;
        public frmstaff()
        {
            InitializeComponent();
        }

        private void staffcontrolreset()
        {
            btnsavestaff.Enabled = false;
            btndeletestaff.Enabled = false;
            btnupdatestaff.Enabled = false;
            btnaddstaff.Enabled = true;
            foreach (Control item in panelstaff.Controls)
            {
                item.ResetText();
                item.Enabled = false;
            }
            btnphoto.Text = "Browse";
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void controlsreset()
        {
            pbphoto.Image = null;           txtid.Text = null;
            txtfnam.Text = null;            txtlnam.Text = null;
            txttol.Text = null;            txtcity.Text = null;
            txtdistrict.Text = null;          txtzone.Text = null;
            txtpin.Text = null;            txtgender.Text = null;
            txtemail.Text = null;            txtdobd.Text =null;
            txtdobm.Text =null;            txtdoby.Text = null;
            txtdojd.Text =null;            txtdojm.Text =null;
            txtdojy.Text = null;            txtrole.Text = null;
            cmbstatus.SelectedIndex = -1;
            txtsalary.Text = null;            txtcontact.Text = null;
            
           
            foreach (Control item in panelstaff.Controls)
            {
                item.Enabled = false;
            }
            btnaddstaff.Enabled = true;
            btnsavestaff.Enabled = false;
            btndeletestaff.Enabled = false;
            btnupdatestaff.Enabled = false;
        }
       
        private void frmstaff_Load(object sender, EventArgs e)
        {
            displaystaff();
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            btnsavestaff.Enabled = false;
            foreach (Control item in panelstaff.Controls)
            {
                item.Enabled = false;
            }
            cmd = new SqlCommand("Select Role_name from Role", x.con);
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string query;
                query = dr[0].ToString();
                txtrole.Items.Add(query);
            }
            txtrole.SelectedIndex = -1;
            dr.Close();//closing the datareader
            x.con.Close();//closing connection
        }

        private void btnaddstaff_Click(object sender, EventArgs e)
        {
            
           
            controlsreset();
            foreach (Control item in panelstaff.Controls)
            {
                item.Enabled = true;
            }
            btnaddstaff.Enabled = false;
            btnsavestaff.Enabled = true;
        }

        private void btnphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Jpeg Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png";
            dlg.Title = "Select Staff Picture";
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pbphoto.ImageLocation = imgLoc;
                pbphoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public byte[] bytephoto()
        {
            MemoryStream ms = new MemoryStream();
            pbphoto.Image.Save(ms, pbphoto.Image.RawFormat);
            return ms.GetBuffer();
        }
        private void btnsavestaff_Click(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            try
            {
                //byte[] img = null;
                //FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                //BinaryReader br = new BinaryReader(fs);
                //img = br.ReadBytes((int)fs.Length);
                cmd = new SqlCommand("INSERT INTO Staff(F_name, L_name, Tol, City, District, Zone, Pin, Gender, Email, DOBd, DOBm, DOBy, DOJd, DOJm, DOJy, Role, Salary, Contact, Photo,Status) VALUES('" + txtfnam.Text + "','" + txtlnam.Text + "','" + txttol.Text + "','" + txtcity.Text + "','" + txtdistrict.Text + "','" + txtzone.Text + "','" + txtpin.Text + "','" + txtgender.Text + "','" + txtemail.Text + "','" + txtdobd.Text + "','" + txtdobm.Text + "','" + txtdoby.Text + "','" + txtdojd.Text + "','" + txtdojm.Text + "','" + txtdojy.Text + "','" + txtrole.Text + "','" + txtsalary.Text + "','" + txtcontact.Text + "', @img,'" + cmbstatus.SelectedItem.ToString() + "')", x.con);
                cmd.Parameters.Add(new SqlParameter("@img", bytephoto()));
                cmd.ExecuteNonQuery();
                x.con.Close();
                controlsreset();
                staffcontrolreset();
                displaystaff();
                MessageBox.Show("Staff added successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check null value of staff name, unique value for contact number or contact tehcnical person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void displaystaff()
        {
            int i = 0;

            if (x.con.State == ConnectionState.Closed)
                x.con.Open();

            cmd = new SqlCommand("Select * from Staff", x.con);
            dr = cmd.ExecuteReader();
            DGVSTAFF.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                DGVSTAFF.Rows.Add(i, dr["Staff_id"].ToString(), dr["F_name"].ToString(), dr["L_name"].ToString(), dr["Tol"].ToString(), dr["City"].ToString(), dr["District"].ToString(), dr["Zone"].ToString(), dr["Pin"].ToString(), dr["Gender"].ToString(), dr["Email"].ToString(), dr["DOBd"].ToString(), dr["DOBm"].ToString(), dr["DOBy"].ToString(), dr["DOJd"].ToString(), dr["DOJm"].ToString(), dr["DOJy"].ToString(), dr["Role"].ToString(), dr["Salary"].ToString(), dr["Contact"].ToString(), dr["Status"].ToString());
            }
            dr.Close();
            x.con.Close();

        }

        private void DGVSTAFF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            
                txtid.Text = DGVSTAFF.CurrentRow.Cells[1].Value.ToString();
                cmd = new SqlCommand("Select Photo from Staff where Staff_id='" + txtid.Text + "'", x.con);
                dr = cmd.ExecuteReader();
                dr.Read();
                byte[] img = (byte[])dr[0];
                if (img == null)
                {
                    pbphoto.Image = null;
                    MessageBox.Show("Staff photo is not available.");
                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pbphoto.Image = Image.FromStream(ms);
                }
                txtfnam.Text = DGVSTAFF.CurrentRow.Cells[2].Value.ToString();
                txtlnam.Text = DGVSTAFF.CurrentRow.Cells[3].Value.ToString();
                txttol.Text = DGVSTAFF.CurrentRow.Cells[4].Value.ToString();
                txtcity.Text = DGVSTAFF.CurrentRow.Cells[5].Value.ToString();
                txtdistrict.Text = DGVSTAFF.CurrentRow.Cells[6].Value.ToString();
                txtzone.Text = DGVSTAFF.CurrentRow.Cells[7].Value.ToString();
                txtpin.Text = DGVSTAFF.CurrentRow.Cells[8].Value.ToString();
                txtgender.Text = DGVSTAFF.CurrentRow.Cells[9].Value.ToString();
                txtemail.Text = DGVSTAFF.CurrentRow.Cells[10].Value.ToString();
                txtdobd.Text = DGVSTAFF.CurrentRow.Cells[11].Value.ToString(); ;
                txtdobm.Text = DGVSTAFF.CurrentRow.Cells[12].Value.ToString();
                txtdoby.Text = DGVSTAFF.CurrentRow.Cells[13].Value.ToString();
                txtdojd.Text = DGVSTAFF.CurrentRow.Cells[14].Value.ToString();
                txtdojm.Text = DGVSTAFF.CurrentRow.Cells[15].Value.ToString();
                txtdojy.Text = DGVSTAFF.CurrentRow.Cells[16].Value.ToString();
                txtrole.Text = DGVSTAFF.CurrentRow.Cells[17].Value.ToString();
                txtsalary.Text = DGVSTAFF.CurrentRow.Cells[18].Value.ToString();
                txtcontact.Text = DGVSTAFF.CurrentRow.Cells[19].Value.ToString();
            cmbstatus.Text= DGVSTAFF.CurrentRow.Cells[20].Value.ToString();

            foreach (Control item in panelstaff.Controls)
            {
                item.Enabled = false;
            }
            btnaddstaff.Enabled = true;
            btnsavestaff.Enabled = false;
            btndeletestaff.Enabled = true;
            btnupdatestaff.Enabled = true;
            dr.Close();
            x.con.Close();
        }

        private void btndeletestaff_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Deactivate Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    txtid.Text = DGVSTAFF.CurrentRow.Cells[1].Value.ToString();
                    cmd = new SqlCommand("Update Staff set Status='Deactive' where Staff_id='" + txtid.Text + "'", x.con);
                    dr = cmd.ExecuteReader();
                    x.con.Close();
                    displaystaff();
                    MessageBox.Show("Successfully deactivated the staff");
                }
                catch (Exception)
                {
                    MessageBox.Show("Technical Error!");
                }
            }
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcontact.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtcontact.Text = txtcontact.Text.Remove(txtcontact.Text.Length - 1);
            }
        }

        private void txttol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnupdatestaff_Click(object sender, EventArgs e)
        {
            if (txtcontact.Enabled == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Update Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    try
                    {

                        cmd = new SqlCommand("UPDATE Staff set F_name='" + txtfnam.Text + "', L_name='" + txtlnam.Text + "', Tol='" + txttol.Text + "', City='" + txtcity.Text + "', District='" + txtdistrict.Text + "', Zone='" + txtzone.Text + "', Pin='" + txtpin.Text + "', Gender='" + txtgender.Text + "', Email='" + txtemail.Text + "', DOBd='" + txtdobd.Text + "', DOBm='" + txtdobm.Text + "', DOBy='" + txtdoby.Text + "', DOJd='" + txtdojd.Text + "', DOJm='" + txtdojm.Text + "', DOJy='" + txtdojy.Text + "', Role='" + txtrole.Text + "', Salary='" + txtsalary.Text + "', Contact='" + txtcontact.Text + "', Photo=@img, Status='" + cmbstatus.Text.ToString() + "' where Staff_id='" + txtid.Text + "'", x.con);
                        cmd.Parameters.Add(new SqlParameter("@img", bytephoto()));
                        cmd.ExecuteNonQuery();
                        x.con.Close();
                        controlsreset();
                        staffcontrolreset();
                        displaystaff();
                        MessageBox.Show("Staff updated successfully!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please check null value of staff name, unique value for contact number or contact tehcnical person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
              
                foreach (Control item in panelstaff.Controls)
                {
                   
                    item.Enabled = true;
                }
                btnphoto.Text = "Browse";
            }
        }
    }
}
