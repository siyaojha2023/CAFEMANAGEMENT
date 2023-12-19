namespace CafeManagement
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountHandlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStocksAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCafeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(27)))));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.ordersToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.stocksToolStripMenuItem,
            this.aboutCafeToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1168, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoleToolStripMenuItem,
            this.staffStatusToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountHandlingToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 29);
            this.toolStripMenuItem2.Text = "HR Department";
            // 
            // RoleToolStripMenuItem
            // 
            this.RoleToolStripMenuItem.Name = "RoleToolStripMenuItem";
            this.RoleToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.RoleToolStripMenuItem.Text = "Roles";
            this.RoleToolStripMenuItem.Click += new System.EventHandler(this.RoleToolStripMenuItem_Click);
            // 
            // staffStatusToolStripMenuItem
            // 
            this.staffStatusToolStripMenuItem.Name = "staffStatusToolStripMenuItem";
            this.staffStatusToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.staffStatusToolStripMenuItem.Text = "Staffs";
            this.staffStatusToolStripMenuItem.Click += new System.EventHandler(this.staffStatusToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountHandlingToolStripMenuItem
            // 
            this.accountHandlingToolStripMenuItem.Name = "accountHandlingToolStripMenuItem";
            this.accountHandlingToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.accountHandlingToolStripMenuItem.Text = "Account Handling";
            this.accountHandlingToolStripMenuItem.Click += new System.EventHandler(this.accountHandlingToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerOrderToolStripMenuItem,
            this.orderSleepToolStripMenuItem});
            this.ordersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // customerOrderToolStripMenuItem
            // 
            this.customerOrderToolStripMenuItem.Name = "customerOrderToolStripMenuItem";
            this.customerOrderToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.customerOrderToolStripMenuItem.Text = "Customer Order";
            this.customerOrderToolStripMenuItem.Click += new System.EventHandler(this.customerOrderToolStripMenuItem_Click);
            // 
            // orderSleepToolStripMenuItem
            // 
            this.orderSleepToolStripMenuItem.Name = "orderSleepToolStripMenuItem";
            this.orderSleepToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.orderSleepToolStripMenuItem.Text = "Order Slip";
            this.orderSleepToolStripMenuItem.Click += new System.EventHandler(this.orderSleepToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(137, 29);
            this.toolStripMenuItem3.Text = "Bill Generation";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.menuToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 29);
            this.toolStripMenuItem1.Text = "Food && Drinks";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(215, 30);
            this.toolStripMenuItem7.Text = "Food Categories";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.menuToolStripMenuItem.Text = "Food Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStockToolStripMenuItem,
            this.viewStocksAvailableToolStripMenuItem});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(161, 29);
            this.toolStripMenuItem4.Text = "Floors and Tables";
            // 
            // addNewStockToolStripMenuItem
            // 
            this.addNewStockToolStripMenuItem.Name = "addNewStockToolStripMenuItem";
            this.addNewStockToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.addNewStockToolStripMenuItem.Text = "Floors";
            this.addNewStockToolStripMenuItem.Click += new System.EventHandler(this.addNewStockToolStripMenuItem_Click);
            // 
            // viewStocksAvailableToolStripMenuItem
            // 
            this.viewStocksAvailableToolStripMenuItem.Name = "viewStocksAvailableToolStripMenuItem";
            this.viewStocksAvailableToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.viewStocksAvailableToolStripMenuItem.Text = "Tables";
            this.viewStocksAvailableToolStripMenuItem.Click += new System.EventHandler(this.viewStocksAvailableToolStripMenuItem_Click);
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.stocksToolStripMenuItem.Text = "Kitchen Orders";
            this.stocksToolStripMenuItem.Click += new System.EventHandler(this.stocksToolStripMenuItem_Click);
            // 
            // aboutCafeToolStripMenuItem
            // 
            this.aboutCafeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.aboutCafeToolStripMenuItem.Name = "aboutCafeToolStripMenuItem";
            this.aboutCafeToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.aboutCafeToolStripMenuItem.Text = "About Cafe";
            this.aboutCafeToolStripMenuItem.Click += new System.EventHandler(this.aboutCafeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(27)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1107, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(27)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1137, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Location = new System.Drawing.Point(912, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 28);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TALITHA", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADMIN";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("TALITHA", 12F);
            this.welcome.ForeColor = System.Drawing.Color.Black;
            this.welcome.Location = new System.Drawing.Point(6, 6);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(107, 17);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "WELCOME,";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeManagement.Properties.Resources.backgroundcafe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 778);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem RoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffStatusToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem addNewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStocksAvailableToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcome;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCafeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountHandlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderSleepToolStripMenuItem;
    }
}



