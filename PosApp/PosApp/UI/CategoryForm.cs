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
            }
            else
            {
                MessageBox.Show("CREATING NEW CATEGORY FAILED SUCCESSFULLY");
            }

        }
    }
}
