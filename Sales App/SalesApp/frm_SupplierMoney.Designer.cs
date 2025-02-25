namespace SalesApp
{
    partial class frm_SupplierMoney
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumPriceRestPaid = new System.Windows.Forms.NumericUpDown();
            this.BtnPaidRest = new System.Windows.Forms.Button();
            this.RBtnPayPart = new System.Windows.Forms.RadioButton();
            this.RBtnPayAll = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGVSuppMoney = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPrintSuppMoney = new System.Windows.Forms.Button();
            this.BtnSearchSupp = new System.Windows.Forms.Button();
            this.RBtnAllSupp = new System.Windows.Forms.RadioButton();
            this.RBtnOneSupp = new System.Windows.Forms.RadioButton();
            this.CBxSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPriceRestPaid)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSuppMoney)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DtpDate);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 587);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 50);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // DtpDate
            // 
            this.DtpDate.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(13, 17);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpDate.RightToLeftLayout = true;
            this.DtpDate.Size = new System.Drawing.Size(125, 40);
            this.DtpDate.TabIndex = 90;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1024, 13);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 89;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NumPriceRestPaid);
            this.groupBox2.Controls.Add(this.BtnPaidRest);
            this.groupBox2.Controls.Add(this.RBtnPayPart);
            this.groupBox2.Controls.Add(this.RBtnPayAll);
            this.groupBox2.Location = new System.Drawing.Point(3, 506);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1066, 74);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(3, 13);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTotal.Size = new System.Drawing.Size(229, 62);
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
            this.TxtTotal.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtTotal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtTotal.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtTotal.TabIndex = 85;
            this.TxtTotal.Text = "000000";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(230, 32);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 84;
            this.label3.Text = "إجمالي المبالغ المتبقية :";
            // 
            // NumPriceRestPaid
            // 
            this.NumPriceRestPaid.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPriceRestPaid.Location = new System.Drawing.Point(541, 16);
            this.NumPriceRestPaid.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NumPriceRestPaid.Name = "NumPriceRestPaid";
            this.NumPriceRestPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumPriceRestPaid.Size = new System.Drawing.Size(168, 48);
            this.NumPriceRestPaid.TabIndex = 84;
            // 
            // BtnPaidRest
            // 
            this.BtnPaidRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPaidRest.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnPaidRest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPaidRest.FlatAppearance.BorderSize = 0;
            this.BtnPaidRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPaidRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPaidRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaidRest.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaidRest.ForeColor = System.Drawing.Color.White;
            this.BtnPaidRest.Location = new System.Drawing.Point(416, 16);
            this.BtnPaidRest.Name = "BtnPaidRest";
            this.BtnPaidRest.Size = new System.Drawing.Size(129, 48);
            this.BtnPaidRest.TabIndex = 82;
            this.BtnPaidRest.Text = "تسديد";
            this.BtnPaidRest.UseVisualStyleBackColor = false;
            this.BtnPaidRest.Click += new System.EventHandler(this.BtnPaidRest_Click);
            // 
            // RBtnPayPart
            // 
            this.RBtnPayPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnPayPart.AutoSize = true;
            this.RBtnPayPart.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnPayPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnPayPart.Location = new System.Drawing.Point(725, 30);
            this.RBtnPayPart.Name = "RBtnPayPart";
            this.RBtnPayPart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnPayPart.Size = new System.Drawing.Size(170, 31);
            this.RBtnPayPart.TabIndex = 81;
            this.RBtnPayPart.Text = "تسديد جزء من المبلغ";
            this.RBtnPayPart.UseVisualStyleBackColor = true;
            // 
            // RBtnPayAll
            // 
            this.RBtnPayAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnPayAll.AutoSize = true;
            this.RBtnPayAll.Checked = true;
            this.RBtnPayAll.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnPayAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnPayAll.Location = new System.Drawing.Point(901, 30);
            this.RBtnPayAll.Name = "RBtnPayAll";
            this.RBtnPayAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnPayAll.Size = new System.Drawing.Size(155, 31);
            this.RBtnPayAll.TabIndex = 80;
            this.RBtnPayAll.TabStop = true;
            this.RBtnPayAll.Text = "تسديد المبلغ كامل";
            this.RBtnPayAll.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVSuppMoney);
            this.panel4.Location = new System.Drawing.Point(0, 178);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1070, 270);
            this.panel4.TabIndex = 87;
            // 
            // DGVSuppMoney
            // 
            this.DGVSuppMoney.AllowUserToAddRows = false;
            this.DGVSuppMoney.AllowUserToDeleteRows = false;
            this.DGVSuppMoney.AllowUserToResizeColumns = false;
            this.DGVSuppMoney.AllowUserToResizeRows = false;
            this.DGVSuppMoney.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSuppMoney.BackgroundColor = System.Drawing.Color.White;
            this.DGVSuppMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVSuppMoney.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVSuppMoney.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVSuppMoney.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSuppMoney.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVSuppMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSuppMoney.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVSuppMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSuppMoney.EnableHeadersVisualStyles = false;
            this.DGVSuppMoney.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVSuppMoney.Location = new System.Drawing.Point(10, 10);
            this.DGVSuppMoney.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DGVSuppMoney.Name = "DGVSuppMoney";
            this.DGVSuppMoney.ReadOnly = true;
            this.DGVSuppMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSuppMoney.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVSuppMoney.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gray;
            this.DGVSuppMoney.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVSuppMoney.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGVSuppMoney.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DGVSuppMoney.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVSuppMoney.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.DGVSuppMoney.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(7);
            this.DGVSuppMoney.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVSuppMoney.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.DGVSuppMoney.RowTemplate.Height = 45;
            this.DGVSuppMoney.RowTemplate.ReadOnly = true;
            this.DGVSuppMoney.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSuppMoney.Size = new System.Drawing.Size(1050, 250);
            this.DGVSuppMoney.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPrintSuppMoney);
            this.groupBox1.Controls.Add(this.BtnSearchSupp);
            this.groupBox1.Controls.Add(this.RBtnAllSupp);
            this.groupBox1.Controls.Add(this.RBtnOneSupp);
            this.groupBox1.Controls.Add(this.CBxSupplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 98);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // BtnPrintSuppMoney
            // 
            this.BtnPrintSuppMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrintSuppMoney.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnPrintSuppMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintSuppMoney.FlatAppearance.BorderSize = 0;
            this.BtnPrintSuppMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintSuppMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintSuppMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintSuppMoney.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintSuppMoney.ForeColor = System.Drawing.Color.White;
            this.BtnPrintSuppMoney.Location = new System.Drawing.Point(12, 44);
            this.BtnPrintSuppMoney.Name = "BtnPrintSuppMoney";
            this.BtnPrintSuppMoney.Size = new System.Drawing.Size(210, 41);
            this.BtnPrintSuppMoney.TabIndex = 83;
            this.BtnPrintSuppMoney.Text = "طباعة تقرير مفصل";
            this.BtnPrintSuppMoney.UseVisualStyleBackColor = false;
            this.BtnPrintSuppMoney.Click += new System.EventHandler(this.BtnPrintSuppMoney_Click);
            // 
            // BtnSearchSupp
            // 
            this.BtnSearchSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchSupp.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnSearchSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchSupp.FlatAppearance.BorderSize = 0;
            this.BtnSearchSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchSupp.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchSupp.ForeColor = System.Drawing.Color.White;
            this.BtnSearchSupp.Location = new System.Drawing.Point(228, 44);
            this.BtnSearchSupp.Name = "BtnSearchSupp";
            this.BtnSearchSupp.Size = new System.Drawing.Size(210, 41);
            this.BtnSearchSupp.TabIndex = 82;
            this.BtnSearchSupp.Text = "بحث";
            this.BtnSearchSupp.UseVisualStyleBackColor = false;
            this.BtnSearchSupp.Click += new System.EventHandler(this.BtnSearchSupp_Click);
            // 
            // RBtnAllSupp
            // 
            this.RBtnAllSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnAllSupp.AutoSize = true;
            this.RBtnAllSupp.Checked = true;
            this.RBtnAllSupp.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnAllSupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnAllSupp.Location = new System.Drawing.Point(519, 54);
            this.RBtnAllSupp.Name = "RBtnAllSupp";
            this.RBtnAllSupp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnAllSupp.Size = new System.Drawing.Size(128, 31);
            this.RBtnAllSupp.TabIndex = 81;
            this.RBtnAllSupp.TabStop = true;
            this.RBtnAllSupp.Text = "جميع الموردين";
            this.RBtnAllSupp.UseVisualStyleBackColor = true;
            // 
            // RBtnOneSupp
            // 
            this.RBtnOneSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnOneSupp.AutoSize = true;
            this.RBtnOneSupp.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnOneSupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnOneSupp.Location = new System.Drawing.Point(658, 54);
            this.RBtnOneSupp.Name = "RBtnOneSupp";
            this.RBtnOneSupp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnOneSupp.Size = new System.Drawing.Size(101, 31);
            this.RBtnOneSupp.TabIndex = 80;
            this.RBtnOneSupp.Text = "مورد محدد";
            this.RBtnOneSupp.UseVisualStyleBackColor = true;
            // 
            // CBxSupplier
            // 
            this.CBxSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBxSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBxSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBxSupplier.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CBxSupplier.DropDownHeight = 150;
            this.CBxSupplier.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBxSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.CBxSupplier.FormattingEnabled = true;
            this.CBxSupplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBxSupplier.IntegralHeight = false;
            this.CBxSupplier.ItemHeight = 33;
            this.CBxSupplier.Location = new System.Drawing.Point(774, 44);
            this.CBxSupplier.Name = "CBxSupplier";
            this.CBxSupplier.Size = new System.Drawing.Size(271, 41);
            this.CBxSupplier.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(774, 14);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(276, 27);
            this.label2.TabIndex = 74;
            this.label2.Text = "يرجى إختيار المورد المطلوب البحث عنه";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(366, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(363, 54);
            this.label1.TabIndex = 85;
            this.label1.Text = "المبالغ المتبقية للموردين";
            // 
            // frm_SupplierMoney
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1080, 597);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SupplierMoney";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SupplierMoney";
            this.Load += new System.EventHandler(this.frm_SupplierMoney_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPriceRestPaid)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSuppMoney)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumPriceRestPaid;
        private System.Windows.Forms.Button BtnPaidRest;
        private System.Windows.Forms.RadioButton RBtnPayPart;
        private System.Windows.Forms.RadioButton RBtnPayAll;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView DGVSuppMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPrintSuppMoney;
        private System.Windows.Forms.Button BtnSearchSupp;
        private System.Windows.Forms.RadioButton RBtnAllSupp;
        private System.Windows.Forms.RadioButton RBtnOneSupp;
        private System.Windows.Forms.ComboBox CBxSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtpDate;
    }
}