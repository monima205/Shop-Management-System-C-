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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();

        }
        public void LoadInvoice(DataGridView cart, string total)
        {
            dgvInvoice.Rows.Clear();

            foreach (DataGridViewRow row in cart.Rows)
            {
                if (row.IsNewRow) continue;

                dgvInvoice.Rows.Add(
                    row.Cells["ProductName"].Value,
                    row.Cells["Quantity"].Value,
                    row.Cells["Price"].Value,
                    row.Cells["Total"].Value
                );
            }

            lblInvoiceNo.Text = "INV-" + DateTime.Now.Ticks.ToString().Substring(10);
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblCustomer.Text = "Walk-in Customer";
            lblTotal.Text = total;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 20;

            e.Graphics.DrawString("SHOP MANAGEMENT SYSTEM",
                new Font("Arial", 16, FontStyle.Bold),
                Brushes.Black, 200, y);

            y += 40;

            e.Graphics.DrawString("Invoice No: " + lblInvoiceNo.Text,
                new Font("Arial", 10), Brushes.Black, 20, y);

            e.Graphics.DrawString("Date: " + lblDate.Text,
                new Font("Arial", 10), Brushes.Black, 400, y);

            y += 30;

            e.Graphics.DrawString("Customer: " + lblCustomer.Text,
                new Font("Arial", 10), Brushes.Black, 20, y);

            y += 40;

            // Table Header
            e.Graphics.DrawString("Product", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 20, y);
            e.Graphics.DrawString("Qty", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 200, y);
            e.Graphics.DrawString("Price", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 300, y);
            e.Graphics.DrawString("Total", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 400, y);

            y += 20;
            e.Graphics.DrawLine(Pens.Black, 20, y, 500, y);
            y += 20;

            // Print DataGridView rows
            foreach (DataGridViewRow row in dgvInvoice.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 20, y);
                    e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 200, y);
                    e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 10), Brushes.Black, 300, y);
                    e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 10), Brushes.Black, 400, y);
                    y += 20;
                }
            }

            y += 20;
            e.Graphics.DrawLine(Pens.Black, 20, y, 500, y);
            y += 20;

            e.Graphics.DrawString("Total Amount: " + lblTotal.Text,
                new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black, 300, y);
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            dgvInvoice.Columns.Clear();
            dgvInvoice.Columns.Add("Product", "Product");
            dgvInvoice.Columns.Add("Qty", "Qty");
            dgvInvoice.Columns.Add("Price", "Price");
            dgvInvoice.Columns.Add("Total", "Total");

        }


    }
}
