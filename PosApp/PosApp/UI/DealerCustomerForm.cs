using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosApp.Bussiness;
using PosApp.DAL;
using PosApp.Login;
using PosApp.UI;

namespace PosApp.UI
{
    public partial class DealerCustomerForm : Form
    {
        public DealerCustomerForm()
        {
            InitializeComponent();
        }
        DealerAndCustomerLL dealerAndCustomer = new DealerAndCustomerLL();
        DealerCustomerDal dealerCustomerDal = new DealerCustomerDal();
        UserDal userDal = new UserDal();
        UserLL userLL = new UserLL();
        public void RefreshDataGrid()
        {
            DataTable dataTable = dealerCustomerDal.Select();
            usersDataGridView.DataSource = dataTable;
        }
        private void ClearTextBox()
        {
            nameTextBox.Clear();
            TypeComboBox.Text = "";
            emailTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
            DealerCustIdTextBox.Text = "";

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            dealerAndCustomer.Name = nameTextBox.Text;
            dealerAndCustomer.Type = TypeComboBox.Text;
            dealerAndCustomer.Email = emailTextBox.Text;
            dealerAndCustomer.Contact = contactTextBox.Text;
            dealerAndCustomer.Addresss = addressTextBox.Text;
            dealerAndCustomer.AddedDate = DateTime.Now;
            string loggedUser = LoginForm.loggedInUser;
            UserLL userLlWitbId = userDal.GetIDFromUserName(loggedUser);
            dealerAndCustomer.AddedBy = userLlWitbId.Id;
            //inserting data into DataBase;
            bool success = dealerCustomerDal.Insert(dealerAndCustomer);
            // if the data were successfully inserted then success will be true;
            //other-wise it will be false.
            if (success == true)
            {
                MessageBox.Show("Operation created successfully");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Operation Failed");
            }
            RefreshDataGrid();
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DealerCustomerForm_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
