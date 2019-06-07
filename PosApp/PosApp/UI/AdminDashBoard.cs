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
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void LoggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void AdminDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AdminDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            loggedInUser.Text = LoginForm.loggedInUser;
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            
        }

        private void DealerAndCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealerCustomerForm dealerCustomerForm = new DealerCustomerForm();
            dealerCustomerForm.Show();
        }

        private void TransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactonForm transactonForm = new TransactonForm();
            transactonForm.Show();
        }
    }
}
