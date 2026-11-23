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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        EmployeeClass ed = new EmployeeClass();

        private void btn_ed_productlist_Click(object sender, EventArgs e)
        {
            DataTable dt = ed.productList();
            dgv_ed.DataSource = dt;
        }

        private void btn_ed_employee_Click(object sender, EventArgs e)
        {
            btn_ed_employee.Visible = false;
        }

        private void btn_ed_logout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void btn_ed_newsale_Click(object sender, EventArgs e)
        {
            SaleDashboard sd = new SaleDashboard();
            sd.Show();
            this.Hide();
        }

        private void btn_ed_salehistory_Click(object sender, EventArgs e)
        {
            SaleHistory sh = new SaleHistory();
            sh.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
