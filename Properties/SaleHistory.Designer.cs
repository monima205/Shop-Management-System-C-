
namespace ShopManagementSystem.Properties
{
    partial class SaleHistory
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
            this.dgvSalesHistory = new System.Windows.Forms.DataGridView();
            this.btn_sh_show = new System.Windows.Forms.Button();
            this.btn_sh_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesHistory
            // 
            this.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesHistory.Location = new System.Drawing.Point(12, 12);
            this.dgvSalesHistory.Name = "dgvSalesHistory";
            this.dgvSalesHistory.RowHeadersWidth = 62;
            this.dgvSalesHistory.RowTemplate.Height = 28;
            this.dgvSalesHistory.Size = new System.Drawing.Size(776, 385);
            this.dgvSalesHistory.TabIndex = 0;
            // 
            // btn_sh_show
            // 
            this.btn_sh_show.BackColor = System.Drawing.Color.DarkGray;
            this.btn_sh_show.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_sh_show.Location = new System.Drawing.Point(403, 400);
            this.btn_sh_show.Name = "btn_sh_show";
            this.btn_sh_show.Size = new System.Drawing.Size(171, 38);
            this.btn_sh_show.TabIndex = 10;
            this.btn_sh_show.Text = "Show";
            this.btn_sh_show.UseVisualStyleBackColor = false;
            this.btn_sh_show.Click += new System.EventHandler(this.btn_sh_show_Click);
            // 
            // btn_sh_back
            // 
            this.btn_sh_back.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sh_back.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btn_sh_back.Location = new System.Drawing.Point(110, 403);
            this.btn_sh_back.Name = "btn_sh_back";
            this.btn_sh_back.Size = new System.Drawing.Size(136, 38);
            this.btn_sh_back.TabIndex = 12;
            this.btn_sh_back.Text = "Back";
            this.btn_sh_back.UseVisualStyleBackColor = false;
            this.btn_sh_back.Click += new System.EventHandler(this.btn_sh_back_Click);
            // 
            // SaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sh_back);
            this.Controls.Add(this.btn_sh_show);
            this.Controls.Add(this.dgvSalesHistory);
            this.Name = "SaleHistory";
            this.Text = "SaleHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesHistory;
        private System.Windows.Forms.Button btn_sh_show;
        private System.Windows.Forms.Button btn_sh_back;
    }
}