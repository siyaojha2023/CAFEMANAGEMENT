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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        if (pictureBox2.Width==2)
            {
                panel1.Visible = true;
                pictureBox2.Visible = true;
                label1.Visible = true;
            }
            pictureBox2.Width += 15;
            if (pictureBox2.Width >= 795)
            {
                LOGIN l = new LOGIN();
                l.Show();
                this.Hide();
                timer1.Stop();
                
            }
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
