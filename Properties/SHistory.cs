using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ShopManagementSystem.Properties
{
    class SHistory
    {

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;
                      Initial Catalog=S_ManagemntDB;
                      Integrated Security=True";

        public DataTable GetSalesByUser(int userId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string q = @"SELECT 
                            SaleId,
                            TotalAmount,
                            SaleDate,UserId 
                         FROM Sales
                         ORDER BY SaleDate DESC";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@uid", userId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
