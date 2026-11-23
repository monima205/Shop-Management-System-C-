using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace ShopManagementSystem
{
    class EmployeeClass
    {
        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=S_ManagemntDB;Integrated Security=True";

        public DataTable productList()
        {
            string q = "Select * From Products";
            SqlDataAdapter sda = new SqlDataAdapter(q, conStr);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }
    }
}
