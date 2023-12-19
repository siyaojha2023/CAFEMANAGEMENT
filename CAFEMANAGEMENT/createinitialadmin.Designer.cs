namespace CafeManagement
{
    partial class createinitialadmin
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcafeid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncreateadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label5.Location = new System.Drawing.Point(58, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label4.Location = new System.Drawing.Point(58, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Username";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(175, 81);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(200, 20);
            this.txtpass.TabIndex = 34;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(175, 31);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(200, 20);
            this.txtuser.TabIndex = 33;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(175, 126);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(200, 20);
            this.txtconfirm.TabIndex = 34;
            this.txtconfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label1.Location = new System.Drawing.Point(58, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(14)))));
            this.label2.Location = new System.Drawing.Point(58, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cafe-Id";
            // 
            // txtcafeid
            // 
            this.txtcafeid.Location = new System.Drawing.Point(175, 173);
            this.txtcafeid.MaxLength = 5;
            this.txtcafeid.Name = "txtcafeid";
            this.txtcafeid.Size = new System.Drawing.Size(200, 20);
            this.txtcafeid.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(59, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 39);
            this.label3.TabIndex = 37;
            this.label3.Text = "Note: Cafe-Id is a maximum five character id that can be used \r\n          to reco" +
    "ver or change password.\r\n         You cannot change your user name and cafe id o" +
    "nce created.";
            // 
            // btncreateadmin
            // 
            this.btncreateadmin.Location = new System.Drawing.Point(211, 311);
            this.btncreateadmin.Name = "btncreateadmin";
            this.btncreateadmin.Size = new System.Drawing.Size(101, 23);
            this.btncreateadmin.TabIndex = 38;
            this.btncreateadmin.Text = "Create Admin";
            this.btncreateadmin.UseVisualStyleBackColor = true;
            this.btncreateadmin.Click += new System.EventHandler(this.btncreateadmin_Click);
            // 
            // createinitialadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeManagement.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(489, 379);
            this.Controls.Add(this.btncreateadmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcafeid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "createinitialadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN CREATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcafeid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncreateadmin;
    }
}