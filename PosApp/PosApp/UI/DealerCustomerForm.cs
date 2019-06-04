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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Get the values from user UI
            dealerAndCustomer.Id = Convert.ToInt32(DealerCustIdTextBox.Text);
            dealerAndCustomer.Name = nameTextBox.Text;
            dealerAndCustomer.Type = TypeComboBox.Text;
            dealerAndCustomer.Email = emailTextBox.Text;
            dealerAndCustomer.Contact = contactTextBox.Text;
            dealerAndCustomer.Addresss = addressTextBox.Text;
            dealerAndCustomer.AddedDate = DateTime.Now;
            string loggedUser = LoginForm.loggedInUser;
            UserLL userLlWitbId = userDal.GetIDFromUserName(loggedUser);
            dealerAndCustomer.AddedBy = userLlWitbId.Id;
            // this helps us to get the id of the user that inserted the
            //entry.
            //string loggedUser = LoginForm.loggedInUser;
            //UserLL userLlWitbId = userDal.GetIDFromUserName(loggedUser);
            //userLL.AddedBy = userLlWitbId.Id;

            // updating Data into dataBase
            bool success = dealerCustomerDal.update(dealerAndCustomer);
            if (success == true)
            {
                MessageBox.Show("Update Completed Successfully!");
                ClearTextBox();
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("update failed!");
            }
            /// refreshing the data grid.
            //RefreshDataGrid();
        }

        private void UsersDataGridView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void UsersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DealerCustIdTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            TypeComboBox.Text = usersDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            nameTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            emailTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
           contactTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            addressTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            //contacTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            
        }

        private void TypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            String keyWords = searchTextBox.Text;

            //check if the keyWords has value or not
            if (keyWords != null)
            {
                //show user based on keywords
                DataTable dataTable = dealerCustomerDal.Search(keyWords);
                usersDataGridView.DataSource = dataTable;
            }
            else
            {
                //show all users from the database
                RefreshDataGrid();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dealerAndCustomer.Id = Convert.ToInt32(DealerCustIdTextBox.Text);
            bool success = dealerCustomerDal.Delete(dealerAndCustomer);
            //if the data is deleted then the value of success will be true else it will be false
            if (success == true)
            {
                MessageBox.Show("Delete Completed Successfully");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Deletion Failed");
            }
            RefreshDataGrid();
        }
    }
}
