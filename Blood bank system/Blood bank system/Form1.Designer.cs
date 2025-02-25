namespace Blood_bank_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Hedearpanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlelabel = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.Sidebarpanel = new System.Windows.Forms.Panel();
            this.Usersbtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.Deconnecterbtn = new System.Windows.Forms.Button();
            this.Donneuractivesbtn = new System.Windows.Forms.Button();
            this.Candidatsbtn = new System.Windows.Forms.Button();
            this.Statsbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Containerpanel = new System.Windows.Forms.Panel();
            this.Containerbody = new System.Windows.Forms.Panel();
            this.Containerhead = new System.Windows.Forms.Panel();
            this.Mois6btn = new System.Windows.Forms.Button();
            this.Mois3btn = new System.Windows.Forms.Button();
            this.Mois1btn = new System.Windows.Forms.Button();
            this.Mois12btn = new System.Windows.Forms.Button();
            this.headerlabel = new System.Windows.Forms.Label();
            this.settings = new Blood_bank_system.apropos();
            this.utilisateurs1 = new Blood_bank_system.Utilisateurs();
            this.donneuractives1 = new Blood_bank_system.donneuractives();
            this.candidats1 = new Blood_bank_system.candidats();
            this.stats1 = new Blood_bank_system.stats();
            this.Hedearpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Sidebarpanel.SuspendLayout();
            this.Containerpanel.SuspendLayout();
            this.Containerbody.SuspendLayout();
            this.Containerhead.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hedearpanel
            // 
            this.Hedearpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Hedearpanel.Controls.Add(this.CloseBtn);
            this.Hedearpanel.Controls.Add(this.pictureBox1);
            this.Hedearpanel.Controls.Add(this.titlelabel);
            this.Hedearpanel.Controls.Add(this.nightControlBox1);
            this.Hedearpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hedearpanel.Location = new System.Drawing.Point(0, 0);
            this.Hedearpanel.Margin = new System.Windows.Forms.Padding(0);
            this.Hedearpanel.Name = "Hedearpanel";
            this.Hedearpanel.Size = new System.Drawing.Size(1200, 31);
            this.Hedearpanel.TabIndex = 0;
            this.Hedearpanel.DoubleClick += new System.EventHandler(this.Hedearpanel_DoubleClick);
            this.Hedearpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hedearpanel_MouseMove);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(1168, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(20, 20);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titlelabel
            // 
            this.titlelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.Color.White;
            this.titlelabel.Location = new System.Drawing.Point(39, 3);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(295, 21);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Logiciel de gestion des donneurs de sang";
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.White;
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.White;
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.White;
            this.nightControlBox1.Location = new System.Drawing.Point(1061, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // Sidebarpanel
            // 
            this.Sidebarpanel.Controls.Add(this.Usersbtn);
            this.Sidebarpanel.Controls.Add(this.SettingsBtn);
            this.Sidebarpanel.Controls.Add(this.Deconnecterbtn);
            this.Sidebarpanel.Controls.Add(this.Donneuractivesbtn);
            this.Sidebarpanel.Controls.Add(this.Candidatsbtn);
            this.Sidebarpanel.Controls.Add(this.Statsbtn);
            this.Sidebarpanel.Controls.Add(this.button1);
            this.Sidebarpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebarpanel.Location = new System.Drawing.Point(0, 31);
            this.Sidebarpanel.Margin = new System.Windows.Forms.Padding(0);
            this.Sidebarpanel.Name = "Sidebarpanel";
            this.Sidebarpanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.Sidebarpanel.Size = new System.Drawing.Size(250, 691);
            this.Sidebarpanel.TabIndex = 1;
            // 
            // Usersbtn
            // 
            this.Usersbtn.BackColor = System.Drawing.Color.White;
            this.Usersbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Usersbtn.FlatAppearance.BorderSize = 0;
            this.Usersbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Usersbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Usersbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Usersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usersbtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usersbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Usersbtn.Image = ((System.Drawing.Image)(resources.GetObject("Usersbtn.Image")));
            this.Usersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usersbtn.Location = new System.Drawing.Point(0, 400);
            this.Usersbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Usersbtn.Name = "Usersbtn";
            this.Usersbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Usersbtn.Size = new System.Drawing.Size(250, 50);
            this.Usersbtn.TabIndex = 7;
            this.Usersbtn.Text = "Utilisateurs";
            this.Usersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usersbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Usersbtn.UseVisualStyleBackColor = false;
            this.Usersbtn.Click += new System.EventHandler(this.Usersbtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 541);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.SettingsBtn.Size = new System.Drawing.Size(250, 50);
            this.SettingsBtn.TabIndex = 6;
            this.SettingsBtn.Text = "Paramètres";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // Deconnecterbtn
            // 
            this.Deconnecterbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Deconnecterbtn.FlatAppearance.BorderSize = 0;
            this.Deconnecterbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Deconnecterbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Deconnecterbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Deconnecterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deconnecterbtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconnecterbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Deconnecterbtn.Image = ((System.Drawing.Image)(resources.GetObject("Deconnecterbtn.Image")));
            this.Deconnecterbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deconnecterbtn.Location = new System.Drawing.Point(0, 591);
            this.Deconnecterbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Deconnecterbtn.Name = "Deconnecterbtn";
            this.Deconnecterbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Deconnecterbtn.Size = new System.Drawing.Size(250, 50);
            this.Deconnecterbtn.TabIndex = 5;
            this.Deconnecterbtn.Text = "Déconnecter";
            this.Deconnecterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deconnecterbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Deconnecterbtn.UseVisualStyleBackColor = true;
            this.Deconnecterbtn.Click += new System.EventHandler(this.Deconnecterbtn_Click);
            // 
            // Donneuractivesbtn
            // 
            this.Donneuractivesbtn.BackColor = System.Drawing.Color.White;
            this.Donneuractivesbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Donneuractivesbtn.FlatAppearance.BorderSize = 0;
            this.Donneuractivesbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Donneuractivesbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Donneuractivesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Donneuractivesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Donneuractivesbtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donneuractivesbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Donneuractivesbtn.Image = ((System.Drawing.Image)(resources.GetObject("Donneuractivesbtn.Image")));
            this.Donneuractivesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Donneuractivesbtn.Location = new System.Drawing.Point(0, 350);
            this.Donneuractivesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Donneuractivesbtn.Name = "Donneuractivesbtn";
            this.Donneuractivesbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Donneuractivesbtn.Size = new System.Drawing.Size(250, 50);
            this.Donneuractivesbtn.TabIndex = 4;
            this.Donneuractivesbtn.Text = "Donneurs actives";
            this.Donneuractivesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Donneuractivesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Donneuractivesbtn.UseVisualStyleBackColor = false;
            this.Donneuractivesbtn.Click += new System.EventHandler(this.Donneuractivesbtn_Click);
            // 
            // Candidatsbtn
            // 
            this.Candidatsbtn.BackColor = System.Drawing.Color.White;
            this.Candidatsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Candidatsbtn.FlatAppearance.BorderSize = 0;
            this.Candidatsbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Candidatsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Candidatsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Candidatsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Candidatsbtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidatsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Candidatsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Candidatsbtn.Image")));
            this.Candidatsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatsbtn.Location = new System.Drawing.Point(0, 300);
            this.Candidatsbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Candidatsbtn.Name = "Candidatsbtn";
            this.Candidatsbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Candidatsbtn.Size = new System.Drawing.Size(250, 50);
            this.Candidatsbtn.TabIndex = 2;
            this.Candidatsbtn.Text = "Sang candidats ";
            this.Candidatsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Candidatsbtn.UseVisualStyleBackColor = false;
            this.Candidatsbtn.Click += new System.EventHandler(this.Candidatsbtn_Click);
            // 
            // Statsbtn
            // 
            this.Statsbtn.BackColor = System.Drawing.Color.White;
            this.Statsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Statsbtn.FlatAppearance.BorderSize = 0;
            this.Statsbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Statsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Statsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Statsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statsbtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Statsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Statsbtn.Image")));
            this.Statsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statsbtn.Location = new System.Drawing.Point(0, 250);
            this.Statsbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Statsbtn.Name = "Statsbtn";
            this.Statsbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Statsbtn.Size = new System.Drawing.Size(250, 50);
            this.Statsbtn.TabIndex = 3;
            this.Statsbtn.Text = "Statistiques";
            this.Statsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Statsbtn.UseVisualStyleBackColor = false;
            this.Statsbtn.Click += new System.EventHandler(this.Statsbtn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 250);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Containerpanel
            // 
            this.Containerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Containerpanel.Controls.Add(this.Containerbody);
            this.Containerpanel.Controls.Add(this.Containerhead);
            this.Containerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Containerpanel.Location = new System.Drawing.Point(250, 31);
            this.Containerpanel.Margin = new System.Windows.Forms.Padding(0);
            this.Containerpanel.Name = "Containerpanel";
            this.Containerpanel.Padding = new System.Windows.Forms.Padding(5);
            this.Containerpanel.Size = new System.Drawing.Size(950, 691);
            this.Containerpanel.TabIndex = 2;
            // 
            // Containerbody
            // 
            this.Containerbody.Controls.Add(this.settings);
            this.Containerbody.Controls.Add(this.utilisateurs1);
            this.Containerbody.Controls.Add(this.donneuractives1);
            this.Containerbody.Controls.Add(this.candidats1);
            this.Containerbody.Controls.Add(this.stats1);
            this.Containerbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Containerbody.Location = new System.Drawing.Point(5, 65);
            this.Containerbody.Margin = new System.Windows.Forms.Padding(0);
            this.Containerbody.Name = "Containerbody";
            this.Containerbody.Size = new System.Drawing.Size(940, 621);
            this.Containerbody.TabIndex = 1;
            // 
            // Containerhead
            // 
            this.Containerhead.BackColor = System.Drawing.Color.Transparent;
            this.Containerhead.Controls.Add(this.Mois6btn);
            this.Containerhead.Controls.Add(this.Mois3btn);
            this.Containerhead.Controls.Add(this.Mois1btn);
            this.Containerhead.Controls.Add(this.Mois12btn);
            this.Containerhead.Controls.Add(this.headerlabel);
            this.Containerhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.Containerhead.Location = new System.Drawing.Point(5, 5);
            this.Containerhead.Margin = new System.Windows.Forms.Padding(0);
            this.Containerhead.Name = "Containerhead";
            this.Containerhead.Size = new System.Drawing.Size(940, 60);
            this.Containerhead.TabIndex = 0;
            // 
            // Mois6btn
            // 
            this.Mois6btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mois6btn.BackColor = System.Drawing.Color.Transparent;
            this.Mois6btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois6btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Mois6btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois6btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois6btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mois6btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mois6btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois6btn.Location = new System.Drawing.Point(727, 10);
            this.Mois6btn.Name = "Mois6btn";
            this.Mois6btn.Size = new System.Drawing.Size(100, 40);
            this.Mois6btn.TabIndex = 4;
            this.Mois6btn.Text = "6 mois";
            this.Mois6btn.UseVisualStyleBackColor = false;
            this.Mois6btn.Click += new System.EventHandler(this.Mois6btn_Click);
            // 
            // Mois3btn
            // 
            this.Mois3btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mois3btn.BackColor = System.Drawing.Color.Transparent;
            this.Mois3btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois3btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Mois3btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois3btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois3btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mois3btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mois3btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois3btn.Location = new System.Drawing.Point(621, 10);
            this.Mois3btn.Name = "Mois3btn";
            this.Mois3btn.Size = new System.Drawing.Size(100, 40);
            this.Mois3btn.TabIndex = 3;
            this.Mois3btn.Text = "3 mois";
            this.Mois3btn.UseVisualStyleBackColor = false;
            this.Mois3btn.Click += new System.EventHandler(this.Mois3btn_Click);
            // 
            // Mois1btn
            // 
            this.Mois1btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mois1btn.BackColor = System.Drawing.Color.Transparent;
            this.Mois1btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois1btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Mois1btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois1btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mois1btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mois1btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois1btn.Location = new System.Drawing.Point(515, 10);
            this.Mois1btn.Name = "Mois1btn";
            this.Mois1btn.Size = new System.Drawing.Size(100, 40);
            this.Mois1btn.TabIndex = 2;
            this.Mois1btn.Text = "1 mois";
            this.Mois1btn.UseVisualStyleBackColor = false;
            this.Mois1btn.Click += new System.EventHandler(this.Mois1btn_Click);
            // 
            // Mois12btn
            // 
            this.Mois12btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mois12btn.BackColor = System.Drawing.Color.Transparent;
            this.Mois12btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois12btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Mois12btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois12btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois12btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mois12btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mois12btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            this.Mois12btn.Location = new System.Drawing.Point(833, 10);
            this.Mois12btn.Name = "Mois12btn";
            this.Mois12btn.Size = new System.Drawing.Size(100, 40);
            this.Mois12btn.TabIndex = 1;
            this.Mois12btn.Text = "12 mois";
            this.Mois12btn.UseVisualStyleBackColor = false;
            this.Mois12btn.Click += new System.EventHandler(this.Mois12btn_Click);
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.Location = new System.Drawing.Point(13, 17);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(143, 25);
            this.headerlabel.TabIndex = 0;
            this.headerlabel.Text = "Les Statistiques";
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(940, 621);
            this.settings.TabIndex = 4;
            // 
            // utilisateurs1
            // 
            this.utilisateurs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.utilisateurs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.utilisateurs1.Location = new System.Drawing.Point(0, 0);
            this.utilisateurs1.Name = "utilisateurs1";
            this.utilisateurs1.Size = new System.Drawing.Size(940, 621);
            this.utilisateurs1.TabIndex = 3;
            // 
            // donneuractives1
            // 
            this.donneuractives1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.donneuractives1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donneuractives1.Location = new System.Drawing.Point(0, 0);
            this.donneuractives1.Margin = new System.Windows.Forms.Padding(0);
            this.donneuractives1.Name = "donneuractives1";
            this.donneuractives1.Padding = new System.Windows.Forms.Padding(5);
            this.donneuractives1.Size = new System.Drawing.Size(940, 621);
            this.donneuractives1.TabIndex = 2;
            // 
            // candidats1
            // 
            this.candidats1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.candidats1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.candidats1.Location = new System.Drawing.Point(0, 0);
            this.candidats1.Margin = new System.Windows.Forms.Padding(0);
            this.candidats1.Name = "candidats1";
            this.candidats1.Padding = new System.Windows.Forms.Padding(5);
            this.candidats1.Size = new System.Drawing.Size(940, 621);
            this.candidats1.TabIndex = 1;
            // 
            // stats1
            // 
            this.stats1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.stats1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stats1.Location = new System.Drawing.Point(0, 0);
            this.stats1.Margin = new System.Windows.Forms.Padding(0);
            this.stats1.Name = "stats1";
            this.stats1.Padding = new System.Windows.Forms.Padding(5);
            this.stats1.Size = new System.Drawing.Size(940, 621);
            this.stats1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 722);
            this.Controls.Add(this.Containerpanel);
            this.Controls.Add(this.Sidebarpanel);
            this.Controls.Add(this.Hedearpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Hedearpanel.ResumeLayout(false);
            this.Hedearpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Sidebarpanel.ResumeLayout(false);
            this.Containerpanel.ResumeLayout(false);
            this.Containerbody.ResumeLayout(false);
            this.Containerhead.ResumeLayout(false);
            this.Containerhead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Hedearpanel;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel Sidebarpanel;
        private System.Windows.Forms.Panel Containerpanel;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Statsbtn;
        private System.Windows.Forms.Button Candidatsbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Donneuractivesbtn;
        private System.Windows.Forms.Button Deconnecterbtn;
        private System.Windows.Forms.Panel Containerbody;
        private System.Windows.Forms.Panel Containerhead;
        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.Button Mois12btn;
        private System.Windows.Forms.Button Mois6btn;
        private System.Windows.Forms.Button Mois3btn;
        private stats stats1;
        private apropos settings;
        private Utilisateurs utilisateurs1;
        private donneuractives donneuractives1;
        private candidats candidats1;
        public System.Windows.Forms.Button Usersbtn;
        public System.Windows.Forms.Button Mois1btn;
        private System.Windows.Forms.Button CloseBtn;
        public System.Windows.Forms.Button SettingsBtn;
    }
}

