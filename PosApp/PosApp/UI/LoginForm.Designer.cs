namespace PosApp.Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TryAgainLabel = new System.Windows.Forms.Label();
            this.designButton = new System.Windows.Forms.Button();
            this.logginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userCheckBox = new System.Windows.Forms.CheckBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(570, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "System Login";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.adminCheckBox);
            this.groupBox1.Controls.Add(this.userCheckBox);
            this.groupBox1.Controls.Add(this.TryAgainLabel);
            this.groupBox1.Controls.Add(this.designButton);
            this.groupBox1.Controls.Add(this.logginButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(505, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 249);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // TryAgainLabel
            // 
            this.TryAgainLabel.BackColor = System.Drawing.Color.Transparent;
            this.TryAgainLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TryAgainLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TryAgainLabel.ForeColor = System.Drawing.Color.Red;
            this.TryAgainLabel.Location = new System.Drawing.Point(25, 208);
            this.TryAgainLabel.Name = "TryAgainLabel";
            this.TryAgainLabel.Size = new System.Drawing.Size(124, 23);
            this.TryAgainLabel.TabIndex = 15;
            this.TryAgainLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // designButton
            // 
            this.designButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.designButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.designButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.designButton.Location = new System.Drawing.Point(313, 195);
            this.designButton.Name = "designButton";
            this.designButton.Size = new System.Drawing.Size(97, 36);
            this.designButton.TabIndex = 14;
            this.designButton.Text = "&Exit";
            this.designButton.UseVisualStyleBackColor = false;
            this.designButton.Click += new System.EventHandler(this.DesignButton_Click);
            // 
            // logginButton
            // 
            this.logginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logginButton.Location = new System.Drawing.Point(190, 195);
            this.logginButton.Name = "logginButton";
            this.logginButton.Size = new System.Drawing.Size(97, 36);
            this.logginButton.TabIndex = 13;
            this.logginButton.Text = "&Login";
            this.logginButton.UseVisualStyleBackColor = false;
            this.logginButton.Click += new System.EventHandler(this.LogginButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(60, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "User Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(60, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(190, 110);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 22);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(190, 52);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(220, 22);
            this.userNameTextBox.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // userCheckBox
            // 
            this.userCheckBox.AutoSize = true;
            this.userCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCheckBox.Location = new System.Drawing.Point(358, 150);
            this.userCheckBox.Name = "userCheckBox";
            this.userCheckBox.Size = new System.Drawing.Size(53, 21);
            this.userCheckBox.TabIndex = 16;
            this.userCheckBox.Text = "user";
            this.userCheckBox.UseVisualStyleBackColor = true;
            this.userCheckBox.CheckedChanged += new System.EventHandler(this.UserCheckBox_CheckedChanged);
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCheckBox.Location = new System.Drawing.Point(288, 150);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(67, 21);
            this.adminCheckBox.TabIndex = 17;
            this.adminCheckBox.Text = "Admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            this.adminCheckBox.CheckedChanged += new System.EventHandler(this.AdminCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button designButton;
        private System.Windows.Forms.Button logginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TryAgainLabel;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.CheckBox userCheckBox;
    }
}