
namespace ShopManagementSystem.Properties
{ 
    partial class AdminDashboard
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
            this.panelleft = new System.Windows.Forms.Panel();
            this.btn_ad_admin = new System.Windows.Forms.Button();
            this.btn_ad_sale = new System.Windows.Forms.Button();
            this.btn_ad_stock = new System.Windows.Forms.Button();
            this.btn_ad_employee = new System.Windows.Forms.Button();
            this.btn_ad_product = new System.Windows.Forms.Button();
            this.btn_ad_dashboard = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBoxa_ad = new System.Windows.Forms.PictureBox();
            this.label_ad_paneltop = new System.Windows.Forms.Label();
            this.paneldown = new System.Windows.Forms.Panel();
            this.btn_ad_showsale = new System.Windows.Forms.Button();
            this.dgv_ad_sale = new System.Windows.Forms.DataGridView();
            this.btn_ad_show = new System.Windows.Forms.Button();
            this.dgv_ad = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelleft.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxa_ad)).BeginInit();
            this.paneldown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ad_sale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ad)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Teal;
            this.panelleft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelleft.Controls.Add(this.btn_ad_admin);
            this.panelleft.Controls.Add(this.btn_ad_sale);
            this.panelleft.Controls.Add(this.btn_ad_stock);
            this.panelleft.Controls.Add(this.btn_ad_employee);
            this.panelleft.Controls.Add(this.btn_ad_product);
            this.panelleft.Controls.Add(this.btn_ad_dashboard);
            this.panelleft.Location = new System.Drawing.Point(0, 9);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(200, 462);
            this.panelleft.TabIndex = 0;
            this.panelleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleft_Paint);
            // 
            // btn_ad_admin
            // 
            this.btn_ad_admin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ad_admin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_admin.ForeColor = System.Drawing.Color.Red;
            this.btn_ad_admin.Location = new System.Drawing.Point(3, 395);
            this.btn_ad_admin.Name = "btn_ad_admin";
            this.btn_ad_admin.Size = new System.Drawing.Size(188, 56);
            this.btn_ad_admin.TabIndex = 5;
            this.btn_ad_admin.Text = "Admin";
            this.btn_ad_admin.UseVisualStyleBackColor = false;
            this.btn_ad_admin.Click += new System.EventHandler(this.btn_ad_admin_Click);
            // 
            // btn_ad_sale
            // 
            this.btn_ad_sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ad_sale.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_sale.Location = new System.Drawing.Point(3, 258);
            this.btn_ad_sale.Name = "btn_ad_sale";
            this.btn_ad_sale.Size = new System.Drawing.Size(190, 56);
            this.btn_ad_sale.TabIndex = 4;
            this.btn_ad_sale.Text = "Sale Report";
            this.btn_ad_sale.UseVisualStyleBackColor = false;
            // 
            // btn_ad_stock
            // 
            this.btn_ad_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ad_stock.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_stock.Location = new System.Drawing.Point(3, 196);
            this.btn_ad_stock.Name = "btn_ad_stock";
            this.btn_ad_stock.Size = new System.Drawing.Size(188, 56);
            this.btn_ad_stock.TabIndex = 3;
            this.btn_ad_stock.Text = "Stock";
            this.btn_ad_stock.UseVisualStyleBackColor = false;
            // 
            // btn_ad_employee
            // 
            this.btn_ad_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ad_employee.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_employee.Location = new System.Drawing.Point(3, 134);
            this.btn_ad_employee.Name = "btn_ad_employee";
            this.btn_ad_employee.Size = new System.Drawing.Size(190, 56);
            this.btn_ad_employee.TabIndex = 2;
            this.btn_ad_employee.Text = "Employee";
            this.btn_ad_employee.UseVisualStyleBackColor = false;
            this.btn_ad_employee.Click += new System.EventHandler(this.btn_ad_employee_Click);
            // 
            // btn_ad_product
            // 
            this.btn_ad_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ad_product.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_product.Location = new System.Drawing.Point(3, 72);
            this.btn_ad_product.Name = "btn_ad_product";
            this.btn_ad_product.Size = new System.Drawing.Size(190, 56);
            this.btn_ad_product.TabIndex = 1;
            this.btn_ad_product.Text = "Product";
            this.btn_ad_product.UseVisualStyleBackColor = false;
            this.btn_ad_product.Click += new System.EventHandler(this.btn_ad_product_Click);
            // 
            // btn_ad_dashboard
            // 
            this.btn_ad_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ad_dashboard.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_dashboard.Location = new System.Drawing.Point(3, 10);
            this.btn_ad_dashboard.Name = "btn_ad_dashboard";
            this.btn_ad_dashboard.Size = new System.Drawing.Size(190, 56);
            this.btn_ad_dashboard.TabIndex = 0;
            this.btn_ad_dashboard.Text = "DashBoard";
            this.btn_ad_dashboard.UseVisualStyleBackColor = false;
            this.btn_ad_dashboard.Click += new System.EventHandler(this.btn_ad_dashboard_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Teal;
            this.paneltop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneltop.Controls.Add(this.btnClose);
            this.paneltop.Controls.Add(this.pictureBoxa_ad);
            this.paneltop.Controls.Add(this.label_ad_paneltop);
            this.paneltop.Location = new System.Drawing.Point(206, 9);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1036, 58);
            this.paneltop.TabIndex = 0;
            // 
            // pictureBoxa_ad
            // 
            this.pictureBoxa_ad.Image = global::ShopManagementSystem.Properties.Resources.download;
            this.pictureBoxa_ad.Location = new System.Drawing.Point(285, 3);
            this.pictureBoxa_ad.Name = "pictureBoxa_ad";
            this.pictureBoxa_ad.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxa_ad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxa_ad.TabIndex = 9;
            this.pictureBoxa_ad.TabStop = false;
            // 
            // label_ad_paneltop
            // 
            this.label_ad_paneltop.AutoSize = true;
            this.label_ad_paneltop.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad_paneltop.ForeColor = System.Drawing.Color.White;
            this.label_ad_paneltop.Location = new System.Drawing.Point(401, 8);
            this.label_ad_paneltop.Name = "label_ad_paneltop";
            this.label_ad_paneltop.Size = new System.Drawing.Size(349, 35);
            this.label_ad_paneltop.TabIndex = 0;
            this.label_ad_paneltop.Text = "Shop Management System";
            // 
            // paneldown
            // 
            this.paneldown.BackColor = System.Drawing.Color.Teal;
            this.paneldown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneldown.Controls.Add(this.btn_ad_showsale);
            this.paneldown.Controls.Add(this.dgv_ad_sale);
            this.paneldown.Controls.Add(this.btn_ad_show);
            this.paneldown.Controls.Add(this.dgv_ad);
            this.paneldown.Location = new System.Drawing.Point(206, 73);
            this.paneldown.Name = "paneldown";
            this.paneldown.Size = new System.Drawing.Size(1036, 398);
            this.paneldown.TabIndex = 1;
            // 
            // btn_ad_showsale
            // 
            this.btn_ad_showsale.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ad_showsale.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_showsale.Location = new System.Drawing.Point(680, 346);
            this.btn_ad_showsale.Name = "btn_ad_showsale";
            this.btn_ad_showsale.Size = new System.Drawing.Size(200, 41);
            this.btn_ad_showsale.TabIndex = 8;
            this.btn_ad_showsale.Text = "Show Sales";
            this.btn_ad_showsale.UseVisualStyleBackColor = false;
            this.btn_ad_showsale.Click += new System.EventHandler(this.btn_ad_showsale_Click);
            // 
            // dgv_ad_sale
            // 
            this.dgv_ad_sale.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_ad_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ad_sale.Location = new System.Drawing.Point(525, 3);
            this.dgv_ad_sale.Name = "dgv_ad_sale";
            this.dgv_ad_sale.RowHeadersWidth = 62;
            this.dgv_ad_sale.RowTemplate.Height = 28;
            this.dgv_ad_sale.Size = new System.Drawing.Size(504, 337);
            this.dgv_ad_sale.TabIndex = 7;
            this.dgv_ad_sale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ad_sale_CellContentClick);
            // 
            // btn_ad_show
            // 
            this.btn_ad_show.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ad_show.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_show.Location = new System.Drawing.Point(134, 342);
            this.btn_ad_show.Name = "btn_ad_show";
            this.btn_ad_show.Size = new System.Drawing.Size(200, 45);
            this.btn_ad_show.TabIndex = 6;
            this.btn_ad_show.Text = "Show Products";
            this.btn_ad_show.UseVisualStyleBackColor = false;
            this.btn_ad_show.Click += new System.EventHandler(this.btn_ad_show_Click);
            // 
            // dgv_ad
            // 
            this.dgv_ad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_ad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ad.Location = new System.Drawing.Point(3, 3);
            this.dgv_ad.Name = "dgv_ad";
            this.dgv_ad.RowHeadersWidth = 62;
            this.dgv_ad.RowTemplate.Height = 28;
            this.dgv_ad.Size = new System.Drawing.Size(516, 337);
            this.dgv_ad.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(990, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 38);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 474);
            this.Controls.Add(this.paneldown);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelleft);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panelleft.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxa_ad)).EndInit();
            this.paneldown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ad_sale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel paneldown;
        private System.Windows.Forms.Button btn_ad_dashboard;
        private System.Windows.Forms.Button btn_ad_admin;
        private System.Windows.Forms.Button btn_ad_sale;
        private System.Windows.Forms.Button btn_ad_stock;
        private System.Windows.Forms.Button btn_ad_employee;
        private System.Windows.Forms.Button btn_ad_product;
        private System.Windows.Forms.Label label_ad_paneltop;
        private System.Windows.Forms.DataGridView dgv_ad;
        private System.Windows.Forms.Button btn_ad_show;
        private System.Windows.Forms.Button btn_ad_showsale;
        private System.Windows.Forms.DataGridView dgv_ad_sale;
        private System.Windows.Forms.PictureBox pictureBoxa_ad;
        private System.Windows.Forms.Button btnClose;
    }
}
