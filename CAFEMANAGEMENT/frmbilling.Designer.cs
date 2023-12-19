namespace CafeManagement
{
    partial class frmbilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbilling));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtamtreturned = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtamountpaid = new System.Windows.Forms.TextBox();
            this.lblnettotal = new System.Windows.Forms.TextBox();
            this.lblserviceamount = new System.Windows.Forms.TextBox();
            this.labeltotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbltaxpercent = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtordertype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfloor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttablenumber = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcustomername = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkinclu = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btngeneratebill = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbillingexit = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prtx = new System.Windows.Forms.PrintPreviewControl();
            this.printpreviewpanel = new System.Windows.Forms.Panel();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbillingexit)).BeginInit();
            this.panel2.SuspendLayout();
            this.printpreviewpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.datetimepicker);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtamtreturned);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtamountpaid);
            this.panel1.Controls.Add(this.lblnettotal);
            this.panel1.Controls.Add(this.lblserviceamount);
            this.panel1.Controls.Add(this.labeltotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgvbill);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btngeneratebill);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnbillingexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 751);
            this.panel1.TabIndex = 25;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // datetimepicker
            // 
            this.datetimepicker.Location = new System.Drawing.Point(174, 700);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.datetimepicker.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(243, 610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Amount Returned:";
            // 
            // txtamtreturned
            // 
            this.txtamtreturned.Location = new System.Drawing.Point(396, 612);
            this.txtamtreturned.Name = "txtamtreturned";
            this.txtamtreturned.ReadOnly = true;
            this.txtamtreturned.Size = new System.Drawing.Size(87, 20);
            this.txtamtreturned.TabIndex = 44;
            this.txtamtreturned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(288, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Amout Paid:";
            // 
            // txtamountpaid
            // 
            this.txtamountpaid.Location = new System.Drawing.Point(396, 580);
            this.txtamountpaid.Name = "txtamountpaid";
            this.txtamountpaid.Size = new System.Drawing.Size(87, 20);
            this.txtamountpaid.TabIndex = 44;
            this.txtamountpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtamountpaid.TextChanged += new System.EventHandler(this.txtamountpaid_TextChanged);
            // 
            // lblnettotal
            // 
            this.lblnettotal.Location = new System.Drawing.Point(396, 547);
            this.lblnettotal.Name = "lblnettotal";
            this.lblnettotal.ReadOnly = true;
            this.lblnettotal.Size = new System.Drawing.Size(87, 20);
            this.lblnettotal.TabIndex = 43;
            this.lblnettotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblserviceamount
            // 
            this.lblserviceamount.Location = new System.Drawing.Point(396, 518);
            this.lblserviceamount.Name = "lblserviceamount";
            this.lblserviceamount.ReadOnly = true;
            this.lblserviceamount.Size = new System.Drawing.Size(87, 20);
            this.lblserviceamount.TabIndex = 43;
            this.lblserviceamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labeltotal
            // 
            this.labeltotal.Location = new System.Drawing.Point(396, 488);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.ReadOnly = true;
            this.labeltotal.Size = new System.Drawing.Size(87, 20);
            this.labeltotal.TabIndex = 43;
            this.labeltotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(308, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Net Total:";
            // 
            // dgvbill
            // 
            this.dgvbill.AllowUserToAddRows = false;
            this.dgvbill.AllowUserToDeleteRows = false;
            this.dgvbill.AllowUserToResizeColumns = false;
            this.dgvbill.AllowUserToResizeRows = false;
            this.dgvbill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.itemGV,
            this.quantityGV,
            this.amountGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbill.Location = new System.Drawing.Point(28, 325);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.RowHeadersVisible = false;
            this.dgvbill.Size = new System.Drawing.Size(470, 142);
            this.dgvbill.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // itemGV
            // 
            this.itemGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemGV.HeaderText = "Item";
            this.itemGV.Name = "itemGV";
            this.itemGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            this.quantityGV.Width = 71;
            // 
            // amountGV
            // 
            this.amountGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            this.amountGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.amountGV.HeaderText = "Amount";
            this.amountGV.Name = "amountGV";
            this.amountGV.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lbltaxpercent);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkinclu);
            this.groupBox1.Location = new System.Drawing.Point(28, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 253);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fetch the Order";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(341, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 13);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Update SC";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbltaxpercent
            // 
            this.lbltaxpercent.Location = new System.Drawing.Point(165, 15);
            this.lbltaxpercent.MaxLength = 2;
            this.lbltaxpercent.Name = "lbltaxpercent";
            this.lbltaxpercent.ReadOnly = true;
            this.lbltaxpercent.Size = new System.Drawing.Size(44, 20);
            this.lbltaxpercent.TabIndex = 0;
            this.lbltaxpercent.Text = "0";
            this.lbltaxpercent.DoubleClick += new System.EventHandler(this.lbltaxpercent_DoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtordertype);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtfloor);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txttablenumber);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.txtcustomername);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtorderid);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 185);
            this.flowLayoutPanel1.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Order Type";
            // 
            // txtordertype
            // 
            this.txtordertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtordertype.FormattingEnabled = true;
            this.txtordertype.Items.AddRange(new object[] {
            "Dine-In",
            "Take Away",
            "Home Deliver"});
            this.txtordertype.Location = new System.Drawing.Point(3, 23);
            this.txtordertype.Name = "txtordertype";
            this.txtordertype.Size = new System.Drawing.Size(284, 21);
            this.txtordertype.TabIndex = 12;
            this.txtordertype.SelectedIndexChanged += new System.EventHandler(this.txtordertype_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Floor";
            // 
            // txtfloor
            // 
            this.txtfloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfloor.FormattingEnabled = true;
            this.txtfloor.Location = new System.Drawing.Point(3, 70);
            this.txtfloor.Name = "txtfloor";
            this.txtfloor.Size = new System.Drawing.Size(284, 21);
            this.txtfloor.TabIndex = 12;
            this.txtfloor.SelectedIndexChanged += new System.EventHandler(this.txtfloor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Table";
            // 
            // txttablenumber
            // 
            this.txttablenumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttablenumber.FormattingEnabled = true;
            this.txttablenumber.Location = new System.Drawing.Point(3, 117);
            this.txttablenumber.Name = "txttablenumber";
            this.txttablenumber.Size = new System.Drawing.Size(284, 21);
            this.txttablenumber.TabIndex = 12;
            this.txttablenumber.SelectedIndexChanged += new System.EventHandler(this.txttablenumber_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(3, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Customer Mobile";
            this.label9.Visible = false;
            // 
            // txtcustomername
            // 
            this.txtcustomername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcustomername.FormattingEnabled = true;
            this.txtcustomername.Location = new System.Drawing.Point(3, 164);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(284, 21);
            this.txtcustomername.TabIndex = 12;
            this.txtcustomername.Visible = false;
            this.txtcustomername.SelectedIndexChanged += new System.EventHandler(this.txtcustomername_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(3, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Order ID";
            // 
            // txtorderid
            // 
            this.txtorderid.Location = new System.Drawing.Point(3, 211);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(284, 20);
            this.txtorderid.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Service Charge(%)";
            // 
            // chkinclu
            // 
            this.chkinclu.AutoSize = true;
            this.chkinclu.Location = new System.Drawing.Point(219, 18);
            this.chkinclu.Name = "chkinclu";
            this.chkinclu.Size = new System.Drawing.Size(40, 17);
            this.chkinclu.TabIndex = 1;
            this.chkinclu.Text = "SC";
            this.chkinclu.UseVisualStyleBackColor = true;
            this.chkinclu.CheckedChanged += new System.EventHandler(this.chkinclu_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(25, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Details:";
            // 
            // btngeneratebill
            // 
            this.btngeneratebill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngeneratebill.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btngeneratebill.Location = new System.Drawing.Point(156, 653);
            this.btngeneratebill.Name = "btngeneratebill";
            this.btngeneratebill.Size = new System.Drawing.Size(233, 41);
            this.btngeneratebill.TabIndex = 10;
            this.btngeneratebill.Text = "GENERATE BILL";
            this.btngeneratebill.UseVisualStyleBackColor = false;
            this.btngeneratebill.Click += new System.EventHandler(this.btngeneratebill_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(264, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Service Charge:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(337, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total:";
            // 
            // btnbillingexit
            // 
            this.btnbillingexit.BackColor = System.Drawing.Color.Transparent;
            this.btnbillingexit.Image = ((System.Drawing.Image)(resources.GetObject("btnbillingexit.Image")));
            this.btnbillingexit.Location = new System.Drawing.Point(12, 9);
            this.btnbillingexit.Name = "btnbillingexit";
            this.btnbillingexit.Size = new System.Drawing.Size(26, 26);
            this.btnbillingexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnbillingexit.TabIndex = 5;
            this.btnbillingexit.TabStop = false;
            this.btnbillingexit.Click += new System.EventHandler(this.btnbillingexit_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILLING SECTION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(517, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 60);
            this.panel2.TabIndex = 26;
            // 
            // prtx
            // 
            this.prtx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.prtx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prtx.Location = new System.Drawing.Point(0, 0);
            this.prtx.Name = "prtx";
            this.prtx.Size = new System.Drawing.Size(776, 691);
            this.prtx.TabIndex = 0;
            // 
            // printpreviewpanel
            // 
            this.printpreviewpanel.Controls.Add(this.btnpreview);
            this.printpreviewpanel.Controls.Add(this.btnprint);
            this.printpreviewpanel.Controls.Add(this.prtx);
            this.printpreviewpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printpreviewpanel.Location = new System.Drawing.Point(517, 60);
            this.printpreviewpanel.Name = "printpreviewpanel";
            this.printpreviewpanel.Size = new System.Drawing.Size(776, 691);
            this.printpreviewpanel.TabIndex = 27;
            // 
            // btnpreview
            // 
            this.btnpreview.Location = new System.Drawing.Point(451, 33);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(169, 44);
            this.btnpreview.TabIndex = 1;
            this.btnpreview.Text = "PREVIEW";
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(221, 33);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(173, 44);
            this.btnprint.TabIndex = 1;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // frmbilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1293, 751);
            this.Controls.Add(this.printpreviewpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmbilling";
            this.Text = "frmbilling";
            this.Load += new System.EventHandler(this.frmbilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnbillingexit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.printpreviewpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btngeneratebill;
        private System.Windows.Forms.PictureBox btnbillingexit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txttablenumber;
        private System.Windows.Forms.ComboBox txtfloor;
        private System.Windows.Forms.ComboBox txtordertype;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.TextBox lbltaxpercent;
        private System.Windows.Forms.CheckBox chkinclu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtcustomername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGV;
        private System.Windows.Forms.TextBox lblserviceamount;
        private System.Windows.Forms.TextBox labeltotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lblnettotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtamtreturned;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtamountpaid;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PrintPreviewControl prtx;
        private System.Windows.Forms.Panel printpreviewpanel;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DateTimePicker datetimepicker;
    }
}