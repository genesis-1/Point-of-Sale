namespace PosApp.UI
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.ibilabel = new System.Windows.Forms.Label();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.categorylabel1 = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ibiSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(803, 35);
            this.panel1.TabIndex = 2;
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
            this.ibilabel.Location = new System.Drawing.Point(364, 9);
            this.ibilabel.Name = "ibilabel";
            this.ibilabel.Size = new System.Drawing.Size(71, 21);
            this.ibilabel.TabIndex = 0;
            this.ibilabel.Text = "Products";
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productIdLabel.Location = new System.Drawing.Point(4, 62);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(73, 17);
            this.productIdLabel.TabIndex = 26;
            this.productIdLabel.Text = " Product ID";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productName.Location = new System.Drawing.Point(3, 95);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(43, 17);
            this.productName.TabIndex = 27;
            this.productName.Text = "Name";
            // 
            // categorylabel1
            // 
            this.categorylabel1.AutoSize = true;
            this.categorylabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categorylabel1.Location = new System.Drawing.Point(3, 132);
            this.categorylabel1.Name = "categorylabel1";
            this.categorylabel1.Size = new System.Drawing.Size(61, 17);
            this.categorylabel1.TabIndex = 28;
            this.categorylabel1.Text = "Category";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descriptionlabel.Location = new System.Drawing.Point(3, 174);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(74, 17);
            this.descriptionlabel.TabIndex = 29;
            this.descriptionlabel.Text = "Description";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rateLabel.Location = new System.Drawing.Point(3, 295);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(31, 17);
            this.rateLabel.TabIndex = 30;
            this.rateLabel.Text = "rate";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBox.Location = new System.Drawing.Point(112, 62);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(223, 25);
            this.productIdTextBox.TabIndex = 31;
            this.productIdTextBox.TextChanged += new System.EventHandler(this.ProductIdTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(112, 95);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(223, 25);
            this.nameTextBox.TabIndex = 32;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(112, 132);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 33;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(112, 174);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(223, 108);
            this.descriptionTextBox.TabIndex = 34;
            // 
            // rateTextBox
            // 
            this.rateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.Location = new System.Drawing.Point(112, 293);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(223, 25);
            this.rateTextBox.TabIndex = 35;
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(352, 98);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(439, 220);
            this.productDataGridView.TabIndex = 36;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellContentClick);
            this.productDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductDataGridView_RowHeaderMouseClick);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(450, 343);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 36);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(352, 343);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(92, 36);
            this.updateButton.TabIndex = 38;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(112, 343);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 36);
            this.AddButton.TabIndex = 37;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(405, 62);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(265, 25);
            this.SearchTextBox.TabIndex = 41;
            // 
            // ibiSearch
            // 
            this.ibiSearch.AutoSize = true;
            this.ibiSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibiSearch.Location = new System.Drawing.Point(353, 64);
            this.ibiSearch.Name = "ibiSearch";
            this.ibiSearch.Size = new System.Drawing.Size(46, 17);
            this.ibiSearch.TabIndex = 40;
            this.ibiSearch.Text = "search";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(803, 400);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ibiSearch);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.descriptionlabel);
            this.Controls.Add(this.categorylabel1);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label ibilabel;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label categorylabel1;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label ibiSearch;
    }
}