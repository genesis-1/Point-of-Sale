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
    public partial class TransactonForm : Form
    {
        public TransactonForm()
        {
            InitializeComponent();
        }
        TransactionDal transaction = new TransactionDal();


        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TransactionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void TransactionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the Value from the combobox
            string type = transactionTypeComboBox.Text;

            DataTable dataTable = transaction.DisplayTransactionByType(type);
            TransactionsDataGridView.DataSource = dataTable;
        }

        private void AllTransactionButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = transaction.DisplayAllTransaction();
            TransactionsDataGridView.DataSource = dataTable;
        }

        private void TransactonForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = transaction.DisplayAllTransaction();
            TransactionsDataGridView.DataSource = dataTable;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
