using PosApp.Bussiness;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosApp.DAL
{
    class TransactionDetailDal
    {
        string myConnectionString = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
        #region insert method for Transaction Details
        public bool InsertTransactionDetail(TransactionDetailLL transactionDetail)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(myConnectionString);

            try
            {
                string sql = "insert into TransactionDetails(productId,rate,qty,total,dealerCustomerId,addedDate,addedBy)" +
                             "values(@productId,@rate,@qty,@total,@dealerCustomerId,@addedDate,@addedBy);select @@IDENTITY;";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@productId",transactionDetail.ProductId);
                command.Parameters.AddWithValue("@rate", transactionDetail.Rate);
                command.Parameters.AddWithValue("@qty", transactionDetail.Qty);
                command.Parameters.AddWithValue("@total", transactionDetail.Total);
                command.Parameters.AddWithValue("@dealerCustomerId", transactionDetail.DealerCustomerId);
                command.Parameters.AddWithValue("@addedDate", transactionDetail.AddedDate);
                command.Parameters.AddWithValue("@addedBy", transactionDetail.AddedBy);

                connection.Open();

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                   // MessageBox.Show("");

                }
                else
                {
                    isSuccess = false;
                }
        
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Console.Write(ex);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}
