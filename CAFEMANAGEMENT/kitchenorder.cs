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
    public partial class kitchenorder : Form
    {
        public kitchenorder()
        {
            InitializeComponent();
        }
        sqlcon x= new sqlcon();
        public void getPendingOrders(DataGridView gv, DataGridViewColumn orderIDGV, DataGridViewColumn statusGV, DataGridViewColumn ordertypegv, DataGridViewColumn floorgv, DataGridViewColumn tablegv)
        {
            try
            {
                if (x.con.State==ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("st_getOrders", x.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderIDGV.DataPropertyName = dt.Columns["Order ID"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                ordertypegv.DataPropertyName = dt.Columns["Order Type"].ToString();
                floorgv.DataPropertyName = dt.Columns["Floor"].ToString();
                tablegv.DataPropertyName = dt.Columns["Table"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                
                gv.DataSource = dt;
                gv.RowHeadersVisible = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }
        public void getPendingOrderDetails(Int64 orderID, DataGridView gv, DataGridViewColumn proGV, DataGridViewColumn quantityGV)
        {
            try
            {
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("st_getOrderDetails", x.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proGV.DataPropertyName = dt.Columns["ITEM"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                gv.DataSource = dt;
                gv.RowHeadersVisible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void labellogout_Click(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            l.Show();
            l.Focus();
            this.Close();
            this.Dispose();
        }
        public void updateOrderStatus(Int64 orderID, string STATUS)
        {
            try
            {
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("st_UpdateOrderStatus", x.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status", STATUS);
                cmd.Parameters.AddWithValue("@orderid", orderID);
                int res = cmd.ExecuteNonQuery();
                x.con.Close();
                if (res > 0)
                { MessageBox.Show("Successfully Servered The Order");}
                else
                    MessageBox.Show("Unabled to Serve the Order");
            }
            catch (Exception)
            {
                MessageBox.Show("Technical Error");
            }
        }

        private void kitchenorder_Load(object sender, EventArgs e)
        {
            dgvpendingorders.AutoGenerateColumns = false;
            dgvorderdetails.AutoGenerateColumns = false;
            getPendingOrders(dgvpendingorders, orderIDGV, statusGV, ordertypegv, floorgv, tablegv);
        }
        Int64 orderID;
        private void dgvpendingorders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1 && e.ColumnIndex!=-1)
            {
                DataGridViewRow row = dgvpendingorders.Rows[e.RowIndex];
                orderID = Convert.ToInt64(row.Cells["orderIDGV"].Value.ToString());
                getPendingOrderDetails(orderID, dgvorderdetails,productGV, QuantityGV);
                if (dgvpendingorders[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                {
                    DialogResult dr = MessageBox.Show("Are you sure  the order is served?", "Serve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updateOrderStatus(orderID, "Served");
                        getPendingOrders(dgvpendingorders, orderIDGV, statusGV, ordertypegv, floorgv, tablegv);
                        dgvorderdetails.DataSource = null;
                        
                    }
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void btndispose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
