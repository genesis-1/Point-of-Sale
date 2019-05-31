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
using System.Windows.Forms;

namespace PosApp.UI
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        UserLL userLL = new UserLL();
        UserDal userDal = new UserDal();
        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //getting data from UI
            userLL.FirstName = firstNameTextBox.Text;
            userLL.LastName = lastNameTextBox.Text;
            userLL.Email = EmailTextBox.Text;
            userLL.UserName = userNameTextBox.Text;
            userLL.Contact = contacTextBox.Text;
            userLL.Gender = genderComboBox.Text;
            userLL.Address = addressTextBox.Text;
            userLL.UserType = userTypeComboBox.Text;
            userLL.PassWord = passwordTextBox.Text;
            userLL.AddedDate = DateTime.Now;
            string loggedUser = LoginForm.loggedInUser;
            UserLL userLlWitbId = userDal.GetIDFromUserName(loggedUser);
            userLL.AddedBy = userLlWitbId.Id;
            //inserting data into DataBase;
            bool success = userDal.Insert(userLL);
            // if the data were successfully inserted then success will be true;
            //other-wise it will be false.
            if (success == true)
            {
                MessageBox.Show("user created successfully");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("user was not created");
            }
            RefreshDataGrid();
            

        }
        public void RefreshDataGrid()
        {
            DataTable dataTable = userDal.Select();
            usersDataGridView.DataSource = dataTable;
        }
        private void ClearTextBox()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            EmailTextBox.Clear();
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            contacTextBox.Clear();
            addressTextBox.Clear();
            genderComboBox.Text = "";
            userTypeComboBox.Text = "";
            
        }

        private void UsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void UsersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the index of a particular row
            int rowIndex = e.RowIndex;
            UserIdTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            firstNameTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            lastNameTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            EmailTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            userNameTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            passwordTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            contacTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            addressTextBox.Text = usersDataGridView.Rows[rowIndex].Cells[7].Value.ToString();
            genderComboBox.Text = usersDataGridView.Rows[rowIndex].Cells[8].Value.ToString();
            userTypeComboBox.Text = usersDataGridView.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
            // Get the values from user UI
            userLL.Id = Convert.ToInt32(UserIdTextBox.Text);
            userLL.FirstName = firstNameTextBox.Text;
            userLL.LastName = lastNameTextBox.Text;
            userLL.Email = EmailTextBox.Text;
            userLL.UserName = userNameTextBox.Text;
            userLL.Contact = contacTextBox.Text;
            userLL.Gender = genderComboBox.Text;
            userLL.Address = addressTextBox.Text;
            userLL.UserType = userTypeComboBox.Text;
            userLL.PassWord = passwordTextBox.Text;
            userLL.AddedDate = DateTime.Now;
            // this helps us to get the id of the user that inserted the
            //entry.
            string loggedUser = LoginForm.loggedInUser;
            UserLL userLlWitbId = userDal.GetIDFromUserName(loggedUser);
            userLL.AddedBy = userLlWitbId.Id;

            // updating Data into dataBase
            bool success = userDal.update(userLL);
            if(success == true)
            {
                MessageBox.Show("The user was Successfull update!");
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //getting the user ID
            userLL.Id = Convert.ToInt32(UserIdTextBox.Text);
            bool success = userDal.Delete(userLL);
            //if the data is deleted then the value of success will be true else it will be false
            if (success == true)
            {
                MessageBox.Show("deleted the user Successfully");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Deletion Failed");
            }
            RefreshDataGrid();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //Get key word from the Text BOx
            String keyWords = SearchTextBox.Text;

            //check if the keyWords has value or not
            if(keyWords != null)
            {
                //show user based on keywords
                DataTable dataTable = userDal.Search(keyWords);
                usersDataGridView.DataSource = dataTable;
            }
            else
            {
                //show all users from the database
                RefreshDataGrid();
            }

        }
    }
}
