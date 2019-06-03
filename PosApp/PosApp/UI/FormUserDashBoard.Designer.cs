namespace PosApp.UI
{
    partial class FormUserDashBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ibiSHead = new System.Windows.Forms.Label();
            this.ibiLastName = new System.Windows.Forms.Label();
            this.ibiAppFName = new System.Windows.Forms.Label();
            this.loggedInUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesFormsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripTop";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesFormsToolStripMenuItem
            // 
            this.salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            this.salesFormsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesFormsToolStripMenuItem.Text = "Sales";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelFooter.Controls.Add(this.label4);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 402);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(982, 48);
            this.panelFooter.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(539, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Developed By: Ntwali patrick";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // ibiSHead
            // 
            this.ibiSHead.AutoSize = true;
            this.ibiSHead.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiSHead.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ibiSHead.Location = new System.Drawing.Point(534, 332);
            this.ibiSHead.Name = "ibiSHead";
            this.ibiSHead.Size = new System.Drawing.Size(239, 25);
            this.ibiSHead.TabIndex = 21;
            this.ibiSHead.Text = "Point of Sale Management ";
            // 
            // ibiLastName
            // 
            this.ibiLastName.BackColor = System.Drawing.Color.Transparent;
            this.ibiLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.ibiLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibiLastName.Location = new System.Drawing.Point(622, 293);
            this.ibiLastName.Name = "ibiLastName";
            this.ibiLastName.Size = new System.Drawing.Size(151, 53);
            this.ibiLastName.TabIndex = 20;
            this.ibiLastName.Text = "System";
            // 
            // ibiAppFName
            // 
            this.ibiAppFName.BackColor = System.Drawing.Color.Transparent;
            this.ibiAppFName.Cursor = System.Windows.Forms.Cursors.Default;
            this.ibiAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiAppFName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibiAppFName.Location = new System.Drawing.Point(565, 293);
            this.ibiAppFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ibiAppFName.Name = "ibiAppFName";
            this.ibiAppFName.Size = new System.Drawing.Size(104, 53);
            this.ibiAppFName.TabIndex = 19;
            this.ibiAppFName.Text = "POS\r\n\r\n";
            // 
            // loggedInUser
            // 
            this.loggedInUser.AutoSize = true;
            this.loggedInUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.loggedInUser.Location = new System.Drawing.Point(45, 24);
            this.loggedInUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedInUser.Name = "loggedInUser";
            this.loggedInUser.Size = new System.Drawing.Size(0, 17);
            this.loggedInUser.TabIndex = 18;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(13, 24);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 17);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "user:";
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.DealerAndCustomerToolStripMenuItem_Click);
            // 
            // FormUserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.ibiSHead);
            this.Controls.Add(this.ibiLastName);
            this.Controls.Add(this.ibiAppFName);
            this.Controls.Add(this.loggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUserDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUserDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.FormUserDashBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ibiSHead;
        private System.Windows.Forms.Label ibiLastName;
        private System.Windows.Forms.Label ibiAppFName;
        private System.Windows.Forms.Label loggedInUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}