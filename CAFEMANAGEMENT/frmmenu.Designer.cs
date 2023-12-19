namespace CafeManagement
{
    partial class frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdatemenu = new System.Windows.Forms.Button();
            this.btndeletemenu = new System.Windows.Forms.Button();
            this.btnaddmenu = new System.Windows.Forms.Button();
            this.btnsavemenu = new System.Windows.Forms.Button();
            this.btnmenuexit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmenusearch = new System.Windows.Forms.TextBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picitem = new System.Windows.Forms.PictureBox();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenuexit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picitem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnupdatemenu);
            this.panel1.Controls.Add(this.btndeletemenu);
            this.panel1.Controls.Add(this.btnaddmenu);
            this.panel1.Controls.Add(this.btnsavemenu);
            this.panel1.Controls.Add(this.btnmenuexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 585);
            this.panel1.TabIndex = 22;
            // 
            // btnupdatemenu
            // 
            this.btnupdatemenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdatemenu.Enabled = false;
            this.btnupdatemenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnupdatemenu.Location = new System.Drawing.Point(38, 396);
            this.btnupdatemenu.Name = "btnupdatemenu";
            this.btnupdatemenu.Size = new System.Drawing.Size(139, 49);
            this.btnupdatemenu.TabIndex = 10;
            this.btnupdatemenu.Text = "UPDATE";
            this.btnupdatemenu.UseVisualStyleBackColor = true;
            this.btnupdatemenu.Click += new System.EventHandler(this.btnupdatemenu_Click);
            // 
            // btndeletemenu
            // 
            this.btndeletemenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletemenu.Enabled = false;
            this.btndeletemenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btndeletemenu.Location = new System.Drawing.Point(38, 290);
            this.btndeletemenu.Name = "btndeletemenu";
            this.btndeletemenu.Size = new System.Drawing.Size(139, 49);
            this.btndeletemenu.TabIndex = 7;
            this.btndeletemenu.Text = "DELETE";
            this.btndeletemenu.UseVisualStyleBackColor = true;
            this.btndeletemenu.Click += new System.EventHandler(this.btndeletemenu_Click);
            // 
            // btnaddmenu
            // 
            this.btnaddmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddmenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnaddmenu.Location = new System.Drawing.Point(38, 78);
            this.btnaddmenu.Name = "btnaddmenu";
            this.btnaddmenu.Size = new System.Drawing.Size(139, 49);
            this.btnaddmenu.TabIndex = 8;
            this.btnaddmenu.Text = "ADD";
            this.btnaddmenu.UseVisualStyleBackColor = true;
            this.btnaddmenu.Click += new System.EventHandler(this.btnaddmenu_Click);
            // 
            // btnsavemenu
            // 
            this.btnsavemenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsavemenu.Enabled = false;
            this.btnsavemenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnsavemenu.Location = new System.Drawing.Point(38, 184);
            this.btnsavemenu.Name = "btnsavemenu";
            this.btnsavemenu.Size = new System.Drawing.Size(139, 49);
            this.btnsavemenu.TabIndex = 9;
            this.btnsavemenu.Text = "SAVE";
            this.btnsavemenu.UseVisualStyleBackColor = true;
            this.btnsavemenu.Click += new System.EventHandler(this.btnsavemenu_Click);
            // 
            // btnmenuexit
            // 
            this.btnmenuexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmenuexit.BackColor = System.Drawing.Color.Transparent;
            this.btnmenuexit.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuexit.Image")));
            this.btnmenuexit.Location = new System.Drawing.Point(13, 5);
            this.btnmenuexit.Name = "btnmenuexit";
            this.btnmenuexit.Size = new System.Drawing.Size(26, 26);
            this.btnmenuexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmenuexit.TabIndex = 5;
            this.btnmenuexit.TabStop = false;
            this.btnmenuexit.Click += new System.EventHandler(this.btnmenuexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 60);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Menu";
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
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(514, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 331);
            this.dataGridView1.TabIndex = 30;
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
            this.Column3.HeaderText = "Menu Item";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CatID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Categories";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(511, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search:";
            // 
            // txtmenusearch
            // 
            this.txtmenusearch.Location = new System.Drawing.Point(557, 139);
            this.txtmenusearch.Name = "txtmenusearch";
            this.txtmenusearch.Size = new System.Drawing.Size(298, 20);
            this.txtmenusearch.TabIndex = 28;
            this.txtmenusearch.TextChanged += new System.EventHandler(this.txtmenusearch_TextChanged);
            // 
            // txtitem
            // 
            this.txtitem.Enabled = false;
            this.txtitem.Location = new System.Drawing.Point(36, 134);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(188, 20);
            this.txtitem.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picitem);
            this.groupBox1.Controls.Add(this.txtstatus);
            this.groupBox1.Controls.Add(this.txtcategory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtitem);
            this.groupBox1.Location = new System.Drawing.Point(234, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 379);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // picitem
            // 
            this.picitem.Location = new System.Drawing.Point(84, 19);
            this.picitem.Name = "picitem";
            this.picitem.Size = new System.Drawing.Size(110, 84);
            this.picitem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picitem.TabIndex = 34;
            this.picitem.TabStop = false;
            this.picitem.Click += new System.EventHandler(this.picitem_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtstatus.Enabled = false;
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.txtstatus.Location = new System.Drawing.Point(36, 318);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(188, 21);
            this.txtstatus.TabIndex = 33;
            // 
            // txtcategory
            // 
            this.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategory.Enabled = false;
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Location = new System.Drawing.Point(36, 193);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(188, 21);
            this.txtcategory.TabIndex = 33;
            this.txtcategory.SelectedIndexChanged += new System.EventHandler(this.txtcategory_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Menu Item";
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(36, 255);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(188, 20);
            this.txtprice.TabIndex = 31;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1057, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmenusearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmenu";
            this.Text = "frmmenu";
            this.Load += new System.EventHandler(this.frmmenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmenuexit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdatemenu;
        private System.Windows.Forms.Button btndeletemenu;
        private System.Windows.Forms.Button btnaddmenu;
        private System.Windows.Forms.Button btnsavemenu;
        private System.Windows.Forms.PictureBox btnmenuexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmenusearch;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox picitem;
    }
}