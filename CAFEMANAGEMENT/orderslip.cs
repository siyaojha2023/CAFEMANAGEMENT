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
    public partial class orderslip : Form
    {
        public orderslip()
        {
            InitializeComponent();
        }
        sqlcon x = new sqlcon();
        public static int i = 0;

        private void btnbillingexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void clear()
        {

            txtitem.Text = "";
            txtquantity.Text = "";
        }
        private void btnaddorder_Click(object sender, EventArgs e)
        {
            i = i + 1;
            dgvslip.Rows.Add(i, txtitem.Text, txtquantity.Text);
            clear();
        }
        string cafename;
        string cafeaddress;
        public void fetchdetail()
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("select * from aboutcafe where id='1'", x.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cafename = dt.Rows[0]["cafename"].ToString();
                cafeaddress = dt.Rows[0]["cafeaddress"].ToString();
            }
            x.con.Close();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            fetchdetail();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 180, 90);
            Font font1 = new Font("Arial", 5, FontStyle.Bold, GraphicsUnit.Point);
            Font font2 = new Font("Segoe UI", 3, FontStyle.Bold, GraphicsUnit.Point);
            Font font3 = new Font("Agency FB", 3, FontStyle.Regular, GraphicsUnit.Point);
            Rectangle rect1 = new Rectangle(2, 2, 175, 85);
            StringFormat centerformat = new StringFormat();
            centerformat.Alignment = StringAlignment.Center;
            StringFormat leftformat = new StringFormat();
            leftformat.Alignment = StringAlignment.Near;
            StringFormat rightformat = new StringFormat();
            rightformat.Alignment = StringAlignment.Far;


            e.Graphics.DrawString(cafename, font1, Brushes.Blue, rect1, centerformat);
            e.Graphics.DrawString(Environment.NewLine + cafeaddress, font2, Brushes.Red, rect1, centerformat);
            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + "Date:" + DateTime.Now, font3, Brushes.Black, rect1, leftformat);
            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + "Supplier:"+txtsupplier.Text, font3, Brushes.Black, rect1, rightformat);
            Pen blackPen = new Pen(Color.Black, 0.5f);
            PointF point1 = new PointF(2.0F, 18.0F);
            PointF point2 = new PointF(177.0F, 18.0F);
             e.Graphics.DrawLine(blackPen, point1, point2);
            e.Graphics.DrawString("                         S. No." + "                                                   Item" + "                                                     Quantity", font3, Brushes.Black, 0, 18);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.5f), new PointF(2.0F, 24.0F), new PointF(177.0F, 24.0F));

            int i = 0;
            int x = 20, y = 25, z = 25;
            foreach (DataGridViewRow row in dgvslip.Rows)
            {

                e.Graphics.DrawString(Convert.ToString((i + 1)), font3, Brushes.Black, x+5, y);
                e.Graphics.DrawString(row.Cells["itemGV"].Value.ToString(), font3, Brushes.Black, x + 50, y);
                e.Graphics.DrawString(row.Cells["quantityGV"].Value.ToString(), font3, Brushes.Black, x + 107, y);


                z += 6;
                y += 6;

                i += 1;
            }


        }

        private void btngenerateslip_Click(object sender, EventArgs e)
        {
            dgvslip.DataSource = null;
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Generate Slip?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {

                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 180, 90);
                if (panel1.Controls.Contains(prtx))
                { }
                else
                    panel1.Controls.Add(prtx);
                prtx.Dock = DockStyle.Fill;
                prtx.Document = printDocument1;
                printpreviewpanel.Controls.Add(prtx);
                prtx.Show();

            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }
    }
}
