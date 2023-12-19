namespace CafeManagement
{
    partial class frmuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtcafeid = new System.Windows.Forms.TextBox();
            this.btnassignuser = new System.Windows.Forms.Button();
            this.btnremuser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelstaff = new System.Windows.Forms.Panel();
            this.cmbaccesssystem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrolesearch = new System.Windows.Forms.TextBox();
            this.DGVUSER = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVSTAFFF = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelstaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUSER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSTAFFF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtcafeid);
            this.panel1.Controls.Add(this.btnassignuser);
            this.panel1.Controls.Add(this.btnremuser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 750);
            this.panel1.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 352);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(180, 26);
            this.label21.TabIndex = 21;
            this.label21.Text = "Please provide a unique CAFE-ID to \r\nhelp user to reset his password.";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtcafeid
            // 
            this.txtcafeid.Enabled = false;
            this.txtcafeid.Location = new System.Drawing.Point(23, 384);
            this.txtcafeid.MaxLength = 5;
            this.txtcafeid.Name = "txtcafeid";
            this.txtcafeid.Size = new System.Drawing.Size(157, 20);
            this.txtcafeid.TabIndex = 9;
            // 
            // btnassignuser
            // 
            this.btnassignuser.Enabled = false;
            this.btnassignuser.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnassignuser.Location = new System.Drawing.Point(36, 156);
            this.btnassignuser.Name = "btnassignuser";
            this.btnassignuser.Size = new System.Drawing.Size(139, 49);
            this.btnassignuser.TabIndex = 19;
            this.btnassignuser.Text = "Assign User";
            this.btnassignuser.UseVisualStyleBackColor = true;
            this.btnassignuser.Click += new System.EventHandler(this.btnassignuser_Click);
            // 
            // btnremuser
            // 
            this.btnremuser.Enabled = false;
            this.btnremuser.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnremuser.Location = new System.Drawing.Point(36, 248);
            this.btnremuser.Name = "btnremuser";
            this.btnremuser.Size = new System.Drawing.Size(139, 49);
            this.btnremuser.TabIndex = 20;
            this.btnremuser.Text = "Remove User";
            this.btnremuser.UseVisualStyleBackColor = true;
            this.btnremuser.Click += new System.EventHandler(this.btnremuser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 60);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Account Management";
            // 
            // panelstaff
            // 
            this.panelstaff.Controls.Add(this.cmbaccesssystem);
            this.panelstaff.Controls.Add(this.label6);
            this.panelstaff.Controls.Add(this.label5);
            this.panelstaff.Controls.Add(this.label4);
            this.panelstaff.Controls.Add(this.label2);
            this.panelstaff.Controls.Add(this.txtpass);
            this.panelstaff.Controls.Add(this.txtuser);
            this.panelstaff.Controls.Add(this.txtid);
            this.panelstaff.Location = new System.Drawing.Point(220, 66);
            this.panelstaff.Name = "panelstaff";
            this.panelstaff.Size = new System.Drawing.Size(334, 654);
            this.panelstaff.TabIndex = 22;
            // 
            // cmbaccesssystem
            // 
            this.cmbaccesssystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaccesssystem.Enabled = false;
            this.cmbaccesssystem.FormattingEnabled = true;
            this.cmbaccesssystem.Items.AddRange(new object[] {
            "Admin",
            "Chef"});
            this.cmbaccesssystem.Location = new System.Drawing.Point(29, 430);
            this.cmbaccesssystem.Name = "cmbaccesssystem";
            this.cmbaccesssystem.Size = new System.Drawing.Size(73, 21);
            this.cmbaccesssystem.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label6.Location = new System.Drawing.Point(25, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Access System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label5.Location = new System.Drawing.Point(25, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label4.Location = new System.Drawing.Point(25, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Staff-ID";
            // 
            // txtpass
            // 
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(28, 320);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(150, 20);
            this.txtpass.TabIndex = 4;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Enabled = false;
            this.txtuser.Location = new System.Drawing.Point(29, 212);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(136, 20);
            this.txtuser.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(28, 119);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(55, 20);
            this.txtid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(557, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Search Staff";
            // 
            // txtrolesearch
            // 
            this.txtrolesearch.Location = new System.Drawing.Point(631, 85);
            this.txtrolesearch.Name = "txtrolesearch";
            this.txtrolesearch.Size = new System.Drawing.Size(236, 20);
            this.txtrolesearch.TabIndex = 23;
            // 
            // DGVUSER
            // 
            this.DGVUSER.AllowUserToAddRows = false;
            this.DGVUSER.AllowUserToDeleteRows = false;
            this.DGVUSER.AllowUserToResizeColumns = false;
            this.DGVUSER.AllowUserToResizeRows = false;
            this.DGVUSER.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.DGVUSER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUSER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column6,
            this.dataGridViewTextBoxColumn2,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column20});
            this.DGVUSER.Location = new System.Drawing.Point(560, 456);
            this.DGVUSER.Name = "DGVUSER";
            this.DGVUSER.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUSER.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVUSER.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.DGVUSER.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVUSER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUSER.Size = new System.Drawing.Size(800, 264);
            this.DGVUSER.TabIndex = 25;
            this.DGVUSER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUSER_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 39;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "uid";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column22.HeaderText = "Password";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column23.HeaderText = "System Role";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Width = 91;
            // 
            // Column24
            // 
            this.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column24.HeaderText = "Cafe-Id";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "ustaffid";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Role";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Email";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column21.HeaderText = "Contact";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Last Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "First Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "staffid";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // DGVSTAFFF
            // 
            this.DGVSTAFFF.AllowUserToAddRows = false;
            this.DGVSTAFFF.AllowUserToDeleteRows = false;
            this.DGVSTAFFF.AllowUserToResizeColumns = false;
            this.DGVSTAFFF.AllowUserToResizeRows = false;
            this.DGVSTAFFF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.DGVSTAFFF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSTAFFF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column21,
            this.Column11,
            this.Column5});
            this.DGVSTAFFF.Location = new System.Drawing.Point(560, 111);
            this.DGVSTAFFF.Name = "DGVSTAFFF";
            this.DGVSTAFFF.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSTAFFF.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVSTAFFF.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.DGVSTAFFF.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVSTAFFF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSTAFFF.Size = new System.Drawing.Size(800, 269);
            this.DGVSTAFFF.TabIndex = 26;
            this.DGVSTAFFF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSTAFF_CellClick);
            // 
            // frmuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1224, 750);
            this.Controls.Add(this.DGVSTAFFF);
            this.Controls.Add(this.DGVUSER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrolesearch);
            this.Controls.Add(this.panelstaff);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmuser";
            this.Text = "frmuser";
            this.Load += new System.EventHandler(this.frmuser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelstaff.ResumeLayout(false);
            this.panelstaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUSER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSTAFFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnassignuser;
        private System.Windows.Forms.Button btnremuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelstaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrolesearch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtcafeid;
        private System.Windows.Forms.DataGridView DGVUSER;
        private System.Windows.Forms.ComboBox cmbaccesssystem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView DGVSTAFFF;
    }
}