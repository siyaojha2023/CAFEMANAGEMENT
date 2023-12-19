namespace CafeManagement
{
    partial class frmfloor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfloor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdatefloor = new System.Windows.Forms.Button();
            this.btndeletefloor = new System.Windows.Forms.Button();
            this.btnaddrole = new System.Windows.Forms.Button();
            this.btnsavefloor = new System.Windows.Forms.Button();
            this.btnfloorexit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfloornumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfloorname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfloorsearch = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnfloorexit)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnupdatefloor);
            this.panel1.Controls.Add(this.btndeletefloor);
            this.panel1.Controls.Add(this.btnaddrole);
            this.panel1.Controls.Add(this.btnsavefloor);
            this.panel1.Controls.Add(this.btnfloorexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 484);
            this.panel1.TabIndex = 23;
            // 
            // btnupdatefloor
            // 
            this.btnupdatefloor.Enabled = false;
            this.btnupdatefloor.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnupdatefloor.Location = new System.Drawing.Point(38, 396);
            this.btnupdatefloor.Name = "btnupdatefloor";
            this.btnupdatefloor.Size = new System.Drawing.Size(139, 49);
            this.btnupdatefloor.TabIndex = 10;
            this.btnupdatefloor.Text = "UPDATE";
            this.btnupdatefloor.UseVisualStyleBackColor = true;
            this.btnupdatefloor.Click += new System.EventHandler(this.btnupdatefloor_Click);
            // 
            // btndeletefloor
            // 
            this.btndeletefloor.Enabled = false;
            this.btndeletefloor.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btndeletefloor.Location = new System.Drawing.Point(38, 290);
            this.btndeletefloor.Name = "btndeletefloor";
            this.btndeletefloor.Size = new System.Drawing.Size(139, 49);
            this.btndeletefloor.TabIndex = 7;
            this.btndeletefloor.Text = "DELETE";
            this.btndeletefloor.UseVisualStyleBackColor = true;
            this.btndeletefloor.Click += new System.EventHandler(this.btndeletefloor_Click);
            // 
            // btnaddrole
            // 
            this.btnaddrole.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnaddrole.Location = new System.Drawing.Point(38, 78);
            this.btnaddrole.Name = "btnaddrole";
            this.btnaddrole.Size = new System.Drawing.Size(139, 49);
            this.btnaddrole.TabIndex = 8;
            this.btnaddrole.Text = "ADD";
            this.btnaddrole.UseVisualStyleBackColor = true;
            this.btnaddrole.Click += new System.EventHandler(this.btnaddrole_Click);
            // 
            // btnsavefloor
            // 
            this.btnsavefloor.Enabled = false;
            this.btnsavefloor.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnsavefloor.Location = new System.Drawing.Point(38, 184);
            this.btnsavefloor.Name = "btnsavefloor";
            this.btnsavefloor.Size = new System.Drawing.Size(139, 49);
            this.btnsavefloor.TabIndex = 9;
            this.btnsavefloor.Text = "SAVE";
            this.btnsavefloor.UseVisualStyleBackColor = true;
            this.btnsavefloor.Click += new System.EventHandler(this.btnsavefloor_Click);
            // 
            // btnfloorexit
            // 
            this.btnfloorexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfloorexit.BackColor = System.Drawing.Color.Transparent;
            this.btnfloorexit.Image = ((System.Drawing.Image)(resources.GetObject("btnfloorexit.Image")));
            this.btnfloorexit.Location = new System.Drawing.Point(13, 5);
            this.btnfloorexit.Name = "btnfloorexit";
            this.btnfloorexit.Size = new System.Drawing.Size(26, 26);
            this.btnfloorexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnfloorexit.TabIndex = 5;
            this.btnfloorexit.TabStop = false;
            this.btnfloorexit.Click += new System.EventHandler(this.btnfloorexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 60);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floor Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfloornumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfloorname);
            this.groupBox1.Location = new System.Drawing.Point(233, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 308);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // txtfloornumber
            // 
            this.txtfloornumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfloornumber.Enabled = false;
            this.txtfloornumber.FormattingEnabled = true;
            this.txtfloornumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.txtfloornumber.Location = new System.Drawing.Point(42, 189);
            this.txtfloornumber.Name = "txtfloornumber";
            this.txtfloornumber.Size = new System.Drawing.Size(188, 21);
            this.txtfloornumber.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Floor Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Floor ";
            // 
            // txtfloorname
            // 
            this.txtfloorname.Enabled = false;
            this.txtfloorname.Location = new System.Drawing.Point(42, 86);
            this.txtfloorname.Name = "txtfloorname";
            this.txtfloorname.Size = new System.Drawing.Size(188, 20);
            this.txtfloorname.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.floorIDGV,
            this.floorNameGV,
            this.floorNumberGV});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(513, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 331);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(510, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Search:";
            // 
            // txtfloorsearch
            // 
            this.txtfloorsearch.Location = new System.Drawing.Point(556, 165);
            this.txtfloorsearch.Name = "txtfloorsearch";
            this.txtfloorsearch.Size = new System.Drawing.Size(298, 20);
            this.txtfloorsearch.TabIndex = 33;
            this.txtfloorsearch.TextChanged += new System.EventHandler(this.txtrolesearch_TextChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // floorIDGV
            // 
            this.floorIDGV.HeaderText = "Id";
            this.floorIDGV.Name = "floorIDGV";
            this.floorIDGV.ReadOnly = true;
            this.floorIDGV.Visible = false;
            // 
            // floorNameGV
            // 
            this.floorNameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorNameGV.HeaderText = "Floor";
            this.floorNameGV.Name = "floorNameGV";
            this.floorNameGV.ReadOnly = true;
            // 
            // floorNumberGV
            // 
            this.floorNumberGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorNumberGV.HeaderText = "Floor Number";
            this.floorNumberGV.Name = "floorNumberGV";
            this.floorNumberGV.ReadOnly = true;
            // 
            // frmfloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1057, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfloorsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmfloor";
            this.Text = "frmfloor";
            this.Load += new System.EventHandler(this.frmfloor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnfloorexit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdatefloor;
        private System.Windows.Forms.Button btndeletefloor;
        private System.Windows.Forms.Button btnaddrole;
        private System.Windows.Forms.Button btnsavefloor;
        private System.Windows.Forms.PictureBox btnfloorexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtfloornumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfloorname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfloorsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberGV;
    }
}