namespace SalesApp
{
    partial class frm_ClientReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGVCustReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearchCust = new System.Windows.Forms.Button();
            this.RBtnAllCust = new System.Windows.Forms.RadioButton();
            this.RBtnOneCust = new System.Windows.Forms.RadioButton();
            this.CBxCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReport)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1071, 618);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(10, 33);
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
            this.DtpDate.Location = new System.Drawing.Point(13, 33);
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
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Location = new System.Drawing.Point(2, 531);
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
            this.label3.Location = new System.Drawing.Point(238, 31);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(179, 27);
            this.label3.TabIndex = 84;
            this.label3.Text = "إجمالي المبالغ المسددة :";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(803, 13);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(254, 62);
            this.BtnDelete.TabIndex = 82;
            this.BtnDelete.Text = "مسح البيانات";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVCustReport);
            this.panel4.Location = new System.Drawing.Point(0, 178);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1070, 360);
            this.panel4.TabIndex = 87;
            // 
            // DGVCustReport
            // 
            this.DGVCustReport.AllowUserToAddRows = false;
            this.DGVCustReport.AllowUserToDeleteRows = false;
            this.DGVCustReport.AllowUserToResizeColumns = false;
            this.DGVCustReport.AllowUserToResizeRows = false;
            this.DGVCustReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCustReport.BackgroundColor = System.Drawing.Color.White;
            this.DGVCustReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCustReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVCustReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVCustReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DGVCustReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCustReport.DefaultCellStyle = dataGridViewCellStyle18;
            this.DGVCustReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustReport.EnableHeadersVisualStyles = false;
            this.DGVCustReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVCustReport.Location = new System.Drawing.Point(10, 10);
            this.DGVCustReport.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DGVCustReport.Name = "DGVCustReport";
            this.DGVCustReport.ReadOnly = true;
            this.DGVCustReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGVCustReport.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Gray;
            this.DGVCustReport.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DGVCustReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGVCustReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DGVCustReport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCustReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.DGVCustReport.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(7);
            this.DGVCustReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVCustReport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.DGVCustReport.RowTemplate.Height = 45;
            this.DGVCustReport.RowTemplate.ReadOnly = true;
            this.DGVCustReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustReport.Size = new System.Drawing.Size(1050, 340);
            this.DGVCustReport.TabIndex = 63;
            // 
            // groupBox1
            // 
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
            this.BtnSearchCust.Location = new System.Drawing.Point(-8, 44);
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
            this.label2.Location = new System.Drawing.Point(768, 16);
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
            this.label1.Location = new System.Drawing.Point(353, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(382, 54);
            this.label1.TabIndex = 85;
            this.label1.Text = "المبالغ المسددة من العملاء";
            // 
            // frm_ClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1081, 628);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ClientReport";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CustomerReport";
            this.Load += new System.EventHandler(this.frm_ClientReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReport)).EndInit();
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
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView DGVCustReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSearchCust;
        private System.Windows.Forms.RadioButton RBtnAllCust;
        private System.Windows.Forms.RadioButton RBtnOneCust;
        private System.Windows.Forms.ComboBox CBxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}