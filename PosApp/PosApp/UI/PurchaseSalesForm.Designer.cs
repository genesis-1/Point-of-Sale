namespace PosApp.UI
{
    partial class PurchaseSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseSalesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.purchaseAndSalesLabel = new System.Windows.Forms.Label();
            this.dealerCustomerpanel = new System.Windows.Forms.Panel();
            this.billLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.dealerCustomerlabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.ProductNametextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.qtytextBox = new System.Windows.Forms.TextBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.ratetextBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.InvertorytextBox = new System.Windows.Forms.TextBox();
            this.InvetoryLabel = new System.Windows.Forms.Label();
            this.addedProductpanel = new System.Windows.Forms.Panel();
            this.addedProductslabel = new System.Windows.Forms.Label();
            this.transactionDataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.ReturnAmountTextBox = new System.Windows.Forms.TextBox();
            this.PaidAmountTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.VatTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.returnAmountLabel = new System.Windows.Forms.Label();
            this.paidAmountlabel = new System.Windows.Forms.Label();
            this.grandLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.Calculationlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.dealerCustomerpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.addedProductpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.purchaseAndSalesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 35);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1226, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 32);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            // 
            // purchaseAndSalesLabel
            // 
            this.purchaseAndSalesLabel.AutoSize = true;
            this.purchaseAndSalesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseAndSalesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchaseAndSalesLabel.Location = new System.Drawing.Point(505, 9);
            this.purchaseAndSalesLabel.Name = "purchaseAndSalesLabel";
            this.purchaseAndSalesLabel.Size = new System.Drawing.Size(211, 25);
            this.purchaseAndSalesLabel.TabIndex = 0;
            this.purchaseAndSalesLabel.Text = "PURCHASE AND SALES\r\n";
            // 
            // dealerCustomerpanel
            // 
            this.dealerCustomerpanel.Controls.Add(this.billLabel);
            this.dealerCustomerpanel.Controls.Add(this.addressTextBox);
            this.dealerCustomerpanel.Controls.Add(this.addressLabel);
            this.dealerCustomerpanel.Controls.Add(this.contactTextBox);
            this.dealerCustomerpanel.Controls.Add(this.EmailTextBox);
            this.dealerCustomerpanel.Controls.Add(this.contactLabel);
            this.dealerCustomerpanel.Controls.Add(this.emailLabel);
            this.dealerCustomerpanel.Controls.Add(this.nameTextBox);
            this.dealerCustomerpanel.Controls.Add(this.searchTextBox);
            this.dealerCustomerpanel.Controls.Add(this.nameLabel);
            this.dealerCustomerpanel.Controls.Add(this.searchLabel);
            this.dealerCustomerpanel.Controls.Add(this.dealerCustomerlabel);
            this.dealerCustomerpanel.Controls.Add(this.dateTimePicker1);
            this.dealerCustomerpanel.Location = new System.Drawing.Point(12, 41);
            this.dealerCustomerpanel.Name = "dealerCustomerpanel";
            this.dealerCustomerpanel.Size = new System.Drawing.Size(1233, 92);
            this.dealerCustomerpanel.TabIndex = 2;
            this.dealerCustomerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DealerCustomerpanel_Paint);
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLabel.Location = new System.Drawing.Point(952, 22);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(57, 17);
            this.billLabel.TabIndex = 13;
            this.billLabel.Text = "Bill Date";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(695, 22);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(232, 28);
            this.addressTextBox.TabIndex = 12;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(632, 22);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(57, 17);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(383, 56);
            this.contactTextBox.Multiline = true;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(232, 28);
            this.contactTextBox.TabIndex = 9;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(383, 22);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(232, 28);
            this.EmailTextBox.TabIndex = 8;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(314, 55);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(55, 17);
            this.contactLabel.TabIndex = 7;
            this.contactLabel.Text = "Contact";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(329, 19);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(40, 17);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(56, 56);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 28);
            this.nameTextBox.TabIndex = 5;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(56, 22);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(232, 28);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(2, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(2, 19);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(48, 17);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search";
            // 
            // dealerCustomerlabel
            // 
            this.dealerCustomerlabel.AutoSize = true;
            this.dealerCustomerlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCustomerlabel.Location = new System.Drawing.Point(3, 0);
            this.dealerCustomerlabel.Name = "dealerCustomerlabel";
            this.dealerCustomerlabel.Size = new System.Drawing.Size(185, 17);
            this.dealerCustomerlabel.TabIndex = 1;
            this.dealerCustomerlabel.Text = "Dealer and Customer Details\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1015, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Details\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(56, 21);
            this.productSearchTextBox.Multiline = true;
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(163, 27);
            this.productSearchTextBox.TabIndex = 6;
            this.productSearchTextBox.TextChanged += new System.EventHandler(this.ProductSearchTextBox_TextChanged);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(224, 21);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(44, 17);
            this.productNameLabel.TabIndex = 7;
            this.productNameLabel.Text = "Name";
            // 
            // ProductNametextBox
            // 
            this.ProductNametextBox.Location = new System.Drawing.Point(274, 21);
            this.ProductNametextBox.Multiline = true;
            this.ProductNametextBox.Name = "ProductNametextBox";
            this.ProductNametextBox.Size = new System.Drawing.Size(179, 27);
            this.ProductNametextBox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.qtytextBox);
            this.panel2.Controls.Add(this.qtyLabel);
            this.panel2.Controls.Add(this.ratetextBox);
            this.panel2.Controls.Add(this.rateLabel);
            this.panel2.Controls.Add(this.InvertorytextBox);
            this.panel2.Controls.Add(this.InvetoryLabel);
            this.panel2.Controls.Add(this.ProductNametextBox);
            this.panel2.Controls.Add(this.productNameLabel);
            this.panel2.Controls.Add(this.productSearchTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 61);
            this.panel2.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(1152, 21);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(78, 27);
            this.AddButton.TabIndex = 47;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // qtytextBox
            // 
            this.qtytextBox.Location = new System.Drawing.Point(967, 21);
            this.qtytextBox.Multiline = true;
            this.qtytextBox.Name = "qtytextBox";
            this.qtytextBox.Size = new System.Drawing.Size(179, 27);
            this.qtytextBox.TabIndex = 14;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(933, 21);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(28, 17);
            this.qtyLabel.TabIndex = 13;
            this.qtyLabel.Text = "qty";
            // 
            // ratetextBox
            // 
            this.ratetextBox.Location = new System.Drawing.Point(748, 21);
            this.ratetextBox.Multiline = true;
            this.ratetextBox.Name = "ratetextBox";
            this.ratetextBox.Size = new System.Drawing.Size(179, 27);
            this.ratetextBox.TabIndex = 12;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(710, 18);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(32, 17);
            this.rateLabel.TabIndex = 11;
            this.rateLabel.Text = "rate";
            // 
            // InvertorytextBox
            // 
            this.InvertorytextBox.Location = new System.Drawing.Point(525, 18);
            this.InvertorytextBox.Multiline = true;
            this.InvertorytextBox.Name = "InvertorytextBox";
            this.InvertorytextBox.Size = new System.Drawing.Size(179, 27);
            this.InvertorytextBox.TabIndex = 10;
            // 
            // InvetoryLabel
            // 
            this.InvetoryLabel.AutoSize = true;
            this.InvetoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvetoryLabel.Location = new System.Drawing.Point(459, 18);
            this.InvetoryLabel.Name = "InvetoryLabel";
            this.InvetoryLabel.Size = new System.Drawing.Size(60, 17);
            this.InvetoryLabel.TabIndex = 9;
            this.InvetoryLabel.Text = "Invetory";
            // 
            // addedProductpanel
            // 
            this.addedProductpanel.Controls.Add(this.addedProductslabel);
            this.addedProductpanel.Controls.Add(this.transactionDataGridView1);
            this.addedProductpanel.Location = new System.Drawing.Point(13, 242);
            this.addedProductpanel.Name = "addedProductpanel";
            this.addedProductpanel.Size = new System.Drawing.Size(614, 262);
            this.addedProductpanel.TabIndex = 4;
            // 
            // addedProductslabel
            // 
            this.addedProductslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedProductslabel.Location = new System.Drawing.Point(14, 0);
            this.addedProductslabel.Name = "addedProductslabel";
            this.addedProductslabel.Size = new System.Drawing.Size(106, 17);
            this.addedProductslabel.TabIndex = 3;
            this.addedProductslabel.Text = "Added Products\r\n\r\n";
            // 
            // transactionDataGridView1
            // 
            this.transactionDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView1.Location = new System.Drawing.Point(5, 30);
            this.transactionDataGridView1.Name = "transactionDataGridView1";
            this.transactionDataGridView1.Size = new System.Drawing.Size(606, 229);
            this.transactionDataGridView1.TabIndex = 0;
            this.transactionDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Controls.Add(this.ReturnAmountTextBox);
            this.panel4.Controls.Add(this.PaidAmountTextBox);
            this.panel4.Controls.Add(this.grandTotalTextBox);
            this.panel4.Controls.Add(this.VatTextBox);
            this.panel4.Controls.Add(this.discountTextBox);
            this.panel4.Controls.Add(this.subTotalTextBox);
            this.panel4.Controls.Add(this.returnAmountLabel);
            this.panel4.Controls.Add(this.paidAmountlabel);
            this.panel4.Controls.Add(this.grandLabel);
            this.panel4.Controls.Add(this.vatLabel);
            this.panel4.Controls.Add(this.discountLabel);
            this.panel4.Controls.Add(this.SubTotalLabel);
            this.panel4.Controls.Add(this.Calculationlabel);
            this.panel4.Location = new System.Drawing.Point(647, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 262);
            this.panel4.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(98)))), ((int)(((byte)(7)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(405, 196);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 51);
            this.saveButton.TabIndex = 48;
            this.saveButton.Text = "&SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReturnAmountTextBox
            // 
            this.ReturnAmountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnAmountTextBox.ForeColor = System.Drawing.Color.DarkRed;
            this.ReturnAmountTextBox.Location = new System.Drawing.Point(125, 206);
            this.ReturnAmountTextBox.Multiline = true;
            this.ReturnAmountTextBox.Name = "ReturnAmountTextBox";
            this.ReturnAmountTextBox.ReadOnly = true;
            this.ReturnAmountTextBox.Size = new System.Drawing.Size(249, 41);
            this.ReturnAmountTextBox.TabIndex = 19;
            this.ReturnAmountTextBox.TextChanged += new System.EventHandler(this.ReturnAmountTextBox_TextChanged);
            // 
            // PaidAmountTextBox
            // 
            this.PaidAmountTextBox.Location = new System.Drawing.Point(125, 171);
            this.PaidAmountTextBox.Multiline = true;
            this.PaidAmountTextBox.Name = "PaidAmountTextBox";
            this.PaidAmountTextBox.Size = new System.Drawing.Size(249, 27);
            this.PaidAmountTextBox.TabIndex = 18;
            this.PaidAmountTextBox.TextChanged += new System.EventHandler(this.PaidAmountTextBox_TextChanged);
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(125, 138);
            this.grandTotalTextBox.Multiline = true;
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.ReadOnly = true;
            this.grandTotalTextBox.Size = new System.Drawing.Size(249, 27);
            this.grandTotalTextBox.TabIndex = 17;
            // 
            // VatTextBox
            // 
            this.VatTextBox.Location = new System.Drawing.Point(125, 105);
            this.VatTextBox.Multiline = true;
            this.VatTextBox.Name = "VatTextBox";
            this.VatTextBox.Size = new System.Drawing.Size(249, 27);
            this.VatTextBox.TabIndex = 16;
            this.VatTextBox.TextChanged += new System.EventHandler(this.VatTextBox_TextChanged);
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(125, 71);
            this.discountTextBox.Multiline = true;
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(249, 27);
            this.discountTextBox.TabIndex = 15;
            this.discountTextBox.TextChanged += new System.EventHandler(this.DiscountTextBox_TextChanged);
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(125, 31);
            this.subTotalTextBox.Multiline = true;
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(249, 27);
            this.subTotalTextBox.TabIndex = 14;
            this.subTotalTextBox.Text = "0\r\n";
            // 
            // returnAmountLabel
            // 
            this.returnAmountLabel.AutoSize = true;
            this.returnAmountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnAmountLabel.Location = new System.Drawing.Point(16, 216);
            this.returnAmountLabel.Name = "returnAmountLabel";
            this.returnAmountLabel.Size = new System.Drawing.Size(103, 17);
            this.returnAmountLabel.TabIndex = 13;
            this.returnAmountLabel.Text = "Return Amount";
            // 
            // paidAmountlabel
            // 
            this.paidAmountlabel.AutoSize = true;
            this.paidAmountlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmountlabel.Location = new System.Drawing.Point(16, 181);
            this.paidAmountlabel.Name = "paidAmountlabel";
            this.paidAmountlabel.Size = new System.Drawing.Size(88, 17);
            this.paidAmountlabel.TabIndex = 12;
            this.paidAmountlabel.Text = "Paid Amount";
            // 
            // grandLabel
            // 
            this.grandLabel.AutoSize = true;
            this.grandLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandLabel.Location = new System.Drawing.Point(16, 143);
            this.grandLabel.Name = "grandLabel";
            this.grandLabel.Size = new System.Drawing.Size(78, 17);
            this.grandLabel.TabIndex = 11;
            this.grandLabel.Text = "Grand Total";
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatLabel.Location = new System.Drawing.Point(16, 105);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(53, 17);
            this.vatLabel.TabIndex = 10;
            this.vatLabel.Text = "VAT (%)";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(16, 71);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(84, 17);
            this.discountLabel.TabIndex = 9;
            this.discountLabel.Text = "Discount (%)\r\n";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(16, 41);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(64, 17);
            this.SubTotalLabel.TabIndex = 8;
            this.SubTotalLabel.Text = "Sub Total";
            // 
            // Calculationlabel
            // 
            this.Calculationlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculationlabel.Location = new System.Drawing.Point(14, 0);
            this.Calculationlabel.Name = "Calculationlabel";
            this.Calculationlabel.Size = new System.Drawing.Size(129, 17);
            this.Calculationlabel.TabIndex = 4;
            this.Calculationlabel.Text = "Calculation Details\r\n\r\n\r\n";
            // 
            // PurchaseSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1257, 516);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.addedProductpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dealerCustomerpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase and Sales";
            this.Load += new System.EventHandler(this.PurchaseSalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.dealerCustomerpanel.ResumeLayout(false);
            this.dealerCustomerpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.addedProductpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label purchaseAndSalesLabel;
        private System.Windows.Forms.Panel dealerCustomerpanel;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label dealerCustomerlabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox ProductNametextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox qtytextBox;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.TextBox ratetextBox;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox InvertorytextBox;
        private System.Windows.Forms.Label InvetoryLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel addedProductpanel;
        private System.Windows.Forms.Label addedProductslabel;
        private System.Windows.Forms.DataGridView transactionDataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ReturnAmountTextBox;
        private System.Windows.Forms.TextBox PaidAmountTextBox;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.TextBox VatTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label returnAmountLabel;
        private System.Windows.Forms.Label paidAmountlabel;
        private System.Windows.Forms.Label grandLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label Calculationlabel;
        private System.Windows.Forms.Button saveButton;
    }
}