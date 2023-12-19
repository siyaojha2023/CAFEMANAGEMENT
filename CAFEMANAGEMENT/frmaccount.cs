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
    public partial class frmaccount : Form
    {
        public frmaccount()
        {
            InitializeComponent();
            
        }
        sqlcon x = new sqlcon();

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void loadsales(DateTimePicker dtp)
        {
            if (x.con.State == ConnectionState.Closed)
                x.con.Open();
            SqlCommand cnd = new SqlCommand("Select sum(total) as 'SUM'  from tblsales where date='"+dtp.Text.ToString()+"'", x.con);
            SqlDataAdapter da1 = new SqlDataAdapter(cnd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            txttotalsale.Text = dt1.Rows[0]["SUM"].ToString();
            SqlCommand cmd = new SqlCommand("select amount_paid as 'Amount Paid', amount_return as 'Amount Returned', total as 'Total' from tblsales where date='"+dtp.Text.ToString()+"'", x.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dgvsales.Rows.Clear();
            int i = 0;
            while (dr.Read())
                {
                i += 1;
                dgvsales.Rows.Add(i, dr["Amount Paid"], dr["Amount Returned"], dr["Total"]);
            }
            dr.Close();


        }
        private void frmaccount_Load(object sender, EventArgs e)
        {
            loadsales(datetimepicker);
        }

        private void datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            loadsales(datetimepicker);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
