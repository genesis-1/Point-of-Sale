using PosApp.Bussiness;
using PosApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            transactionDataTable.Columns.Add("Product Name");
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
            //InvertorytextBox.Text = productLL.;
            ratetextBox.Text = productLL.rate.ToString();
            qtytextBox.Text = (productLL.qty).ToString();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Get product name,Rate and Quantity the customer wansts to buy
            string productName = ProductNametextBox.Text;
            decimal Rate = decimal.Parse(ratetextBox.Text);
            decimal Qty = decimal.Parse(qtytextBox.Text);

            //calculate Total
            decimal Total = Rate * Qty;

            // display the subtotal in textBox
            //get the subTotal value from textBox
            decimal subTotal = decimal.Parse(subTotalTextBox.Text);

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
                decimal subtotal = decimal.Parse(subTotalTextBox.Text);
                decimal discount = decimal.Parse(discountTextBox.Text);

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
                else
                {
                    grandTotalTextBox.Text = "";
                }
                

                
            }
        }

        private void PaidAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(grandTotalTextBox.Text);
            decimal paidAmount = decimal.Parse(PaidAmountTextBox.Text);

            decimal returnAmount = paidAmount - grandTotal;

            //Display the Returned Amount

            ReturnAmountTextBox.Text = returnAmount.ToString();

        }
    }
}
