namespace SalesApp
{
    partial class frm_PayPuy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnPayEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRest = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtPaid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtRequired = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnPayEnter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtRest);
            this.panel1.Controls.Add(this.TxtPaid);
            this.panel1.Controls.Add(this.TxtRequired);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 295);
            this.panel1.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(36, 212);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(74, 62);
            this.BtnCancel.TabIndex = 85;
            this.BtnCancel.Text = "إلغاء";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnPayEnter
            // 
            this.BtnPayEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPayEnter.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnPayEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPayEnter.FlatAppearance.BorderSize = 0;
            this.BtnPayEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPayEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.BtnPayEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPayEnter.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayEnter.ForeColor = System.Drawing.Color.White;
            this.BtnPayEnter.Location = new System.Drawing.Point(116, 212);
            this.BtnPayEnter.Name = "BtnPayEnter";
            this.BtnPayEnter.Size = new System.Drawing.Size(244, 62);
            this.BtnPayEnter.TabIndex = 84;
            this.BtnPayEnter.Text = "الدفع و الطباعة إضغط انتر ";
            this.BtnPayEnter.UseVisualStyleBackColor = false;
            this.BtnPayEnter.Click += new System.EventHandler(this.BtnPayEnter_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(392, 165);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 83;
            this.label3.Text = "الباقي :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(384, 110);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 82;
            this.label1.Text = "المدفوع :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(378, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 81;
            this.label2.Text = "المطلوب :";
            // 
            // TxtRest
            // 
            this.TxtRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRest.Location = new System.Drawing.Point(36, 152);
            this.TxtRest.Name = "TxtRest";
            this.TxtRest.ReadOnly = true;
            this.TxtRest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtRest.Size = new System.Drawing.Size(324, 40);
            this.TxtRest.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.TxtRest.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TxtRest.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtRest.StateActive.Border.ColorAngle = 45F;
            this.TxtRest.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtRest.StateActive.Border.Rounding = 0;
            this.TxtRest.StateActive.Border.Width = 1;
            this.TxtRest.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtRest.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRest.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtRest.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtRest.TabIndex = 80;
            this.TxtRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPaid
            // 
            this.TxtPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPaid.Location = new System.Drawing.Point(36, 87);
            this.TxtPaid.Multiline = true;
            this.TxtPaid.Name = "TxtPaid";
            this.TxtPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtPaid.Size = new System.Drawing.Size(324, 59);
            this.TxtPaid.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.TxtPaid.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TxtPaid.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtPaid.StateActive.Border.ColorAngle = 45F;
            this.TxtPaid.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtPaid.StateActive.Border.Rounding = 0;
            this.TxtPaid.StateActive.Border.Width = 1;
            this.TxtPaid.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtPaid.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaid.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 10, 2, 5);
            this.TxtPaid.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtPaid.TabIndex = 78;
            this.TxtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPaid.TextChanged += new System.EventHandler(this.TxtPaid_TextChanged);
            // 
            // TxtRequired
            // 
            this.TxtRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRequired.Location = new System.Drawing.Point(36, 41);
            this.TxtRequired.Name = "TxtRequired";
            this.TxtRequired.ReadOnly = true;
            this.TxtRequired.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtRequired.Size = new System.Drawing.Size(324, 40);
            this.TxtRequired.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.TxtRequired.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.TxtRequired.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtRequired.StateActive.Border.ColorAngle = 45F;
            this.TxtRequired.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TxtRequired.StateActive.Border.Rounding = 0;
            this.TxtRequired.StateActive.Border.Width = 1;
            this.TxtRequired.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TxtRequired.StateActive.Content.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRequired.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtRequired.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtRequired.TabIndex = 88;
            this.TxtRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_PayPuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(475, 305);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_PayPuy";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PayPuy";
            this.Load += new System.EventHandler(this.frm_PayPuy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PayPuy_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnPayEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtRest;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtPaid;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtRequired;
    }
}