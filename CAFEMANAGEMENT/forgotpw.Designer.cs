namespace CafeManagement
{
    partial class pwforgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwforgot));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cafeid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtuserfrgt = new System.Windows.Forms.TextBox();
            this.txtnpw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcnpw = new System.Windows.Forms.TextBox();
            this.btnfrgtapply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please write the CAFE-ID provided by your ADMIN to continue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "CAFE-ID";
            // 
            // txt_cafeid
            // 
            this.txt_cafeid.Location = new System.Drawing.Point(172, 64);
            this.txt_cafeid.Name = "txt_cafeid";
            this.txt_cafeid.Size = new System.Drawing.Size(239, 20);
            this.txt_cafeid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Password";
            // 
            // txtuserfrgt
            // 
            this.txtuserfrgt.Location = new System.Drawing.Point(172, 118);
            this.txtuserfrgt.Name = "txtuserfrgt";
            this.txtuserfrgt.Size = new System.Drawing.Size(239, 20);
            this.txtuserfrgt.TabIndex = 2;
            // 
            // txtnpw
            // 
            this.txtnpw.Location = new System.Drawing.Point(172, 165);
            this.txtnpw.Name = "txtnpw";
            this.txtnpw.Size = new System.Drawing.Size(239, 20);
            this.txtnpw.TabIndex = 2;
            this.txtnpw.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm New Password";
            // 
            // txtcnpw
            // 
            this.txtcnpw.Location = new System.Drawing.Point(172, 212);
            this.txtcnpw.Name = "txtcnpw";
            this.txtcnpw.Size = new System.Drawing.Size(239, 20);
            this.txtcnpw.TabIndex = 2;
            this.txtcnpw.UseSystemPasswordChar = true;
            // 
            // btnfrgtapply
            // 
            this.btnfrgtapply.Location = new System.Drawing.Point(253, 271);
            this.btnfrgtapply.Name = "btnfrgtapply";
            this.btnfrgtapply.Size = new System.Drawing.Size(91, 23);
            this.btnfrgtapply.TabIndex = 3;
            this.btnfrgtapply.Text = "Apply Changes";
            this.btnfrgtapply.UseVisualStyleBackColor = true;
            this.btnfrgtapply.Click += new System.EventHandler(this.btnfrgtapply_Click);
            // 
            // pwforgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 331);
            this.Controls.Add(this.btnfrgtapply);
            this.Controls.Add(this.txtcnpw);
            this.Controls.Add(this.txtnpw);
            this.Controls.Add(this.txtuserfrgt);
            this.Controls.Add(this.txt_cafeid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pwforgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cafeid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtuserfrgt;
        private System.Windows.Forms.TextBox txtnpw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcnpw;
        private System.Windows.Forms.Button btnfrgtapply;
    }
}