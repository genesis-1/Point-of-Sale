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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }
        CategoryDal category = new CategoryDal();
        ProductDal product = new ProductDal();
        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            //Display the Categories in Combobox
            DataTable dataTable = category.Select();
            productTypeComboBox.DataSource = dataTable;

            //give the value member and display member for combobox
            productTypeComboBox.DisplayMember = "title";
            productTypeComboBox.ValueMember = "title";

            //display all the products in datagrid view when the form is loaded
            DataTable productDataTable = product.Select();
            InvetoryDataGridView.DataSource = productDataTable;



        }

        private void ProductTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display all the Products Based on Selected Category
            string category = productTypeComboBox.Text;

            DataTable dataTable = product.DisplayProductsByCategory(category);
            InvetoryDataGridView.DataSource = dataTable;

        }

        private void AllProductsButton_Click(object sender, EventArgs e)
        {
            DataTable productDataTable = product.Select();
            InvetoryDataGridView.DataSource = productDataTable;
        }
    }
}
