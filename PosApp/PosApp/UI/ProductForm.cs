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

        }

        private void ProductIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
