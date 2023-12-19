namespace CafeManagement
{
    partial class frmservicecharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmservicecharge));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btntaxexit = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtinclu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btntaxexit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btntaxexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 366);
            this.panel1.TabIndex = 25;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnupdate.Location = new System.Drawing.Point(32, 173);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 49);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btntaxexit
            // 
            this.btntaxexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntaxexit.BackColor = System.Drawing.Color.Transparent;
            this.btntaxexit.Image = ((System.Drawing.Image)(resources.GetObject("btntaxexit.Image")));
            this.btntaxexit.Location = new System.Drawing.Point(7, 5);
            this.btntaxexit.Name = "btntaxexit";
            this.btntaxexit.Size = new System.Drawing.Size(26, 26);
            this.btntaxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btntaxexit.TabIndex = 5;
            this.btntaxexit.TabStop = false;
            this.btntaxexit.Click += new System.EventHandler(this.btntaxexit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label11.Location = new System.Drawing.Point(410, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Service Charge(%)";
            // 
            // txtinclu
            // 
            this.txtinclu.Enabled = false;
            this.txtinclu.Location = new System.Drawing.Point(569, 150);
            this.txtinclu.Name = "txtinclu";
            this.txtinclu.Size = new System.Drawing.Size(56, 20);
            this.txtinclu.TabIndex = 34;
            this.txtinclu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taxform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(738, 366);
            this.ControlBox = false;
            this.Controls.Add(this.txtinclu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "taxform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Update";
            this.Load += new System.EventHandler(this.taxform_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btntaxexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.PictureBox btntaxexit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtinclu;
    }
}