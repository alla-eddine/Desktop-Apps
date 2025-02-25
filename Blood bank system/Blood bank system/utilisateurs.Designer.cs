namespace Blood_bank_system
{
    partial class Utilisateurs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilisateurs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteuserBtn = new System.Windows.Forms.Button();
            this.EdituserBtn = new System.Windows.Forms.Button();
            this.newuserBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.DeleteuserBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.EdituserBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.newuserBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 571);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DeleteuserBtn
            // 
            this.DeleteuserBtn.BackColor = System.Drawing.Color.Tomato;
            this.DeleteuserBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteuserBtn.FlatAppearance.BorderSize = 0;
            this.DeleteuserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteuserBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteuserBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteuserBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteuserBtn.Image")));
            this.DeleteuserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteuserBtn.Location = new System.Drawing.Point(631, 0);
            this.DeleteuserBtn.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.DeleteuserBtn.Name = "DeleteuserBtn";
            this.DeleteuserBtn.Size = new System.Drawing.Size(309, 50);
            this.DeleteuserBtn.TabIndex = 2;
            this.DeleteuserBtn.Text = "supprimer utilisateur";
            this.DeleteuserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteuserBtn.UseVisualStyleBackColor = false;
            this.DeleteuserBtn.Click += new System.EventHandler(this.DeleteuserBtn_Click);
            // 
            // EdituserBtn
            // 
            this.EdituserBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.EdituserBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdituserBtn.FlatAppearance.BorderSize = 0;
            this.EdituserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdituserBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdituserBtn.ForeColor = System.Drawing.Color.White;
            this.EdituserBtn.Image = ((System.Drawing.Image)(resources.GetObject("EdituserBtn.Image")));
            this.EdituserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EdituserBtn.Location = new System.Drawing.Point(318, 0);
            this.EdituserBtn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EdituserBtn.Name = "EdituserBtn";
            this.EdituserBtn.Size = new System.Drawing.Size(303, 50);
            this.EdituserBtn.TabIndex = 1;
            this.EdituserBtn.Text = "editer utilisateur";
            this.EdituserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EdituserBtn.UseVisualStyleBackColor = false;
            this.EdituserBtn.Click += new System.EventHandler(this.EdituserBtn_Click);
            // 
            // newuserBtn
            // 
            this.newuserBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.newuserBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newuserBtn.FlatAppearance.BorderSize = 0;
            this.newuserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newuserBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuserBtn.ForeColor = System.Drawing.Color.White;
            this.newuserBtn.Image = ((System.Drawing.Image)(resources.GetObject("newuserBtn.Image")));
            this.newuserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newuserBtn.Location = new System.Drawing.Point(0, 0);
            this.newuserBtn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.newuserBtn.Name = "newuserBtn";
            this.newuserBtn.Size = new System.Drawing.Size(308, 50);
            this.newuserBtn.TabIndex = 0;
            this.newuserBtn.Text = "nouveau utilisateur";
            this.newuserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newuserBtn.UseVisualStyleBackColor = false;
            this.newuserBtn.Click += new System.EventHandler(this.newuserBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 10);
            this.panel1.Size = new System.Drawing.Size(940, 571);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(84)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 15);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(940, 546);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Utilisateurs";
            this.Size = new System.Drawing.Size(940, 621);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button DeleteuserBtn;
        public System.Windows.Forms.Button EdituserBtn;
        private System.Windows.Forms.Button newuserBtn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
