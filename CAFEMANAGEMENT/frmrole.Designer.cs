namespace CafeManagement
{
    partial class frmrole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrole));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdaterole = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btndeleterole = new System.Windows.Forms.Button();
            this.btnaddrole = new System.Windows.Forms.Button();
            this.btnsaverole = new System.Windows.Forms.Button();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrolesearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnupdaterole);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btndeleterole);
            this.panel1.Controls.Add(this.btnaddrole);
            this.panel1.Controls.Add(this.btnsaverole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 530);
            this.panel1.TabIndex = 0;
            // 
            // btnupdaterole
            // 
            this.btnupdaterole.Enabled = false;
            this.btnupdaterole.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnupdaterole.Location = new System.Drawing.Point(31, 418);
            this.btnupdaterole.Name = "btnupdaterole";
            this.btnupdaterole.Size = new System.Drawing.Size(139, 49);
            this.btnupdaterole.TabIndex = 6;
            this.btnupdaterole.Text = "UPDATE";
            this.btnupdaterole.UseVisualStyleBackColor = true;
            this.btnupdaterole.Click += new System.EventHandler(this.btnupdaterole_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btndeleterole
            // 
            this.btndeleterole.Enabled = false;
            this.btndeleterole.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btndeleterole.Location = new System.Drawing.Point(31, 312);
            this.btndeleterole.Name = "btndeleterole";
            this.btndeleterole.Size = new System.Drawing.Size(139, 49);
            this.btndeleterole.TabIndex = 2;
            this.btndeleterole.Text = "DELETE";
            this.btndeleterole.UseVisualStyleBackColor = true;
            this.btndeleterole.Click += new System.EventHandler(this.btndeleterole_Click);
            // 
            // btnaddrole
            // 
            this.btnaddrole.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnaddrole.Location = new System.Drawing.Point(31, 100);
            this.btnaddrole.Name = "btnaddrole";
            this.btnaddrole.Size = new System.Drawing.Size(139, 49);
            this.btnaddrole.TabIndex = 2;
            this.btnaddrole.Text = "ADD";
            this.btnaddrole.UseVisualStyleBackColor = true;
            this.btnaddrole.Click += new System.EventHandler(this.btnaddrole_Click);
            // 
            // btnsaverole
            // 
            this.btnsaverole.Enabled = false;
            this.btnsaverole.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnsaverole.Location = new System.Drawing.Point(31, 206);
            this.btnsaverole.Name = "btnsaverole";
            this.btnsaverole.Size = new System.Drawing.Size(139, 49);
            this.btnsaverole.TabIndex = 2;
            this.btnsaverole.Text = "SAVE";
            this.btnsaverole.UseVisualStyleBackColor = true;
            this.btnsaverole.Click += new System.EventHandler(this.btnsaverole_Click);
            // 
            // txtrole
            // 
            this.txtrole.Enabled = false;
            this.txtrole.Location = new System.Drawing.Point(240, 340);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(189, 20);
            this.txtrole.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label2.Location = new System.Drawing.Point(236, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Role";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 60);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(317, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role Management";
            // 
            // txtrolesearch
            // 
            this.txtrolesearch.Location = new System.Drawing.Point(497, 115);
            this.txtrolesearch.Name = "txtrolesearch";
            this.txtrolesearch.Size = new System.Drawing.Size(298, 20);
            this.txtrolesearch.TabIndex = 3;
            this.txtrolesearch.TextChanged += new System.EventHandler(this.txtrolesearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(451, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(454, 170);
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
            this.dataGridView1.Size = new System.Drawing.Size(773, 331);
            this.dataGridView1.TabIndex = 5;
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
            this.Column3.HeaderText = "Role Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmrole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1013, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrolesearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmrole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmrole";
            this.Load += new System.EventHandler(this.frmrole_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.Button btnaddrole;
        private System.Windows.Forms.Button btnsaverole;
        private System.Windows.Forms.Button btndeleterole;
        private System.Windows.Forms.TextBox txtrolesearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnupdaterole;
    }
}