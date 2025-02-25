namespace SalesApp
{
    partial class FormSetting
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPrinter = new System.Windows.Forms.ComboBox();
            this.btnSavePrinter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesciption = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdressStore = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNameStore = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BtnDeleteImage = new System.Windows.Forms.Button();
            this.BtnLoadImage = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveGenral = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtnA4Buy = new System.Windows.Forms.RadioButton();
            this.rbtn8cmBuy = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnA4Sales = new System.Windows.Forms.RadioButton();
            this.rbtn8cmSales = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.NudSaleNumber = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NudBuyNumber = new System.Windows.Forms.NumericUpDown();
            this.checkBuyPrint = new System.Windows.Forms.CheckBox();
            this.checkSalePrint = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.EmptyDbBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ImpDbBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ExpDbBtn = new System.Windows.Forms.Button();
            this.progressBarText = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSaleNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBuyNumber)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbxPrinter);
            this.groupBox3.Controls.Add(this.btnSavePrinter);
            this.groupBox3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.groupBox3.Location = new System.Drawing.Point(936, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(323, 572);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "إعدادات الطابعة";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(57, 55);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(260, 27);
            this.label4.TabIndex = 107;
            this.label4.Text = "اختر طابعة لكي تكون هي الرئيسية :";
            // 
            // cbxPrinter
            // 
            this.cbxPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPrinter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxPrinter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPrinter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxPrinter.DropDownHeight = 150;
            this.cbxPrinter.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrinter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.cbxPrinter.FormattingEnabled = true;
            this.cbxPrinter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxPrinter.IntegralHeight = false;
            this.cbxPrinter.ItemHeight = 29;
            this.cbxPrinter.Location = new System.Drawing.Point(16, 95);
            this.cbxPrinter.Name = "cbxPrinter";
            this.cbxPrinter.Size = new System.Drawing.Size(296, 37);
            this.cbxPrinter.TabIndex = 106;
            // 
            // btnSavePrinter
            // 
            this.btnSavePrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePrinter.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSavePrinter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.btnSavePrinter.FlatAppearance.BorderSize = 0;
            this.btnSavePrinter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.btnSavePrinter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.btnSavePrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrinter.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrinter.ForeColor = System.Drawing.Color.White;
            this.btnSavePrinter.Location = new System.Drawing.Point(16, 148);
            this.btnSavePrinter.Name = "btnSavePrinter";
            this.btnSavePrinter.Size = new System.Drawing.Size(296, 41);
            this.btnSavePrinter.TabIndex = 88;
            this.btnSavePrinter.Text = "حفظ بيانات الطابعة";
            this.btnSavePrinter.UseVisualStyleBackColor = false;
            this.btnSavePrinter.Click += new System.EventHandler(this.btnSavePrinter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDesciption);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdressStore);
            this.groupBox1.Controls.Add(this.txtNameStore);
            this.groupBox1.Controls.Add(this.BtnDeleteImage);
            this.groupBox1.Controls.Add(this.BtnLoadImage);
            this.groupBox1.Controls.Add(this.pictureLogo);
            this.groupBox1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.groupBox1.Location = new System.Drawing.Point(387, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(543, 572);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إعدادات الفاتورة";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(361, 315);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(170, 27);
            this.label7.TabIndex = 114;
            this.label7.Text = "جملة في أسفل الفاتورة";
            // 
            // txtDesciption
            // 
            this.txtDesciption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesciption.Location = new System.Drawing.Point(15, 345);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDesciption.Size = new System.Drawing.Size(511, 40);
            this.txtDesciption.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtDesciption.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txtDesciption.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDesciption.StateActive.Border.ColorAngle = 45F;
            this.txtDesciption.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDesciption.StateActive.Border.Rounding = 0;
            this.txtDesciption.StateActive.Border.Width = 1;
            this.txtDesciption.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.txtDesciption.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesciption.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtDesciption.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDesciption.TabIndex = 113;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(513, 41);
            this.button1.TabIndex = 112;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(163, 244);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 111;
            this.label3.Text = "رقم الهاتف";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(15, 277);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(239, 40);
            this.txtPhone.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtPhone.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txtPhone.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPhone.StateActive.Border.ColorAngle = 45F;
            this.txtPhone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhone.StateActive.Border.Rounding = 0;
            this.txtPhone.StateActive.Border.Width = 1;
            this.txtPhone.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.txtPhone.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtPhone.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPhone.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(163, 163);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 109;
            this.label2.Text = "عنوان المحل";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(175, 81);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 108;
            this.label1.Text = "اسم المحل";
            // 
            // txtAdressStore
            // 
            this.txtAdressStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdressStore.Location = new System.Drawing.Point(15, 192);
            this.txtAdressStore.Name = "txtAdressStore";
            this.txtAdressStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAdressStore.Size = new System.Drawing.Size(239, 40);
            this.txtAdressStore.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtAdressStore.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txtAdressStore.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdressStore.StateActive.Border.ColorAngle = 45F;
            this.txtAdressStore.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAdressStore.StateActive.Border.Rounding = 0;
            this.txtAdressStore.StateActive.Border.Width = 1;
            this.txtAdressStore.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.txtAdressStore.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdressStore.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtAdressStore.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdressStore.TabIndex = 103;
            // 
            // txtNameStore
            // 
            this.txtNameStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameStore.Location = new System.Drawing.Point(15, 111);
            this.txtNameStore.Name = "txtNameStore";
            this.txtNameStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameStore.Size = new System.Drawing.Size(239, 40);
            this.txtNameStore.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtNameStore.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.txtNameStore.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNameStore.StateActive.Border.ColorAngle = 45F;
            this.txtNameStore.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNameStore.StateActive.Border.Rounding = 0;
            this.txtNameStore.StateActive.Border.Width = 1;
            this.txtNameStore.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.txtNameStore.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameStore.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtNameStore.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNameStore.TabIndex = 102;
            // 
            // BtnDeleteImage
            // 
            this.BtnDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteImage.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(128)))));
            this.BtnDeleteImage.Location = new System.Drawing.Point(288, 205);
            this.BtnDeleteImage.Name = "BtnDeleteImage";
            this.BtnDeleteImage.Size = new System.Drawing.Size(108, 43);
            this.BtnDeleteImage.TabIndex = 49;
            this.BtnDeleteImage.Text = "مسح صورة";
            this.BtnDeleteImage.UseVisualStyleBackColor = true;
            this.BtnDeleteImage.Click += new System.EventHandler(this.BtnDeleteImage_Click);
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadImage.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(128)))));
            this.BtnLoadImage.Location = new System.Drawing.Point(413, 205);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(115, 43);
            this.BtnLoadImage.TabIndex = 48;
            this.BtnLoadImage.Text = "اختر صورة";
            this.BtnLoadImage.UseVisualStyleBackColor = true;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogo.Location = new System.Drawing.Point(288, 81);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(239, 118);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 47;
            this.pictureLogo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSaveGenral);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.NudSaleNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NudBuyNumber);
            this.groupBox2.Controls.Add(this.checkBuyPrint);
            this.groupBox2.Controls.Add(this.checkSalePrint);
            this.groupBox2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(369, 572);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إعدادات عامة";
            // 
            // btnSaveGenral
            // 
            this.btnSaveGenral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveGenral.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSaveGenral.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.btnSaveGenral.FlatAppearance.BorderSize = 0;
            this.btnSaveGenral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.btnSaveGenral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.btnSaveGenral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGenral.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGenral.ForeColor = System.Drawing.Color.White;
            this.btnSaveGenral.Location = new System.Drawing.Point(6, 525);
            this.btnSaveGenral.Name = "btnSaveGenral";
            this.btnSaveGenral.Size = new System.Drawing.Size(357, 41);
            this.btnSaveGenral.TabIndex = 113;
            this.btnSaveGenral.Text = "حفظ";
            this.btnSaveGenral.UseVisualStyleBackColor = false;
            this.btnSaveGenral.Click += new System.EventHandler(this.btnSaveGenral_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtnA4Buy);
            this.groupBox5.Controls.Add(this.rbtn8cmBuy);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.groupBox5.Location = new System.Drawing.Point(6, 409);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(357, 92);
            this.groupBox5.TabIndex = 109;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "مقاسات طباعة فواتير المشتريات";
            // 
            // rbtnA4Buy
            // 
            this.rbtnA4Buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnA4Buy.AutoSize = true;
            this.rbtnA4Buy.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnA4Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.rbtnA4Buy.Location = new System.Drawing.Point(64, 34);
            this.rbtnA4Buy.Name = "rbtnA4Buy";
            this.rbtnA4Buy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnA4Buy.Size = new System.Drawing.Size(111, 31);
            this.rbtnA4Buy.TabIndex = 90;
            this.rbtnA4Buy.Text = "طباعة (A4)";
            this.rbtnA4Buy.UseVisualStyleBackColor = true;
            // 
            // rbtn8cmBuy
            // 
            this.rbtn8cmBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn8cmBuy.AutoSize = true;
            this.rbtn8cmBuy.Checked = true;
            this.rbtn8cmBuy.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn8cmBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.rbtn8cmBuy.Location = new System.Drawing.Point(179, 34);
            this.rbtn8cmBuy.Name = "rbtn8cmBuy";
            this.rbtn8cmBuy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn8cmBuy.Size = new System.Drawing.Size(169, 31);
            this.rbtn8cmBuy.TabIndex = 89;
            this.rbtn8cmBuy.TabStop = true;
            this.rbtn8cmBuy.Text = "طباعة حرارية (8cm)";
            this.rbtn8cmBuy.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(50, -244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 41);
            this.button3.TabIndex = 88;
            this.button3.Text = "حفظ بيانات الطابعة";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnA4Sales);
            this.groupBox4.Controls.Add(this.rbtn8cmSales);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.groupBox4.Location = new System.Drawing.Point(6, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(357, 92);
            this.groupBox4.TabIndex = 108;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "مقاسات طباعة فواتير المبيعات";
            // 
            // rbtnA4Sales
            // 
            this.rbtnA4Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnA4Sales.AutoSize = true;
            this.rbtnA4Sales.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnA4Sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.rbtnA4Sales.Location = new System.Drawing.Point(64, 34);
            this.rbtnA4Sales.Name = "rbtnA4Sales";
            this.rbtnA4Sales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnA4Sales.Size = new System.Drawing.Size(111, 31);
            this.rbtnA4Sales.TabIndex = 90;
            this.rbtnA4Sales.Text = "طباعة (A4)";
            this.rbtnA4Sales.UseVisualStyleBackColor = true;
            // 
            // rbtn8cmSales
            // 
            this.rbtn8cmSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn8cmSales.AutoSize = true;
            this.rbtn8cmSales.Checked = true;
            this.rbtn8cmSales.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn8cmSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.rbtn8cmSales.Location = new System.Drawing.Point(179, 34);
            this.rbtn8cmSales.Name = "rbtn8cmSales";
            this.rbtn8cmSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn8cmSales.Size = new System.Drawing.Size(169, 31);
            this.rbtn8cmSales.TabIndex = 89;
            this.rbtn8cmSales.TabStop = true;
            this.rbtn8cmSales.Text = "طباعة حرارية (8cm)";
            this.rbtn8cmSales.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(50, -244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 41);
            this.button2.TabIndex = 88;
            this.button2.Text = "حفظ بيانات الطابعة";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // NudSaleNumber
            // 
            this.NudSaleNumber.Location = new System.Drawing.Point(133, 235);
            this.NudSaleNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudSaleNumber.Name = "NudSaleNumber";
            this.NudSaleNumber.Size = new System.Drawing.Size(230, 35);
            this.NudSaleNumber.TabIndex = 119;
            this.NudSaleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(121, 205);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(247, 27);
            this.label6.TabIndex = 118;
            this.label6.Text = "عدد طباعة فاتورة شاشة المبيعات ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(112, 124);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(256, 27);
            this.label5.TabIndex = 117;
            this.label5.Text = "عدد طباعة فاتورة شاشة المشتريات ";
            // 
            // NudBuyNumber
            // 
            this.NudBuyNumber.Location = new System.Drawing.Point(133, 154);
            this.NudBuyNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudBuyNumber.Name = "NudBuyNumber";
            this.NudBuyNumber.Size = new System.Drawing.Size(230, 35);
            this.NudBuyNumber.TabIndex = 116;
            this.NudBuyNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBuyPrint
            // 
            this.checkBuyPrint.AutoSize = true;
            this.checkBuyPrint.Location = new System.Drawing.Point(73, 71);
            this.checkBuyPrint.Name = "checkBuyPrint";
            this.checkBuyPrint.Size = new System.Drawing.Size(290, 31);
            this.checkBuyPrint.TabIndex = 115;
            this.checkBuyPrint.Text = "تفعيل طباعة فاتورة شاشة المشتريات ";
            this.checkBuyPrint.UseVisualStyleBackColor = true;
            // 
            // checkSalePrint
            // 
            this.checkSalePrint.AutoSize = true;
            this.checkSalePrint.Location = new System.Drawing.Point(82, 34);
            this.checkSalePrint.Name = "checkSalePrint";
            this.checkSalePrint.Size = new System.Drawing.Size(281, 31);
            this.checkSalePrint.TabIndex = 114;
            this.checkSalePrint.Text = "تفعيل طباعة فاتورة شاشة المبيعات ";
            this.checkSalePrint.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.progressBarText);
            this.groupBox6.Controls.Add(this.progressBar);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.EmptyDbBtn);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.ImpDbBtn);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.ExpDbBtn);
            this.groupBox6.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.groupBox6.Location = new System.Drawing.Point(12, 613);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(1247, 176);
            this.groupBox6.TabIndex = 108;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "إعدادات البيانات";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(271, 85);
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar.Size = new System.Drawing.Size(394, 41);
            this.progressBar.TabIndex = 112;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label10.Location = new System.Drawing.Point(111, 55);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(145, 27);
            this.label10.TabIndex = 111;
            this.label10.Text = "قاعدة بيانات جديدة";
            // 
            // EmptyDbBtn
            // 
            this.EmptyDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmptyDbBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.EmptyDbBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.EmptyDbBtn.FlatAppearance.BorderSize = 0;
            this.EmptyDbBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.EmptyDbBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.EmptyDbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmptyDbBtn.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyDbBtn.ForeColor = System.Drawing.Color.White;
            this.EmptyDbBtn.Location = new System.Drawing.Point(6, 85);
            this.EmptyDbBtn.Name = "EmptyDbBtn";
            this.EmptyDbBtn.Size = new System.Drawing.Size(245, 41);
            this.EmptyDbBtn.TabIndex = 110;
            this.EmptyDbBtn.Text = "انشاء قاعدة بيانات جديدة";
            this.EmptyDbBtn.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label9.Location = new System.Drawing.Point(728, 55);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(205, 27);
            this.label9.TabIndex = 109;
            this.label9.Text = "رفع نسخة من قاعدة البيانات";
            // 
            // ImpDbBtn
            // 
            this.ImpDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImpDbBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ImpDbBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ImpDbBtn.FlatAppearance.BorderSize = 0;
            this.ImpDbBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ImpDbBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ImpDbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImpDbBtn.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpDbBtn.ForeColor = System.Drawing.Color.White;
            this.ImpDbBtn.Location = new System.Drawing.Point(683, 85);
            this.ImpDbBtn.Name = "ImpDbBtn";
            this.ImpDbBtn.Size = new System.Drawing.Size(245, 41);
            this.ImpDbBtn.TabIndex = 108;
            this.ImpDbBtn.Text = "رفع نسخة بيانات";
            this.ImpDbBtn.UseVisualStyleBackColor = false;
            this.ImpDbBtn.Click += new System.EventHandler(this.ImpDbBtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label8.Location = new System.Drawing.Point(1025, 55);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(216, 27);
            this.label8.TabIndex = 107;
            this.label8.Text = "حفظ نسخة من قاعدة البيانات";
            // 
            // ExpDbBtn
            // 
            this.ExpDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpDbBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ExpDbBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ExpDbBtn.FlatAppearance.BorderSize = 0;
            this.ExpDbBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ExpDbBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ExpDbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpDbBtn.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDbBtn.ForeColor = System.Drawing.Color.White;
            this.ExpDbBtn.Location = new System.Drawing.Point(991, 85);
            this.ExpDbBtn.Name = "ExpDbBtn";
            this.ExpDbBtn.Size = new System.Drawing.Size(245, 41);
            this.ExpDbBtn.TabIndex = 88;
            this.ExpDbBtn.Text = "حفظ نسخة بيانات";
            this.ExpDbBtn.UseVisualStyleBackColor = false;
            this.ExpDbBtn.Click += new System.EventHandler(this.ExpDbBtn_Click);
            // 
            // progressBarText
            // 
            this.progressBarText.AutoSize = true;
            this.progressBarText.BackColor = System.Drawing.Color.Transparent;
            this.progressBarText.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.progressBarText.Location = new System.Drawing.Point(499, 55);
            this.progressBarText.Name = "progressBarText";
            this.progressBarText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarText.Size = new System.Drawing.Size(171, 27);
            this.progressBarText.TabIndex = 113;
            this.progressBarText.Text = "100% تم التحمبل بنجاح";
            this.progressBarText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 801);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSaleNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBuyNumber)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSavePrinter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPrinter;
        private System.Windows.Forms.Button BtnDeleteImage;
        private System.Windows.Forms.Button BtnLoadImage;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAdressStore;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNameStore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NudSaleNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudBuyNumber;
        private System.Windows.Forms.CheckBox checkBuyPrint;
        private System.Windows.Forms.CheckBox checkSalePrint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtnA4Sales;
        private System.Windows.Forms.RadioButton rbtn8cmSales;
        private System.Windows.Forms.Button btnSaveGenral;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtnA4Buy;
        private System.Windows.Forms.RadioButton rbtn8cmBuy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDesciption;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ExpDbBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button EmptyDbBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ImpDbBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressBarText;
    }
}