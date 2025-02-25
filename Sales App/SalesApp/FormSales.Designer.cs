namespace SalesApp
{
    partial class FormSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGVSales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblProductsCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeNow = new System.Windows.Forms.DateTimePicker();
            this.RBtnCustomerNow = new System.Windows.Forms.RadioButton();
            this.RBtnCustomerAagel = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimeReminder = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCustomerNow = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDeleteProducts = new System.Windows.Forms.Button();
            this.BtnAddProducts = new System.Windows.Forms.Button();
            this.BtnCustomerrBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBxProducts = new System.Windows.Forms.ComboBox();
            this.CBxCustomer = new System.Windows.Forms.ComboBox();
            this.dTPDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBarcode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSales)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVSales);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 176);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1361, 519);
            this.panel4.TabIndex = 81;
            // 
            // DGVSales
            // 
            this.DGVSales.AllowUserToAddRows = false;
            this.DGVSales.AllowUserToDeleteRows = false;
            this.DGVSales.AllowUserToResizeColumns = false;
            this.DGVSales.AllowUserToResizeRows = false;
            this.DGVSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSales.BackgroundColor = System.Drawing.Color.White;
            this.DGVSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVSales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSales.EnableHeadersVisualStyles = false;
            this.DGVSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVSales.Location = new System.Drawing.Point(10, 10);
            this.DGVSales.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DGVSales.Name = "DGVSales";
            this.DGVSales.ReadOnly = true;
            this.DGVSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVSales.RowHeadersVisible = false;
            this.DGVSales.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.DGVSales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVSales.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGVSales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DGVSales.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVSales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.DGVSales.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(7);
            this.DGVSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVSales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.DGVSales.RowTemplate.Height = 45;
            this.DGVSales.RowTemplate.ReadOnly = true;
            this.DGVSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSales.Size = new System.Drawing.Size(1341, 499);
            this.DGVSales.TabIndex = 64;
            this.DGVSales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSales_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "إسم المنتج";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "الكمية";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "السعر";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 60F;
            this.Column5.HeaderText = "الخصم";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "الإجمالي";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtTotal);
            this.panel3.Controls.Add(this.LblProductsCount);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 695);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1361, 119);
            this.panel3.TabIndex = 80;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(10, 13);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTotal.Size = new System.Drawing.Size(556, 94);
            this.TxtTotal.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtTotal.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TxtTotal.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtTotal.StateActive.Border.ColorAngle = 45F;
            this.TxtTotal.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtTotal.StateActive.Border.Rounding = 0;
            this.TxtTotal.StateActive.Border.Width = 1;
            this.TxtTotal.StateActive.Content.Color1 = System.Drawing.Color.GreenYellow;
            this.TxtTotal.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtTotal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtTotal.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtTotal.TabIndex = 78;
            this.TxtTotal.Text = "000000";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblProductsCount
            // 
            this.LblProductsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProductsCount.AutoSize = true;
            this.LblProductsCount.BackColor = System.Drawing.Color.Transparent;
            this.LblProductsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblProductsCount.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.LblProductsCount.Location = new System.Drawing.Point(1205, 78);
            this.LblProductsCount.Name = "LblProductsCount";
            this.LblProductsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblProductsCount.Size = new System.Drawing.Size(30, 29);
            this.LblProductsCount.TabIndex = 77;
            this.LblProductsCount.Text = "....";
            this.LblProductsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label10.Location = new System.Drawing.Point(1234, 78);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(116, 29);
            this.label10.TabIndex = 76;
            this.label10.Text = "عدد المنتجات :";
            // 
            // dateTimeNow
            // 
            this.dateTimeNow.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNow.Location = new System.Drawing.Point(183, 35);
            this.dateTimeNow.Name = "dateTimeNow";
            this.dateTimeNow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeNow.RightToLeftLayout = true;
            this.dateTimeNow.Size = new System.Drawing.Size(74, 40);
            this.dateTimeNow.TabIndex = 81;
            // 
            // RBtnCustomerNow
            // 
            this.RBtnCustomerNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnCustomerNow.AutoSize = true;
            this.RBtnCustomerNow.Checked = true;
            this.RBtnCustomerNow.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCustomerNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnCustomerNow.Location = new System.Drawing.Point(961, 14);
            this.RBtnCustomerNow.Name = "RBtnCustomerNow";
            this.RBtnCustomerNow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnCustomerNow.Size = new System.Drawing.Size(107, 31);
            this.RBtnCustomerNow.TabIndex = 80;
            this.RBtnCustomerNow.TabStop = true;
            this.RBtnCustomerNow.Text = "عميل نقدي";
            this.RBtnCustomerNow.UseVisualStyleBackColor = true;
            this.RBtnCustomerNow.CheckedChanged += new System.EventHandler(this.RBtnCustomerNow_CheckedChanged);
            // 
            // RBtnCustomerAagel
            // 
            this.RBtnCustomerAagel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnCustomerAagel.AutoSize = true;
            this.RBtnCustomerAagel.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCustomerAagel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnCustomerAagel.Location = new System.Drawing.Point(858, 14);
            this.RBtnCustomerAagel.Name = "RBtnCustomerAagel";
            this.RBtnCustomerAagel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnCustomerAagel.Size = new System.Drawing.Size(97, 31);
            this.RBtnCustomerAagel.TabIndex = 79;
            this.RBtnCustomerAagel.Text = "عميل آجل";
            this.RBtnCustomerAagel.UseVisualStyleBackColor = true;
            this.RBtnCustomerAagel.CheckedChanged += new System.EventHandler(this.RBtnCustomerAagel_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dateTimeNow);
            this.panel2.Controls.Add(this.dateTimeReminder);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TxtCustomerNow);
            this.panel2.Controls.Add(this.RBtnCustomerNow);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.RBtnCustomerAagel);
            this.panel2.Controls.Add(this.TxtID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtnDeleteProducts);
            this.panel2.Controls.Add(this.BtnAddProducts);
            this.panel2.Controls.Add(this.BtnCustomerrBrowse);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CBxProducts);
            this.panel2.Controls.Add(this.CBxCustomer);
            this.panel2.Controls.Add(this.dTPDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TxtBarcode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 176);
            this.panel2.TabIndex = 79;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(170, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 50);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimeReminder
            // 
            this.dateTimeReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeReminder.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeReminder.Location = new System.Drawing.Point(355, 45);
            this.dateTimeReminder.Name = "dateTimeReminder";
            this.dateTimeReminder.RightToLeftLayout = true;
            this.dateTimeReminder.Size = new System.Drawing.Size(139, 40);
            this.dateTimeReminder.TabIndex = 84;
            this.dateTimeReminder.ValueChanged += new System.EventHandler(this.dateTimeReminder_ValueChanged);
            this.dateTimeReminder.Leave += new System.EventHandler(this.TxtCustomerNow_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label9.Location = new System.Drawing.Point(372, 15);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(128, 27);
            this.label9.TabIndex = 83;
            this.label9.Text = "تاريخ الإستحقاق :";
            // 
            // TxtCustomerNow
            // 
            this.TxtCustomerNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCustomerNow.Location = new System.Drawing.Point(825, 44);
            this.TxtCustomerNow.Name = "TxtCustomerNow";
            this.TxtCustomerNow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCustomerNow.Size = new System.Drawing.Size(244, 40);
            this.TxtCustomerNow.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.TxtCustomerNow.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TxtCustomerNow.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtCustomerNow.StateActive.Border.ColorAngle = 45F;
            this.TxtCustomerNow.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtCustomerNow.StateActive.Border.Rounding = 0;
            this.TxtCustomerNow.StateActive.Border.Width = 1;
            this.TxtCustomerNow.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtCustomerNow.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerNow.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtCustomerNow.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtCustomerNow.TabIndex = 82;
            this.TxtCustomerNow.Leave += new System.EventHandler(this.TxtCustomerNow_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label8.Location = new System.Drawing.Point(1254, 90);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(98, 27);
            this.label8.TabIndex = 80;
            this.label8.Text = "رقم الفاتورة :";
            // 
            // TxtID
            // 
            this.TxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtID.Location = new System.Drawing.Point(1086, 120);
            this.TxtID.Name = "TxtID";
            this.TxtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtID.Size = new System.Drawing.Size(262, 40);
            this.TxtID.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.TxtID.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TxtID.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtID.StateActive.Border.ColorAngle = 45F;
            this.TxtID.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtID.StateActive.Border.Rounding = 0;
            this.TxtID.StateActive.Border.Width = 1;
            this.TxtID.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtID.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtID.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtID.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(591, 128);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 78;
            this.label7.Text = "Delete";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(721, 130);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(33, 27);
            this.label4.TabIndex = 77;
            this.label4.Text = "F2";
            // 
            // BtnDeleteProducts
            // 
            this.BtnDeleteProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteProducts.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDeleteProducts.Image = global::SalesApp.Properties.Resources.remove;
            this.BtnDeleteProducts.Location = new System.Drawing.Point(667, 118);
            this.BtnDeleteProducts.Name = "BtnDeleteProducts";
            this.BtnDeleteProducts.Size = new System.Drawing.Size(48, 42);
            this.BtnDeleteProducts.TabIndex = 76;
            this.BtnDeleteProducts.UseVisualStyleBackColor = true;
            this.BtnDeleteProducts.Click += new System.EventHandler(this.BtnDeleteProducts_Click);
            // 
            // BtnAddProducts
            // 
            this.BtnAddProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddProducts.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddProducts.Image = global::SalesApp.Properties.Resources.down__1_;
            this.BtnAddProducts.Location = new System.Drawing.Point(760, 119);
            this.BtnAddProducts.Name = "BtnAddProducts";
            this.BtnAddProducts.Size = new System.Drawing.Size(48, 42);
            this.BtnAddProducts.TabIndex = 75;
            this.BtnAddProducts.UseVisualStyleBackColor = true;
            this.BtnAddProducts.Click += new System.EventHandler(this.BtnAddProducts_Click);
            // 
            // BtnCustomerrBrowse
            // 
            this.BtnCustomerrBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCustomerrBrowse.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnCustomerrBrowse.Location = new System.Drawing.Point(509, 44);
            this.BtnCustomerrBrowse.Name = "BtnCustomerrBrowse";
            this.BtnCustomerrBrowse.Size = new System.Drawing.Size(48, 41);
            this.BtnCustomerrBrowse.TabIndex = 74;
            this.BtnCustomerrBrowse.Text = "...";
            this.BtnCustomerrBrowse.UseVisualStyleBackColor = true;
            this.BtnCustomerrBrowse.Click += new System.EventHandler(this.BtnCustomerrBrowse_Click);
            this.BtnCustomerrBrowse.Leave += new System.EventHandler(this.TxtCustomerNow_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(1254, 14);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 73;
            this.label2.Text = "رقم الباركود :";
            // 
            // CBxProducts
            // 
            this.CBxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBxProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBxProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBxProducts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CBxProducts.DropDownHeight = 150;
            this.CBxProducts.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBxProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.CBxProducts.FormattingEnabled = true;
            this.CBxProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBxProducts.IntegralHeight = false;
            this.CBxProducts.ItemHeight = 33;
            this.CBxProducts.Location = new System.Drawing.Point(824, 121);
            this.CBxProducts.Name = "CBxProducts";
            this.CBxProducts.Size = new System.Drawing.Size(245, 41);
            this.CBxProducts.TabIndex = 72;
            this.CBxProducts.Leave += new System.EventHandler(this.TxtCustomerNow_Leave);
            // 
            // CBxCustomer
            // 
            this.CBxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBxCustomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CBxCustomer.DropDownHeight = 150;
            this.CBxCustomer.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBxCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.CBxCustomer.FormattingEnabled = true;
            this.CBxCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBxCustomer.IntegralHeight = false;
            this.CBxCustomer.ItemHeight = 33;
            this.CBxCustomer.Location = new System.Drawing.Point(563, 44);
            this.CBxCustomer.Name = "CBxCustomer";
            this.CBxCustomer.Size = new System.Drawing.Size(245, 41);
            this.CBxCustomer.TabIndex = 71;
            this.CBxCustomer.Leave += new System.EventHandler(this.TxtCustomerNow_Leave);
            // 
            // dTPDate
            // 
            this.dTPDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPDate.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDate.Location = new System.Drawing.Point(355, 121);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.RightToLeftLayout = true;
            this.dTPDate.Size = new System.Drawing.Size(139, 40);
            this.dTPDate.TabIndex = 70;
            this.dTPDate.Leave += new System.EventHandler(this.TxtCustomerNow_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(978, 92);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 69;
            this.label1.Text = "اختر المنتج :";
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBarcode.Location = new System.Drawing.Point(1086, 44);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBarcode.Size = new System.Drawing.Size(262, 40);
            this.TxtBarcode.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.TxtBarcode.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TxtBarcode.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtBarcode.StateActive.Border.ColorAngle = 45F;
            this.TxtBarcode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtBarcode.StateActive.Border.Rounding = 0;
            this.TxtBarcode.StateActive.Border.Width = 1;
            this.TxtBarcode.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtBarcode.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBarcode.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtBarcode.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtBarcode.TabIndex = 68;
            this.TxtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBarcode_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(714, 16);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 66;
            this.label3.Text = "اسم العميل :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(436, 92);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 67;
            this.label5.Text = "التاريخ :";
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 814);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormSales";
            this.Text = "FormSales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSales_KeyDown);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimeNow;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtTotal;
        private System.Windows.Forms.Label LblProductsCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RBtnCustomerNow;
        private System.Windows.Forms.RadioButton RBtnCustomerAagel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDeleteProducts;
        private System.Windows.Forms.Button BtnAddProducts;
        private System.Windows.Forms.Button BtnCustomerrBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBxProducts;
        private System.Windows.Forms.ComboBox CBxCustomer;
        private System.Windows.Forms.DateTimePicker dTPDate;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeReminder;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtCustomerNow;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView DGVSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}