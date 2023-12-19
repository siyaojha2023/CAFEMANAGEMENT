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
using System.Transactions;

namespace CafeManagement
{
    public partial class frmorder : Form
    {
        public frmorder()
        {
            InitializeComponent();
        }
        public int costumerstate=0;
        string cstid;
        sqlcon x = new sqlcon();
        float totalamount = 0;
        string cid;
        string pid;
        string tid;
        string fid;
        private void btnorderexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadcategory()
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            string q = "select distinct c.cat_id, c.cat_name from category c inner join menu m on c.cat_id =m.m_catID";
            SqlCommand cmd = new SqlCommand(q, x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            txtcategory.Items.Clear();
            while (dr.Read())
            {
                txtcategory.Items.Add(dr["cat_name"].ToString());
                txtcategory.DisplayMember = (dr["cat_name"].ToString());
                txtcategory.ValueMember = (dr["cat_id"].ToString());
            }
            dr.Close();
            x.con.Close();
        }
        public void loadfloors()
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            string q = "select distinct f.f_id as [ID], f.f_name as [NAME] from floors f inner join tables t on f.f_id =t.t_floorid";
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

        private void frmorder_Load(object sender, EventArgs e)
        {
            txtordertype.SelectedIndex = 0;
            loadcategory();
            loadfloors();
        }

        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            if (txtcategory.SelectedIndex != -1)
            {
                SqlCommand cnd = new SqlCommand("Select cat_id from category where cat_name='" + txtcategory.Text + "' ", x.con);
                SqlDataReader dr = cnd.ExecuteReader();
                while (dr.Read())
                {
                    cid = dr[0].ToString();
                }

                dr.Close();

                string q = "select m.m_name as [ITEM] from menu m inner join category c on m.m_catID=c.cat_id where c.cat_name='" + txtcategory.Text + "'";
                SqlCommand cmd = new SqlCommand(q, x.con);
                SqlDataReader drr = cmd.ExecuteReader();
                txtitem.Items.Clear();
                while (drr.Read())
                {
                    txtitem.Items.Add(drr["ITEM"].ToString());
                }
                
                drr.Close();
                x.con.Close();
                txtprice.Text = "";
                txtitem.SelectedIndex = -1;
            }
        }
        public void insertcustomers(string name, string contact, string address)
        {
            //try
            //{
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("st_InsertCustomer", x.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cstname", name);
                cmd.Parameters.AddWithValue("@cstphone", contact);
                cmd.Parameters.AddWithValue("@cstaddress", address);
                cmd.ExecuteNonQuery();
             
            //}          
            //catch (Exception)
            //{
            //    MessageBox.Show("Unable To Insert Customer!");
            //}
        }
        private void txtitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cnd = new SqlCommand("Select m_id from menu where m_name='" + txtitem.Text + "' ", x.con);
            SqlDataReader dr = cnd.ExecuteReader();
            while (dr.Read())
            {
                pid = dr[0].ToString();
            }
            dr.Close();
            string q = "select m.m_price as [PRICE] from menu m inner join category c on m.m_catID=c.cat_id where c.cat_name='" + txtcategory.Text + "' and m.m_name='"+txtitem.Text+"'";
            SqlCommand cmd = new SqlCommand(q, x.con);
            SqlDataReader drr = cmd.ExecuteReader();
             while (drr.Read())
            {

                txtprice.Text=(Math.Round(Convert.ToDouble(drr["PRICE"].ToString()))).ToString();
            }
            drr.Close();
            
            x.con.Close();
            
        }

        private void txtfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cnd = new SqlCommand("Select f_id from floors where f_name='" + txtfloor.Text + "' ",x.con);
            SqlDataReader dr = cnd.ExecuteReader();
            while (dr.Read())
            {
                fid = dr[0].ToString();
            }
            dr.Close();
            string q = "select  t.t_number as [NUMBER] from floors f inner join tables t on f.f_id =t.t_floorid where f.f_name='" + txtfloor.Text + "' order by t.t_number";
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
        int dgvi=0;
        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            bool check = new bool(); check = false;
            
                foreach (DataGridViewRow row in dgvcart.Rows)
                {
                    if (row.Cells[2].Value.ToString() == txtitem.SelectedItem.ToString())
                    {

                        check = true;

                        break;
                    }
                }
                if (check)
                MessageBox.Show("Item already exist.");
            else
                  
            {

                if (txtordertype.SelectedItem.ToString() == "Dine-In")
                {
                    dgvi += 1;
                    dgvcart.Rows.Add(dgvi, txtcategory.SelectedItem.ToString(), txtitem.SelectedItem.ToString(), txtprice.Text, txtqty.Text, txtordertype.SelectedItem.ToString(), txtfloor.SelectedItem.ToString(), txttablenumber.SelectedItem.ToString(),"",pid);
                    totalamount = totalamount + Convert.ToInt32((Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text)).ToString());
                    labeltotal.Text = totalamount.ToString();
                }
                else
                {
                    dgvi += 1;
                    dgvcart.Rows.Add(dgvi, txtcategory.SelectedItem.ToString(), txtitem.SelectedItem.ToString(), txtprice.Text, txtqty.Text, txtordertype.SelectedItem.ToString(), "", "","", pid);
                    totalamount = totalamount + Convert.ToInt32((Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text)).ToString());
                    labeltotal.Text = totalamount.ToString();
                }


            }
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtqty.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtqty.Text = txtqty.Text.Remove(txtqty.Text.Length - 1);
            }
        }
        public  void insertOrder(DateTime date, string custID, string orderType, string floorID, string tableID, float tamount, float amtPaid, float amtReturned, string status)
        {
            SqlCommand cmd;
                sqlcon x = new sqlcon();
                if (x.con.State==ConnectionState.Closed)
                x.con.Open();
            if (txtordertype.Text == "Dine-In")
                cmd = new SqlCommand("Insert into orders(o_date,o_custID,o_orderType,o_floorId, o_tableId, o_totalAmount, o_amountPaid,o_amountReturned,status) values ('" + date + "', '" + custID + "', '" + orderType + "', '" + floorID + "', '" + tableID + "', '" + tamount + "', '" + amtPaid + "', '" + amtReturned + "', '" + status + "') ", x.con);
            else
            {
                cmd = new SqlCommand("Insert into orders(o_date,o_custID,o_orderType,o_floorId, o_tableId, o_totalAmount, o_amountPaid,o_amountReturned,status) values ('" + date + "', '" + cstid + "', '" + orderType + "', @fiid, @tiid, '" + tamount + "', '" + amtPaid + "', '" + amtReturned + "', '" + status + "') ", x.con);
                cmd.Parameters.AddWithValue("@fiid", DBNull.Value);
                cmd.Parameters.AddWithValue("@tiid", DBNull.Value);
            }
            cmd.ExecuteNonQuery();
            x.con.Close();
            
        }
        
        public void lastCustomerID()
        {
            sqlcon x = new sqlcon(); 
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("select top 1 c.c_id from customers c order by c.c_id desc ", x.con);
            cmd.CommandType = CommandType.Text;
    
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
              //  btnplaceorder.Text= dt.Rows[0]["c_id"].ToString(); ;
                cstid = dt.Rows[0]["c_id"].ToString();
              
                MessageBox.Show("Customer Successfully Fetched");

            }




           
                     

           
            
        }
        public static Int64 lastOrderID()
        {
            Int64 orderID = 0;
            try
            {
                
                sqlcon x = new sqlcon();
                if (x.con.State==ConnectionState.Closed)
                    x.con.Open();

                SqlCommand cmd = new SqlCommand("select top 1 o.o_id from orders o order by o.o_id desc", x.con);
                orderID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                x.con.Close();
                
            }
            catch(Exception)
            {
                

            }
            return orderID;
        }
       public void ordertypedinein()
        {
            txtfloor.SelectedIndex = -1;
            txtfloor.Visible = true;
            txttablenumber.SelectedIndex = -1;
            txttablenumber.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            txtcustaddress.Visible = false;
            txtcstname.Visible = false;
            txtitem.Items.Clear();
            txtcontact.Visible = false;

        }
        public void ordertypedtakeaway()
        {
          
            txtfloor.Visible = false;
          
            txttablenumber.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = true;
            txtcontact.Visible = true;
            txtcontact.Text = "";
            label11.Visible = true;
            txtcstname.Visible = true;
            txtcstname.Text = "";
            label12.Visible = true;
            txtcustaddress.Visible = true;
            txtcustaddress.Text = "";
            txtitem.Items.Clear();
            }
        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            if (txtordertype.Text == "Dine-In")
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    // try
                    //{

                    insertOrder(DateTime.Today, "1", txtordertype.Text, fid, tid, Convert.ToSingle(labeltotal.Text), 0, 0, "Pending");
                    Int64 orderID = lastOrderID();

                    sqlcon x = new sqlcon();
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();

                    int res = 0;
                    foreach (DataGridViewRow row in dgvcart.Rows)
                    {

                        SqlCommand cmd = new SqlCommand("Insert into orderDetails(od_orderID,od_proID,od_quan) values (@oid, @proid, @quan)", x.con);
                        cmd.Parameters.AddWithValue("@oid", orderID);
                        cmd.Parameters.AddWithValue("@proid", row.Cells[9].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@quan", row.Cells[4].Value ?? DBNull.Value);
                         int y = cmd.ExecuteNonQuery();
                        if (y > 0)
                        { res += 1; }


                       
                    }
                    if (res > 0)
                    {
                        MessageBox.Show("Order Sent to Chef Successfully.");
                        labeltotal.Text = "0";
                        totalamount = 0; 
                        txtcategory.SelectedIndex = -1;
                        txtprice.Text = "";
                        txtqty.Text = "";
                        txtitem.SelectedIndex = -1;
                        txtfloor.SelectedIndex = -1;
                        txttablenumber.SelectedIndex = -1;
                        txtitem.Items.Clear();
                    }

                    x.con.Close();
                    dgvcart.Rows.Clear();
                    //}
                    sc.Complete();
                }
            }
            else
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    // try
                    //{
                    if (costumerstate == 0)
                    {
                        insertcustomers(txtcstname.Text, txtcontact.Text, txtcustaddress.Text);
                        lastCustomerID();
                        
                    }
                    insertOrder(DateTime.Today, cstid, txtordertype.Text, "","", Convert.ToSingle(labeltotal.Text), 0, 0, "Pending");
                    Int64 orderID = lastOrderID();

                    sqlcon x = new sqlcon();
                    if (x.con.State == ConnectionState.Closed)
                        x.con.Open();

                    int res = 0;
                    foreach (DataGridViewRow row in dgvcart.Rows)
                    {

                        SqlCommand cmd = new SqlCommand("Insert into orderDetails(od_orderID,od_proID,od_quan) values (@oid, @proid, @quan)", x.con);
                        cmd.Parameters.AddWithValue("@oid", orderID);
                        cmd.Parameters.AddWithValue("@proid", row.Cells[9].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@quan", row.Cells[4].Value ?? DBNull.Value);
                        int y = cmd.ExecuteNonQuery();
                        if (y > 0) { res +=1;  }




                        
                    }
                    if (res > 0)
                    {
                        MessageBox.Show("Order Sent to Chef Successfully.");
                        labeltotal.Text = "0";
                        totalamount = 0;
                        txtcategory.SelectedIndex = -1;
                        txtprice.Text = "";
                        txtqty.Text = "";
                        txtitem.SelectedIndex = -1;
                        txtfloor.SelectedIndex = -1;
                        txttablenumber.SelectedIndex = -1;
                    }
                    x.con.Close();
                    //}

                    dgvcart.Rows.Clear();
                    sc.Complete();
                }
            }
                
        
        }
        public bool checktable(int tableID)
        {
            bool state = false;
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cmd = new SqlCommand("st_checkTableBusyFree", x.con);
 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tableID", tableID);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
                state= true;
            else state =false;
            dr.Close();
            return state;
        }
        private void txttablenumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cnd = new SqlCommand("Select t_id from tables where t_number='" + txttablenumber.Text + "' ", x.con);
            SqlDataReader dr = cnd.ExecuteReader();
            while (dr.Read())
            {
                tid = dr[0].ToString();
            }

            dr.Close();

            x.con.Close();
            if (txttablenumber.SelectedIndex != -1)
            {
                
                if (checktable(Convert.ToInt16(tid)))
                    txttablenumber.SelectedIndex = -1;
               
            }
        }

        private void dgvcart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1 && e.ColumnIndex !=-1)
            {
                if (dgvcart.Columns[e.ColumnIndex].Name=="deleteGV")
                {
                    DataGridViewRow row = dgvcart.Rows[e.RowIndex];
                    float prc = Convert.ToSingle(row.Cells["priceGV"].Value.ToString()) * Convert.ToSingle(row.Cells["quantityGV"].Value.ToString());
                    totalamount -= prc;
                    labeltotal.Text = totalamount.ToString();
                    dgvcart.Rows.Remove(row);
                }
            }
        }

        private void txtordertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtordertype.SelectedItem.ToString() == "Dine-In")
            {
                ordertypedinein();
            }
            else
            {
                ordertypedtakeaway();
            }
        }
        
        private void labeltotal_TextChanged(object sender, EventArgs e)
        {
            if (labeltotal.Text=="0")
            {
                btnplaceorder.Enabled = false;
            }
            else
            {
                btnplaceorder.Enabled = true;
            }
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            {
                if (x.con.State == ConnectionState.Closed)
                    x.con.Open();
                SqlCommand cmd = new SqlCommand("st_GetCstWRTNo", x.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", txtcontact.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cstid = dt.Rows[0]["c_id"].ToString();
                    costumerstate = 1;
                    txtcstname.Text = dt.Rows[0]["c_name"].ToString();
                    txtcustaddress.Text = dt.Rows[0]["c_address"].ToString();
                    MessageBox.Show("Customer Successfully Fetched");
    
                }
            }
           
        }

        private void label13_Click(object sender, EventArgs e)
        {
            lastCustomerID();
           
        }
    }
        
    }
