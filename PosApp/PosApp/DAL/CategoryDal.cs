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
    class CategoryDal
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
        #region select into dataTable
        public DataTable Select()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select * from Categories";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTable;

        }
        #endregion
        #region insert into categories
        
        public bool Insert(CategoryLL categoryLL)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                DataTable dataTable = new DataTable();
                string sql = "insert into Categories (title,description,addedDate,addedBy)" +
                    "                     values(@title,@description,@addedDate,@addedBy)";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@title", categoryLL.Title);
                sqlCommand.Parameters.AddWithValue("@description", categoryLL.Description);
                sqlCommand.Parameters.AddWithValue("@addedDate", categoryLL.AddedDate);
                sqlCommand.Parameters.AddWithValue("@addedBy", categoryLL.AddedBy);

                sqlConnection.Open();

                int rows = sqlCommand.ExecuteNonQuery();
                if(rows > 0)
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
        #endregion
        #region update Categories
        public bool update(CategoryLL categoryLL)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string sql = "Update Categories SET title = @title,description = @description,addedDate = @addedDate,addedBy = @addedBy WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@title", categoryLL.Title);
                command.Parameters.AddWithValue("@description", categoryLL.Description);
                command.Parameters.AddWithValue("@addedDate", categoryLL.AddedDate);
                command.Parameters.AddWithValue("@addedBy", categoryLL.AddedBy);
                command.Parameters.AddWithValue("@Id", categoryLL.Id);

                connection.Open();

                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        #endregion
        #region delete categories
        public bool Delete(CategoryLL categoryLL)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                string sql = "delete from Categories where Id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", categoryLL.Id);
                connection.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
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
                connection.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Search
        public DataTable Search(String keyWords)
        {
            //static method to connect to database
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //this is used to hold data from the database
            DataTable dataTable = new DataTable();
            try
            {
                //query to fetch the data from the database
                string sql = "select * from Categories Where id like '%" + keyWords + "%' or title like '%" + keyWords + "%' or description like '%"+keyWords+"%'";
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


    }
}
