namespace CafeManagement
{
    partial class frmorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnorderexit = new System.Windows.Forms.PictureBox();
            this.btnplaceorder = new System.Windows.Forms.Button();
            this.btnfloorexit = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtcstname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtordertype = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcustaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfloor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttablenumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.dgvcart = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.itemIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labeltotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnorderexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfloorexit)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnorderexit);
            this.panel1.Controls.Add(this.btnplaceorder);
            this.panel1.Controls.Add(this.btnfloorexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 674);
            this.panel1.TabIndex = 24;
            // 
            // btnorderexit
            // 
            this.btnorderexit.BackColor = System.Drawing.Color.Transparent;
            this.btnorderexit.Image = ((System.Drawing.Image)(resources.GetObject("btnorderexit.Image")));
            this.btnorderexit.Location = new System.Drawing.Point(12, 12);
            this.btnorderexit.Name = "btnorderexit";
            this.btnorderexit.Size = new System.Drawing.Size(26, 26);
            this.btnorderexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnorderexit.TabIndex = 11;
            this.btnorderexit.TabStop = false;
            this.btnorderexit.Click += new System.EventHandler(this.btnorderexit_Click);
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.Enabled = false;
            this.btnplaceorder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnplaceorder.Location = new System.Drawing.Point(21, 359);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.Size = new System.Drawing.Size(129, 58);
            this.btnplaceorder.TabIndex = 9;
            this.btnplaceorder.Text = "Place Order";
            this.btnplaceorder.UseVisualStyleBackColor = true;
            this.btnplaceorder.Click += new System.EventHandler(this.btnplaceorder_Click);
            // 
            // btnfloorexit
            // 
            this.btnfloorexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfloorexit.BackColor = System.Drawing.Color.Transparent;
            this.btnfloorexit.Image = ((System.Drawing.Image)(resources.GetObject("btnfloorexit.Image")));
            this.btnfloorexit.Location = new System.Drawing.Point(-28, 5);
            this.btnfloorexit.Name = "btnfloorexit";
            this.btnfloorexit.Size = new System.Drawing.Size(26, 26);
            this.btnfloorexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnfloorexit.TabIndex = 5;
            this.btnfloorexit.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Customer Mobile No.";
            this.label9.Visible = false;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(23, 56);
            this.txtcontact.MaxLength = 15;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(188, 20);
            this.txtcontact.TabIndex = 31;
            this.txtcontact.Visible = false;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            // 
            // txtcstname
            // 
            this.txtcstname.Location = new System.Drawing.Point(23, 95);
            this.txtcstname.Name = "txtcstname";
            this.txtcstname.Size = new System.Drawing.Size(188, 20);
            this.txtcstname.TabIndex = 31;
            this.txtcstname.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Customer Name";
            this.label11.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 60);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLACE ORDERS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnaddtocart);
            this.groupBox1.Location = new System.Drawing.Point(191, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 502);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Order";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtordertype);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.txtcontact);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.txtcstname);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.txtcustaddress);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.txtfloor);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.txttablenumber);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtcategory);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.txtitem);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtprice);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtqty);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 422);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Order Type";
            // 
            // txtordertype
            // 
            this.txtordertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtordertype.FormattingEnabled = true;
            this.txtordertype.Items.AddRange(new object[] {
            "Dine-In",
            "Take-Away",
            "Home-Delivery"});
            this.txtordertype.Location = new System.Drawing.Point(23, 16);
            this.txtordertype.Name = "txtordertype";
            this.txtordertype.Size = new System.Drawing.Size(188, 21);
            this.txtordertype.TabIndex = 33;
            this.txtordertype.SelectedIndexChanged += new System.EventHandler(this.txtordertype_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Customer Address";
            this.label12.Visible = false;
            // 
            // txtcustaddress
            // 
            this.txtcustaddress.Location = new System.Drawing.Point(23, 134);
            this.txtcustaddress.Name = "txtcustaddress";
            this.txtcustaddress.Size = new System.Drawing.Size(188, 20);
            this.txtcustaddress.TabIndex = 31;
            this.txtcustaddress.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Floor";
            // 
            // txtfloor
            // 
            this.txtfloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfloor.FormattingEnabled = true;
            this.txtfloor.Location = new System.Drawing.Point(23, 173);
            this.txtfloor.Name = "txtfloor";
            this.txtfloor.Size = new System.Drawing.Size(188, 21);
            this.txtfloor.TabIndex = 33;
            this.txtfloor.SelectedIndexChanged += new System.EventHandler(this.txtfloor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Table";
            // 
            // txttablenumber
            // 
            this.txttablenumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttablenumber.FormattingEnabled = true;
            this.txttablenumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.txttablenumber.Location = new System.Drawing.Point(23, 213);
            this.txttablenumber.Name = "txttablenumber";
            this.txttablenumber.Size = new System.Drawing.Size(188, 21);
            this.txttablenumber.TabIndex = 33;
            this.txttablenumber.SelectedIndexChanged += new System.EventHandler(this.txttablenumber_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Select Category";
            // 
            // txtcategory
            // 
            this.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.txtcategory.Location = new System.Drawing.Point(23, 253);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(188, 21);
            this.txtcategory.TabIndex = 33;
            this.txtcategory.SelectedIndexChanged += new System.EventHandler(this.txtcategory_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Select Item";
            // 
            // txtitem
            // 
            this.txtitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtitem.FormattingEnabled = true;
            this.txtitem.Location = new System.Drawing.Point(23, 293);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(188, 21);
            this.txtitem.TabIndex = 33;
            this.txtitem.SelectedIndexChanged += new System.EventHandler(this.txtitem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(23, 333);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(188, 20);
            this.txtprice.TabIndex = 31;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quantity";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(23, 372);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(188, 20);
            this.txtqty.TabIndex = 31;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnaddtocart.Location = new System.Drawing.Point(71, 467);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(131, 23);
            this.btnaddtocart.TabIndex = 34;
            this.btnaddtocart.Text = "Add To Cart";
            this.btnaddtocart.UseVisualStyleBackColor = false;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // dgvcart
            // 
            this.dgvcart.AllowUserToAddRows = false;
            this.dgvcart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.dgvcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.itemgv,
            this.priceGV,
            this.quantityGV,
            this.Column7,
            this.Column8,
            this.Column9,
            this.deleteGV,
            this.itemIDGV});
            this.dgvcart.Location = new System.Drawing.Point(6, 19);
            this.dgvcart.Name = "dgvcart";
            this.dgvcart.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcart.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvcart.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.dgvcart.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvcart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcart.Size = new System.Drawing.Size(798, 422);
            this.dgvcart.TabIndex = 39;
            this.dgvcart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcart_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // itemgv
            // 
            this.itemgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemgv.HeaderText = "Item ";
            this.itemgv.Name = "itemgv";
            this.itemgv.ReadOnly = true;
            // 
            // priceGV
            // 
            this.priceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Order Type";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Floor";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Table";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteGV.Text = "Remove";
            this.deleteGV.UseColumnTextForButtonValue = true;
            this.deleteGV.Width = 62;
            // 
            // itemIDGV
            // 
            this.itemIDGV.HeaderText = "ITEMID";
            this.itemIDGV.Name = "itemIDGV";
            this.itemIDGV.ReadOnly = true;
            this.itemIDGV.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labeltotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvcart);
            this.groupBox2.Location = new System.Drawing.Point(481, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 502);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.labeltotal.Location = new System.Drawing.Point(213, 462);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(22, 26);
            this.labeltotal.TabIndex = 40;
            this.labeltotal.Text = "0";
            this.labeltotal.TextChanged += new System.EventHandler(this.labeltotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(128, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // frmorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1309, 674);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmorder";
            this.Text = "frmorder";
            this.Load += new System.EventHandler(this.frmorder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnorderexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfloorexit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnplaceorder;
        private System.Windows.Forms.PictureBox btnfloorexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DataGridView dgvcart;
        private System.Windows.Forms.ComboBox txttablenumber;
        private System.Windows.Forms.ComboBox txtfloor;
        private System.Windows.Forms.ComboBox txtordertype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.PictureBox btnorderexit;
        private System.Windows.Forms.ComboBox txtitem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcstname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcustaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDGV;
        public System.Windows.Forms.Label label13;
    }
}