namespace PosApp.UI
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.ibilabel = new System.Windows.Forms.Label();
            this.InvetoryDataGridView = new System.Windows.Forms.DataGridView();
            this.allProductsButton = new System.Windows.Forms.Button();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvetoryDataGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(918, 35);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(884, 0);
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
            this.ibilabel.Location = new System.Drawing.Point(427, 9);
            this.ibilabel.Name = "ibilabel";
            this.ibilabel.Size = new System.Drawing.Size(76, 21);
            this.ibilabel.TabIndex = 0;
            this.ibilabel.Text = "Inventory";
            // 
            // InvetoryDataGridView
            // 
            this.InvetoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvetoryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InvetoryDataGridView.Location = new System.Drawing.Point(8, 105);
            this.InvetoryDataGridView.Name = "InvetoryDataGridView";
            this.InvetoryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.InvetoryDataGridView.Size = new System.Drawing.Size(898, 333);
            this.InvetoryDataGridView.TabIndex = 3;
            // 
            // allProductsButton
            // 
            this.allProductsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.allProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allProductsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProductsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allProductsButton.Location = new System.Drawing.Point(363, 60);
            this.allProductsButton.Name = "allProductsButton";
            this.allProductsButton.Size = new System.Drawing.Size(137, 34);
            this.allProductsButton.TabIndex = 32;
            this.allProductsButton.Text = "&Show All";
            this.allProductsButton.UseVisualStyleBackColor = false;
            this.allProductsButton.Click += new System.EventHandler(this.AllProductsButton_Click);
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Items.AddRange(new object[] {
            "Sales",
            "Purchase"});
            this.productTypeComboBox.Location = new System.Drawing.Point(81, 68);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(250, 21);
            this.productTypeComboBox.TabIndex = 31;
            this.productTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Category";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.allProductsButton);
            this.Controls.Add(this.productTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvetoryDataGridView);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvetoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label ibilabel;
        private System.Windows.Forms.DataGridView InvetoryDataGridView;
        private System.Windows.Forms.Button allProductsButton;
        private System.Windows.Forms.ComboBox productTypeComboBox;
        private System.Windows.Forms.Label label2;
    }
}