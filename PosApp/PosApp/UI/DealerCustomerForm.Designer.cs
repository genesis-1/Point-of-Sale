namespace PosApp.UI
{
    partial class DealerCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DealerCustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.ibilabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.DealerCustIdTextBox = new System.Windows.Forms.TextBox();
            this.typelabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.dealerCustIdLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.Contactlabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.ibilabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 35);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(772, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 32);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            // 
            // ibilabel
            // 
            this.ibilabel.AutoSize = true;
            this.ibilabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibilabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibilabel.Location = new System.Drawing.Point(314, 9);
            this.ibilabel.Name = "ibilabel";
            this.ibilabel.Size = new System.Drawing.Size(157, 21);
            this.ibilabel.TabIndex = 0;
            this.ibilabel.Text = "Dealer and Customer";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.TypeComboBox.Location = new System.Drawing.Point(121, 81);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 39;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(120, 109);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(223, 25);
            this.nameTextBox.TabIndex = 38;
            // 
            // DealerCustIdTextBox
            // 
            this.DealerCustIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DealerCustIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerCustIdTextBox.Location = new System.Drawing.Point(120, 51);
            this.DealerCustIdTextBox.Name = "DealerCustIdTextBox";
            this.DealerCustIdTextBox.ReadOnly = true;
            this.DealerCustIdTextBox.Size = new System.Drawing.Size(223, 25);
            this.DealerCustIdTextBox.TabIndex = 37;
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.typelabel.Location = new System.Drawing.Point(12, 81);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(61, 17);
            this.typelabel.TabIndex = 36;
            this.typelabel.Text = "Category";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productName.Location = new System.Drawing.Point(12, 109);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(43, 17);
            this.productName.TabIndex = 35;
            this.productName.Text = "Name";
            // 
            // dealerCustIdLabel
            // 
            this.dealerCustIdLabel.AutoSize = true;
            this.dealerCustIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCustIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dealerCustIdLabel.Location = new System.Drawing.Point(12, 51);
            this.dealerCustIdLabel.Name = "dealerCustIdLabel";
            this.dealerCustIdLabel.Size = new System.Drawing.Size(79, 17);
            this.dealerCustIdLabel.TabIndex = 34;
            this.dealerCustIdLabel.Text = " DealCust ID";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(120, 140);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(223, 25);
            this.emailTextBox.TabIndex = 41;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLabel.Location = new System.Drawing.Point(12, 140);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 17);
            this.emailLabel.TabIndex = 40;
            this.emailLabel.Text = "Email";
            // 
            // contactTextBox
            // 
            this.contactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.Location = new System.Drawing.Point(121, 171);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(223, 25);
            this.contactTextBox.TabIndex = 43;
            // 
            // Contactlabel
            // 
            this.Contactlabel.AutoSize = true;
            this.Contactlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contactlabel.Location = new System.Drawing.Point(13, 171);
            this.Contactlabel.Name = "Contactlabel";
            this.Contactlabel.Size = new System.Drawing.Size(52, 17);
            this.Contactlabel.TabIndex = 42;
            this.Contactlabel.Text = "Contact";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(120, 202);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(223, 97);
            this.addressTextBox.TabIndex = 45;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Address.Location = new System.Drawing.Point(12, 202);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 17);
            this.Address.TabIndex = 44;
            this.Address.Text = "AddressTextBox";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(374, 337);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 36);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(247, 337);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(121, 36);
            this.updateButton.TabIndex = 47;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(120, 337);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 36);
            this.AddButton.TabIndex = 46;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersDataGridView.Location = new System.Drawing.Point(350, 81);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.usersDataGridView.Size = new System.Drawing.Size(442, 218);
            this.usersDataGridView.TabIndex = 49;
            this.usersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellContentClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(424, 49);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.ReadOnly = true;
            this.searchTextBox.Size = new System.Drawing.Size(327, 25);
            this.searchTextBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(371, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Search";
            // 
            // DealerCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(804, 385);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.Contactlabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.DealerCustIdTextBox);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.dealerCustIdLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DealerCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DealerCustomerForm";
            this.Load += new System.EventHandler(this.DealerCustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label ibilabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox DealerCustIdTextBox;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label dealerCustIdLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label Contactlabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
    }
}