using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

class Sale
{
    string connection = @"Data Source=(localdb)\MSSQLLocalDB;
                          Initial Catalog=S_ManagemntDB;
                          Integrated Security=True";

    // 🔹 COMPLETE SALE
    public bool CompleteSale(DataGridView dgvCart, decimal totalAmount, int userId)
    {
        bool isSuccess = false;

        using (SqlConnection con = new SqlConnection(connection))
        {
            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                // 🔹 1. INSERT INTO SALES
                string saleQuery =
                @"INSERT INTO Sales (TotalAmount, SaleDate, UserId)
                  OUTPUT INSERTED.SaleId
                  VALUES (@total, GETDATE(), @uid)";

                SqlCommand saleCmd = new SqlCommand(saleQuery, con, tran);
                saleCmd.Parameters.AddWithValue("@total", totalAmount);
                saleCmd.Parameters.AddWithValue("@uid", userId);

                int saleId = Convert.ToInt32(saleCmd.ExecuteScalar());

                // 🔹 2. INSERT SALE DETAILS
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                    int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal lineTotal = qty * price;

                    // 🔹 STOCK CHECK
                    SqlCommand stockCmd = new SqlCommand(
                        "SELECT Stock FROM Products WHERE ProductId=@pid",
                        con, tran);

                    stockCmd.Parameters.AddWithValue("@pid", productId);

                    int stock = Convert.ToInt32(stockCmd.ExecuteScalar());

                    if (qty > stock)
                        throw new Exception("Not enough stock!");

                    // 🔹 INSERT SALE DETAILS
                    SqlCommand detailCmd = new SqlCommand(
                        @"INSERT INTO SaleDetails
                          (SaleId, ProductId, Quantity, Price, LineTotal)
                          VALUES (@sid, @pid, @q, @p, @t)",
                        con, tran);

                    detailCmd.Parameters.AddWithValue("@sid", saleId);
                    detailCmd.Parameters.AddWithValue("@pid", productId);
                    detailCmd.Parameters.AddWithValue("@q", qty);
                    detailCmd.Parameters.AddWithValue("@p", price);
                    detailCmd.Parameters.AddWithValue("@t", lineTotal);

                    detailCmd.ExecuteNonQuery();

                    // 🔹 UPDATE PRODUCT STOCK
                    SqlCommand updateStock = new SqlCommand(
                        @"UPDATE Products
                          SET Stock = Stock - @q
                          WHERE ProductId=@pid",
                        con, tran);

                    updateStock.Parameters.AddWithValue("@q", qty);
                    updateStock.Parameters.AddWithValue("@pid", productId);

                    updateStock.ExecuteNonQuery();
                }

                tran.Commit();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
                isSuccess = false;
            }
        }

        return isSuccess;
    }
}
