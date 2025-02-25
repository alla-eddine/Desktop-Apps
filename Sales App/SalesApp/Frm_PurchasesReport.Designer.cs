namespace SalesApp
{
    partial class Frm_PurchasesReport
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnPrintAll = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPrintOrder = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGVSupplierReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtOrderNBR = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.checkBoxOrderNBR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.BtnSearchSupp = new System.Windows.Forms.Button();
            this.RBtnAllSupp = new System.Windows.Forms.RadioButton();
            this.RBtnOneSupp = new System.Windows.Forms.RadioButton();
            this.CBxSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSupplierReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 698);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnPrintAll);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.TxtTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BtnPrintOrder);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 603);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1380, 95);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // BtnPrintAll
            // 
            this.BtnPrintAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrintAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnPrintAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintAll.FlatAppearance.BorderSize = 0;
            this.BtnPrintAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintAll.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintAll.ForeColor = System.Drawing.Color.White;
            this.BtnPrintAll.Location = new System.Drawing.Point(476, 3);
            this.BtnPrintAll.Name = "BtnPrintAll";
            this.BtnPrintAll.Size = new System.Drawing.Size(310, 62);
            this.BtnPrintAll.TabIndex = 88;
            this.BtnPrintAll.Text = "طباعة كل الفواتير";
            this.BtnPrintAll.UseVisualStyleBackColor = false;
            this.BtnPrintAll.Click += new System.EventHandler(this.BtnPrintAll_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(792, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(272, 62);
            this.BtnDelete.TabIndex = 87;
            this.BtnDelete.Text = "مسح بيانات الفاتورة المحددة";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(-1, 3);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTotal.Size = new System.Drawing.Size(464, 62);
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
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(165, 68);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(303, 27);
            this.label3.TabIndex = 84;
            this.label3.Text = "إجمالي مبالغ الشراء في هذه الفترة المحددة";
            // 
            // BtnPrintOrder
            // 
            this.BtnPrintOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrintOrder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnPrintOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintOrder.FlatAppearance.BorderSize = 0;
            this.BtnPrintOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintOrder.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintOrder.ForeColor = System.Drawing.Color.White;
            this.BtnPrintOrder.Location = new System.Drawing.Point(1070, 3);
            this.BtnPrintOrder.Name = "BtnPrintOrder";
            this.BtnPrintOrder.Size = new System.Drawing.Size(300, 62);
            this.BtnPrintOrder.TabIndex = 82;
            this.BtnPrintOrder.Text = "طباعة الفاتورة المحددة";
            this.BtnPrintOrder.UseVisualStyleBackColor = false;
            this.BtnPrintOrder.Click += new System.EventHandler(this.BtnPrintOrder_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVSupplierReport);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 154);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1380, 544);
            this.panel4.TabIndex = 87;
            // 
            // DGVSupplierReport
            // 
            this.DGVSupplierReport.AllowUserToAddRows = false;
            this.DGVSupplierReport.AllowUserToDeleteRows = false;
            this.DGVSupplierReport.AllowUserToResizeColumns = false;
            this.DGVSupplierReport.AllowUserToResizeRows = false;
            this.DGVSupplierReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVSupplierReport.BackgroundColor = System.Drawing.Color.White;
            this.DGVSupplierReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVSupplierReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVSupplierReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVSupplierReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSupplierReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSupplierReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSupplierReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVSupplierReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSupplierReport.EnableHeadersVisualStyles = false;
            this.DGVSupplierReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVSupplierReport.Location = new System.Drawing.Point(10, 10);
            this.DGVSupplierReport.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DGVSupplierReport.Name = "DGVSupplierReport";
            this.DGVSupplierReport.ReadOnly = true;
            this.DGVSupplierReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSupplierReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVSupplierReport.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.DGVSupplierReport.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVSupplierReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGVSupplierReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DGVSupplierReport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVSupplierReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.DGVSupplierReport.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(7);
            this.DGVSupplierReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVSupplierReport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.DGVSupplierReport.RowTemplate.Height = 45;
            this.DGVSupplierReport.RowTemplate.ReadOnly = true;
            this.DGVSupplierReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSupplierReport.Size = new System.Drawing.Size(1360, 524);
            this.DGVSupplierReport.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtOrderNBR);
            this.groupBox1.Controls.Add(this.checkBoxOrderNBR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtpFrom);
            this.groupBox1.Controls.Add(this.DtpTo);
            this.groupBox1.Controls.Add(this.BtnSearchSupp);
            this.groupBox1.Controls.Add(this.RBtnAllSupp);
            this.groupBox1.Controls.Add(this.RBtnOneSupp);
            this.groupBox1.Controls.Add(this.CBxSupplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1380, 154);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // TxtOrderNBR
            // 
            this.TxtOrderNBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOrderNBR.Location = new System.Drawing.Point(551, 101);
            this.TxtOrderNBR.Name = "TxtOrderNBR";
            this.TxtOrderNBR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtOrderNBR.Size = new System.Drawing.Size(164, 40);
            this.TxtOrderNBR.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.TxtOrderNBR.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TxtOrderNBR.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtOrderNBR.StateActive.Border.ColorAngle = 45F;
            this.TxtOrderNBR.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtOrderNBR.StateActive.Border.Rounding = 0;
            this.TxtOrderNBR.StateActive.Border.Width = 1;
            this.TxtOrderNBR.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtOrderNBR.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrderNBR.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtOrderNBR.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TxtOrderNBR.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtOrderNBR.TabIndex = 95;
            // 
            // checkBoxOrderNBR
            // 
            this.checkBoxOrderNBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOrderNBR.AutoSize = true;
            this.checkBoxOrderNBR.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrderNBR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.checkBoxOrderNBR.Location = new System.Drawing.Point(721, 110);
            this.checkBoxOrderNBR.Name = "checkBoxOrderNBR";
            this.checkBoxOrderNBR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxOrderNBR.Size = new System.Drawing.Size(151, 31);
            this.checkBoxOrderNBR.TabIndex = 94;
            this.checkBoxOrderNBR.Text = "بحث برقم الفاتورة";
            this.checkBoxOrderNBR.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(306, 112);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(44, 27);
            this.label5.TabIndex = 93;
            this.label5.Text = "إلى :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(506, 112);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(39, 27);
            this.label4.TabIndex = 92;
            this.label4.Text = "من :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(893, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(490, 54);
            this.label1.TabIndex = 85;
            this.label1.Text = "إجمالي المشتريات في فترة محددة";
            // 
            // DtpFrom
            // 
            this.DtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFrom.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFrom.Location = new System.Drawing.Point(356, 101);
            this.DtpFrom.Name = "DtpFrom";
            this.DtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpFrom.RightToLeftLayout = true;
            this.DtpFrom.Size = new System.Drawing.Size(144, 40);
            this.DtpFrom.TabIndex = 91;
            // 
            // DtpTo
            // 
            this.DtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpTo.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTo.Location = new System.Drawing.Point(156, 102);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpTo.RightToLeftLayout = true;
            this.DtpTo.Size = new System.Drawing.Size(144, 40);
            this.DtpTo.TabIndex = 90;
            // 
            // BtnSearchSupp
            // 
            this.BtnSearchSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchSupp.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnSearchSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchSupp.FlatAppearance.BorderSize = 0;
            this.BtnSearchSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnSearchSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchSupp.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchSupp.ForeColor = System.Drawing.Color.White;
            this.BtnSearchSupp.Location = new System.Drawing.Point(34, 101);
            this.BtnSearchSupp.Name = "BtnSearchSupp";
            this.BtnSearchSupp.Size = new System.Drawing.Size(116, 41);
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
            this.RBtnAllSupp.Location = new System.Drawing.Point(878, 109);
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
            this.RBtnOneSupp.Location = new System.Drawing.Point(1012, 109);
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
            this.CBxSupplier.Location = new System.Drawing.Point(1119, 99);
            this.CBxSupplier.Name = "CBxSupplier";
            this.CBxSupplier.Size = new System.Drawing.Size(251, 41);
            this.CBxSupplier.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(1098, 69);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(276, 27);
            this.label2.TabIndex = 74;
            this.label2.Text = "يرجى إختيار المورد المطلوب البحث عنه";
            // 
            // Frm_PurchasesReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1390, 708);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PurchasesReport";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_PurchasesReport_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSupplierReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPrintOrder;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView DGVSupplierReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSearchSupp;
        private System.Windows.Forms.RadioButton RBtnAllSupp;
        private System.Windows.Forms.RadioButton RBtnOneSupp;
        private System.Windows.Forms.ComboBox CBxSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPrintAll;
        private System.Windows.Forms.Button BtnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtOrderNBR;
        private System.Windows.Forms.CheckBox checkBoxOrderNBR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpFrom;
    }
}