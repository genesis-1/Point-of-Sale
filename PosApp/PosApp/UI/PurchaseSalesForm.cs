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
    public partial class PurchaseSalesForm : Form
    {
        public PurchaseSalesForm()
        {
            InitializeComponent();
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
