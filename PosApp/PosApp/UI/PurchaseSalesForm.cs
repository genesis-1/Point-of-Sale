using DGVPrinterHelper;
using PosApp.Bussiness;
using PosApp.DAL;
using PosApp.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace PosApp.UI
{
    public partial class PurchaseSalesForm : Form
    {
        public PurchaseSalesForm()
        {
            InitializeComponent();
        }
        
        DealerCustomerDal dealerCustomerDal = new DealerCustomerDal();
        ProductDal productDal = new ProductDal();
        DataTable transactionDataTable = new DataTable();
        UserDal user = new UserDal();
        TransactionDal transactionDal = new TransactionDal();
        TransactionDetailDal transactionDetailDal = new TransactionDetailDal();

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String keyWord = searchTextBox.Text;
            if (keyWord == "")
            {
                //clear the text boxes
                nameTextBox.Text = "";
                EmailTextBox.Text = "";
                contactTextBox.Text = "";
                addressTextBox.Text = "";
                return;
            }
            // write the code to get the value of text boxes
            DealerAndCustomerLL dealerAndCustomerLL = dealerCustomerDal.SearchDealerCustomerForTransaction(keyWord);

            // transfer or set value from DealerCustomer object to textboxes
            nameTextBox.Text = dealerAndCustomerLL.Name;
            EmailTextBox.Text = dealerAndCustomerLL.Email;
            contactTextBox.Text = dealerAndCustomerLL.Contact;
            addressTextBox.Text = dealerAndCustomerLL.Addresss;


        }

        private void ReturnAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PurchaseSalesForm_Load(object sender, EventArgs e)
        {
            // get the values of transaction type from user Dashboard.
            string transactiontype = FormUserDashBoard.transactionType;
            purchaseAndSalesLabel.Text = transactiontype;

            // specify columns for our TransactionDataTable
            transactionDataTable.Columns.Add("Name");
            transactionDataTable.Columns.Add("Rate");
            transactionDataTable.Columns.Add("Qty");
            transactionDataTable.Columns.Add("Total");
         
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //get the keyWOrds from productSearch textbox
            string keyword = productSearchTextBox.Text;
            if (keyword == "")
            {
                ProductNametextBox.Text = "";
                InvertorytextBox.Text = "";
                ratetextBox.Text = "";
                qtytextBox.Text = "";
                return;
            }
            //search the product and display on respective textBoxes
            ProductLL productLL = productDal.GetProductLLForTransactionModule(keyword);

            //set values on textboxes
            ProductNametextBox.Text = productLL.Name;
            InvertorytextBox.Text = (productLL.qty).ToString();
            ratetextBox.Text = productLL.rate.ToString();
           

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Get product name,Rate and Quantity the customer wansts to buy
            string productName = ProductNametextBox.Text;
            decimal Rate = Math.Round(decimal.Parse(ratetextBox.Text),2);
            decimal Qty = Math.Round(decimal.Parse(qtytextBox.Text),2);

            //calculate Total
            decimal Total = Rate * Qty;

            // display the subtotal in textBox
            //get the subTotal value from textBox
            decimal subTotal = Math.Round(decimal.Parse(subTotalTextBox.Text),2);

            subTotal = subTotal + Total;

            if (productName == "")
            {
                //Display Error Message
                MessageBox.Show("Please Select the Product First.Try Again");

            }
            else
            {
                //add the product to dataGrid View
                transactionDataTable.Rows.Add(productName, Rate, Qty, Total);

                //show in datagridView
                transactionDataGridView1.DataSource = transactionDataTable;

                //Display the subTotal in textBOx
                subTotalTextBox.Text = subTotal.ToString();

                //clear the TextBOxes
                productSearchTextBox.Text = "";
                ProductNametextBox.Text = "";
                InvertorytextBox.Text = "0.00";
                ratetextBox.Text = "0.00";
                qtytextBox.Text = "0.00";

            }
        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            //get the value from discount TextBox

            // first create the value to chack the text box is empty or not
            string value = discountTextBox.Text;

            if (value =="")
            {
                // display an error message
                MessageBox.Show("Please Add Discount First");


            }
            else
            {
                //get the discount in decimal value
                decimal subtotal = Math.Round(decimal.Parse(subTotalTextBox.Text),2);
                decimal discount = Math.Round(decimal.Parse(discountTextBox.Text),2);

                //calculate the grand total based on Discount
                decimal grandTotal = ((100 - discount) / 100) * subtotal;

                //Display the GrandTotal in textBOx
                grandTotalTextBox.Text = grandTotal.ToString();

            }

        }

        private void VatTextBox_TextChanged(object sender, EventArgs e)
        {
            // check if grand total has value or not.
            string check = grandTotalTextBox.Text;
            if (check == "")
            {
                //Display the Error Message to calculate Discount
                MessageBox.Show("calculate the Discount and set the Grand Total");

            }
            else
            {
                //calculate Vat
                //getting The Vat Percent first.
                decimal previousGrandTotal = decimal.Parse(grandTotalTextBox.Text);
                decimal vat;
                decimal grandTotalWithVat;
                if (decimal.TryParse(VatTextBox.Text,out vat))
                {
                    grandTotalWithVat = ((100 + vat) / 100) * previousGrandTotal;
                    grandTotalTextBox.Text = grandTotalWithVat.ToString();
                }
                //else
                //{
                //    grandTotalTextBox.Text = "0.00";
                //}
                

                
            }
        }

        private void PaidAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal, paidAmount;

            if ((decimal.TryParse(grandTotalTextBox.Text, out grandTotal)) && (decimal.TryParse(PaidAmountTextBox.Text, out paidAmount)))
            {
                decimal returnAmount = paidAmount - grandTotal;
                Math.Round(returnAmount, 2);
                ReturnAmountTextBox.Text = returnAmount.ToString();
            }
            //else
            //{
            //    grandTotalTextBox.Text = "0.00";
            //    PaidAmountTextBox.Text = "0.00";
            //}
            //decimal grandTotal = decimal.Parse(grandTotalTextBox.Text);
            //decimal paidAmount = decimal.Parse(PaidAmountTextBox.Text);

            

            //Display the Returned Amount

            

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //get the values from purchase and sales form
            TransactionLL transaction = new TransactionLL();
            transaction.Type = purchaseAndSalesLabel.Text;

            //get The ID of Dealer or customer Here
            //lets get name of the Dealer or customer first
            string dealerCustomerName = nameTextBox.Text.Trim();
            DealerAndCustomerLL dealerAndCustomer = dealerCustomerDal.GetCustomerIdFromName(dealerCustomerName);

            transaction.DealerCustomerId = dealerAndCustomer.Id;
            transaction.GrandTotal = Math.Round(decimal.Parse(grandTotalTextBox.Text),2);
            transaction.TransactionDate = DateTime.Now;
            transaction.Tax = Math.Round(decimal.Parse(VatTextBox.Text),2);
            transaction.Discount = Math.Round(decimal.Parse(discountTextBox.Text),2);
            // get the userName of logged in user
            string userName = LoginForm.loggedInUser;
            UserLL userLL = user.GetIDFromUserName(userName);
            transaction.AddedBy = userLL.Id;
            transaction.TransactionDetails = transactionDataTable;

            bool success = false;

            //actual code to insert Transaction and Transaction Details

            using(TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                //create a boolean value and insert Transaction
                bool isInsertTransaction = transactionDal.InsertTransaction(transaction,out transactionID);

                //use forLoop to insert Transaction Details.
                for(int i = 0; i < transactionDataTable.Rows.Count; i++)
                {
                    //get all details of the Product
                    TransactionDetailLL detailLL = new TransactionDetailLL();
                    //get the Product name and convert it to id
                    string ProductName = transactionDataTable.Rows[i][0].ToString().Trim();
                    ProductLL product = productDal.GetProductIdFromName(ProductName);
                    detailLL.ProductId = product.Id;
                    detailLL.Rate = Math.Round(decimal.Parse(transactionDataTable.Rows[i][1].ToString()),2);
                    detailLL.Qty = Math.Round(decimal.Parse(transactionDataTable.Rows[i][2].ToString()),2);
                    detailLL.Total = Math.Round(decimal.Parse(transactionDataTable.Rows[i][3].ToString()),2);
                    detailLL.DealerCustomerId = dealerAndCustomer.Id;
                    detailLL.AddedDate = DateTime.Now;
                    detailLL.AddedBy = userLL.Id;

                    //here increase or decrese Product Quantity based on Purchase or Sales
                    string transactionTyp = purchaseAndSalesLabel.Text;
                    bool quantityRegulator = false;
                    //lets check whether we are on purchase or sales
                    try
                    {
                        if (transactionTyp == "Purchase")
                        {
                            //increase the Products
                            quantityRegulator = productDal.IncreaseProducts(detailLL.ProductId, detailLL.Qty);
                        }
                        else if (transactionTyp == "Sales")
                        {
                            //decrease the Sales
                            quantityRegulator = productDal.DecreaseProduct(detailLL.ProductId, detailLL.Qty);

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                  

                    // insert Transaction Details inside the DataBase
                    bool isInsertTransactioDetail = transactionDetailDal.InsertTransactionDetail(detailLL);
                    success = isInsertTransaction && isInsertTransactioDetail && quantityRegulator;

                }
                
                if (success == true)
                {
                    //transaction Completed

                    //code to print the bill
                    DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n Driib";
                    printer.SubTitle = "Kigali, Rwanda \r\n Phone: +250 781-916-866";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;

                    printer.Footer = "Discount:" + discountTextBox.Text +"% \r\n" + "VAT: " + VatTextBox.Text +"% \r\n" +
                         "Grand Total: "+ grandTotalTextBox.Text +"" + "\r\n" +"Thank Your Doing Bussiness With Us";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(transactionDataGridView1);




                    MessageBox.Show("Transaction Completed SuccessFully");

                    //clear the data Grid View and clear all the TextBoxes
                    transactionDataGridView1.DataSource = null;
                    transactionDataGridView1.Rows.Clear();
                    searchTextBox.Text = "";
                    ProductNametextBox.Text = "";
                    InvertorytextBox.Text = "";
                    ratetextBox.Text = "";
                    qtytextBox.Text = "";
                    productSearchTextBox.Text = "";
                    ProductNametextBox.Text = "";
                    InvertorytextBox.Text = "0.00";
                    ratetextBox.Text = "0.00";
                    qtytextBox.Text = "0.00";
                    subTotalTextBox.Text = "0.00";
                    discountTextBox.Text = "0.00";
                    VatTextBox.Text = "0.00";
                    grandTotalTextBox.Text = "0.00";
                    PaidAmountTextBox.Text = "0.00";
                    ReturnAmountTextBox.Text = "0.00";
                    scope.Complete();
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
                }

            }


        }

        private void TransactionDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DealerCustomerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseAndSalesLabel_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QtytextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
