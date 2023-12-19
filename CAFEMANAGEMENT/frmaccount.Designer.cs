namespace CafeManagement
{
    partial class frmaccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaccount));
            this.txttotalsale = new System.Windows.Forms.TextBox();
            this.dgvsales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.printpreviewpanel = new System.Windows.Forms.Panel();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).BeginInit();
            this.panel2.SuspendLayout();
            this.printpreviewpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txttotalsale
            // 
            this.txttotalsale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalsale.Location = new System.Drawing.Point(931, 81);
            this.txttotalsale.Name = "txttotalsale";
            this.txttotalsale.ReadOnly = true;
            this.txttotalsale.Size = new System.Drawing.Size(87, 20);
            this.txttotalsale.TabIndex = 43;
            this.txttotalsale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvsales
            // 
            this.dgvsales.AllowUserToAddRows = false;
            this.dgvsales.AllowUserToDeleteRows = false;
            this.dgvsales.AllowUserToResizeColumns = false;
            this.dgvsales.AllowUserToResizeRows = false;
            this.dgvsales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvsales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvsales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsales.Location = new System.Drawing.Point(0, 168);
            this.dgvsales.Name = "dgvsales";
            this.dgvsales.RowHeadersVisible = false;
            this.dgvsales.Size = new System.Drawing.Size(1277, 544);
            this.dgvsales.TabIndex = 15;
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
            this.itemGV.HeaderText = "Amout Paid";
            this.itemGV.Name = "itemGV";
            this.itemGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityGV.HeaderText = "Amount Returned";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            this.quantityGV.Width = 105;
            // 
            // amountGV
            // 
            this.amountGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            this.amountGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.amountGV.HeaderText = "Total";
            this.amountGV.Name = "amountGV";
            this.amountGV.ReadOnly = true;
            this.amountGV.ToolTipText = "It gives total sales of particular person.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 54);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Market", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(542, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAILY SALES";
            // 
            // printpreviewpanel
            // 
            this.printpreviewpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.printpreviewpanel.Controls.Add(this.datetimepicker);
            this.printpreviewpanel.Controls.Add(this.label4);
            this.printpreviewpanel.Controls.Add(this.txttotalsale);
            this.printpreviewpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.printpreviewpanel.Location = new System.Drawing.Point(0, 54);
            this.printpreviewpanel.Name = "printpreviewpanel";
            this.printpreviewpanel.Size = new System.Drawing.Size(1277, 114);
            this.printpreviewpanel.TabIndex = 28;
            // 
            // datetimepicker
            // 
            this.datetimepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimepicker.Location = new System.Drawing.Point(1067, 81);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.datetimepicker.TabIndex = 47;
            this.datetimepicker.ValueChanged += new System.EventHandler(this.datetimepicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(908, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Total Daily Sales";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 712);
            this.Controls.Add(this.dgvsales);
            this.Controls.Add(this.printpreviewpanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmaccount";
            this.Text = "frmaccount";
            this.Load += new System.EventHandler(this.frmaccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.printpreviewpanel.ResumeLayout(false);
            this.printpreviewpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txttotalsale;
        private System.Windows.Forms.DataGridView dgvsales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel printpreviewpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGV;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}