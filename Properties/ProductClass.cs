using System;
using System.Data;
using System.Data.SqlClient;

namespace ShopManagementSystem.Properties
{
    class ProductClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int quantity { get; set; } 

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;
                          Initial Catalog=S_ManagemntDB;
                          Integrated Security=True";

        // 🔹 SHOW ALL PRODUCTS
        public DataTable showAllProducts()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string q = "SELECT * FROM Products";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                sda.Fill(dt);
            }

            return dt;
        }

        // 🔹 INSERT PRODUCT
        public bool insert(ProductClass p)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string q = @"INSERT INTO Products
                     (ProductName, Category, Price, Stock, Quantity)
                     VALUES (@Name, @Cat, @Price, @Stock, @Qty)";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Name", p.name);
                cmd.Parameters.AddWithValue("@Cat", p.category);
                cmd.Parameters.AddWithValue("@Price", p.price);
                cmd.Parameters.AddWithValue("@Stock", p.stock);
                cmd.Parameters.AddWithValue("@Qty", p.quantity);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        // 🔹 UPDATE PRODUCT
        public bool Update(ProductClass p)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string q = @"UPDATE Products
                             SET ProductName = @Name,
                                 Category = @Cat,
                                 Price = @Price,
                                 Stock = @Stock,
                                 Quantity = @Qty
                             WHERE ProductId = @Id";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Id", p.id);
                cmd.Parameters.AddWithValue("@Name", p.name);
                cmd.Parameters.AddWithValue("@Cat", p.category);
                cmd.Parameters.AddWithValue("@Price", p.price);
                cmd.Parameters.AddWithValue("@Stock", p.stock);
                cmd.Parameters.AddWithValue("@Qty", p.quantity);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 🔹 DELETE PRODUCT
        public bool Delete(int productId)
        {
            bool isSuccess = false;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string q = "DELETE FROM Products WHERE ProductId = @Id";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Id", productId);

                con.Open();
                isSuccess = cmd.ExecuteNonQuery() > 0;
            }

            return isSuccess;
        }

    }
}
