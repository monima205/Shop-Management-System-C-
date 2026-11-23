using ShopManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class Product : Form
    {
        ProductClass s = new ProductClass();
        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=S_ManagemntDB;Integrated Security=True";

        public Product()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
        public void Clear()
        {
            txt_pname = null;
            txt_pid.Clear();
            txt_category = null;
            txt_price.Clear();
            txt_stock.Clear();
            txt_quantity = null;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            ProductClass s = new ProductClass();

            s.name = txt_pname.Text;
            s.category = txt_category.Text;
            s.price = Convert.ToDecimal(txt_price.Text);
            s.stock = Convert.ToInt32(txt_stock.Text);
            s.quantity = Convert.ToInt32(txt_quantity.Text);

            if (s.insert(s))
            {
                MessageBox.Show("Product added successfully!");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add product!");
            }

            dgv_product.DataSource = s.showAllProducts();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ProductClass p = new ProductClass();

            p.id = Convert.ToInt32(txt_pid.Text);
            p.name = txt_pname.Text;      // must exist
            p.category = txt_category.Text;
            p.price = Convert.ToDecimal(txt_price.Text);
            p.stock = Convert.ToInt32(txt_stock.Text);
            p.quantity = Convert.ToInt32(txt_quantity.Text);

            if (p.Update(p))
            {
                MessageBox.Show("Product Updated Successfully!");
                dgv_product.DataSource = p.showAllProducts();
                Clear();
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }
            DataTable dt = s.showAllProducts();
            dgv_product.DataSource = dt;

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = s.showAllProducts();
            dgv_product.DataSource = dt;
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_pid.Text = dgv_product.CurrentRow.Cells["ProductId"].Value.ToString();
            txt_pname.Text = dgv_product.CurrentRow.Cells["ProductName"].Value.ToString();
            txt_category.Text = dgv_product.CurrentRow.Cells["Category"].Value.ToString();
            txt_price.Text = dgv_product.CurrentRow.Cells["Price"].Value.ToString();
            txt_stock.Text = dgv_product.CurrentRow.Cells["Stock"].Value.ToString();
            txt_quantity.Text = dgv_product.CurrentRow.Cells["Quantity"].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ProductClass p = new ProductClass();

            int productId = Convert.ToInt32(txt_pid.Text);

            if (p.Delete(productId))
            {
                MessageBox.Show("Product deleted successfully!");
                dgv_product.DataSource = p.showAllProducts();
                Clear();
            }
            else
            {
                MessageBox.Show("Delete failed!");
            }
        }
    }
}

