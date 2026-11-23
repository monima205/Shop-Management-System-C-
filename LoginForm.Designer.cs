
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
            this.pictureBoxlogin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lg_login = new System.Windows.Forms.Button();
            this.txt_lg_password = new System.Windows.Forms.TextBox();
            this.txt_lg_usarname = new System.Windows.Forms.TextBox();
            this.label_lg_password = new System.Windows.Forms.Label();
            this.label_lg_usarname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxlogin
            // 
            this.pictureBoxlogin.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBoxlogin.Image = global::ShopManagementSystem.Properties.Resources.images;
            this.pictureBoxlogin.Location = new System.Drawing.Point(310, 10);
            this.pictureBoxlogin.Name = "pictureBoxlogin";
            this.pictureBoxlogin.Size = new System.Drawing.Size(129, 117);
            this.pictureBoxlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlogin.TabIndex = 14;
            this.pictureBoxlogin.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(735, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 38);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(177, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shop Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_lg_login
            // 
            this.btn_lg_login.BackColor = System.Drawing.SystemColors.Info;
            this.btn_lg_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_lg_login.Location = new System.Drawing.Point(300, 317);
            this.btn_lg_login.Name = "btn_lg_login";
            this.btn_lg_login.Size = new System.Drawing.Size(139, 50);
            this.btn_lg_login.TabIndex = 5;
            this.btn_lg_login.Text = "Login";
            this.btn_lg_login.UseVisualStyleBackColor = false;
            this.btn_lg_login.Click += new System.EventHandler(this.btn_lg_login_Click_1);
            // 
            // txt_lg_password
            // 
            this.txt_lg_password.BackColor = System.Drawing.SystemColors.Info;
            this.txt_lg_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lg_password.Location = new System.Drawing.Point(284, 262);
            this.txt_lg_password.Name = "txt_lg_password";
            this.txt_lg_password.PasswordChar = '*';
            this.txt_lg_password.Size = new System.Drawing.Size(254, 35);
            this.txt_lg_password.TabIndex = 4;
            // 
            // txt_lg_usarname
            // 
            this.txt_lg_usarname.BackColor = System.Drawing.SystemColors.Info;
            this.txt_lg_usarname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_lg_usarname.Location = new System.Drawing.Point(284, 209);
            this.txt_lg_usarname.Name = "txt_lg_usarname";
            this.txt_lg_usarname.Size = new System.Drawing.Size(254, 35);
            this.txt_lg_usarname.TabIndex = 3;
            // 
            // label_lg_password
            // 
            this.label_lg_password.AutoSize = true;
            this.label_lg_password.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label_lg_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lg_password.ForeColor = System.Drawing.Color.Snow;
            this.label_lg_password.Location = new System.Drawing.Point(154, 265);
            this.label_lg_password.Name = "label_lg_password";
            this.label_lg_password.Size = new System.Drawing.Size(124, 26);
            this.label_lg_password.TabIndex = 2;
            this.label_lg_password.Text = "Password :";
            // 
            // label_lg_usarname
            // 
            this.label_lg_usarname.AutoSize = true;
            this.label_lg_usarname.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label_lg_usarname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_lg_usarname.ForeColor = System.Drawing.Color.Snow;
            this.label_lg_usarname.Location = new System.Drawing.Point(149, 212);
            this.label_lg_usarname.Name = "label_lg_usarname";
            this.label_lg_usarname.Size = new System.Drawing.Size(129, 26);
            this.label_lg_usarname.TabIndex = 1;
            this.label_lg_usarname.Text = "Username :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBoxlogin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_lg_login);
            this.panel1.Controls.Add(this.txt_lg_usarname);
            this.panel1.Controls.Add(this.label_lg_password);
            this.panel1.Controls.Add(this.txt_lg_password);
            this.panel1.Controls.Add(this.label_lg_usarname);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 427);
            this.panel1.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lg_login;
        private System.Windows.Forms.TextBox txt_lg_password;
        private System.Windows.Forms.TextBox txt_lg_usarname;
        private System.Windows.Forms.Label label_lg_password;
        private System.Windows.Forms.Label label_lg_usarname;
        private System.Windows.Forms.PictureBox pictureBoxlogin;
        private System.Windows.Forms.Panel panel1;
    }
}