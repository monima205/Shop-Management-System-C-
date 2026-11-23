
namespace ShopManagementSystem.Properties
{
    partial class InvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary> 
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNo.Location = new System.Drawing.Point(82, 83);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(135, 26);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Invoice No :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(107, 131);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 26);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(82, 178);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(126, 26);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer :";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(332, 23);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 62;
            this.dgvInvoice.RowTemplate.Height = 28;
            this.dgvInvoice.Size = new System.Drawing.Size(728, 314);
            this.dgvInvoice.TabIndex = 3;
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(103, 223);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 26);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total :";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(644, 369);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 37);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 486);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInvoiceNo);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
