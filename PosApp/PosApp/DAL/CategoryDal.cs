using PosApp.Bussiness;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosApp.DAL
{
    class CategoryDal
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
        #region select into dataTable
        #endregion
        #region insert into categories
        
        public bool Insert(CategoryLL categoryLL)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                DataTable dataTable = new DataTable();
                string sql = "insert into Categories (Id,title,description,addedDate,addedBy)"

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isSuccess;

        }
        #endregion


    }
}
