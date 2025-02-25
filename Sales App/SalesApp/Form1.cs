using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class Form1 : Form
    {
        private DatabaseClass model;
        public Form1()
        {
            InitializeComponent();
            model = new DatabaseClass();
        }

        
        DataTable tbl,tbl2 = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            LblUserName.Text = Properties.Settings.Default.UserName;
            tbl = model.readData("select * from Users where User_Name = '"+ Properties.Settings.Default.UserName.ToString().Trim() + "' and User_Type = '"+ Properties.Settings.Default.USerType.ToString().Trim() + "'","");
            if (tbl.Rows.Count >= 1)
            {   
                tbl2 = model.readData("select * from UserAccess where User_ID = " + Convert.ToInt32(tbl.Rows[0][0])+"", "");


                if (tbl2.Rows[0][1].ToString() == "true")
                    BtnSells.Enabled = true;
                else if (tbl2.Rows[0][1].ToString() == "false")
                    BtnSells.Enabled = false;

                    if (tbl2.Rows[0][2].ToString() == "true")
                        BtnPurchases.Enabled = true;
                    else if (tbl2.Rows[0][2].ToString() == "false")
                        BtnPurchases.Enabled = false;

                    if (tbl2.Rows[0][3].ToString() == "true")
                        BtnProducts.Enabled = true;
                    else if (tbl2.Rows[0][3].ToString() == "false")
                        BtnProducts.Enabled = false;

                    if (tbl2.Rows[0][4].ToString() == "true")
                        BtnExpenses.Enabled = true;
                    else if (tbl2.Rows[0][4].ToString() == "false")
                        BtnExpenses.Enabled = false;

                    if (tbl2.Rows[0][5].ToString() == "true")
                        BtnReturns.Enabled = true;
                    else if (tbl2.Rows[0][5].ToString() == "false")
                        BtnReturns.Enabled = false;

                    if (tbl2.Rows[0][6].ToString() == "true")
                        BtnClients.Enabled = true;
                    else if (tbl2.Rows[0][6].ToString() == "false")
                        BtnClients.Enabled = false;

                    if (tbl2.Rows[0][7].ToString() == "true")
                        BtnSetting.Enabled = true;
                    else if (tbl2.Rows[0][7].ToString() == "false")
                        BtnSetting.Enabled = false;

                    if (tbl2.Rows[0][8].ToString() == "true")
                        BtnUsers.Enabled = true;
                    else if (tbl2.Rows[0][8].ToString() == "false")
                        BtnUsers.Enabled = false;

                    if (tbl2.Rows[0][9].ToString() == "true")
                        BtnSupllies.Enabled = true;
                    else if (tbl2.Rows[0][9].ToString() == "false")
                        BtnSupllies.Enabled = false;

                    if (tbl2.Rows[0][10].ToString() == "true")
                        RbtReportSale.Enabled = true;
                    else if (tbl2.Rows[0][10].ToString() == "false")
                        RbtReportSale.Enabled = false;

                    if (tbl2.Rows[0][11].ToString() == "true")
                        RbtReportBuy.Enabled = true;
                    else if (tbl2.Rows[0][11].ToString() == "false")
                        RbtReportBuy.Enabled = false;

                    if (tbl2.Rows[0][12].ToString() == "true")
                        RbtReportRbh.Enabled = true;
                    else if (tbl2.Rows[0][12].ToString() == "false")
                        RbtReportRbh.Enabled = false;

                    if (tbl2.Rows[0][13].ToString() == "true")
                        txtShowtoppro.Enabled = true;
                    else if (tbl2.Rows[0][13].ToString() == "false")
                        txtShowtoppro.Enabled = false;

                
                //BtnClients.Enabled = false;
                //BtnExpenses.Enabled = false;
                //BtnProducts.Enabled = false;
                //BtnPurchases.Enabled = false;
                //BtnUsers.Enabled = false;
                //BtnSupllies.Enabled = false;
            }
        }

        private void BtnMenuBar_Click(object sender, EventArgs e)
        {
            if (kryptonPanelMenu.Width == 182)
            {
                kryptonPanelMenu.Width = 50;
            }
            else
            {
                kryptonPanelMenu.Width = 182;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
            
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();



        }

        private void BtnSells_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSales());
            //FormSales frm = new FormSales();
            //frm.Show();
            
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduct());
            FormProduct F = new FormProduct();
            var command = "select * from Products";
            F.dataGridViewProduct.DataSource = model.LoadData("SELECT * FROM Products ORDER BY Pro_Id", null);
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new FormPurchases());
             
        }

        private void BtnExpenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormExpenses());
        }

        private void BtnReturns_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReturns());
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClients());
        }

        private void BtnSupllies_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSuppliers());
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUsers());
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSetting());
        }

        private void RbtReportBuy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_PurchasesReport());
            //Frm_PurchasesReport frm_PurRep = new Frm_PurchasesReport();
            //frm_PurRep.ShowDialog();
        }

        private void RbtReportSale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SalesReport());    
        }

        private void RbtReportRbh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SalesRb7h());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
            }
        }

        private void txtShowtoppro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TopProduct());
        }
    }
}
