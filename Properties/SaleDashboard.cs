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
                Sale sale = new Sale();

                int userId = 1; // logged-in user id
                decimal total = Convert.ToDecimal(lblTotal.Text);

                if (sale.CompleteSale(dgvCart, total, userId))
                {
                    MessageBox.Show("Sale Completed Successfully");
                    dgvCart.Rows.Clear();
                    lblTotal.Text = "0.00";
                }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
        }

        private void btn_sd_back_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }
    }
}
