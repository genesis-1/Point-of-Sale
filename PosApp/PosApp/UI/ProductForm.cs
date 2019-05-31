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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            //CategoryComboBox.Text = "--Select--";
        }

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
    }
}
