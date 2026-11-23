using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementSystem
{

    class AdminClass
    {
        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=S_ManagemntDB;Integrated Security=True";

        public DataTable showAllProducts()
        {
            string q = "Select * From Products";
            SqlDataAdapter sda = new SqlDataAdapter(q, conStr);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }
        public DataTable showSale()
        {
            string q = "Select * From Sales";
            SqlDataAdapter sda = new SqlDataAdapter(q, conStr);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }
    }
}
