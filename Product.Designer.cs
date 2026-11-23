
namespace ShopManagementSystem
{
    partial class Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblpid = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_show);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.dgv_product);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.txt_stock);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.txt_category);
            this.panel1.Controls.Add(this.txt_pname);
            this.panel1.Controls.Add(this.txt_pid);
            this.panel1.Controls.Add(this.lblprice);
            this.panel1.Controls.Add(this.lblstock);
            this.panel1.Controls.Add(this.lblquantity);
            this.panel1.Controls.Add(this.lblcategory);
            this.panel1.Controls.Add(this.lblpname);
            this.panel1.Controls.Add(this.lblpid);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblpid.Location = new System.Drawing.Point(50, 22);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(137, 26);
            this.lblpid.TabIndex = 6;
            this.lblpid.Text = "Product Id :";
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblpname.Location = new System.Drawing.Point(13, 80);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(174, 26);
            this.lblpname.TabIndex = 7;
            this.lblpname.Text = "Product Name :";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblcategory.Location = new System.Drawing.Point(66, 133);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(121, 26);
            this.lblcategory.TabIndex = 8;
            this.lblcategory.Text = "Category :";
            this.lblcategory.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblquantity.Location = new System.Drawing.Point(69, 193);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(118, 26);
            this.lblquantity.TabIndex = 9;
            this.lblquantity.Text = "Quantity :";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblstock.Location = new System.Drawing.Point(104, 244);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(83, 26);
            this.lblstock.TabIndex = 10;
            this.lblstock.Text = "Stock :";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblprice.Location = new System.Drawing.Point(106, 307);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(81, 26);
            this.lblprice.TabIndex = 11;
            this.lblprice.Text = "Price :";
            // 
            // txt_pid
            // 
            this.txt_pid.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_pid.Location = new System.Drawing.Point(193, 19);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(110, 35);
            this.txt_pid.TabIndex = 12;
            // 
            // txt_pname
            // 
            this.txt_pname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_pname.Location = new System.Drawing.Point(193, 77);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(110, 35);
            this.txt_pname.TabIndex = 13;
            // 
            // txt_category
            // 
            this.txt_category.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_category.Location = new System.Drawing.Point(193, 130);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(110, 35);
            this.txt_category.TabIndex = 14;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_quantity.Location = new System.Drawing.Point(193, 190);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(110, 35);
            this.txt_quantity.TabIndex = 15;
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_stock.Location = new System.Drawing.Point(193, 241);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(110, 35);
            this.txt_stock.TabIndex = 16;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_price.Location = new System.Drawing.Point(193, 298);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(110, 35);
            this.txt_price.TabIndex = 17;
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(309, 22);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 62;
            this.dgv_product.RowTemplate.Height = 28;
            this.dgv_product.Size = new System.Drawing.Size(460, 314);
            this.dgv_product.TabIndex = 18;
            this.dgv_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(421, 355);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 53);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(547, 355);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(109, 53);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(662, 355);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 53);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(18, 355);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 53);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(299, 355);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(116, 53);
            this.btn_show.TabIndex = 23;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.TextBox txt_pid;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_show;
    }
}