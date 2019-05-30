using PosApp.Login;
using PosApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosApp.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;

            if(progressBar1.Value >= 100)
            {
                //LoginForm ln = new LoginForm();
                AdminDashBoard adminDashBoard = new AdminDashBoard();
                this.Hide();
                adminDashBoard.Show();
                timer1.Enabled = true;
                progressBar1.Visible = false;
                timer1.Enabled = false;
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
