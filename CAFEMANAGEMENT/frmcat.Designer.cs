namespace CafeManagement
{
    partial class frmcat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdatecat = new System.Windows.Forms.Button();
            this.btndeletecat = new System.Windows.Forms.Button();
            this.btnaddcat = new System.Windows.Forms.Button();
            this.btnsavecat = new System.Windows.Forms.Button();
            this.catexit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcatsearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catexit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnupdatecat);
            this.panel1.Controls.Add(this.btndeletecat);
            this.panel1.Controls.Add(this.btnaddcat);
            this.panel1.Controls.Add(this.btnsavecat);
            this.panel1.Controls.Add(this.catexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 523);
            this.panel1.TabIndex = 21;
            // 
            // btnupdatecat
            // 
            this.btnupdatecat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdatecat.Enabled = false;
            this.btnupdatecat.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnupdatecat.Location = new System.Drawing.Point(38, 396);
            this.btnupdatecat.Name = "btnupdatecat";
            this.btnupdatecat.Size = new System.Drawing.Size(139, 49);
            this.btnupdatecat.TabIndex = 10;
            this.btnupdatecat.Text = "UPDATE";
            this.btnupdatecat.UseVisualStyleBackColor = true;
            this.btnupdatecat.Click += new System.EventHandler(this.btnupdatecat_Click);
            // 
            // btndeletecat
            // 
            this.btndeletecat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletecat.Enabled = false;
            this.btndeletecat.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btndeletecat.Location = new System.Drawing.Point(38, 290);
            this.btndeletecat.Name = "btndeletecat";
            this.btndeletecat.Size = new System.Drawing.Size(139, 49);
            this.btndeletecat.TabIndex = 7;
            this.btndeletecat.Text = "DELETE";
            this.btndeletecat.UseVisualStyleBackColor = true;
            this.btndeletecat.Click += new System.EventHandler(this.btndeletecat_Click);
            // 
            // btnaddcat
            // 
            this.btnaddcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddcat.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnaddcat.Location = new System.Drawing.Point(38, 78);
            this.btnaddcat.Name = "btnaddcat";
            this.btnaddcat.Size = new System.Drawing.Size(139, 49);
            this.btnaddcat.TabIndex = 8;
            this.btnaddcat.Text = "ADD";
            this.btnaddcat.UseVisualStyleBackColor = true;
            this.btnaddcat.Click += new System.EventHandler(this.btnaddcat_Click);
            // 
            // btnsavecat
            // 
            this.btnsavecat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsavecat.Enabled = false;
            this.btnsavecat.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnsavecat.Location = new System.Drawing.Point(38, 184);
            this.btnsavecat.Name = "btnsavecat";
            this.btnsavecat.Size = new System.Drawing.Size(139, 49);
            this.btnsavecat.TabIndex = 9;
            this.btnsavecat.Text = "SAVE";
            this.btnsavecat.UseVisualStyleBackColor = true;
            this.btnsavecat.Click += new System.EventHandler(this.btnsavecat_Click);
            // 
            // catexit
            // 
            this.catexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.catexit.BackColor = System.Drawing.Color.Transparent;
            this.catexit.Image = ((System.Drawing.Image)(resources.GetObject("catexit.Image")));
            this.catexit.Location = new System.Drawing.Point(13, 5);
            this.catexit.Name = "catexit";
            this.catexit.Size = new System.Drawing.Size(26, 26);
            this.catexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catexit.TabIndex = 5;
            this.catexit.TabStop = false;
            this.catexit.Click += new System.EventHandler(this.catexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 60);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label2.Location = new System.Drawing.Point(248, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Category";
            // 
            // txtcat
            // 
            this.txtcat.Enabled = false;
            this.txtcat.Location = new System.Drawing.Point(252, 307);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(189, 20);
            this.txtcat.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(466, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 331);
            this.dataGridView1.TabIndex = 25;
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
            this.Column3.HeaderText = "Category Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(463, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Search:";
            // 
            // txtcatsearch
            // 
            this.txtcatsearch.Location = new System.Drawing.Point(509, 82);
            this.txtcatsearch.Name = "txtcatsearch";
            this.txtcatsearch.Size = new System.Drawing.Size(298, 20);
            this.txtcatsearch.TabIndex = 23;
            this.txtcatsearch.TextChanged += new System.EventHandler(this.txtcatsearch_TextChanged);
            // 
            // frmcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1073, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcatsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcat";
            this.Text = "frmcat";
            this.Load += new System.EventHandler(this.frmcat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catexit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox catexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdatecat;
        private System.Windows.Forms.Button btndeletecat;
        private System.Windows.Forms.Button btnaddcat;
        private System.Windows.Forms.Button btnsavecat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcatsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}