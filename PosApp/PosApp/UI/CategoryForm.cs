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
    }
}
