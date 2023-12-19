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
    public partial class createinitialadmin : Form
    {
        public createinitialadmin()
        {
            InitializeComponent();
        }
        sqlcon x = new sqlcon();
        private void btncreateadmin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "" || txtcafeid.Text == "" || txtconfirm.Text == "")
            {
                MessageBox.Show("Please Complete All Required Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtpass.Text == txtconfirm.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Create admin with these details?", "Admin ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //try
                        //{
                        if (x.con.State == ConnectionState.Closed)
                            x.con.Open();

                        SqlCommand cmd1 = new SqlCommand("Insert into Connect(Username, Password,Role,CAFEID) values ('" + txtuser.Text + "','" + txtpass.Text + "','" + "Admin" + "','" + txtcafeid.Text + "')", x.con);
                        cmd1.ExecuteNonQuery();


                        x.con.Close();

                        MessageBox.Show("Successfully created the admin.");
                        this.Close();
                        //}
                        //catch (Exception)
                        //{
                        //    MessageBox.Show("Technical Error!");
                        //}
                    }
                }
                else
                {
                    MessageBox.Show("Password Not Confirmed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpass.Text = "";
                    txtconfirm.Text = "";
                    txtcafeid.Text = "";
                }
                
            }
        }






    }
}
