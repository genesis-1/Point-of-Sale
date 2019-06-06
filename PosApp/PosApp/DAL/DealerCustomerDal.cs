using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PosApp.Bussiness;
using System.Windows.Forms;
using System;
using System.Text;
using System.Threading.Tasks;

namespace PosApp.DAL
{
    class DealerCustomerDal
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
                string sql = "select * from DealerCustomers";
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
        public bool Insert(DealerAndCustomerLL dealerAndCustomerLL)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                string sql = "insert into DealerCustomers(type,name,email,contact,address,addedDate,addedBy )" +
                                        "values(@type,@name,@email,@contact,@address,@addedDate,@addedBy )";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@type", dealerAndCustomerLL.Type);
                sqlCommand.Parameters.AddWithValue("@name", dealerAndCustomerLL.Name);
                sqlCommand.Parameters.AddWithValue("@email", dealerAndCustomerLL.Email);
                sqlCommand.Parameters.AddWithValue("@contact", dealerAndCustomerLL.Contact);
                sqlCommand.Parameters.AddWithValue("@address", dealerAndCustomerLL.Addresss);
                sqlCommand.Parameters.AddWithValue("@addedDate", dealerAndCustomerLL.AddedDate);
                sqlCommand.Parameters.AddWithValue("@addedBy", dealerAndCustomerLL.AddedBy);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                //if the query is executed Successfully then the value is to row will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //query was executed successfully
                    isSuccess = true;
                }
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
        public bool update(DealerAndCustomerLL dealerAndCustomerLL)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                String sql = "Update DealerCustomers SET type = @type,name = @name,email = @email,contact = @contact,addedDate = @addedDate,addedBy = @addedBy WHERE Id = @Id";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@type", dealerAndCustomerLL.Type);
                sqlCommand.Parameters.AddWithValue("@name", dealerAndCustomerLL.Name);
                sqlCommand.Parameters.AddWithValue("@email", dealerAndCustomerLL.Email);
                sqlCommand.Parameters.AddWithValue("@contact", dealerAndCustomerLL.Contact);
                sqlCommand.Parameters.AddWithValue("@address", dealerAndCustomerLL.Addresss);
                sqlCommand.Parameters.AddWithValue("@addedDate", dealerAndCustomerLL.AddedDate);
                sqlCommand.Parameters.AddWithValue("@addedBy", dealerAndCustomerLL.AddedBy);
                sqlCommand.Parameters.AddWithValue("@Id", dealerAndCustomerLL.Id);
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
        public bool Delete(DealerAndCustomerLL dealerAndCustomerLL)
        {
            bool isDeleted = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                string sql = "delete from DealerCustomers WHERE id = @id";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", dealerAndCustomerLL.Id);
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
                string sql = "select * from DealerCustomers Where id like '%" + keyWords + "%' or name like '%" + keyWords + "%'" +
                    "or type like '%" + keyWords + "%' or email like '%" + keyWords + "%' or address like '%" + keyWords + "%'";
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
        #region Method to search Dealer or customer for transaction module
        public DealerAndCustomerLL SearchDealerCustomerForTransaction(string keyWord)
        {
            //create an object for DealerCustomer class
            DealerAndCustomerLL dealerAndCustomer = new DealerAndCustomerLL();

            SqlConnection connection = new SqlConnection(myconnectionstring);

            //create a dataTable to hold the value temporily
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select name,email,contact,address from DealerCustomers where Id like '%" + keyWord + "%' or name like '%" + keyWord + "%'";

                //create SqlData adapter to execute the Query

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

                connection.Open();

                //Transfer the data from sqlData adapter to Data table
                dataAdapter.Fill(dataTable);

                // if we hava values on datatable we need to save it in dealerCustomerBLL

                if (dataTable.Rows.Count > 0)
                {
                    dealerAndCustomer.Name = dataTable.Rows[0]["name"].ToString();
                    dealerAndCustomer.Email = dataTable.Rows[0]["email"].ToString();
                    dealerAndCustomer.Contact = dataTable.Rows[0]["contact"].ToString();
                    dealerAndCustomer.Addresss = dataTable.Rows[0]["address"].ToString();
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

            return dealerAndCustomer;
        }
        #endregion
        #region Method to get the ID of dealer and customer Based on Name
        public DealerAndCustomerLL GetCustomerIdFromName(string keyWord)
        {
            DealerAndCustomerLL dealerAndCustomer = new DealerAndCustomerLL();

            SqlConnection connection = new SqlConnection(myconnectionstring);

            //create a dataTable to hold the value temporily
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select id from DealerCustomers where  name = '"+keyWord+"'";

                //create SqlData adapter to execute the Query

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

                connection.Open();

                //Transfer the data from sqlData adapter to Data table
                dataAdapter.Fill(dataTable);

                // if we hava values on datatable we need to save it in dealerCustomerBLL

                if (dataTable.Rows.Count > 0)
                {
                    dealerAndCustomer.Id = int.Parse(dataTable.Rows[0]["Id"].ToString());
                    
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
            return dealerAndCustomer;
        }
        

        #endregion
    }
}
