namespace SalesApp
{
    partial class FormPurchases
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
            this.DGVPurchases = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimeAagel = new System.Windows.Forms.DateTimePicker();
            this.RBtnAagel = new System.Windows.Forms.RadioButton();
            this.RBtnCash = new System.Windows.Forms.RadioButton();
            this.TxtTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblProductsCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDeleteProducts = new System.Windows.Forms.Button();
            this.BtnAddProducts = new System.Windows.Forms.Button();
            this.BtnSupplierBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBxProducts = new System.Windows.Forms.ComboBox();
            this.CBxSupplier = new System.Windows.Forms.ComboBox();
            this.dateTimePurchases = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBarcode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPurchases)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVPurchases);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 176);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1233, 505);
            this.panel4.TabIndex = 78;
            // 
            // DGVPurchases
            // 
            this.DGVPurchases.AllowUserToAddRows = false;
            this.DGVPurchases.AllowUserToDeleteRows = false;
            this.DGVPurchases.AllowUserToResizeColumns = false;
            this.DGVPurchases.AllowUserToResizeRows = false;
            this.DGVPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPurchases.BackgroundColor = System.Drawing.Color.White;
            this.DGVPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVPurchases.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DGVPurchases.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPurchases.EnableHeadersVisualStyles = false;
            this.DGVPurchases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVPurchases.Location = new System.Drawing.Point(10, 10);
            this.DGVPurchases.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DGVPurchases.Name = "DGVPurchases";
            this.DGVPurchases.ReadOnly = true;
            this.DGVPurchases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPurchases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPurchases.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.DGVPurchases.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVPurchases.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGVPurchases.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DGVPurchases.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVPurchases.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.DGVPurchases.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(7);
            this.DGVPurchases.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVPurchases.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.DGVPurchases.RowTemplate.Height = 45;
            this.DGVPurchases.RowTemplate.ReadOnly = true;
            this.DGVPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPurchases.Size = new System.Drawing.Size(1213, 485);
            this.DGVPurchases.TabIndex = 63;
            this.DGVPurchases.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPurchases_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "إسم المنتج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "الكمية";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "السعر";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 60F;
            this.Column5.HeaderText = "الخصم";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "الإجمالي";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimeAagel);
            this.panel3.Controls.Add(this.RBtnAagel);
            this.panel3.Controls.Add(this.RBtnCash);
            this.panel3.Controls.Add(this.TxtTotal);
            this.panel3.Controls.Add(this.LblProductsCount);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 681);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1233, 100);
            this.panel3.TabIndex = 77;
            // 
            // dateTimeAagel
            // 
            this.dateTimeAagel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeAagel.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAagel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAagel.Location = new System.Drawing.Point(686, 40);
            this.dateTimeAagel.Name = "dateTimeAagel";
            this.dateTimeAagel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeAagel.RightToLeftLayout = true;
            this.dateTimeAagel.Size = new System.Drawing.Size(135, 40);
            this.dateTimeAagel.TabIndex = 81;
            // 
            // RBtnAagel
            // 
            this.RBtnAagel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnAagel.AutoSize = true;
            this.RBtnAagel.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnAagel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnAagel.Location = new System.Drawing.Point(854, 51);
            this.RBtnAagel.Name = "RBtnAagel";
            this.RBtnAagel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnAagel.Size = new System.Drawing.Size(97, 31);
            this.RBtnAagel.TabIndex = 80;
            this.RBtnAagel.Text = "الدفع آجل";
            this.RBtnAagel.UseVisualStyleBackColor = true;
            // 
            // RBtnCash
            // 
            this.RBtnCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBtnCash.AutoSize = true;
            this.RBtnCash.Checked = true;
            this.RBtnCash.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.RBtnCash.Location = new System.Drawing.Point(848, 20);
            this.RBtnCash.Name = "RBtnCash";
            this.RBtnCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnCash.Size = new System.Drawing.Size(103, 31);
            this.RBtnCash.TabIndex = 79;
            this.RBtnCash.TabStop = true;
            this.RBtnCash.Text = "الدفع كاش";
            this.RBtnCash.UseVisualStyleBackColor = true;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(10, 18);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTotal.Size = new System.Drawing.Size(353, 62);
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
            this.LblProductsCount.Location = new System.Drawing.Point(1077, 51);
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
            this.label10.Location = new System.Drawing.Point(1106, 51);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(116, 29);
            this.label10.TabIndex = 76;
            this.label10.Text = "عدد المنتجات :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.TxtID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtnDeleteProducts);
            this.panel2.Controls.Add(this.BtnAddProducts);
            this.panel2.Controls.Add(this.BtnSupplierBrowse);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CBxProducts);
            this.panel2.Controls.Add(this.CBxSupplier);
            this.panel2.Controls.Add(this.dateTimePurchases);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TxtBarcode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 176);
            this.panel2.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label8.Location = new System.Drawing.Point(402, 7);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(98, 27);
            this.label8.TabIndex = 80;
            this.label8.Text = "رقم الفاتورة :";
            // 
            // TxtID
            // 
            this.TxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtID.Location = new System.Drawing.Point(332, 37);
            this.TxtID.Name = "TxtID";
            this.TxtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtID.Size = new System.Drawing.Size(164, 40);
            this.TxtID.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
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
            this.label7.Location = new System.Drawing.Point(332, 128);
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
            this.label4.Location = new System.Drawing.Point(463, 127);
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
            this.BtnDeleteProducts.Location = new System.Drawing.Point(409, 119);
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
            this.BtnAddProducts.Location = new System.Drawing.Point(501, 119);
            this.BtnAddProducts.Name = "BtnAddProducts";
            this.BtnAddProducts.Size = new System.Drawing.Size(48, 42);
            this.BtnAddProducts.TabIndex = 75;
            this.BtnAddProducts.UseVisualStyleBackColor = true;
            this.BtnAddProducts.Click += new System.EventHandler(this.BtnAddProducts_Click);
            this.BtnAddProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnAddProducts_KeyPress);
            // 
            // BtnSupplierBrowse
            // 
            this.BtnSupplierBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSupplierBrowse.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSupplierBrowse.Location = new System.Drawing.Point(502, 37);
            this.BtnSupplierBrowse.Name = "BtnSupplierBrowse";
            this.BtnSupplierBrowse.Size = new System.Drawing.Size(48, 41);
            this.BtnSupplierBrowse.TabIndex = 74;
            this.BtnSupplierBrowse.Text = "...";
            this.BtnSupplierBrowse.UseVisualStyleBackColor = true;
            this.BtnSupplierBrowse.Click += new System.EventHandler(this.BtnSupplierBrowse_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(1126, 8);
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
            this.CBxProducts.Location = new System.Drawing.Point(555, 120);
            this.CBxProducts.Name = "CBxProducts";
            this.CBxProducts.Size = new System.Drawing.Size(325, 41);
            this.CBxProducts.TabIndex = 72;
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
            this.CBxSupplier.Location = new System.Drawing.Point(556, 37);
            this.CBxSupplier.Name = "CBxSupplier";
            this.CBxSupplier.Size = new System.Drawing.Size(325, 41);
            this.CBxSupplier.TabIndex = 71;
            // 
            // dateTimePurchases
            // 
            this.dateTimePurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePurchases.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePurchases.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePurchases.Location = new System.Drawing.Point(896, 121);
            this.dateTimePurchases.Name = "dateTimePurchases";
            this.dateTimePurchases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePurchases.RightToLeftLayout = true;
            this.dateTimePurchases.Size = new System.Drawing.Size(324, 40);
            this.dateTimePurchases.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(789, 91);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 69;
            this.label1.Text = "اختر المنتج :";
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBarcode.Location = new System.Drawing.Point(896, 38);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBarcode.Size = new System.Drawing.Size(324, 40);
            this.TxtBarcode.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
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
            this.label3.Location = new System.Drawing.Point(793, 11);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 66;
            this.label3.Text = "اسم المورد :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(1163, 91);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 67;
            this.label5.Text = "التاريخ :";
            // 
            // FormPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 781);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormPurchases";
            this.Text = "FormPurchases";
            this.Load += new System.EventHandler(this.FormPurchases_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPurchases_KeyDown);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPurchases)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView DGVPurchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimeAagel;
        private System.Windows.Forms.RadioButton RBtnAagel;
        private System.Windows.Forms.RadioButton RBtnCash;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtTotal;
        private System.Windows.Forms.Label LblProductsCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDeleteProducts;
        private System.Windows.Forms.Button BtnAddProducts;
        private System.Windows.Forms.Button BtnSupplierBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBxProducts;
        private System.Windows.Forms.ComboBox CBxSupplier;
        private System.Windows.Forms.DateTimePicker dateTimePurchases;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtID;
    }
}