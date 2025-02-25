namespace SalesApp
{
    partial class frm_ClientMoney
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
            this.DGVCustMoney = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPrintCustMoney = new System.Windows.Forms.Button();
            this.BtnSearchCust = new System.Windows.Forms.Button();
            this.RBtnAllCust = new System.Windows.Forms.RadioButton();
            this.RBtnOneCust = new System.Windows.Forms.RadioButton();
            this.CBxCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPriceRestPaid)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustMoney)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(10, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 50);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // DtpDate
            // 
            this.DtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
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
            this.label3.Size = new System.Drawing.Size(178, 27);
            this.label3.TabIndex = 84;
            this.label3.Text = "إجمالي الديون المتبقية :";
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
            this.RBtnPayAll.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnPayAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnPayAll.Location = new System.Drawing.Point(901, 30);
            this.RBtnPayAll.Name = "RBtnPayAll";
            this.RBtnPayAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnPayAll.Size = new System.Drawing.Size(155, 31);
            this.RBtnPayAll.TabIndex = 80;
            this.RBtnPayAll.Text = "تسديد المبلغ كامل";
            this.RBtnPayAll.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVCustMoney);
            this.panel4.Location = new System.Drawing.Point(0, 178);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1070, 270);
            this.panel4.TabIndex = 87;
            // 
            // DGVCustMoney
            // 
            this.DGVCustMoney.AllowUserToAddRows = false;
            this.DGVCustMoney.AllowUserToDeleteRows = false;
            this.DGVCustMoney.AllowUserToResizeColumns = false;
            this.DGVCustMoney.AllowUserToResizeRows = false;
            this.DGVCustMoney.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCustMoney.BackgroundColor = System.Drawing.Color.White;
            this.DGVCustMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCustMoney.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVCustMoney.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVCustMoney.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustMoney.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCustMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCustMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCustMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustMoney.EnableHeadersVisualStyles = false;
            this.DGVCustMoney.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVCustMoney.Location = new System.Drawing.Point(10, 10);
            this.DGVCustMoney.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DGVCustMoney.Name = "DGVCustMoney";
            this.DGVCustMoney.ReadOnly = true;
            this.DGVCustMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustMoney.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCustMoney.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.DGVCustMoney.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVCustMoney.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGVCustMoney.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DGVCustMoney.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCustMoney.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.DGVCustMoney.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(7);
            this.DGVCustMoney.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVCustMoney.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.DGVCustMoney.RowTemplate.Height = 45;
            this.DGVCustMoney.RowTemplate.ReadOnly = true;
            this.DGVCustMoney.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustMoney.Size = new System.Drawing.Size(1050, 250);
            this.DGVCustMoney.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPrintCustMoney);
            this.groupBox1.Controls.Add(this.BtnSearchCust);
            this.groupBox1.Controls.Add(this.RBtnAllCust);
            this.groupBox1.Controls.Add(this.RBtnOneCust);
            this.groupBox1.Controls.Add(this.CBxCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 98);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // BtnPrintCustMoney
            // 
            this.BtnPrintCustMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrintCustMoney.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnPrintCustMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintCustMoney.FlatAppearance.BorderSize = 0;
            this.BtnPrintCustMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintCustMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintCustMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintCustMoney.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintCustMoney.ForeColor = System.Drawing.Color.White;
            this.BtnPrintCustMoney.Location = new System.Drawing.Point(12, 44);
            this.BtnPrintCustMoney.Name = "BtnPrintCustMoney";
            this.BtnPrintCustMoney.Size = new System.Drawing.Size(210, 41);
            this.BtnPrintCustMoney.TabIndex = 83;
            this.BtnPrintCustMoney.Text = "طباعة تقرير مفصل";
            this.BtnPrintCustMoney.UseVisualStyleBackColor = false;
            this.BtnPrintCustMoney.Click += new System.EventHandler(this.BtnPrintCustMoney_Click);
            // 
            // BtnSearchCust
            // 
            this.BtnSearchCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchCust.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnSearchCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchCust.FlatAppearance.BorderSize = 0;
            this.BtnSearchCust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchCust.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchCust.ForeColor = System.Drawing.Color.White;
            this.BtnSearchCust.Location = new System.Drawing.Point(228, 44);
            this.BtnSearchCust.Name = "BtnSearchCust";
            this.BtnSearchCust.Size = new System.Drawing.Size(210, 41);
            this.BtnSearchCust.TabIndex = 82;
            this.BtnSearchCust.Text = "بحث";
            this.BtnSearchCust.UseVisualStyleBackColor = false;
            this.BtnSearchCust.Click += new System.EventHandler(this.BtnSearchCust_Click);
            // 
            // RBtnAllCust
            // 
            this.RBtnAllCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnAllCust.AutoSize = true;
            this.RBtnAllCust.Checked = true;
            this.RBtnAllCust.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnAllCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnAllCust.Location = new System.Drawing.Point(530, 54);
            this.RBtnAllCust.Name = "RBtnAllCust";
            this.RBtnAllCust.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnAllCust.Size = new System.Drawing.Size(117, 31);
            this.RBtnAllCust.TabIndex = 81;
            this.RBtnAllCust.TabStop = true;
            this.RBtnAllCust.Text = "جميع العملاء";
            this.RBtnAllCust.UseVisualStyleBackColor = true;
            // 
            // RBtnOneCust
            // 
            this.RBtnOneCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnOneCust.AutoSize = true;
            this.RBtnOneCust.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnOneCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnOneCust.Location = new System.Drawing.Point(651, 54);
            this.RBtnOneCust.Name = "RBtnOneCust";
            this.RBtnOneCust.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnOneCust.Size = new System.Drawing.Size(108, 31);
            this.RBtnOneCust.TabIndex = 80;
            this.RBtnOneCust.Text = "عميل محدد";
            this.RBtnOneCust.UseVisualStyleBackColor = true;
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
            this.CBxCustomer.Location = new System.Drawing.Point(774, 44);
            this.CBxCustomer.Name = "CBxCustomer";
            this.CBxCustomer.Size = new System.Drawing.Size(271, 41);
            this.CBxCustomer.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(768, 14);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(282, 27);
            this.label2.TabIndex = 74;
            this.label2.Text = "يرجى إختيار العميل المطلوب البحث عنه";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(303, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(503, 54);
            this.label1.TabIndex = 85;
            this.label1.Text = "المبالغ المستحقة من العملاء (ديون)";
            // 
            // frm_ClientMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1080, 597);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ClientMoney";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ClientMoneyzz";
            this.Load += new System.EventHandler(this.frm_ClientMoney_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPriceRestPaid)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustMoney)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumPriceRestPaid;
        private System.Windows.Forms.Button BtnPaidRest;
        private System.Windows.Forms.RadioButton RBtnPayPart;
        private System.Windows.Forms.RadioButton RBtnPayAll;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView DGVCustMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPrintCustMoney;
        private System.Windows.Forms.Button BtnSearchCust;
        private System.Windows.Forms.RadioButton RBtnAllCust;
        private System.Windows.Forms.RadioButton RBtnOneCust;
        private System.Windows.Forms.ComboBox CBxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}