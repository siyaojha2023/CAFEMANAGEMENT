namespace CafeManagement
{
    partial class frmtables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtables));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdatetable = new System.Windows.Forms.Button();
            this.btndeletetable = new System.Windows.Forms.Button();
            this.btnaddtable = new System.Windows.Forms.Button();
            this.btnsavetable = new System.Windows.Forms.Button();
            this.btntableexit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttfloorid = new System.Windows.Forms.ComboBox();
            this.txttablechairs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttablenumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txttablesearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btntableexit)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnupdatetable);
            this.panel1.Controls.Add(this.btndeletetable);
            this.panel1.Controls.Add(this.btnaddtable);
            this.panel1.Controls.Add(this.btnsavetable);
            this.panel1.Controls.Add(this.btntableexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 484);
            this.panel1.TabIndex = 24;
            // 
            // btnupdatetable
            // 
            this.btnupdatetable.Enabled = false;
            this.btnupdatetable.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnupdatetable.Location = new System.Drawing.Point(38, 396);
            this.btnupdatetable.Name = "btnupdatetable";
            this.btnupdatetable.Size = new System.Drawing.Size(139, 49);
            this.btnupdatetable.TabIndex = 10;
            this.btnupdatetable.Text = "UPDATE";
            this.btnupdatetable.UseVisualStyleBackColor = true;
            this.btnupdatetable.Click += new System.EventHandler(this.btnupdatetable_Click);
            // 
            // btndeletetable
            // 
            this.btndeletetable.Enabled = false;
            this.btndeletetable.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btndeletetable.Location = new System.Drawing.Point(38, 290);
            this.btndeletetable.Name = "btndeletetable";
            this.btndeletetable.Size = new System.Drawing.Size(139, 49);
            this.btndeletetable.TabIndex = 7;
            this.btndeletetable.Text = "DELETE";
            this.btndeletetable.UseVisualStyleBackColor = true;
            this.btndeletetable.Click += new System.EventHandler(this.btndeletetable_Click);
            // 
            // btnaddtable
            // 
            this.btnaddtable.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnaddtable.Location = new System.Drawing.Point(38, 78);
            this.btnaddtable.Name = "btnaddtable";
            this.btnaddtable.Size = new System.Drawing.Size(139, 49);
            this.btnaddtable.TabIndex = 8;
            this.btnaddtable.Text = "ADD";
            this.btnaddtable.UseVisualStyleBackColor = true;
            this.btnaddtable.Click += new System.EventHandler(this.btnaddtable_Click);
            // 
            // btnsavetable
            // 
            this.btnsavetable.Enabled = false;
            this.btnsavetable.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnsavetable.Location = new System.Drawing.Point(38, 184);
            this.btnsavetable.Name = "btnsavetable";
            this.btnsavetable.Size = new System.Drawing.Size(139, 49);
            this.btnsavetable.TabIndex = 9;
            this.btnsavetable.Text = "SAVE";
            this.btnsavetable.UseVisualStyleBackColor = true;
            this.btnsavetable.Click += new System.EventHandler(this.btnsavetable_Click);
            // 
            // btntableexit
            // 
            this.btntableexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntableexit.BackColor = System.Drawing.Color.Transparent;
            this.btntableexit.Image = ((System.Drawing.Image)(resources.GetObject("btntableexit.Image")));
            this.btntableexit.Location = new System.Drawing.Point(13, 5);
            this.btntableexit.Name = "btntableexit";
            this.btntableexit.Size = new System.Drawing.Size(26, 26);
            this.btntableexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btntableexit.TabIndex = 5;
            this.btntableexit.TabStop = false;
            this.btntableexit.Click += new System.EventHandler(this.btntableexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 60);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tables Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttfloorid);
            this.groupBox1.Controls.Add(this.txttablechairs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttablenumber);
            this.groupBox1.Location = new System.Drawing.Point(238, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 308);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // txttfloorid
            // 
            this.txttfloorid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttfloorid.Enabled = false;
            this.txttfloorid.FormattingEnabled = true;
            this.txttfloorid.Location = new System.Drawing.Point(42, 226);
            this.txttfloorid.Name = "txttfloorid";
            this.txttfloorid.Size = new System.Drawing.Size(188, 21);
            this.txttfloorid.TabIndex = 33;
            this.txttfloorid.SelectedIndexChanged += new System.EventHandler(this.txttfloorid_SelectedIndexChanged);
            // 
            // txttablechairs
            // 
            this.txttablechairs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttablechairs.Enabled = false;
            this.txttablechairs.FormattingEnabled = true;
            this.txttablechairs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.txttablechairs.Location = new System.Drawing.Point(42, 154);
            this.txttablechairs.Name = "txttablechairs";
            this.txttablechairs.Size = new System.Drawing.Size(188, 21);
            this.txttablechairs.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Floor #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "No. of Chairs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Table Number";
            // 
            // txttablenumber
            // 
            this.txttablenumber.Enabled = false;
            this.txttablenumber.Location = new System.Drawing.Point(42, 86);
            this.txttablenumber.Name = "txttablenumber";
            this.txttablenumber.Size = new System.Drawing.Size(188, 20);
            this.txttablenumber.TabIndex = 31;
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
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(518, 184);
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
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Table Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Chairs";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Floor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(515, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Search:";
            // 
            // txttablesearch
            // 
            this.txttablesearch.Location = new System.Drawing.Point(561, 148);
            this.txttablesearch.Name = "txttablesearch";
            this.txttablesearch.Size = new System.Drawing.Size(298, 20);
            this.txttablesearch.TabIndex = 37;
            this.txttablesearch.TextChanged += new System.EventHandler(this.txttablesearch_TextChanged);
            // 
            // frmtables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1057, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttablesearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtables";
            this.Text = "frmtables";
            this.Load += new System.EventHandler(this.frmtables_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btntableexit)).EndInit();
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
        private System.Windows.Forms.Button btnupdatetable;
        private System.Windows.Forms.Button btndeletetable;
        private System.Windows.Forms.Button btnaddtable;
        private System.Windows.Forms.Button btnsavetable;
        private System.Windows.Forms.PictureBox btntableexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txttfloorid;
        private System.Windows.Forms.ComboBox txttablechairs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttablenumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttablesearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}