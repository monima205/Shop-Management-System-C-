using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.Properties
{
    public partial class SaleDashboard : Form
    {
        public SaleDashboard()
        {
            InitializeComponent();
        }

        void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ProductId, ProductName, Price FROM Products WHERE Quantity > 0", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbProducts.DataSource = dt;
                cmbProducts.DisplayMember = "ProductName";
                cmbProducts.ValueMember = "ProductId";
            }
        }

        private void SaleDashboard_Load(object sender, EventArgs e)
        {
            LoadProducts();

            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("ProductId", "Product ID");
            dgvCart.Columns.Add("ProductName", "Product Name");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.Columns.Add("Price", "Price");
            dgvCart.Columns.Add("Total", "Total");

            dgvCart.Columns["ProductId"].Visible = false;
        }


        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=S_ManagemntDB;Integrated Security=True";
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem == null) return;

            DataRowView drv = cmbProducts.SelectedItem as DataRowView;
            txtPrice.Text = drv["Price"].ToString();
        }

        void CalculateTotal()
        {
            decimal sum = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;
                sum += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            lblTotal.Text = sum.ToString("0.00");
        }



        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter valid quantity");
                return;
            }

            int pid = Convert.ToInt32(cmbProducts.SelectedValue);
            string pname = cmbProducts.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;

                if (Convert.ToInt32(row.Cells["ProductId"].Value) == pid)
                {
                    int newQty = Convert.ToInt32(row.Cells["Quantity"].Value) + qty;

                    row.Cells["Quantity"].Value = newQty;
                    row.Cells["Total"].Value = newQty * price;

                    CalculateTotal();
                    return;
                }
            }

            dgvCart.Rows.Add(pid, pname, qty, price, qty * price);
            CalculateTotal();

            txtQty.Clear();
        }


        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    // 🔹 Convert total safely
                    if (!decimal.TryParse(lblTotal.Text, out decimal totalAmount))
                        throw new Exception("Invalid total amount.");

                    // 🔹 Insert Sale
                    SqlCommand saleCmd = new SqlCommand(
                        @"INSERT INTO Sales ( TotalAmount, SaleDate)
                  OUTPUT INSERTED.SaleId
                  VALUES (@t, GETDATE())",
                        con, tran);

                    //saleCmd.Parameters.AddWithValue("@SI", "SaleId");
                   // saleCmd.Parameters.AddWithValue("@PI", "ProductId");
                    saleCmd.Parameters.AddWithValue("@t", totalAmount);
                    //saleCmd.Parameters.AddWithValue("@EN", "EmployeeName");

                    int saleId = Convert.ToInt32(saleCmd.ExecuteScalar());

                    // 🔹 Process each cart item
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        decimal lineTotal = quantity * price;

                        // 🔹 Check stock
                        SqlCommand stockCheck = new SqlCommand(
                            "SELECT Stock FROM Products WHERE ProductId = @pid",
                            con, tran);

                        stockCheck.Parameters.AddWithValue("@pid", productId);

                        object result = stockCheck.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                            throw new Exception("Product not found!");

                        int stock = Convert.ToInt32(result);

                        if (quantity > stock)
                            throw new Exception("Not enough stock for selected product.");

                        // 🔹 Insert Sale Details
                        SqlCommand detailCmd = new SqlCommand(
                            @"INSERT INTO SaleDetails
                      (SaleId, ProductId, Quantity, Price, LineTotal)
                      VALUES (@sid, @pid, @q, @p, @t)",
                            con, tran);

                        detailCmd.Parameters.AddWithValue("@sid", saleId);
                        detailCmd.Parameters.AddWithValue("@pid", productId);
                        detailCmd.Parameters.AddWithValue("@q", quantity);
                        detailCmd.Parameters.AddWithValue("@p", price);
                        detailCmd.Parameters.AddWithValue("@t", lineTotal);

                        detailCmd.ExecuteNonQuery();

                        // 🔹 Update stock
                        SqlCommand stockCmd = new SqlCommand(
                            @"UPDATE Products SET Quantity = Quantity - @q WHERE ProductId = @pid",
                            con, tran);

                        stockCmd.Parameters.AddWithValue("@q", quantity);
                        stockCmd.Parameters.AddWithValue("@pid", productId);

                        stockCmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show("Sale Completed Successfully");

                    dgvCart.Rows.Clear();
                    lblTotal.Text = "0.00";
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            InvoiceForm inv = new InvoiceForm();
            inv.LoadInvoice(dgvCart, lblTotal.Text);
            inv.ShowDialog();
        }

    }
}
