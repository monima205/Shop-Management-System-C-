using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShopManagementSystem.LoginForm;

namespace ShopManagementSystem.Properties
{
    public partial class SaleHistory : Form
    {
        public SaleHistory()
        {
            InitializeComponent();
        }
        private void btn_sh_show_Click(object sender, EventArgs e)
        {
            SHistory sh = new SHistory();

            DataTable dt = new DataTable();
            

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No sales history found.");
                return;
            }

            dgvSalesHistory.DataSource = dt;
        }

        private void btn_sh_back_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }
    }
}
