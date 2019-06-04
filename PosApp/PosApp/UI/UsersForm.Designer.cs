namespace PosApp.UI
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.ibilabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contacTextBox = new System.Windows.Forms.TextBox();
            this.ibiContact = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ibiAdress = new System.Windows.Forms.Label();
            this.ibiPassword = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ibiUserName = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.ibiEmail = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ibiGender = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ibiUserType = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.ibiUserId = new System.Windows.Forms.Label();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ibiSearch = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(835, 35);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(801, 0);
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
            this.ibilabel.Location = new System.Drawing.Point(379, 3);
            this.ibilabel.Name = "ibilabel";
            this.ibilabel.Size = new System.Drawing.Size(49, 21);
            this.ibilabel.TabIndex = 0;
            this.ibilabel.Text = "Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(92, 88);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(187, 25);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(92, 119);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(187, 25);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // contacTextBox
            // 
            this.contacTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contacTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacTextBox.Location = new System.Drawing.Point(92, 243);
            this.contacTextBox.Name = "contacTextBox";
            this.contacTextBox.Size = new System.Drawing.Size(187, 25);
            this.contacTextBox.TabIndex = 12;
            // 
            // ibiContact
            // 
            this.ibiContact.AutoSize = true;
            this.ibiContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiContact.Location = new System.Drawing.Point(27, 245);
            this.ibiContact.Name = "ibiContact";
            this.ibiContact.Size = new System.Drawing.Size(53, 17);
            this.ibiContact.TabIndex = 11;
            this.ibiContact.Text = "contact:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(92, 274);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(187, 69);
            this.addressTextBox.TabIndex = 14;
            // 
            // ibiAdress
            // 
            this.ibiAdress.AutoSize = true;
            this.ibiAdress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiAdress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiAdress.Location = new System.Drawing.Point(22, 276);
            this.ibiAdress.Name = "ibiAdress";
            this.ibiAdress.Size = new System.Drawing.Size(58, 17);
            this.ibiAdress.TabIndex = 13;
            this.ibiAdress.Text = "address:";
            // 
            // ibiPassword
            // 
            this.ibiPassword.AutoSize = true;
            this.ibiPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiPassword.Location = new System.Drawing.Point(12, 214);
            this.ibiPassword.Name = "ibiPassword";
            this.ibiPassword.Size = new System.Drawing.Size(68, 17);
            this.ibiPassword.TabIndex = 9;
            this.ibiPassword.Text = "password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(92, 212);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(187, 25);
            this.passwordTextBox.TabIndex = 10;
            // 
            // ibiUserName
            // 
            this.ibiUserName.AutoSize = true;
            this.ibiUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiUserName.Location = new System.Drawing.Point(12, 183);
            this.ibiUserName.Name = "ibiUserName";
            this.ibiUserName.Size = new System.Drawing.Size(73, 17);
            this.ibiUserName.TabIndex = 7;
            this.ibiUserName.Text = "UserName:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(92, 181);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(187, 25);
            this.userNameTextBox.TabIndex = 8;
            // 
            // ibiEmail
            // 
            this.ibiEmail.AutoSize = true;
            this.ibiEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiEmail.Location = new System.Drawing.Point(43, 152);
            this.ibiEmail.Name = "ibiEmail";
            this.ibiEmail.Size = new System.Drawing.Size(42, 17);
            this.ibiEmail.TabIndex = 5;
            this.ibiEmail.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(92, 150);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(187, 25);
            this.EmailTextBox.TabIndex = 6;
            // 
            // ibiGender
            // 
            this.ibiGender.AutoSize = true;
            this.ibiGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiGender.Location = new System.Drawing.Point(22, 349);
            this.ibiGender.Name = "ibiGender";
            this.ibiGender.Size = new System.Drawing.Size(54, 17);
            this.ibiGender.TabIndex = 15;
            this.ibiGender.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "No Specified"});
            this.genderComboBox.Location = new System.Drawing.Point(92, 349);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 25);
            this.genderComboBox.TabIndex = 16;
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.userTypeComboBox.Location = new System.Drawing.Point(92, 380);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(121, 25);
            this.userTypeComboBox.TabIndex = 18;
            // 
            // ibiUserType
            // 
            this.ibiUserType.AutoSize = true;
            this.ibiUserType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiUserType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiUserType.Location = new System.Drawing.Point(22, 380);
            this.ibiUserType.Name = "ibiUserType";
            this.ibiUserType.Size = new System.Drawing.Size(69, 17);
            this.ibiUserType.TabIndex = 17;
            this.ibiUserType.Text = "User Type:";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdTextBox.Location = new System.Drawing.Point(92, 57);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.ReadOnly = true;
            this.UserIdTextBox.Size = new System.Drawing.Size(187, 25);
            this.UserIdTextBox.TabIndex = 20;
            // 
            // ibiUserId
            // 
            this.ibiUserId.AutoSize = true;
            this.ibiUserId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiUserId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiUserId.Location = new System.Drawing.Point(26, 59);
            this.ibiUserId.Name = "ibiUserId";
            this.ibiUserId.Size = new System.Drawing.Size(54, 17);
            this.ibiUserId.TabIndex = 19;
            this.ibiUserId.Text = "User ID:";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersDataGridView.Location = new System.Drawing.Point(285, 90);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.usersDataGridView.Size = new System.Drawing.Size(538, 307);
            this.usersDataGridView.TabIndex = 21;
            this.usersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellContentClick);
            this.usersDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersDataGridView_RowHeaderMouseClick);
            this.usersDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsersDataGridView_MouseClick);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(370, 57);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(418, 25);
            this.SearchTextBox.TabIndex = 23;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ibiSearch
            // 
            this.ibiSearch.AutoSize = true;
            this.ibiSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiSearch.Location = new System.Drawing.Point(304, 59);
            this.ibiSearch.Name = "ibiSearch";
            this.ibiSearch.Size = new System.Drawing.Size(46, 17);
            this.ibiSearch.TabIndex = 22;
            this.ibiSearch.Text = "search";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(92, 430);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 36);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(219, 430);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(121, 36);
            this.updateButton.TabIndex = 25;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(346, 430);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 36);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(835, 478);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ibiSearch);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.ibiUserId);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(this.ibiUserType);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.ibiGender);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.ibiAdress);
            this.Controls.Add(this.contacTextBox);
            this.Controls.Add(this.ibiContact);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.ibiPassword);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.ibiUserName);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ibiEmail);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ibilabel;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contacTextBox;
        private System.Windows.Forms.Label ibiContact;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label ibiAdress;
        private System.Windows.Forms.Label ibiPassword;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label ibiUserName;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label ibiEmail;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label ibiGender;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.Label ibiUserType;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label ibiUserId;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label ibiSearch;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
    }
}