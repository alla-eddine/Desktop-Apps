namespace Blood_bank_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.RadioUser = new System.Windows.Forms.RadioButton();
            this.RadioAdmin = new System.Windows.Forms.RadioButton();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.Font = new System.Drawing.Font("Yu Gothic UI", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(41, 202);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(295, 42);
            this.UserName.TabIndex = 0;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(41, 301);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(295, 32);
            this.Password.TabIndex = 1;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.Red;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.White;
            this.Connect.Location = new System.Drawing.Point(28, 369);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(322, 60);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // RadioUser
            // 
            this.RadioUser.AutoSize = true;
            this.RadioUser.BackColor = System.Drawing.Color.White;
            this.RadioUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioUser.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioUser.Location = new System.Drawing.Point(31, 114);
            this.RadioUser.Name = "RadioUser";
            this.RadioUser.Size = new System.Drawing.Size(117, 29);
            this.RadioUser.TabIndex = 3;
            this.RadioUser.TabStop = true;
            this.RadioUser.Text = "Utilisateur";
            this.RadioUser.UseVisualStyleBackColor = false;
            // 
            // RadioAdmin
            // 
            this.RadioAdmin.AutoSize = true;
            this.RadioAdmin.BackColor = System.Drawing.Color.White;
            this.RadioAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioAdmin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAdmin.Location = new System.Drawing.Point(155, 114);
            this.RadioAdmin.Name = "RadioAdmin";
            this.RadioAdmin.Size = new System.Drawing.Size(86, 29);
            this.RadioAdmin.TabIndex = 4;
            this.RadioAdmin.TabStop = true;
            this.RadioAdmin.Text = "Admin";
            this.RadioAdmin.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.Window;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(-2, -2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 25);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RadioAdmin);
            this.Controls.Add(this.RadioUser);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.RadioButton RadioUser;
        private System.Windows.Forms.RadioButton RadioAdmin;
        private System.Windows.Forms.Button CloseBtn;
    }
}