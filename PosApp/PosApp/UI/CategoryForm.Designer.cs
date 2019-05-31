namespace PosApp.UI
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.ibilabel = new System.Windows.Forms.Label();
            this.categoryIdTextBox = new System.Windows.Forms.TextBox();
            this.categoryIdLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryDescriptionlabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryTitlelabel = new System.Windows.Forms.Label();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ibiSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(819, 35);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(788, 0);
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
            this.ibilabel.Location = new System.Drawing.Point(364, 9);
            this.ibilabel.Name = "ibilabel";
            this.ibilabel.Size = new System.Drawing.Size(84, 21);
            this.ibilabel.TabIndex = 0;
            this.ibilabel.Text = "Categories";
            // 
            // categoryIdTextBox
            // 
            this.categoryIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIdTextBox.Location = new System.Drawing.Point(91, 82);
            this.categoryIdTextBox.Name = "categoryIdTextBox";
            this.categoryIdTextBox.ReadOnly = true;
            this.categoryIdTextBox.Size = new System.Drawing.Size(223, 25);
            this.categoryIdTextBox.TabIndex = 26;
            // 
            // categoryIdLabel
            // 
            this.categoryIdLabel.AutoSize = true;
            this.categoryIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryIdLabel.Location = new System.Drawing.Point(5, 84);
            this.categoryIdLabel.Name = "categoryIdLabel";
            this.categoryIdLabel.Size = new System.Drawing.Size(80, 17);
            this.categoryIdLabel.TabIndex = 25;
            this.categoryIdLabel.Text = " CategoryID:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(91, 144);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(223, 121);
            this.descriptionTextBox.TabIndex = 24;
            // 
            // categoryDescriptionlabel
            // 
            this.categoryDescriptionlabel.AutoSize = true;
            this.categoryDescriptionlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDescriptionlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryDescriptionlabel.Location = new System.Drawing.Point(5, 146);
            this.categoryDescriptionlabel.Name = "categoryDescriptionlabel";
            this.categoryDescriptionlabel.Size = new System.Drawing.Size(77, 17);
            this.categoryDescriptionlabel.TabIndex = 23;
            this.categoryDescriptionlabel.Text = "Description:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(91, 113);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(223, 25);
            this.titleTextBox.TabIndex = 22;
            // 
            // categoryTitlelabel
            // 
            this.categoryTitlelabel.AutoSize = true;
            this.categoryTitlelabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTitlelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryTitlelabel.Location = new System.Drawing.Point(43, 113);
            this.categoryTitlelabel.Name = "categoryTitlelabel";
            this.categoryTitlelabel.Size = new System.Drawing.Size(35, 17);
            this.categoryTitlelabel.TabIndex = 21;
            this.categoryTitlelabel.Text = "Title:";
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryDataGridView.Location = new System.Drawing.Point(320, 113);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.categoryDataGridView.Size = new System.Drawing.Size(468, 228);
            this.categoryDataGridView.TabIndex = 27;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(247, 369);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 36);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(149, 369);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(92, 36);
            this.updateButton.TabIndex = 29;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(44, 369);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 36);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(385, 82);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(265, 25);
            this.SearchTextBox.TabIndex = 32;
            // 
            // ibiSearch
            // 
            this.ibiSearch.AutoSize = true;
            this.ibiSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiSearch.Location = new System.Drawing.Point(333, 84);
            this.ibiSearch.Name = "ibiSearch";
            this.ibiSearch.Size = new System.Drawing.Size(46, 17);
            this.ibiSearch.TabIndex = 31;
            this.ibiSearch.Text = "search";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(819, 439);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ibiSearch);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.categoryIdTextBox);
            this.Controls.Add(this.categoryIdLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.categoryDescriptionlabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.categoryTitlelabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label ibilabel;
        private System.Windows.Forms.TextBox categoryIdTextBox;
        private System.Windows.Forms.Label categoryIdLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label categoryDescriptionlabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label categoryTitlelabel;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label ibiSearch;
    }
}