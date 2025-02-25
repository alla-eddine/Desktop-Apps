namespace Blood_bank_system
{
    partial class newdonorform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newdonorform));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegisterNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NomComplet = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Sexe = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Telephone = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LieuNaissance = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.TypeDonneur = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.DateDonne = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Groupage = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.Poches = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.AddDonorBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RegisterNum);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(280, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Num";
            // 
            // RegisterNum
            // 
            this.RegisterNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterNum.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNum.Location = new System.Drawing.Point(5, 27);
            this.RegisterNum.Name = "RegisterNum";
            this.RegisterNum.Size = new System.Drawing.Size(270, 33);
            this.RegisterNum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NomComplet);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(330, 127);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(280, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nom complet";
            // 
            // NomComplet
            // 
            this.NomComplet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NomComplet.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomComplet.Location = new System.Drawing.Point(5, 27);
            this.NomComplet.Name = "NomComplet";
            this.NomComplet.Size = new System.Drawing.Size(270, 33);
            this.NomComplet.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Sexe);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(621, 127);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(280, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexe";
            // 
            // Sexe
            // 
            this.Sexe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sexe.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexe.FormattingEnabled = true;
            this.Sexe.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sexe.Location = new System.Drawing.Point(5, 27);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(270, 33);
            this.Sexe.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Telephone);
            this.groupBox4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(621, 212);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(280, 70);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Numero de Telephone";
            // 
            // Telephone
            // 
            this.Telephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Telephone.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.Location = new System.Drawing.Point(5, 27);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(270, 33);
            this.Telephone.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LieuNaissance);
            this.groupBox5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(330, 212);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(280, 70);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lieu de naissance";
            // 
            // LieuNaissance
            // 
            this.LieuNaissance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LieuNaissance.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LieuNaissance.Location = new System.Drawing.Point(5, 27);
            this.LieuNaissance.Name = "LieuNaissance";
            this.LieuNaissance.Size = new System.Drawing.Size(270, 33);
            this.LieuNaissance.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DateNaissance);
            this.groupBox6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(38, 212);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(280, 70);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Date de naissance";
            // 
            // DateNaissance
            // 
            this.DateNaissance.CustomFormat = "";
            this.DateNaissance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateNaissance.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNaissance.Location = new System.Drawing.Point(5, 27);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(270, 33);
            this.DateNaissance.TabIndex = 0;
            this.DateNaissance.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.TypeDonneur);
            this.groupBox7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(621, 407);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox7.Size = new System.Drawing.Size(280, 70);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Type de donneur";
            // 
            // TypeDonneur
            // 
            this.TypeDonneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeDonneur.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeDonneur.FormattingEnabled = true;
            this.TypeDonneur.Items.AddRange(new object[] {
            "Régulier",
            "Régulier-Cp",
            "Occasionnel",
            "Occasionnel-Cp"});
            this.TypeDonneur.Location = new System.Drawing.Point(5, 27);
            this.TypeDonneur.Name = "TypeDonneur";
            this.TypeDonneur.Size = new System.Drawing.Size(270, 33);
            this.TypeDonneur.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.DateDonne);
            this.groupBox8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(327, 407);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox8.Size = new System.Drawing.Size(280, 70);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Date de donne";
            // 
            // DateDonne
            // 
            this.DateDonne.CustomFormat = " ";
            this.DateDonne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateDonne.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDonne.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDonne.Location = new System.Drawing.Point(5, 27);
            this.DateDonne.Name = "DateDonne";
            this.DateDonne.Size = new System.Drawing.Size(270, 33);
            this.DateDonne.TabIndex = 0;
            this.DateDonne.Value = new System.DateTime(2025, 2, 5, 0, 0, 0, 0);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Groupage);
            this.groupBox9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(35, 407);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox9.Size = new System.Drawing.Size(280, 70);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Groupage";
            // 
            // Groupage
            // 
            this.Groupage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Groupage.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupage.FormattingEnabled = true;
            this.Groupage.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.Groupage.Location = new System.Drawing.Point(5, 27);
            this.Groupage.Name = "Groupage";
            this.Groupage.Size = new System.Drawing.Size(270, 33);
            this.Groupage.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.Poches);
            this.groupBox10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(327, 490);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox10.Size = new System.Drawing.Size(280, 70);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Poches";
            // 
            // Poches
            // 
            this.Poches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Poches.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poches.FormattingEnabled = true;
            this.Poches.Items.AddRange(new object[] {
            "Poche",
            "DNP",
            "QI"});
            this.Poches.Location = new System.Drawing.Point(5, 27);
            this.Poches.Name = "Poches";
            this.Poches.Size = new System.Drawing.Size(270, 33);
            this.Poches.TabIndex = 2;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.Adresse);
            this.groupBox13.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(40, 296);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox13.Size = new System.Drawing.Size(863, 100);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Adresse de donneur";
            // 
            // Adresse
            // 
            this.Adresse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Adresse.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(5, 27);
            this.Adresse.Multiline = true;
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(853, 68);
            this.Adresse.TabIndex = 0;
            // 
            // AddDonorBtn
            // 
            this.AddDonorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.AddDonorBtn.FlatAppearance.BorderSize = 0;
            this.AddDonorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDonorBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDonorBtn.ForeColor = System.Drawing.Color.White;
            this.AddDonorBtn.Location = new System.Drawing.Point(327, 581);
            this.AddDonorBtn.Name = "AddDonorBtn";
            this.AddDonorBtn.Size = new System.Drawing.Size(283, 40);
            this.AddDonorBtn.TabIndex = 9;
            this.AddDonorBtn.Text = "Ajouter";
            this.AddDonorBtn.UseVisualStyleBackColor = false;
            this.AddDonorBtn.Click += new System.EventHandler(this.AddDonorBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.titlelabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 31);
            this.panel1.TabIndex = 10;
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(916, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 25);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.Color.White;
            this.titlelabel.Location = new System.Drawing.Point(3, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(156, 17);
            this.titlelabel.TabIndex = 1;
            this.titlelabel.Text = "Ajouter nouveau donneur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(343, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter nouveau donneur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newdonorform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddDonorBtn);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "newdonorform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter nouveau donneur";
            this.Load += new System.EventHandler(this.newdonorform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newdonorform_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button AddDonorBtn;
        private System.Windows.Forms.TextBox RegisterNum;
        private System.Windows.Forms.TextBox NomComplet;
        private System.Windows.Forms.TextBox Telephone;
        private System.Windows.Forms.TextBox LieuNaissance;
        private System.Windows.Forms.ComboBox Sexe;
        private System.Windows.Forms.ComboBox TypeDonneur;
        private System.Windows.Forms.ComboBox Groupage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.ComboBox Poches;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DateTimePicker DateNaissance;
        private System.Windows.Forms.DateTimePicker DateDonne;
    }
}