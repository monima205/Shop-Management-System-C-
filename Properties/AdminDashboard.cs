using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace ShopManagementSystem.Properties
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        AdminClass ad = new AdminClass();

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_ad_dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }

        private void btn_ad_show_Click(object sender, EventArgs e)
        {
            DataTable dt = ad.showAllProducts();
            dgv_ad.DataSource = dt;
        }

        private void btn_ad_showsale_Click(object sender, EventArgs e)
        {
            DataTable dt = ad.showSale();
            dgv_ad_sale.DataSource = dt;
        }

        private void btn_ad_admin_Click(object sender, EventArgs e)
        {
            btn_ad_admin.Visible = false;
        }

        private void btn_ad_product_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
            this.Hide();
        }

        private void dgv_ad_sale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ad_employee_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
