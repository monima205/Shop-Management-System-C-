
namespace ShopManagementSystem.Properties
{
    partial class EmployeeDashboard
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
            this.btn_ed_logout = new System.Windows.Forms.Button();
            this.btn_ed_employee = new System.Windows.Forms.Button();
            this.btn_ed_salehistory = new System.Windows.Forms.Button();
            this.btn_ed_newsale = new System.Windows.Forms.Button();
            this.btn_ed_productlist = new System.Windows.Forms.Button();
            this.btn_ed_dashboard = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBoxa_ad = new System.Windows.Forms.PictureBox();
            this.label_ad_paneltop = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ed = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelleft.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxa_ad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Teal;
            this.panelleft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelleft.Controls.Add(this.btn_ed_logout);
            this.panelleft.Controls.Add(this.btn_ed_employee);
            this.panelleft.Controls.Add(this.btn_ed_salehistory);
            this.panelleft.Controls.Add(this.btn_ed_newsale);
            this.panelleft.Controls.Add(this.btn_ed_productlist);
            this.panelleft.Controls.Add(this.btn_ed_dashboard);
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(200, 470);
            this.panelleft.TabIndex = 0;
            // 
            // btn_ed_logout
            // 
            this.btn_ed_logout.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ed_logout.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ed_logout.ForeColor = System.Drawing.Color.Red;
            this.btn_ed_logout.Location = new System.Drawing.Point(115, 396);
            this.btn_ed_logout.Name = "btn_ed_logout";
            this.btn_ed_logout.Size = new System.Drawing.Size(78, 56);
            this.btn_ed_logout.TabIndex = 6;
            this.btn_ed_logout.Text = "Log Out";
            this.btn_ed_logout.UseVisualStyleBackColor = false;
            this.btn_ed_logout.Click += new System.EventHandler(this.btn_ed_logout_Click);
            // 
            // btn_ed_employee
            // 
            this.btn_ed_employee.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ed_employee.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ed_employee.Location = new System.Drawing.Point(3, 396);
            this.btn_ed_employee.Name = "btn_ed_employee";
            this.btn_ed_employee.Size = new System.Drawing.Size(106, 56);
            this.btn_ed_employee.TabIndex = 5;
            this.btn_ed_employee.Text = "Employee";
            this.btn_ed_employee.UseVisualStyleBackColor = false;
            this.btn_ed_employee.Click += new System.EventHandler(this.btn_ed_employee_Click);
            // 
            // btn_ed_salehistory
            // 
            this.btn_ed_salehistory.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ed_salehistory.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ed_salehistory.Location = new System.Drawing.Point(3, 205);
            this.btn_ed_salehistory.Name = "btn_ed_salehistory";
            this.btn_ed_salehistory.Size = new System.Drawing.Size(190, 56);
            this.btn_ed_salehistory.TabIndex = 4;
            this.btn_ed_salehistory.Text = "Sale History";
            this.btn_ed_salehistory.UseVisualStyleBackColor = false;
            this.btn_ed_salehistory.Click += new System.EventHandler(this.btn_ed_salehistory_Click);
            // 
            // btn_ed_newsale
            // 
            this.btn_ed_newsale.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_ed_newsale.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ed_newsale.Location = new System.Drawing.Point(3, 143);
            this.btn_ed_newsale.Name = "btn_ed_newsale";
            this.btn_ed_newsale.Size = new System.Drawing.Size(190, 56);
            this.btn_ed_newsale.TabIndex = 3;
            this.btn_ed_newsale.Text = "New Sale";
            this.btn_ed_newsale.UseVisualStyleBackColor = false;
            this.btn_ed_newsale.Click += new System.EventHandler(this.btn_ed_newsale_Click);
            // 
            // btn_ed_productlist
            // 
            this.btn_ed_productlist.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ed_productlist.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ed_productlist.Location = new System.Drawing.Point(3, 81);
            this.btn_ed_productlist.Name = "btn_ed_productlist";
            this.btn_ed_productlist.Size = new System.Drawing.Size(190, 56);
            this.btn_ed_productlist.TabIndex = 2;
            this.btn_ed_productlist.Text = "Product List";
            this.btn_ed_productlist.UseVisualStyleBackColor = false;
            this.btn_ed_productlist.Click += new System.EventHandler(this.btn_ed_productlist_Click);
            // 
            // btn_ed_dashboard
            // 
            this.btn_ed_dashboard.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_ed_dashboard.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ed_dashboard.Location = new System.Drawing.Point(3, 19);
            this.btn_ed_dashboard.Name = "btn_ed_dashboard";
            this.btn_ed_dashboard.Size = new System.Drawing.Size(190, 56);
            this.btn_ed_dashboard.TabIndex = 1;
            this.btn_ed_dashboard.Text = "DashBoard";
            this.btn_ed_dashboard.UseVisualStyleBackColor = false;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Teal;
            this.paneltop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneltop.Controls.Add(this.btnClose);
            this.paneltop.Controls.Add(this.pictureBoxa_ad);
            this.paneltop.Controls.Add(this.label_ad_paneltop);
            this.paneltop.Location = new System.Drawing.Point(201, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1033, 116);
            this.paneltop.TabIndex = 3;
            // 
            // pictureBoxa_ad
            // 
            this.pictureBoxa_ad.Image = global::ShopManagementSystem.Properties.Resources.download;
            this.pictureBoxa_ad.Location = new System.Drawing.Point(472, 53);
            this.pictureBoxa_ad.Name = "pictureBoxa_ad";
            this.pictureBoxa_ad.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxa_ad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxa_ad.TabIndex = 10;
            this.pictureBoxa_ad.TabStop = false;
            // 
            // label_ad_paneltop
            // 
            this.label_ad_paneltop.AutoSize = true;
            this.label_ad_paneltop.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad_paneltop.ForeColor = System.Drawing.Color.Snow;
            this.label_ad_paneltop.Location = new System.Drawing.Point(364, 18);
            this.label_ad_paneltop.Name = "label_ad_paneltop";
            this.label_ad_paneltop.Size = new System.Drawing.Size(330, 32);
            this.label_ad_paneltop.TabIndex = 1;
            this.label_ad_paneltop.Text = "Shop Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgv_ed);
            this.panel1.Location = new System.Drawing.Point(201, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 337);
            this.panel1.TabIndex = 4;
            // 
            // dgv_ed
            // 
            this.dgv_ed.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ed.Location = new System.Drawing.Point(13, 12);
            this.dgv_ed.Name = "dgv_ed";
            this.dgv_ed.RowHeadersWidth = 62;
            this.dgv_ed.RowTemplate.Height = 28;
            this.dgv_ed.Size = new System.Drawing.Size(1007, 307);
            this.dgv_ed.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(986, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 38);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.panelleft.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxa_ad)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button btn_ed_dashboard;
        private System.Windows.Forms.Button btn_ed_productlist;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label label_ad_paneltop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ed;
        private System.Windows.Forms.Button btn_ed_employee;
        private System.Windows.Forms.Button btn_ed_salehistory;
        private System.Windows.Forms.Button btn_ed_newsale;
        private System.Windows.Forms.Button btn_ed_logout;
        private System.Windows.Forms.PictureBox pictureBoxa_ad;
        private System.Windows.Forms.Button btnClose;
    }
}