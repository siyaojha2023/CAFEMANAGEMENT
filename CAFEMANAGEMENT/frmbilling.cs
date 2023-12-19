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
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace CafeManagement
{
    public partial class frmbilling : Form
    {
        public frmbilling()
        {
            InitializeComponent();
        }
        string fid;
        string tid;
        string cid;
   
        sqlcon x = new sqlcon();
        public void loadfloors()
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            string q = "select distinct f.f_id as [ID], f.f_name as [NAME] from floors f inner join tables t on f.f_id =t.t_floorid inner join orders o on f.f_id =o.o_floorId where o.status='Served'";
            SqlCommand cmd = new SqlCommand(q, x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            txtfloor.Items.Clear();
            while (dr.Read())
            {
                txtfloor.Items.Add(dr["NAME"].ToString());
                txtfloor.DisplayMember = (dr["NAME"].ToString());
                txtfloor.ValueMember = (dr["ID"].ToString());
            }
            dr.Close();
            x.con.Close();
        }
        private void btnbillingexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmbilling_Load(object sender, EventArgs e)
        {
            
            ctrldinein();
            dgvbill.AutoGenerateColumns = false;
            loadfloors();
            txtcustomername.Items.Clear();

           
        }

        private void chkinclu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkinclu.Checked == true)
            {
              
                gettaxvalue(chkinclu);
            }
            else if (chkinclu.Checked==false)
            {
                lbltaxpercent.Text = "0";
            }
            if (txtorderid.Text != "")
            {
                lblserviceamount.Text = (Math.Round((Convert.ToDouble(lbltaxpercent.Text) / 100) * Convert.ToDouble(labeltotal.Text))).ToString();
                if (chkinclu.Checked == true)
                    lblnettotal.Text = Math.Round(Convert.ToDouble(labeltotal.Text) + Convert.ToDouble(lblserviceamount.Text)).ToString();
                else
                    lblnettotal.Text = labeltotal.Text;
                if (txtamountpaid.Text != "")
                    txtamtreturned.Text = Math.Round(Convert.ToDouble(txtamountpaid.Text) - Convert.ToDouble(lblnettotal.Text)).ToString();
                else
                    txtamtreturned.Text = "";
            }
            
        }

       

        private void txtfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            txtorderid.Text = "";
            dgvbill.DataSource = null;
            lblnettotal.Text = null;
            lblserviceamount.Text = null;
            labeltotal.Text = null;
            SqlCommand cnd = new SqlCommand("Select f_id from floors where f_name='" + txtfloor.Text + "' ", x.con);
            SqlDataReader dr = cnd.ExecuteReader();
            while (dr.Read())
            {
                fid = dr[0].ToString();
            }
            dr.Close();
            string q = "select  t.t_number as [NUMBER] from floors f inner join tables t on f.f_id =t.t_floorid inner join orders o on t.t_id=o.o_tableId where f.f_name='" + txtfloor.Text + "' and o.status='Served'";
            SqlCommand cmd = new SqlCommand(q, x.con);
            SqlDataReader drr = cmd.ExecuteReader();
            txttablenumber.Items.Clear();
            while (drr.Read())
            {
                txttablenumber.Items.Add(drr["NUMBER"].ToString());

            }

            drr.Close();
            x.con.Close();
        }
        public void gettaxvalue(CheckBox cb)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("Select top 1 sc_percent from servicechrg", x.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lbltaxpercent.Text = dt.Rows[0]["sc_percent"].ToString();
        }

        private void txttablenumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cnd = new SqlCommand("Select t_id from tables where t_number='" + txttablenumber.SelectedText + "'", x.con);
            SqlDataReader dr = cnd.ExecuteReader();
            while (dr.Read())
            {
                tid = dr[0].ToString();
              
            }
            dr.Close();
            
            getOrder4Bill(Convert.ToInt32(txttablenumber.SelectedItem.ToString()), dgvbill, itemGV, quantityGV, amountGV, txtorderid);
            lblserviceamount.Text = (Math.Round((Convert.ToDouble(lbltaxpercent.Text) / 100) * Convert.ToDouble(labeltotal.Text))).ToString();
            if (chkinclu.Checked == true)
                lblnettotal.Text = Math.Round(Convert.ToDouble(labeltotal.Text) + Convert.ToDouble(lblserviceamount.Text)).ToString();
            else
                lblnettotal.Text = labeltotal.Text;

            x.con.Close();
        }
        public void getOrder4Bill(int tableNUM, DataGridView gv, DataGridViewColumn itemGV, DataGridViewColumn quantGV, DataGridViewColumn amountGV, TextBox orderidtxtbox)
        {
            if (tableNUM != 0)
            {
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("st_getOrderDetailsWRTTable", x.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tablenum", tableNUM);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                itemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                amountGV.DataPropertyName = dt.Columns["Price"].ToString();
                orderidtxtbox.Text = dt.Rows[0]["ID"].ToString();
                labeltotal.Text = Math.Round(Convert.ToDouble(dt.Rows[0]["Total Amount"].ToString()), 0).ToString();
                gv.DataSource = dt;
            }
            else
            {
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("st_getOrderDetailsWRTNumber", x.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num", txtcustomername.SelectedItem.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                itemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                amountGV.DataPropertyName = dt.Columns["Price"].ToString();
                orderidtxtbox.Text = dt.Rows[0]["ID"].ToString();
                labeltotal.Text = Math.Round(Convert.ToDouble(dt.Rows[0]["Total Amount"].ToString()), 0).ToString();
                gv.DataSource = dt;
            }


        }
        public void ctrlelsedinein()
        {
            label9.Visible = true;
            txtcustomername.Visible = true;
            txtcustomername.Text = "";
            label4.Visible = false;
            label5.Visible = false;
            txtfloor.Visible = false;
            txttablenumber.Visible = false;


        }
        public void ctrldinein()
        {
           
            txtordertype.SelectedItem = "Dine-In";
            label9.Visible = false;
            txtcustomername.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            txtfloor.Visible = true;
            txtfloor.SelectedIndex = -1;
            txttablenumber.Visible = true;
            txtfloor.SelectedIndex = -1;
        }
        public void updateOrder(Int64 orderID, double amtPaid, double amtReturned, string status)
        {
            SqlCommand cmd = new SqlCommand("st_updateOrder", x.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderID",orderID);
            cmd.Parameters.AddWithValue("@amtPaid",amtPaid);
            cmd.Parameters.AddWithValue("@amtReturned",amtReturned);
            cmd.Parameters.AddWithValue("@statu",status);
            if (x.con.State == ConnectionState.Closed) x.con.Open();
            cmd.ExecuteNonQuery();
            x.con.Close();
        }
       public void insertsales()
        {
            
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblsales(amount_paid, amount_return, total, date) values('"+txtamountpaid.Text+"', '"+txtamtreturned.Text+"', '"+lblnettotal.Text+"', '"+datetimepicker.Text.ToString()+"')", x.con);
            cmd.ExecuteNonQuery();
            x.con.Close();
        }
       
        private void btngeneratebill_Click(object sender, EventArgs e)
        {
            
            dgvbill.DataSource = null;
            DialogResult dr = MessageBox.Show("Order completed successfully, do wanna generate bill?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                updateOrder(Convert.ToInt64(txtorderid.Text), Convert.ToDouble(txtamountpaid.Text), Convert.ToDouble(txtamtreturned.Text), "Completed");
                insertsales();
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

        private void txtordertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlinitial();
            if (txtordertype.SelectedItem.ToString() == "Dine-In")
            {
                ctrldinein();
                loadfloors();
                
            }
            else
            {
                txtcustomername.Items.Clear();
                ctrlelsedinein();
                loadcustomernumbers();

            }
        }
        public void loadcustomernumbers()
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            string q = "select  c.c_id as [ID], c.c_name as [NAME], c.c_phone as [NUMBER] from customers c  inner join orders o on c.c_id =o.o_custID where c.c_id<>1 and o.status='Served'";
            SqlCommand cmd = new SqlCommand(q, x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            txtfloor.Items.Clear();
            while (dr.Read())
            {
                txtcustomername.Items.Add(dr["NUMBER"].ToString());
                txtcustomername.DisplayMember = (dr["NUMBER"].ToString());
                txtcustomername.ValueMember = (dr["ID"].ToString());
            }
            dr.Close();
            x.con.Close();
        }
        public void controlinitial()
        {
            dgvbill.DataSource = null;
            labeltotal.Text = "";
            lblserviceamount.Text = "";
            lblnettotal.Text = "";
            txttablenumber.Items.Clear();
            txtamountpaid.Text = "";
            txtamtreturned.Text = "";
            txtorderid.Text = "";
        }
        private void lbltaxpercent_DoubleClick(object sender, EventArgs e)
        {
            lbltaxpercent.Text = "0";
            chkinclu.Checked = false;
            if (txtorderid.Text != "")
            {
                lblserviceamount.Text = (Math.Round((Convert.ToDouble(lbltaxpercent.Text) / 100) * Convert.ToDouble(labeltotal.Text))).ToString();
                if (chkinclu.Checked == true)
                    lblnettotal.Text = Math.Round(Convert.ToDouble(labeltotal.Text) + Convert.ToDouble(lblserviceamount.Text)).ToString();
                else
                    lblnettotal.Text = labeltotal.Text;
                if (txtamountpaid.Text != "")
                    txtamtreturned.Text = Math.Round(Convert.ToDouble(txtamountpaid.Text) - Convert.ToDouble(lblnettotal.Text)).ToString();
                else
                    txtamtreturned.Text = "";
            }
        }

        private void txtcustomername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cnd = new SqlCommand("Select c.c_id, o.o_id from customers c inner join orders o on c.c_id=o.o_custID where c.c_phone='" + txtcustomername.SelectedItem.ToString() + "' and o.Status='Served' ", x.con);
            SqlDataReader dr = cnd.ExecuteReader();
            while (dr.Read())
            {
                cid = dr[0].ToString();
                
                
            }
            dr.Close();

            getOrder4Bill(0, dgvbill, itemGV, quantityGV, amountGV, txtorderid);
            lblserviceamount.Text = (Math.Round((Convert.ToDouble(lbltaxpercent.Text) / 100) * Convert.ToDouble(labeltotal.Text))).ToString();
            if (chkinclu.Checked == true)
                lblnettotal.Text = Math.Round(Convert.ToDouble(labeltotal.Text) + Convert.ToDouble(lblserviceamount.Text)).ToString();
            else
                lblnettotal.Text = labeltotal.Text;

            x.con.Close();
        }

        private void txtamountpaid_TextChanged(object sender, EventArgs e)
        {
            if (txtamountpaid.Text != "")
                txtamtreturned.Text = Math.Round(Convert.ToDouble(txtamountpaid.Text) - Convert.ToDouble(lblnettotal.Text)).ToString();
            else
                txtamtreturned.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltaxpercent.Text = "0";
            chkinclu.Checked = false;
            frmservicecharge t = new frmservicecharge();
            t.BringToFront();
            t.ShowDialog();
            t.StartPosition = FormStartPosition.Manual;
            

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
            e.Graphics.DrawString(Environment.NewLine+cafeaddress, font2, Brushes.Red, rect1,centerformat);
            e.Graphics.DrawString(Environment.NewLine+Environment.NewLine +"Date:"+ DateTime.Now, font3, Brushes.Black, rect1, leftformat);
            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + "Bill No.: 101", font3, Brushes.Black, rect1, rightformat);
            Pen blackPen = new Pen(Color.Black, 0.5f);
            PointF point1 = new PointF(2.0F, 18.0F);
            PointF point2 = new PointF(177.0F, 18.0F);      
            e.Graphics.DrawLine(blackPen, point1, point2);
            e.Graphics.DrawString("                    S. No." + "                                  Item"+"                             Quantity"+"                                 Amount", font3, Brushes.Black, 0, 18);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.5f), new PointF(2.0F,24.0F), new PointF(177.0F,24.0F));

            int i = 0;
            int x = 20, y = 25, z = 25;
            foreach (DataGridViewRow row in dgvbill.Rows)
            {
                
                e.Graphics.DrawString(Convert.ToString((i+1)), font3, Brushes.Black, x, y);
                e.Graphics.DrawString(row.Cells["itemGV"].Value.ToString(), font3, Brushes.Black, x+33, y);
                e.Graphics.DrawString(row.Cells["quantityGV"].Value.ToString(), font3, Brushes.Black, x + 69, y);
                e.Graphics.DrawString(Math.Round(Convert.ToDouble(row.Cells["amountGV"].Value.ToString())).ToString(), font3, Brushes.Black, x + 103, y);


                z += 6;
                y += 6;
                
                i += 1;
            }
            e.Graphics.DrawLine(new Pen(Color.Black, 0.5f), new PointF(2.0F, z), new PointF(177.0F, z));
            Pen p = new Pen(Color.Black,0.5f);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            e.Graphics.DrawString("Total:", font3, Brushes.Black, x + 95, z+2);
            e.Graphics.DrawString(labeltotal.Text, font3, Brushes.Black, x + 103, z+2);
            e.Graphics.DrawString("S.C.:", font3, Brushes.Black, x + 97, z + 7);
            e.Graphics.DrawString(lblserviceamount.Text, font3, Brushes.Black, x + 103, z + 7);
            e.Graphics.DrawLine(p, new PointF(2.0F, z+12), new PointF(177.0F, z+12));
            e.Graphics.DrawString("Net-Total:", font3, Brushes.Black, x + 89, z + 12);
            e.Graphics.DrawString(lblnettotal.Text, font3, Brushes.Black, x + 103, z + 12);
            e.Graphics.DrawString("Amount Paid:", font3, Brushes.Black, x + 85, z + 17);
            e.Graphics.DrawString(txtamountpaid.Text, font3, Brushes.Black, x + 103, z + 17);
            e.Graphics.DrawLine(p, new PointF(2.0F, z + 22), new PointF(177.0F, z + 22));
            e.Graphics.DrawString("Amount Returned:", font3, Brushes.Black, x + 78, z + 22);
            e.Graphics.DrawString(txtamtreturned.Text, font3, Brushes.Black, x + 103, z + 22);
            e.Graphics.DrawRectangle(Pens.Black, rect1);
            
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();

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

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            controlinitial();
                 ctrldinein();
            loadfloors();
            lbltaxpercent.Text = "0";
            chkinclu.Checked = false;

        }
    }
}
