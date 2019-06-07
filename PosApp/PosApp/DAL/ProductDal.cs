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
    class ProductDal
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
                string sql = "select * from Products";
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
        public bool Insert(ProductLL productLL)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                string sql = "insert into Products(name,category,description ,rate,qty,addedDate,addedBy )" +
                                        "values(@name,@category,@description ,@rate,@qty,@addedDate,@addedBy )";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", productLL.Name);
                sqlCommand.Parameters.AddWithValue("@category", productLL.Category);
                sqlCommand.Parameters.AddWithValue("@description", productLL.description);
                sqlCommand.Parameters.AddWithValue("@rate", productLL.rate);
                sqlCommand.Parameters.AddWithValue("@qty", productLL.qty);
                sqlCommand.Parameters.AddWithValue("@addedDate", productLL.addedDate);
                sqlCommand.Parameters.AddWithValue("@addedBy", productLL.addedBy);
          
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
        public bool update(ProductLL productLL)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                String sql = "Update Products SET name = @name,category=@category,description=@description ,rate=@rate,addedDate=@addedDate,addedBy=@addedBy WHERE Id = @Id";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", productLL.Name);
                sqlCommand.Parameters.AddWithValue("@category", productLL.Category);
                sqlCommand.Parameters.AddWithValue("@description", productLL.description);
                sqlCommand.Parameters.AddWithValue("@rate", productLL.rate);
                sqlCommand.Parameters.AddWithValue("@qty", productLL.qty);
                sqlCommand.Parameters.AddWithValue("@addedDate", productLL.addedDate);
                sqlCommand.Parameters.AddWithValue("@addedBy", productLL.addedBy);
                sqlCommand.Parameters.AddWithValue("@Id", productLL.Id);
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
        public bool Delete(ProductLL productLL)
        {
            bool isDeleted = false;
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);
            try
            {
                string sql = "delete from Products WHERE id = @id";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", productLL.Id);
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
                string sql = "select * from Products Where id like '%" + keyWords + "%' or name like '%" + keyWords + "%'" +
                    "or category like '%" + keyWords + "%' or description like '%" + keyWords + "%'or qty like '%" + keyWords + "%'";
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

        #region Methd to search Product in transaction MOdule
        public ProductLL GetProductLLForTransactionModule(string keyword)
        {
            ProductLL productLL = new ProductLL();
            SqlConnection connection = new SqlConnection(myconnectionstring);

            //create a dataTable to hold the value temporily
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select name,rate,qty from Products where Id like '%" + keyword + "%' or name like '%" + keyword + "%'";

                //create SqlData adapter to execute the Query

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

                connection.Open();

                //Transfer the data from sqlData adapter to Data table
                dataAdapter.Fill(dataTable);

                // if we hava values on datatable we need to save it in dealerCustomerBLL

                if (dataTable.Rows.Count > 0)
                {
                    productLL.Name = dataTable.Rows[0]["name"].ToString();
                    productLL.rate = decimal.Parse( dataTable.Rows[0]["rate"].ToString());
                    productLL.qty = decimal.Parse(dataTable.Rows[0]["qty"].ToString());
                   // dealerAndCustomer.Addresss = dataTable.Rows[0]["address"].ToString();
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
            return productLL;
        }
        #endregion
        #region METHOD TO GET ID BASED ON PRODUCTName
        public ProductLL GetProductIdFromName(string keyWord)
        {
            ProductLL productLL = new ProductLL();

            SqlConnection connection = new SqlConnection(myconnectionstring);

            //create a dataTable to hold the value temporily
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select id from Products where name = '" + keyWord + "'";

                //create SqlData adapter to execute the Query

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

                connection.Open();

                //Transfer the data from sqlData adapter to Data table
                dataAdapter.Fill(dataTable);

                // if we hava values on datatable we need to save it in dealerCustomerBLL

                if (dataTable.Rows.Count > 0)
                {
                    productLL.Id = int.Parse(dataTable.Rows[0]["Id"].ToString());

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
            return productLL;
        }
        #endregion
        #region Method to get current Quantity from the Database based on ProductID
        public decimal GetProductQty(int productId)
        {
            ProductLL productLL = new ProductLL();
            decimal qty = 0;
            SqlConnection connection = new SqlConnection(myconnectionstring);
            //create a dataTable to hold the value temporily
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select qty from Products where Id = '"+productId+"'";

                //create SqlData adapter to execute the Query

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

                connection.Open();

                //Transfer the data from sqlData adapter to Data table
                dataAdapter.Fill(dataTable);

                // if we hava values on datatable we need to save it in dealerCustomerBLL

                if (dataTable.Rows.Count > 0)
                {
                    qty = decimal.Parse(dataTable.Rows[0]["qty"].ToString());

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
            return qty;
        }
        #endregion
        #region Method to Update Quantity
        public bool UpdateQuantity(int productId,decimal qty)
        {
            bool success = false;
            SqlConnection connection = new SqlConnection(myconnectionstring);
            try
            {
                string sql = "update Products set qty = @qty where Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@qty", qty);
                command.Parameters.AddWithValue("@Id", productId);

                connection.Open();
                int row = command.ExecuteNonQuery();
                //lets check if the Querry is executed Successfully
                if (row > 0)
                {
                    success = true;
                    
                }
                else
                {
                    success = false;
                    
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
            return success;
        }
        #endregion
        #region method to increase Products
        public bool IncreaseProducts(int ProductId,decimal increaseQty)
        {
            bool success = false;

            SqlConnection connection = new SqlConnection(myconnectionstring);
            try
            {
                //get the Current Quatity
                decimal currentQty = GetProductQty(ProductId);
                //increase the Quantity
                decimal newQuantity = currentQty + increaseQty;

                // update the Quantity
                success = UpdateQuantity(ProductId,newQuantity);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return success;
        }
        #endregion
        #region Method to decrease Poducts
        public bool DecreaseProduct(int productId,decimal qty)
        {
            bool success = false;
            SqlConnection connection = new SqlConnection(myconnectionstring);
            try
            {
                //decimal the current product Quantity
                decimal currentQty = GetProductQty(productId);

                //Decrease the Product Quantity

                decimal newQty = currentQty - qty;
                success = UpdateQuantity(productId,newQty);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return success;
        }
        #endregion
        #region Display Region Based ON Categories
        public DataTable DisplayProductsByCategory(String category)
        {
            SqlConnection sqlConnection = new SqlConnection(myconnectionstring);

            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select * from Products where category = '" + category + "'";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // open the Data Base Connection
                sqlConnection.Open();
                adapter.Fill(dataTable);

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
    }
}
