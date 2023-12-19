using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class main : Form
    {
        private int childFormNumber = 0;

        public main()
        {
            InitializeComponent();
       
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            l.Show();
            l.Focus();
            this.Close();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrole f = new frmrole();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
            f.Focus();
            
            
        }

        private void staffStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstaff f = new frmstaff();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
            f.Focus();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmuser f = new frmuser();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
            f.Focus();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmcat f = new frmcat();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
         }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmenu f = new frmmenu();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void addNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfloor f = new frmfloor();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void viewStocksAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtables f = new frmtables();
            f.MdiParent = this;
           f.Dock = DockStyle.Fill;
            f.Show();
        
        }

        private void customerOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmorder f = new frmorder();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmbilling f = new frmbilling();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitchenorder x = new kitchenorder();
            x.Show();
        }

        private void aboutCafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cafedetail x = new cafedetail();
            x.ShowDialog();
        }

        private void accountHandlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaccount f = new frmaccount();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();

        }

        private void orderSleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderslip f = new orderslip();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();

        }
    }
}
