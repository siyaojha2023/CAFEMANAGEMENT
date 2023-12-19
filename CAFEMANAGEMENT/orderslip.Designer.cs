namespace CafeManagement
{
    partial class orderslip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderslip));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvslip = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddorder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.btngenerateslip = new System.Windows.Forms.Button();
            this.btnbillingexit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.printpreviewpanel = new System.Windows.Forms.Panel();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.prtx = new System.Windows.Forms.PrintPreviewControl();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvslip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbillingexit)).BeginInit();
            this.panel2.SuspendLayout();
            this.printpreviewpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btngenerateslip);
            this.panel1.Controls.Add(this.btnbillingexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 712);
            this.panel1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvslip);
            this.groupBox1.Controls.Add(this.btnaddorder);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtitem);
            this.groupBox1.Controls.Add(this.txtsupplier);
            this.groupBox1.Location = new System.Drawing.Point(28, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 558);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply Order";
            // 
            // dgvslip
            // 
            this.dgvslip.AllowUserToAddRows = false;
            this.dgvslip.AllowUserToDeleteRows = false;
            this.dgvslip.AllowUserToResizeColumns = false;
            this.dgvslip.AllowUserToResizeRows = false;
            this.dgvslip.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvslip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvslip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvslip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.itemGV,
            this.quantityGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvslip.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvslip.Location = new System.Drawing.Point(18, 310);
            this.dgvslip.Name = "dgvslip";
            this.dgvslip.RowHeadersVisible = false;
            this.dgvslip.Size = new System.Drawing.Size(413, 229);
            this.dgvslip.TabIndex = 17;
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
            // btnaddorder
            // 
            this.btnaddorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnaddorder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnaddorder.Location = new System.Drawing.Point(179, 207);
            this.btnaddorder.Name = "btnaddorder";
            this.btnaddorder.Size = new System.Drawing.Size(89, 32);
            this.btnaddorder.TabIndex = 10;
            this.btnaddorder.Text = "ADD";
            this.btnaddorder.UseVisualStyleBackColor = false;
            this.btnaddorder.Click += new System.EventHandler(this.btnaddorder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(15, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(28, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(146, 137);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(165, 20);
            this.txtquantity.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Order From:";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(146, 83);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(165, 20);
            this.txtitem.TabIndex = 0;
            // 
            // txtsupplier
            // 
            this.txtsupplier.Location = new System.Drawing.Point(146, 32);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(165, 20);
            this.txtsupplier.TabIndex = 0;
            this.txtsupplier.Text = " ";
            // 
            // btngenerateslip
            // 
            this.btngenerateslip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngenerateslip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btngenerateslip.Location = new System.Drawing.Point(163, 641);
            this.btngenerateslip.Name = "btngenerateslip";
            this.btngenerateslip.Size = new System.Drawing.Size(214, 41);
            this.btngenerateslip.TabIndex = 10;
            this.btngenerateslip.Text = "GENERATE SLIP";
            this.btngenerateslip.UseVisualStyleBackColor = false;
            this.btngenerateslip.Click += new System.EventHandler(this.btngenerateslip_Click);
            // 
            // btnbillingexit
            // 
            this.btnbillingexit.BackColor = System.Drawing.Color.Transparent;
            this.btnbillingexit.Image = ((System.Drawing.Image)(resources.GetObject("btnbillingexit.Image")));
            this.btnbillingexit.Location = new System.Drawing.Point(16, 12);
            this.btnbillingexit.Name = "btnbillingexit";
            this.btnbillingexit.Size = new System.Drawing.Size(26, 26);
            this.btnbillingexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnbillingexit.TabIndex = 5;
            this.btnbillingexit.TabStop = false;
            this.btnbillingexit.Click += new System.EventHandler(this.btnbillingexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(517, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 60);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER SLIP GENERATION";
            // 
            // printpreviewpanel
            // 
            this.printpreviewpanel.Controls.Add(this.btnpreview);
            this.printpreviewpanel.Controls.Add(this.btnprint);
            this.printpreviewpanel.Controls.Add(this.prtx);
            this.printpreviewpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printpreviewpanel.Location = new System.Drawing.Point(517, 60);
            this.printpreviewpanel.Name = "printpreviewpanel";
            this.printpreviewpanel.Size = new System.Drawing.Size(760, 652);
            this.printpreviewpanel.TabIndex = 28;
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
            // prtx
            // 
            this.prtx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.prtx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prtx.Location = new System.Drawing.Point(0, 0);
            this.prtx.Name = "prtx";
            this.prtx.Size = new System.Drawing.Size(760, 652);
            this.prtx.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // orderslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 712);
            this.Controls.Add(this.printpreviewpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderslip";
            this.Text = "orderslip";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvslip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbillingexit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.printpreviewpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngenerateslip;
        private System.Windows.Forms.PictureBox btnbillingexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.Panel printpreviewpanel;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PrintPreviewControl prtx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.DataGridView dgvslip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnaddorder;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}