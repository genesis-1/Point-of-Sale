using PosApp.Bussiness;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosApp.DAL
{
    class LoginDal
    {
        //static string to connect Database
        static string myconnstr = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;

        public bool LoginCheck(LoginLL loginLL)
        {
            bool isSuccess = false;
              // connect to the database
              SqlConnection sqlConnection = new SqlConnection(myconnstr);
            try
            {
                // sql query to check login
                string sql = "select * from Users where userName = @userName and password = @password " +
                    "and userType = @userType";
                //creating sql command to pass value
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@userName", loginLL.UserName);
                sqlCommand.Parameters.AddWithValue("@password", loginLL.Password);
                sqlCommand.Parameters.AddWithValue("@userType", loginLL.UserType);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //checking the rows in DataTable
                if (dataTable.Rows.Count > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return isSuccess;
        }
    }
}
