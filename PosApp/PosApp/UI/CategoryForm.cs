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
    public partial class CategoryForm : Form
    {
        CategoryLL category = new CategoryLL();
        CategoryDal categoryDal = new CategoryDal();
        

        public CategoryForm()
        {
            InitializeComponent();
        }


        private void CategoryForm_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            category.Title = titleTextBox.Text;
            category.Description = descriptionTextBox.Text;
            category.AddedDate = DateTime.Now;

            //getting Id in added by field
            string loggedin = LoginForm.loggedInUser;
            UserDal user = new UserDal();
            UserLL userLL = user.GetIDFromUserName(loggedin);

            category.AddedBy = userLL.Id;
            // 
            bool success = categoryDal.Insert(category);
            if (success == true)
            {
                MessageBox.Show("OPERATION COMPLETED SUCCESSFULLY");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("CREATING NEW CATEGORY FAILED SUCCESSFULLY");
            }
            RefreshDataGrid();

        }
        private void ClearTextBox()
        {
            categoryIdTextBox.Text = "";
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            SearchTextBox.Text = "";

        }
        public void RefreshDataGrid()
        {
            DataTable dataTable = categoryDal.Select();
            categoryDataGridView.DataSource = dataTable;        }

        private void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            categoryIdTextBox.Text = categoryDataGridView.Rows[row].Cells[0].Value.ToString();
            titleTextBox.Text = categoryDataGridView.Rows[row].Cells[1].Value.ToString();
            descriptionTextBox.Text = categoryDataGridView.Rows[row].Cells[2].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            category.Id = Convert.ToInt32(categoryIdTextBox.Text);
            category.Title = titleTextBox.Text;
            category.Description = descriptionTextBox.Text;
            category.AddedDate = DateTime.Now;
            // this helps us to get the id of the user that inserted the
            //entry.
            string loggedUser = LoginForm.loggedInUser;
            UserDal userDal = new UserDal();
            UserLL userWithId = userDal.GetIDFromUserName(loggedUser);
            category.AddedBy = userWithId.Id;

            // updating Data into dataBase
            bool success = categoryDal.update(category);
            if (success == true)
            {
                MessageBox.Show("The Catagory was SuccessfullY update!");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("update failed!");
            }
            /// refreshing the data grid.
            RefreshDataGrid();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //getting the user ID
            category.Id = Convert.ToInt32(categoryIdTextBox.Text);
            bool success = categoryDal.Delete(category);
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
            if (keyWords != null)
            {
                //show user based on keywords
                DataTable dataTable = categoryDal.Search(keyWords);
                categoryDataGridView.DataSource = dataTable;
            }
            else
            {
                //show all users from the database
                RefreshDataGrid();
            }
        }
    }
}
