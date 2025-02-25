namespace Blood_bank_system
{
    partial class edituserform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edituserform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditUserBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.EditUserBtn);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 461);
            this.panel1.TabIndex = 1;
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.EditUserBtn.FlatAppearance.BorderSize = 0;
            this.EditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUserBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserBtn.ForeColor = System.Drawing.Color.White;
            this.EditUserBtn.Location = new System.Drawing.Point(22, 377);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(340, 50);
            this.EditUserBtn.TabIndex = 4;
            this.EditUserBtn.Text = "Editer";
            this.EditUserBtn.UseVisualStyleBackColor = false;
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Password);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.groupBox3.Size = new System.Drawing.Size(360, 80);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "motpass";
            // 
            // Password
            // 
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(10, 31);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(340, 43);
            this.Password.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Username);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.groupBox2.Size = new System.Drawing.Size(360, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "utilisateur";
            // 
            // Username
            // 
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(10, 31);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(340, 43);
            this.Username.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserType);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.groupBox1.Size = new System.Drawing.Size(360, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type d\'utilisateur";
            // 
            // UserType
            // 
            this.UserType.BackColor = System.Drawing.SystemColors.Info;
            this.UserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserType.DropDownHeight = 100;
            this.UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserType.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.FormattingEnabled = true;
            this.UserType.IntegralHeight = false;
            this.UserType.Items.AddRange(new object[] {
            "adminstrateur",
            "utilisateur"});
            this.UserType.Location = new System.Drawing.Point(10, 31);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(340, 40);
            this.UserType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editer utilisateur";
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(356, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 25);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // edituserform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "edituserform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edituserform";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edituserform_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditUserBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseBtn;
    }
}