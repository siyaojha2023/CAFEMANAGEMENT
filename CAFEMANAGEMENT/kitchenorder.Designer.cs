namespace CafeManagement
{
    partial class kitchenorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitchenorder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labellogout = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvpendingorders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertypegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvorderdetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndispose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpendingorders)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndispose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.btndispose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labellogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.welcome);
            this.panel2.Location = new System.Drawing.Point(80, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 28);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TALITHA", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("TALITHA", 12F);
            this.welcome.ForeColor = System.Drawing.Color.Black;
            this.welcome.Location = new System.Drawing.Point(6, 6);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(107, 17);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "WELCOME,";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(520, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "KITCHEN SECTION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labellogout
            // 
            this.labellogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labellogout.AutoSize = true;
            this.labellogout.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogout.ForeColor = System.Drawing.Color.White;
            this.labellogout.Location = new System.Drawing.Point(1053, 9);
            this.labellogout.Name = "labellogout";
            this.labellogout.Size = new System.Drawing.Size(93, 33);
            this.labellogout.TabIndex = 0;
            this.labellogout.Text = "Log Out";
            this.labellogout.Visible = false;
            this.labellogout.Click += new System.EventHandler(this.labellogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.groupBox1.Controls.Add(this.dgvpendingorders);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 688);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pending Orders";
            // 
            // dgvpendingorders
            // 
            this.dgvpendingorders.AllowUserToAddRows = false;
            this.dgvpendingorders.AllowUserToDeleteRows = false;
            this.dgvpendingorders.AllowUserToResizeRows = false;
            this.dgvpendingorders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpendingorders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpendingorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpendingorders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.orderIDGV,
            this.ordertypegv,
            this.floorgv,
            this.tablegv,
            this.statusGV,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpendingorders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpendingorders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpendingorders.Location = new System.Drawing.Point(3, 16);
            this.dgvpendingorders.Name = "dgvpendingorders";
            this.dgvpendingorders.RowHeadersVisible = false;
            this.dgvpendingorders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpendingorders.Size = new System.Drawing.Size(602, 669);
            this.dgvpendingorders.TabIndex = 16;
            this.dgvpendingorders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpendingorders_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // orderIDGV
            // 
            this.orderIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderIDGV.HeaderText = "Order ID";
            this.orderIDGV.Name = "orderIDGV";
            this.orderIDGV.ReadOnly = true;
            // 
            // ordertypegv
            // 
            this.ordertypegv.HeaderText = "Type";
            this.ordertypegv.Name = "ordertypegv";
            this.ordertypegv.ReadOnly = true;
            // 
            // floorgv
            // 
            this.floorgv.HeaderText = "Floor";
            this.floorgv.Name = "floorgv";
            this.floorgv.ReadOnly = true;
            // 
            // tablegv
            // 
            this.tablegv.HeaderText = "Table";
            this.tablegv.Name = "tablegv";
            this.tablegv.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            this.statusGV.Width = 62;
            // 
            // Action
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Action.DefaultCellStyle = dataGridViewCellStyle2;
            this.Action.HeaderText = "Served";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Done";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.groupBox2.Controls.Add(this.dgvorderdetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(608, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 688);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dgvorderdetails
            // 
            this.dgvorderdetails.AllowUserToAddRows = false;
            this.dgvorderdetails.AllowUserToDeleteRows = false;
            this.dgvorderdetails.AllowUserToResizeColumns = false;
            this.dgvorderdetails.AllowUserToResizeRows = false;
            this.dgvorderdetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorderdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvorderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.productGV,
            this.QuantityGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvorderdetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvorderdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvorderdetails.Location = new System.Drawing.Point(3, 16);
            this.dgvorderdetails.Name = "dgvorderdetails";
            this.dgvorderdetails.RowHeadersVisible = false;
            this.dgvorderdetails.Size = new System.Drawing.Size(538, 669);
            this.dgvorderdetails.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // productGV
            // 
            this.productGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productGV.HeaderText = "Item";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // QuantityGV
            // 
            this.QuantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // btndispose
            // 
            this.btndispose.BackColor = System.Drawing.Color.Transparent;
            this.btndispose.Image = ((System.Drawing.Image)(resources.GetObject("btndispose.Image")));
            this.btndispose.Location = new System.Drawing.Point(22, 14);
            this.btndispose.Name = "btndispose";
            this.btndispose.Size = new System.Drawing.Size(26, 26);
            this.btndispose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btndispose.TabIndex = 8;
            this.btndispose.TabStop = false;
            this.btndispose.Click += new System.EventHandler(this.btndispose_Click);
            // 
            // kitchenorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeManagement.Properties.Resources.backgroundcafe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 739);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitchenorder";
            this.Text = "kitchenorder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kitchenorder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpendingorders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndispose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvpendingorders;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvorderdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertypegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        public System.Windows.Forms.Label labellogout;
        public System.Windows.Forms.PictureBox btndispose;
    }
}