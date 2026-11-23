
namespace ShopManagementSystem
{
    partial class LoginForm
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
            this.label_lg_usarname = new System.Windows.Forms.Label();
            this.label_lg_password = new System.Windows.Forms.Label();
            this.txt_lg_usarname = new System.Windows.Forms.TextBox();
            this.txt_lg_password = new System.Windows.Forms.TextBox();
            this.btn_lg_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_lg_usarname
            // 
            this.label_lg_usarname.AutoSize = true;
            this.label_lg_usarname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_lg_usarname.Location = new System.Drawing.Point(119, 152);
            this.label_lg_usarname.Name = "label_lg_usarname";
            this.label_lg_usarname.Size = new System.Drawing.Size(129, 26);
            this.label_lg_usarname.TabIndex = 0;
            this.label_lg_usarname.Text = "Username :";
            // 
            // label_lg_password
            // 
            this.label_lg_password.AutoSize = true;
            this.label_lg_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lg_password.Location = new System.Drawing.Point(124, 209);
            this.label_lg_password.Name = "label_lg_password";
            this.label_lg_password.Size = new System.Drawing.Size(124, 26);
            this.label_lg_password.TabIndex = 1;
            this.label_lg_password.Text = "Password :";
            // 
            // txt_lg_usarname
            // 
            this.txt_lg_usarname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_lg_usarname.Location = new System.Drawing.Point(254, 152);
            this.txt_lg_usarname.Name = "txt_lg_usarname";
            this.txt_lg_usarname.Size = new System.Drawing.Size(301, 35);
            this.txt_lg_usarname.TabIndex = 2;
            // 
            // txt_lg_password
            // 
            this.txt_lg_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lg_password.Location = new System.Drawing.Point(254, 206);
            this.txt_lg_password.Name = "txt_lg_password";
            this.txt_lg_password.PasswordChar = '*';
            this.txt_lg_password.Size = new System.Drawing.Size(301, 35);
            this.txt_lg_password.TabIndex = 3;
            // 
            // btn_lg_login
            // 
            this.btn_lg_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_lg_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_lg_login.Location = new System.Drawing.Point(453, 273);
            this.btn_lg_login.Name = "btn_lg_login";
            this.btn_lg_login.Size = new System.Drawing.Size(139, 50);
            this.btn_lg_login.TabIndex = 4;
            this.btn_lg_login.Text = "Login";
            this.btn_lg_login.UseVisualStyleBackColor = false;
            this.btn_lg_login.Click += new System.EventHandler(this.btn_lg_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shop Management System";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_lg_login);
            this.Controls.Add(this.txt_lg_password);
            this.Controls.Add(this.txt_lg_usarname);
            this.Controls.Add(this.label_lg_password);
            this.Controls.Add(this.label_lg_usarname);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_lg_usarname;
        private System.Windows.Forms.Label label_lg_password;
        private System.Windows.Forms.TextBox txt_lg_usarname;
        private System.Windows.Forms.TextBox txt_lg_password;
        private System.Windows.Forms.Button btn_lg_login;
        private System.Windows.Forms.Label label1;
    }
}