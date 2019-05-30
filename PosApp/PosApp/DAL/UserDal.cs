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
    class UserDal
    {
        static string myconnectionstring = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
        #region select data from the database
        public DataTable Select()
        {
            //static method to connect to database
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);

            //this is used to hold data from the database
            DataTable dataTable = new DataTable();
            try
            {
                //query to fetch the data from the database
                string sql = "select * from Users";
                //for executing the command of the statement
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                //getting the data from the database
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //data base connection open
                sqlConnection.Open();
                //fill the data in our dataTable
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // throw any error in case there is an exeption.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //closing the connection
                sqlConnection.Close();
            }
            // return the value from the dataTable
            return dataTable;
        }
        #endregion
        #region insert the data in database
        public bool Insert(UserLL userLL)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                string sql = "insert into users(firstName,lastName ,Email,userName ,password,contact,address ,gender ,userType,addedDate,addedBy )" +
                                        "values(@firstName,@lastName ,@Email,@userName ,@password,@contact,@address ,@gender ,@userType,@addedDate,@addedBy)";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@firstName", userLL.FirstName);
                sqlCommand.Parameters.AddWithValue("@lastName", userLL.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", userLL.Email);
                sqlCommand.Parameters.AddWithValue("@userName", userLL.UserName);
                sqlCommand.Parameters.AddWithValue("@password", userLL.PassWord);
                sqlCommand.Parameters.AddWithValue("@contact", userLL.Contact);
                sqlCommand.Parameters.AddWithValue("@address", userLL.Address);
                sqlCommand.Parameters.AddWithValue("@gender", userLL.Gender);
                sqlCommand.Parameters.AddWithValue("@userType", userLL.UserType);
                sqlCommand.Parameters.AddWithValue("@addedDate", userLL.AddedDate);
                sqlCommand.Parameters.AddWithValue("@addedBy", userLL.AddedBy);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                //if the query is executed Successfully then the value is to row will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //query was executed successfully
                    isSuccess = true;                }
                else
                {
                    //query has failed
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
        #endregion
        #region update the data in dataBase
        public bool update(UserLL userLL)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                String sql = "Update Users SET firstName = @firstName,lastName = @lastName,Email = @Email ,userName = @userName,password = @password,contact = @contact,address = @address ,gender = @gender ,userType = @userType,addedDate = @addedDate,addedBy = @addedBy WHERE Id = @Id";
                SqlCommand sqlCommand = new SqlCommand(sql,sqlConnection);
                sqlCommand.Parameters.AddWithValue("@firstName", userLL.FirstName);
                sqlCommand.Parameters.AddWithValue("@lastName", userLL.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", userLL.Email);
                sqlCommand.Parameters.AddWithValue("@userName", userLL.UserName);
                sqlCommand.Parameters.AddWithValue("@password", userLL.PassWord);
                sqlCommand.Parameters.AddWithValue("@contact", userLL.Contact);
                sqlCommand.Parameters.AddWithValue("@address", userLL.Address);
                sqlCommand.Parameters.AddWithValue("@gender", userLL.Gender);
                sqlCommand.Parameters.AddWithValue("@userType", userLL.UserType);
                sqlCommand.Parameters.AddWithValue("@addedDate", userLL.AddedDate);
                sqlCommand.Parameters.AddWithValue("@addedBy", userLL.AddedBy);
                sqlCommand.Parameters.AddWithValue("@Id", userLL.Id);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                if (rows > 0)
                {
                    //the querry was executed successfully
                    isSuccess = true;
                }
                else
                {
                    //the query was not executed successfully
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
        #endregion
        #region delete data from the dataBase
        public bool Delete(UserLL userLL)
        {
            bool isDeleted = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                string sql = "delete from Users WHERE id = @id";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", userLL.Id);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                if (rows > 0)
                {
                    isDeleted = true;
                }
                else
                {
                    isDeleted = false;
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
            return isDeleted;
        }
        #endregion
        #region search data using keyWord
        public DataTable Search(String keyWords)
        {
            //static method to connect to database
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);

            //this is used to hold data from the database
            DataTable dataTable = new DataTable();
            try
            {
                //query to fetch the data from the database
                string sql = "select * from Users Where id like '%"+keyWords+"%' or firstName like '%"+keyWords+"%'" +
                    "or userName like '%"+keyWords+"%' or lastName like '%"+keyWords+"%'";
                //for executing the command of the statement
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                //getting the data from the database
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //data base connection open
                sqlConnection.Open();
                //fill the data in our dataTable
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // throw any error in case there is an exeption.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //closing the connection
                sqlConnection.Close();
            }
            // return the value from the dataTable
            return dataTable;
        }
        #endregion
        #region getting the userId
        public UserLL GetIDFromUserName(String userName)
        {
            UserLL userLL = new UserLL();
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            DataTable dataTable = new DataTable();
            try
            {
                String sql = "select Id from Users where userName = '" + userName + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);

                if(dataTable.Rows.Count > 0)
                {
                    userLL.Id = int.Parse(dataTable.Rows[0]["id"].ToString());

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
            
            return userLL;
        }
   
        #endregion

    }
}
