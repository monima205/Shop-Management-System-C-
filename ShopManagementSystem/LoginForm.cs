using ShopManagementSystem.Properties;
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

namespace ShopManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=S_ManagemntDB;Integrated Security=True";
        private void btn_lg_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT Role FROM Users WHERE Username=@u AND Password=@p";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@u", txt_lg_usarname.Text);
            cmd.Parameters.AddWithValue("@p", txt_lg_password.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string role = dr["Role"].ToString();

                if (role == "Admin")
                {
                    AdminDashboard ad = new AdminDashboard();
                    ad.Show();
                }
                else
                {
                    EmployeeDashboard ed = new EmployeeDashboard();
                    ed.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            con.Close();
        }
    }
}
