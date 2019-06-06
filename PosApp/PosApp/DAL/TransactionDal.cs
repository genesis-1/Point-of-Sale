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
    class TransactionDal
    {
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
        #region insert
        public bool InsertTransaction(TransactionLL transactionLL,out int transactionId)
        {
            bool isSuccess = false;

            transactionId = -1;

            SqlConnection connection = new SqlConnection(myConnectionString);

            try
            {
                string sql = "insert into Transactions(type,DealerCustomerId,grandTotal,TransactionDate,tax,discount,addedBy)" +
                                          "values(@type,@DealerCustomerId,@grandTotal,@TransactionDate,@tax,@discount,@addedBy);select @@IDENTITY;";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@type", transactionLL.Type);
                command.Parameters.AddWithValue("@DealerCustomerId", transactionLL.DealerCustomerId);
                command.Parameters.AddWithValue("@grandTotal", transactionLL.GrandTotal);
                command.Parameters.AddWithValue("@TransactionDate", transactionLL.TransactionDate);
                command.Parameters.AddWithValue("@tax", transactionLL.Tax);
                command.Parameters.AddWithValue("@discount", transactionLL.Discount);
                command.Parameters.AddWithValue("@addedBy", transactionLL.AddedBy);
                connection.Open();
                /*
                 * the difference between ExecuteNonQuery and ExecuteScalar is that
                 * ExecuteNONQuery returns the number of Rows affected after executing the query
                 * While ExecuteScalar returns the value of first column of first row in the result set by the query.
                 * 
                 * in this section we are going to use executeScalar.
                 */
                object o = command.ExecuteScalar();
                /*
                 * if the value is executed successfully then the value of Object o will not be null
                 * else it will null.
                 */

                if (o != null)
                {
                    transactionId = int.Parse(o.ToString());
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
