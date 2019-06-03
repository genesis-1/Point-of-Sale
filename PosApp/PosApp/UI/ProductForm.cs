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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            //CategoryComboBox.Text = "--Select--";
        }
        ProductDal productDal = new ProductDal();
        ProductLL productLL = new ProductLL();
        UserDal user = new UserDal();


        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //first of all create the objecct of categoryDal
        CategoryDal categoryDal = new CategoryDal();
        private void ProductForm_Load(object sender, EventArgs e)
        {
            //creating dataTable to hold data from the database;
            DataTable categories = categoryDal.Select();
           
            //specify datasource for categories
            CategoryComboBox.DataSource = categories;
            //specify Display member and value member for combobox
            CategoryComboBox.DisplayMember = "title";
            CategoryComboBox.ValueMember = "title";
            UpdateDataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            productLL.Name = nameTextBox.Text;
            productLL.Category = CategoryComboBox.Text;
            productLL.description = descriptionTextBox.Text;
            productLL.rate = decimal.Parse(rateTextBox.Text);
            productLL.qty = 0;
            productLL.addedDate = DateTime.Now;
            //get the id of the loggedin user
            String loggedUser = LoginForm.loggedInUser;
            UserLL userLL = user.GetIDFromUserName(loggedUser);
            productLL.addedBy = userLL.Id;
            if (productDal.Insert(productLL) == true)
            {
                MessageBox.Show("the product is added successfully");
                CleareTextFields();
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Failed to add products");
            }


        }

        private void UpdateDataGridView()
        {
            DataTable dataTable = productDal.Select();
            productDataGridView.DataSource = dataTable;
        }

        private void CleareTextFields()
        {
            nameTextBox.Text = "";
            productIdTextBox.Text = "";
            CategoryComboBox.Text = "";
            descriptionTextBox.Text = "";
            rateTextBox.Text = "";
            SearchTextBox.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            productLL.Id = Convert.ToInt32(productIdTextBox.Text);
            productLL.Name = nameTextBox.Text;
            productLL.Category = CategoryComboBox.Text;
            productLL.description = descriptionTextBox.Text;
            productLL.rate = decimal.Parse(rateTextBox.Text);
            //productLL.qty = 0;
            productLL.addedDate = DateTime.Now;
            //get the id of the loggedin user
            String loggedUser = LoginForm.loggedInUser;
            UserLL userLL = user.GetIDFromUserName(loggedUser);
            productLL.addedBy = userLL.Id;
            if (productDal.update(productLL) == true)
            {
                MessageBox.Show("the product is updated successfully");
                CleareTextFields();
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Failed to update the products");
            }


       

            
            /// refreshing the data grid.
        }

        private void ProductIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            productIdTextBox.Text = productDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            nameTextBox.Text = productDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            CategoryComboBox.Text = productDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            descriptionTextBox.Text = productDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            rateTextBox.Text = productDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //getting the user ID
            productLL.Id = Convert.ToInt32(productIdTextBox.Text);
            bool success = productDal.Delete(productLL);
            //if the data is deleted then the value of success will be true else it will be false
            if (success == true)
            {
                MessageBox.Show("deleted the Product Successfully");
                
                CleareTextFields();
                
            }
            else
            {
                MessageBox.Show("Deletion Failed");
            }
            UpdateDataGridView();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //Get key word from the Text BOx
            String keyWords = SearchTextBox.Text;

            //check if the keyWords has value or not
            if (keyWords != null)
            {
                //show user based on keywords
                DataTable dataTable = productDal.Search(keyWords);
               productDataGridView.DataSource = dataTable;
            }
            else
            {
                //show all users from the database
                UpdateDataGridView();
            }
        }
    }
}
