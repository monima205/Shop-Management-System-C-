
namespace ShopManagementSystem.Properties
{
    partial class SaleDashboard
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
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label_sd_price = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label_sd_qty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btn_sd_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProducts
            // 
            this.cmbProducts.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(314, 33);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(419, 28);
            this.cmbProducts.TabIndex = 0;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // label_sd_price
            // 
            this.label_sd_price.AutoSize = true;
            this.label_sd_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_sd_price.Location = new System.Drawing.Point(49, 146);
            this.label_sd_price.Name = "label_sd_price";
            this.label_sd_price.Size = new System.Drawing.Size(81, 26);
            this.label_sd_price.TabIndex = 1;
            this.label_sd_price.Text = "Price :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPrice.Location = new System.Drawing.Point(136, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(65, 35);
            this.txtPrice.TabIndex = 3;
            // 
            // label_sd_qty
            // 
            this.label_sd_qty.AutoSize = true;
            this.label_sd_qty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_sd_qty.Location = new System.Drawing.Point(12, 91);
            this.label_sd_qty.Name = "label_sd_qty";
            this.label_sd_qty.Size = new System.Drawing.Size(118, 26);
            this.label_sd_qty.TabIndex = 4;
            this.label_sd_qty.Text = "Quantity :";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtQty.Location = new System.Drawing.Point(136, 91);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(65, 35);
            this.txtQty.TabIndex = 5;
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(207, 76);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.RowTemplate.Height = 28;
            this.dgvCart.Size = new System.Drawing.Size(581, 318);
            this.dgvCart.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Snow;
            this.btnAddToCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.Location = new System.Drawing.Point(99, 207);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(102, 95);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(690, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 33);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total :";
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.Snow;
            this.btnCompleteSale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompleteSale.Location = new System.Drawing.Point(617, 400);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(171, 38);
            this.btnCompleteSale.TabIndex = 9;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Snow;
            this.btnInvoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnInvoice.Location = new System.Drawing.Point(468, 401);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(143, 38);
            this.btnInvoice.TabIndex = 10;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btn_sd_back
            // 
            this.btn_sd_back.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sd_back.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sd_back.Location = new System.Drawing.Point(12, 402);
            this.btn_sd_back.Name = "btn_sd_back";
            this.btn_sd_back.Size = new System.Drawing.Size(118, 38);
            this.btn_sd_back.TabIndex = 11;
            this.btn_sd_back.Text = "Back";
            this.btn_sd_back.UseVisualStyleBackColor = false;
            this.btn_sd_back.Click += new System.EventHandler(this.btn_sd_back_Click);
            // 
            // SaleDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sd_back);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnCompleteSale);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label_sd_qty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label_sd_price);
            this.Controls.Add(this.cmbProducts);
            this.Name = "SaleDashboard";
            this.Text = "SaleDashboard";
            this.Load += new System.EventHandler(this.SaleDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label_sd_price;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label_sd_qty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btn_sd_back;
    }
}