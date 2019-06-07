using PosApp.Login;
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
    public partial class FormUserDashBoard : Form
    {
        public FormUserDashBoard()
        {
            InitializeComponent();
        }

        //create a static method to specify wether the form is Sales or Purchase
        public static string transactionType;


        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void FormUserDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void FormUserDashBoard_Load(object sender, EventArgs e)
        {
            loggedInUser.Text = LoginForm.loggedInUser;
        }

        private void DealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealerCustomerForm dealerCustomerForm = new DealerCustomerForm();
            dealerCustomerForm.Show();
        }

        private void PurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the value on transactionType static method
            transactionType = "Purchase";
            PurchaseSalesForm purchaseSales = new PurchaseSalesForm();
            purchaseSales.Show();
           
        }

        private void SalesFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the value on transactionType static method
            transactionType = "Sales";
            PurchaseSalesForm sales = new PurchaseSalesForm();
            sales.Show();
            
        }

        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.Show();
        }
    }
}
