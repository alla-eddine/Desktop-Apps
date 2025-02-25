using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FormPurchases : Form
    {
        private static FormPurchases frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FormPurchases GetFormPurchases
        {
            get
            {
                if (frm == null)
                {
                    frm = new FormPurchases();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FormPurchases()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        DatabaseClass db = new DatabaseClass();
        DataTable tbl = new DataTable();

        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.LoadData("select max(Order_Id) from Buy");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtID.Text = "1";
            }
            else
            {
                TxtID.Text = (Convert.ToInt32(tbl.Rows[0][0])+1).ToString();
            }
            dateTimePurchases.Text = DateTime.Now.ToShortDateString();
            dateTimeAagel.Text = DateTime.Now.ToShortDateString();
            try
            {
                CBxProducts.SelectedIndex = 0;
                CBxSupplier.SelectedIndex = 0;
            }
            catch (Exception) { }
            CBxProducts.Text = "اختر منتج";
            DGVPurchases.Rows.Clear();
            RBtnCash.Checked = true;
            TxtBarcode.Clear();
            TxtBarcode.Focus();
            TxtTotal.Clear();
            
        }
        public void FillProducts()
        {
            CBxProducts.DataSource = db.LoadData("select * from Products");
            CBxProducts.DisplayMember = "Pro_Name";
            CBxProducts.ValueMember = "Pro_Id";
        }
        public void FillSupplier()
        {
            CBxSupplier.DataSource = db.LoadData("select * from Suppliers");
            CBxSupplier.DisplayMember = "Sup_Name";
            CBxSupplier.ValueMember = "Sup_Id";
        }

        private void FormPurchases_Load(object sender, EventArgs e)
        {
            FillProducts();
            FillSupplier();
            try
            {
                AutoNumber();
            }
            catch (Exception)
            {
                
            }
        }

        private void BtnSupplierBrowse_Click(object sender, EventArgs e)
        {
            FormSuppliers frmSup = new FormSuppliers();
            frmSup.ShowDialog();
        }

        private void BtnAddProducts_Click(object sender, EventArgs e)
        {
            if (CBxProducts.Text == "اختر منتج")
            {
                MessageBox.Show("من فضلك إختر منتج", "تأكيد", MessageBoxButtons.OK,MessageBoxIcon.Information) ;
                return;
            }
            if(CBxProducts.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل منتجات أولا", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable TblItems = new DataTable();
            TblItems.Clear();
            

            TblItems = db.LoadData("select * from Products where Pro_Id ="+CBxProducts.SelectedValue+" ");
            if (TblItems.Rows.Count >= 1)
            {
                try
                {
                    
                    string Product_Id = TblItems.Rows[0][0].ToString();
                    string Product_Name = TblItems.Rows[0][1].ToString();
                    string Product_Qty = "1";
                    string Product_Price = TblItems.Rows[0][3].ToString();
                    decimal Discount = 0;
                    decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(TblItems.Rows[0][3]);

                    DGVPurchases.Rows.Add(1);
                    int rowindex = DGVPurchases.Rows.Count - 1;

                    DGVPurchases.Rows[rowindex].Cells[0].Value = Product_Id;
                    DGVPurchases.Rows[rowindex].Cells[1].Value = Product_Name;
                    DGVPurchases.Rows[rowindex].Cells[2].Value = Product_Qty;
                    DGVPurchases.Rows[rowindex].Cells[3].Value = Product_Price;
                    DGVPurchases.Rows[rowindex].Cells[4].Value = Discount;
                    DGVPurchases.Rows[rowindex].Cells[5].Value = total;
                }
                catch (Exception){ }

                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0; i <= DGVPurchases.Rows.Count - 1; i++)
                    {

                        TotalOrder += Convert.ToDecimal(DGVPurchases.Rows[i].Cells[5].Value);
                        DGVPurchases.ClearSelection();
                        DGVPurchases.FirstDisplayedScrollingRowIndex = DGVPurchases.Rows.Count - 1;
                        DGVPurchases.Rows[DGVPurchases.Rows.Count - 1].Selected = true;
                    }


                    TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                    LblProductsCount.Text = (DGVPurchases.Rows.Count).ToString();

                }
                catch (Exception) { }
                TxtBarcode.Clear();
                TxtBarcode.Focus();
            }
        }

        private void BtnDeleteProducts_Click(object sender, EventArgs e)
        {
            if(DGVPurchases.Rows.Count >= 1)
            {
                int index = DGVPurchases.SelectedRows[0].Index;
                DGVPurchases.Rows.RemoveAt(index);
            }

            if(DGVPurchases.Rows.Count <= 0)
            {
                TxtTotal.Text = "0";
            }

            try
            {
                decimal TotalOrder = 0;
                for (int i = 0; i <= DGVPurchases.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDecimal(DGVPurchases.Rows[i].Cells[5].Value);
                    DGVPurchases.ClearSelection();
                    DGVPurchases.FirstDisplayedScrollingRowIndex = DGVPurchases.Rows.Count - 1;
                    DGVPurchases.Rows[DGVPurchases.Rows.Count - 1].Selected = true;
                }


                TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                LblProductsCount.Text = (DGVPurchases.Rows.Count).ToString();

            }
            catch (Exception) { }
            TxtBarcode.Clear();
            TxtBarcode.Focus();
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                /*if (CBxProducts.Text == "اختر منتج")
                {
                    MessageBox.Show("من فضلك إختر منتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (CBxProducts.Items.Count <= 0)
                {
                    MessageBox.Show("من فضلك ادخل منتجات أولا", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }*/

                DataTable TblItems = new DataTable();
                TblItems.Clear();

                
                SqlParameter[] parameters =
                {
                      new SqlParameter("@Pro_Barcode", TxtBarcode.Text.Trim())
                };
                TblItems = db.LoadData("select * from Products where Barcode = @Pro_Barcode", parameters);
                 

               
                if (TblItems.Rows.Count >= 1)
                {
                    try
                    {

                        string Product_Id = TblItems.Rows[0][0].ToString();
                        string Product_Name = TblItems.Rows[0][1].ToString();
                        string Product_Qty = "1";
                        string Product_Price = TblItems.Rows[0][3].ToString();
                        decimal Discount = 0;
                        decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(TblItems.Rows[0][3]);

                        DGVPurchases.Rows.Add(1);
                        int rowindex = DGVPurchases.Rows.Count - 1;

                        DGVPurchases.Rows[rowindex].Cells[0].Value = Product_Id;
                        DGVPurchases.Rows[rowindex].Cells[1].Value = Product_Name;
                        DGVPurchases.Rows[rowindex].Cells[2].Value = Product_Qty;
                        DGVPurchases.Rows[rowindex].Cells[3].Value = Product_Price;
                        DGVPurchases.Rows[rowindex].Cells[4].Value = Discount;
                        DGVPurchases.Rows[rowindex].Cells[5].Value = total;
                    }
                    catch (Exception) { }

                    try
                    {
                        decimal TotalOrder = 0;
                        for (int i = 0; i <= DGVPurchases.Rows.Count - 1; i++)
                        {

                            TotalOrder += Convert.ToDecimal(DGVPurchases.Rows[i].Cells[5].Value);
                            DGVPurchases.ClearSelection();
                            DGVPurchases.FirstDisplayedScrollingRowIndex = DGVPurchases.Rows.Count - 1;
                            DGVPurchases.Rows[DGVPurchases.Rows.Count - 1].Selected = true;
                        }


                        TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                        LblProductsCount.Text = (DGVPurchases.Rows.Count).ToString();

                    }
                    catch (Exception) { }
                    TxtBarcode.Clear();
                    TxtBarcode.Focus();
                }
            }
        }
        private void PayOrder()
        {
            
            if (DGVPurchases.Rows.Count >= 1)
            {
                if (CBxSupplier.Items.Count <= 1) { MessageBox.Show("من فضلك أدخل مورد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                {
                    if (DGVPurchases.Rows.Count >= 1)
                    {

                        

                        Properties.Settings.Default.PriceRequired = Convert.ToDecimal(TxtTotal.Text);
                        Properties.Settings.Default.PricePaid = 0;
                        Properties.Settings.Default.PriceRest = 0;
                        Properties.Settings.Default.Save();

                        frm_PayPuy frm = new frm_PayPuy();
                        frm.ShowDialog();




                    }

                    if (Properties.Settings.Default.ChekButton == true)
                    {
                        try
                        {
                            string d = dateTimePurchases.Value.ToString("dd/MM/yyyy");
                            string dreminder = dateTimeAagel.Value.ToString("dd/MM/yyyy");
                            db.InsertRecord("Buy", new SqlParameter[]
                                {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Sup_Id", CBxSupplier.SelectedValue)

                                });

                            for (int i = 0; i <= DGVPurchases.Rows.Count - 1; i++)
                            {
                                db.InsertRecord("Buy_Detail", new SqlParameter[]
                                {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Sup_Id", CBxSupplier.SelectedValue),
                                    new SqlParameter("@Pro_Id", DGVPurchases.Rows[i].Cells[0].Value),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Qty", DGVPurchases.Rows[i].Cells[2].Value),
                                    new SqlParameter("@User_Name", Properties.Settings.Default.UserName.ToString()),
                                    new SqlParameter("@Price", DGVPurchases.Rows[i].Cells[3].Value),
                                    new SqlParameter("@Discount", DGVPurchases.Rows[i].Cells[4].Value),
                                    new SqlParameter("@Total", DGVPurchases.Rows[i].Cells[5].Value),
                                    new SqlParameter("@Total_Order", TxtTotal.Text),
                                    new SqlParameter("@Price_Paid", Properties.Settings.Default.PricePaid),
                                    new SqlParameter("@Price_Rest", Properties.Settings.Default.PriceRest)
                                });
                                /* update Qty in the Products Table */
                                db.exceuteData("update Products set Qty = Qty + "+ DGVPurchases.Rows[i].Cells[2].Value + " where Pro_Id = "+ DGVPurchases.Rows[i].Cells[0].Value + " ","");
                                
                            }

                            if (RBtnCash.Checked == true)
                                {
                                    db.InsertRecord("Supplier_Report", new SqlParameter[]
                                    {       
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Price", Properties.Settings.Default.PricePaid),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Sup_Id", CBxSupplier.SelectedValue)
                                    });
                                }
                            else if(RBtnAagel.Checked == true)
                                {
                                    db.InsertRecord("Supplier_Money", new SqlParameter[]
                                    {       
                                            new SqlParameter("@Order_Id", TxtID.Text),
                                            new SqlParameter("@Sup_Id", CBxSupplier.SelectedValue),
                                            new SqlParameter("@Price", Properties.Settings.Default.PriceRest),
                                            new SqlParameter("@Order_Date", d),
                                            new SqlParameter("@Reminder_Date", dreminder)

                                    });

                                    if( Properties.Settings.Default.PricePaid>=1 )
                                    {
                                        db.InsertRecord("Supplier_Report", new SqlParameter[]
                                        {
                                        new SqlParameter("@Order_Id", TxtID.Text),
                                        new SqlParameter("@Price", Properties.Settings.Default.PricePaid),
                                        new SqlParameter("@Date", d),
                                        new SqlParameter("@Sup_Id", CBxSupplier.SelectedValue)
                                        });
                                    }
                                }
                            if(Properties.Settings.Default.BuyPrint == true)
                            {
                                int data = 0;
                                if (Properties.Settings.Default.PrinterName == "")
                                { MessageBox.Show("من فضلك حدد إسم الطابعة من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                                try
                                {
                                    data =Convert.ToInt32( db.readData("select count(Name) from OrderPrintData", "").Rows[0][0]);
                                } catch (Exception) { }

                                if (data<=0)
                                { MessageBox.Show("من فضلك أدخل بيانات الفاتورة أولا في شاشة أعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                                for (int i =0; i<= Properties.Settings.Default.BuyPrintNum -1; i++)
                                {
                                    Print();
                                }  
                            }
                            
                            AutoNumber();
                        }
                        catch (Exception) { }
                       
                    }

                }
            }
        }

        private void Print()
        {
            try
            {
                int id = Convert.ToInt32(TxtID.Text);
                DataTable TblRpt = new DataTable();
                TblRpt.Clear();

                TblRpt = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' ,Suppliers.Sup_Name as 'اسم المورد' ,Products.Pro_Name as 'اسم المنتج' ,[Date] as 'تاريخ الفاتورة' ,[Buy_Detail].[Qty] as 'الكمية' ,[User_Name] as 'اسم المستخدم' ,[Price] as 'سعر الشراء' ,[Discount] as 'الخصم' ,[Total] as 'اجمالي المنتج' ,[Total_Order] as 'الاجمالي الكلي' ,[Price_Paid] as 'المبلغ المدفوع' ,[Price_Rest] as 'المبلغ المتبقي' FROM [dbo].[Buy_Detail],Suppliers,Products where Suppliers.Sup_Id = [Buy_Detail].Sup_Id and Products.Pro_Id = [Buy_Detail].Pro_Id and Order_Id = "+id+"","");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();

                if(Properties.Settings.Default.BuyPrintKind == "8CM")
                {
                    RptOrderBuy rpt = new RptOrderBuy();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "sales");
                    rpt.SetDataSource(TblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm1.crystalReportViewer1.ReportSource = rpt;
                    //frm1.Show();
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                    //frm1.crystalReportViewer1.ReportSource = rpt;
                }
                else if (Properties.Settings.Default.BuyPrintKind == "A4")
                {
                    RptOrderBuyA4 rpt = new RptOrderBuyA4();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "sales");
                    rpt.SetDataSource(TblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm1.crystalReportViewer1.ReportSource = rpt;
                    //frm1.Show();
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                    //frm1.crystalReportViewer1.ReportSource = rpt;
                }








            }
            catch (Exception) { }
        }

        private void UpdateQty()
        {
            if (DGVPurchases.Rows.Count >= 1)
            {

                int index = DGVPurchases.SelectedRows[0].Index;

                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(DGVPurchases.Rows[index].Cells[2].Value);
                Properties.Settings.Default.Item_BuyPrice = Convert.ToDecimal(DGVPurchases.Rows[index].Cells[3].Value);
                Properties.Settings.Default.Item_Discount = Convert.ToDecimal(DGVPurchases.Rows[index].Cells[4].Value);

                Properties.Settings.Default.Save();

                frm_BuyQty frm = new frm_BuyQty();
                frm.ShowDialog();
                

            }
        }

        private void FormPurchases_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) 
            {
                BtnAddProducts_Click(null, null);
            }
            if (e.KeyCode == Keys.F12)
            {
                PayOrder();
            }
            else if (e.KeyCode == Keys.F11)
            {
                

                UpdateQty();

                try
                {

                    int index = DGVPurchases.SelectedRows[0].Index;

                    DGVPurchases.Rows[index].Cells[2].Value = Properties.Settings.Default.Item_Qty;
                    DGVPurchases.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_BuyPrice;
                    DGVPurchases.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_Discount;

                }
                catch (Exception) { }


            }
        }

        private void BtnAddProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void DGVPurchases_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal Item_Qty = 0,Item_BuyPrice = 0,Item_Discount = 0;
            try
            {
                int index = DGVPurchases.SelectedRows[0].Index;

                Item_Qty = Convert.ToDecimal(DGVPurchases.Rows[index].Cells[2].Value);
                Item_BuyPrice = Convert.ToDecimal(DGVPurchases.Rows[index].Cells[3].Value);
                Item_Discount = Convert.ToDecimal(DGVPurchases.Rows[index].Cells[4].Value);

                decimal Total = (Item_Qty * Item_BuyPrice) - Item_Discount;

                DGVPurchases.Rows[index].Cells[5].Value = Total;
                decimal TotalOrder = 0;
                for (int i = 0; i <= DGVPurchases.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDecimal(DGVPurchases.Rows[i].Cells[5].Value);
                    /*DGVPurchases.ClearSelection();
                    DGVPurchases.FirstDisplayedScrollingRowIndex = DGVPurchases.Rows.Count - 1;
                    DGVPurchases.Rows[DGVPurchases.Rows.Count - 1].Selected = true;*/
                }


                TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                //LblProductsCount.Text = (DGVPurchases.Rows.Count).ToString();

            }
            catch { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
