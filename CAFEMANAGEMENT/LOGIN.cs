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
using System.Windows;
using System.Media;
namespace CafeManagement
{
    public partial class LOGIN : Form
    {
        sqlcon y = new sqlcon();
      //  SoundPlayer x = new SoundPlayer(@"C:\Users\Manoj\Desktop\Proposal Working\My Proposal\sound\Login.wav");
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string utype;
            if (y.con.State == ConnectionState.Closed)
                y.con.Open();
          
            SqlCommand cmd1 = y.con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * from Connect";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
                            {
                                            if (y.con.State == ConnectionState.Closed)
                                                y.con.Open();
                                            SqlCommand cmd = y.con.CreateCommand();
                                            cmd.CommandType = CommandType.Text;
                                            cmd.CommandText = "SELECT * from Connect where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                                            cmd.ExecuteNonQuery();
                                            DataTable dt1 = new DataTable();
                                            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                                            da1.Fill(dt1);
                                            if (dt1.Rows.Count > 0)
                                            {
                                                utype = dt1.Rows[0][3].ToString();
                                                if (utype == "Admin")
                                                {
                                                  //  SoundPlayer y = new SoundPlayer(@"C:\Users\Manoj\Desktop\Proposal Working\My Proposal\sound\adminlogin.wav");
                                                    main m = new main();
                                                    m.Show();
                                                    m.Focus();
                                                    m.label2.Text = "ADMIN";
                                                //  y.Play();
                                                    MessageBox.Show("You are logged in as '" + utype + "'!");
                                                    this.Hide();
                                                }
                                                else if (utype=="Chef")
                                                {
                                                   // SoundPlayer y = new SoundPlayer(@"C:\Users\Manoj\Desktop\Proposal Working\My Proposal\sound\cheflogin.wav");
                                                    kitchenorder k = new kitchenorder();
                                                    k.Show();
                                                    k.Focus();
                                                    k.label1.Text = "CHEF";
                                                    k.btndispose.Visible = false;
                            k.labellogout.Visible = true;
                                                  //  y.Play();
                                                    MessageBox.Show("You are logged in as '" + utype + "'!");
                                                    this.Hide();
                                                }
                                            }
                                            else
                                            {
                                                SoundPlayer z = new SoundPlayer(@"C:\Users\Manoj\Desktop\Proposal Working\My Proposal\sound\passwordunmatched.wav");
                                                z.Play();
                                                MessageBox.Show("Username & Password Unmatched!!");
                                                textBox1.Text = "";
                                                textBox2.Text = "";

                                            }
                                            y.con.Close();
                                            }
                            else
                            MessageBox.Show("Incomplete Information");
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                createinitialadmin a = new createinitialadmin();
                a.ShowDialog();
            }
        }
    
      private void btnreset_click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

       

        private void LOGIN_Load(object sender, EventArgs e)
        {
            
            if (y.con.State == ConnectionState.Closed)
                y.con.Open();
            SqlCommand cmd1 = y.con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * from Connect";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                createinitialadmin a = new createinitialadmin();
                a.ShowDialog();
            }
           // x.Play();

        }

        private void forgotpw_MouseHover(object sender, EventArgs e)
        {
            forgotpw.ForeColor = Color.IndianRed;
        }

        private void forgotpw_MouseLeave(object sender, EventArgs e)
        {
            forgotpw.ForeColor = Color.FromArgb(219, 197, 185);
        }

        private void forgotpw_Click(object sender, EventArgs e)
        {
            pwforgot f = new pwforgot();
            f.ShowDialog();
        }

        private void shpw_Click(object sender, EventArgs e)
        {
            if (shpw.Text=="Show")
                {
                textBox2.UseSystemPasswordChar = false;
                shpw.Text = "Hide";
                }
            else
                {
                textBox2.UseSystemPasswordChar = true;
                shpw.Text = "Show";
                }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
