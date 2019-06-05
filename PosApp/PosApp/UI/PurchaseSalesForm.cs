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
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
