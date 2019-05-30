using PosApp.Bussiness;
using PosApp.DAL;
using PosApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosApp.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        LoginLL loginLL = new LoginLL();
        LoginDal loginDal = new LoginDal();

        // this is going to hold the name of the user logged in the system.
        public static string loggedInUser;
       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogginButton_Click(object sender, EventArgs e)
        { 

            loginLL.UserName = userNameTextBox.Text.Trim();
            loginLL.Password = PasswordTextBox.Text.Trim();
            //if the checked username is admin
            //set object of the user loginlogiclayer 's usertype to Admin
            if(adminCheckBox.Checked){
                loginLL.UserType = "Admin";

            }
            else if(userCheckBox.Checked)
            {
                loginLL.UserType = "user";
            }
            else
            {
                loginLL.UserType = null;
                MessageBox.Show("Please provide the user Types");
            }

            //check if the data of the userLogged in are valid.
            bool success = loginDal.LoginCheck(loginLL);
            if(success){
                //if login is successfull
                //grab the userName of the user Logged in.
                loggedInUser = loginLL.UserName;
                MessageBox.Show("logged in successfully");
                switch (loginLL.UserType)
                {
                    case "Admin":
                        {
                            // display Admin UserDash board.
                            AdminDashBoard adminDashBoard = new AdminDashBoard();
                            adminDashBoard.Show();
                            this.Hide();
                        }
                        break;
                    case "user":
                        {
                            //display userDashBoard.
                            FormUserDashBoard formUserDashBoard = new FormUserDashBoard();
                            formUserDashBoard.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            //Display an error message
                            MessageBox.Show("invalid User Type");
                        }
                        break;
                }

            }
            else
            {
                //login 
                MessageBox.Show("lOgin failed.try again");
            }
            
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            adminCheckBox.Checked = (userCheckBox.Checked) ? false : adminCheckBox.Checked;

        }

        private void UserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            userCheckBox.Checked = (adminCheckBox.Checked) ? false : userCheckBox.Checked;
        }
    }
}
