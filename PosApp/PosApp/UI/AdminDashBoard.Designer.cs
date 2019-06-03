namespace PosApp.UI
{
    partial class AdminDashBoard
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invetoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.loggedInUser = new System.Windows.Forms.Label();
            this.ibiAppFName = new System.Windows.Forms.Label();
            this.ibiLastName = new System.Windows.Forms.Label();
            this.ibiSHead = new System.Windows.Forms.Label();
            this.dealerAndCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelFooter.Controls.Add(this.label4);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 402);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1067, 48);
            this.panelFooter.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(500, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Developed By: Ntwali patrick";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.invetoryToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.dealerAndCustomersToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripTop.Size = new System.Drawing.Size(1067, 24);
            this.menuStripTop.TabIndex = 1;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.usersToolStripMenuItem.Text = "users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.categoryToolStripMenuItem.Text = "category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // invetoryToolStripMenuItem
            // 
            this.invetoryToolStripMenuItem.Name = "invetoryToolStripMenuItem";
            this.invetoryToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.invetoryToolStripMenuItem.Text = "invetory";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.transactionsToolStripMenuItem.Text = "transactions";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(17, 28);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "user:";
            // 
            // loggedInUser
            // 
            this.loggedInUser.AutoSize = true;
            this.loggedInUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.loggedInUser.Location = new System.Drawing.Point(49, 28);
            this.loggedInUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedInUser.Name = "loggedInUser";
            this.loggedInUser.Size = new System.Drawing.Size(0, 17);
            this.loggedInUser.TabIndex = 3;
            this.loggedInUser.Click += new System.EventHandler(this.LoggedInUser_Click);
            // 
            // ibiAppFName
            // 
            this.ibiAppFName.BackColor = System.Drawing.Color.Transparent;
            this.ibiAppFName.Cursor = System.Windows.Forms.Cursors.Default;
            this.ibiAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiAppFName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibiAppFName.Location = new System.Drawing.Point(568, 220);
            this.ibiAppFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ibiAppFName.Name = "ibiAppFName";
            this.ibiAppFName.Size = new System.Drawing.Size(104, 53);
            this.ibiAppFName.TabIndex = 14;
            this.ibiAppFName.Text = "POS\r\n\r\n";
            // 
            // ibiLastName
            // 
            this.ibiLastName.BackColor = System.Drawing.Color.Transparent;
            this.ibiLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.ibiLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibiLastName.Location = new System.Drawing.Point(625, 220);
            this.ibiLastName.Name = "ibiLastName";
            this.ibiLastName.Size = new System.Drawing.Size(151, 53);
            this.ibiLastName.TabIndex = 15;
            this.ibiLastName.Text = "System";
            // 
            // ibiSHead
            // 
            this.ibiSHead.AutoSize = true;
            this.ibiSHead.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiSHead.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ibiSHead.Location = new System.Drawing.Point(537, 259);
            this.ibiSHead.Name = "ibiSHead";
            this.ibiSHead.Size = new System.Drawing.Size(239, 25);
            this.ibiSHead.TabIndex = 16;
            this.ibiSHead.Text = "Point of Sale Management ";
            // 
            // dealerAndCustomersToolStripMenuItem
            // 
            this.dealerAndCustomersToolStripMenuItem.Name = "dealerAndCustomersToolStripMenuItem";
            this.dealerAndCustomersToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.dealerAndCustomersToolStripMenuItem.Text = "Dealer and Customers";
            this.dealerAndCustomersToolStripMenuItem.Click += new System.EventHandler(this.DealerAndCustomersToolStripMenuItem_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.ibiSHead);
            this.Controls.Add(this.ibiLastName);
            this.Controls.Add(this.ibiAppFName);
            this.Controls.Add(this.loggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.MainMenuStrip = this.menuStripTop;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashBoard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashBoard_Load);
            this.panelFooter.ResumeLayout(false);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invetoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label loggedInUser;
        private System.Windows.Forms.Label ibiAppFName;
        private System.Windows.Forms.Label ibiLastName;
        private System.Windows.Forms.Label ibiSHead;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomersToolStripMenuItem;
    }
}