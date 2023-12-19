using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CafeManagement
{
    public partial class frmuser : Form
    {

        sqlcon x = new sqlcon();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public frmuser()
        {
            InitializeComponent();
        }
        private void controlreset()
        {
            foreach (Control item in panelstaff.Controls)
            {
                item.Enabled = false;
            }
            btnassignuser.Enabled = false;
            btnremuser.Enabled = false;
            txtcafeid.Enabled = false;
            txtcafeid.Text = "";
            txtid.Text = "";
            txtpass.Text = "";
            txtuser.Text = "";
            cmbaccesssystem.Text = "";
        }
        
        private void displaystafff()
        {
            int i = 0;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();

            cmd = new SqlCommand("Select Staff_id, F_name, L_name, Contact, Email, Role from Staff where Access='N' and Status='Active' ", x.con);
            dr = cmd.ExecuteReader();
            DGVSTAFFF.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                DGVSTAFFF.Rows.Add(i, dr["Staff_id"].ToString(), dr["F_name"].ToString(), dr["L_name"].ToString(), dr["Contact"].ToString(), dr["Email"].ToString(), dr["Role"]);
            }
            dr.Close();
            x.con.Close();
            
        }
        private void displayusers()
        {
            int i = 0;

            if (x.con.State == ConnectionState.Closed)
                x.con.Open();

            cmd = new SqlCommand("Select id, Username, Password, Role, CAFEID, u_staffid from Connect where u_staffid<>'"+""+"' ", x.con);
            dr = cmd.ExecuteReader();
            DGVUSER.Rows.Clear();
            while (dr.Read())
            {
                i += 1;
                DGVUSER.Rows.Add(i, dr["id"].ToString(), dr["Username"].ToString(), dr["Password"].ToString(), dr["Role"].ToString(), dr["CAFEID"].ToString(), dr["u_staffid"]);
            }
            dr.Close();
            x.con.Close();
        }



        private void frmuser_Load(object sender, EventArgs e)
        {
            displaystafff();
            displayusers();
        }

        private void DGVSTAFF_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            controlreset();
            btnassignuser.Enabled = true;
           txtid.Text= DGVSTAFFF.CurrentRow.Cells[1].Value.ToString();

            //dr.Close();
            //con.Close();

        }

        private void btnassignuser_Click(object sender, EventArgs e)
        {
            if (txtuser.Enabled == false)
            {
                txtpass.Enabled = true;
                txtpass.Text = "";
                txtuser.Enabled = true;
                txtuser.Text = null;
                txtcafeid.Enabled = true;
                txtcafeid.Text = null;
                cmbaccesssystem.Enabled = true;
                cmbaccesssystem.SelectedIndex = -1;
            }
            else if (txtuser.Enabled==true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Activate User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (x.con.State == ConnectionState.Closed)
                            x.con.Open();
                        txtid.Text = DGVSTAFFF.CurrentRow.Cells[1].Value.ToString();
                        SqlCommand cmd1 = new SqlCommand("Insert into Connect(Username, Password,Role,CAFEID,u_staffid) values ('"+txtuser.Text+"','"+txtpass.Text+"','"+cmbaccesssystem.SelectedItem.ToString()+"','"+txtcafeid.Text+"','"+txtid.Text+"')", x.con);
                        cmd1.ExecuteNonQuery();
                        cmd = new SqlCommand("Update Staff set Access='Y' where Staff_id='" + txtid.Text + "'", x.con);
                        cmd.ExecuteNonQuery();
                        x.con.Close();
                        displaystafff();
                        displayusers();
                        MessageBox.Show("Successfully activated the user");
                        controlreset();
                }
                    catch (Exception)
                {
                    MessageBox.Show("Note: All Fields are Mandatory & cafe-id should be unique of 5 characters!");
                }
            }
            }
        }
        string uid;
        private void DGVUSER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Control item in panelstaff.Controls)
            {
                item.Enabled = false;
            }
            txtid.Text = DGVUSER.CurrentRow.Cells[6].Value.ToString();
            uid= DGVUSER.CurrentRow.Cells[1].Value.ToString();
            txtuser.Text= DGVUSER.CurrentRow.Cells[2].Value.ToString();
            txtpass.Text= DGVUSER.CurrentRow.Cells[3].Value.ToString();
            cmbaccesssystem.Text= DGVUSER.CurrentRow.Cells[4].Value.ToString();
            txtcafeid.Text= DGVUSER.CurrentRow.Cells[5].Value.ToString();
            btnremuser.Enabled = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnremuser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Deactivate User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();
                    uid= DGVUSER.CurrentRow.Cells[1].Value.ToString();
                    cmd = new SqlCommand("Delete from Connect where Id='"+uid+"'", x.con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("Update Staff set Access='" + "N" + "' where Staff_id='" + txtid.Text + "'", x.con);
                    cmd1.ExecuteNonQuery();
                    x.con.Close();
                    displaystafff();
                displayusers();
                    MessageBox.Show("Successfully deactivated the staff");
                }
                catch (Exception)
                {
                    MessageBox.Show("Technical Error!");
                }
            }
        }
    }
}
