using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FormSales : Form
    {

        private static FormSales frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FormSales GetFormSales
        {
            get
            {
                if (frm == null)
                {
                    frm = new FormSales();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public FormSales()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        DatabaseClass db = new DatabaseClass();
        DataTable tbl = new DataTable();

        public void FillProducts()
        {
            CBxProducts.DataSource = db.LoadData("select * from Products");
            CBxProducts.DisplayMember = "Pro_Name";
            CBxProducts.ValueMember = "Pro_Id";
        }
        public void FillCustomer()
        {
            CBxCustomer.DataSource = db.LoadData("select * from Clients");
            CBxCustomer.DisplayMember = "Client_Name";
            CBxCustomer.ValueMember = "Client_Id";
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            FillCustomer();
            FillProducts();
            RBtnCustomerNow_CheckedChanged(null, null);

            dateTimeReminder.Text = DateTime.Now.ToShortDateString();
            dTPDate.Text = DateTime.Now.ToShortDateString();

           

            try
            {
                AutoNumber();
            } catch { }
        }


        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.LoadData("select max(Order_Id) from Sale");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtID.Text = "1";
            }
            else
            {
                TxtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            dTPDate.Text = DateTime.Now.ToShortDateString();
            dateTimeReminder.Text = DateTime.Now.ToShortDateString();
            try
            {
                CBxProducts.SelectedIndex = 0;
                CBxCustomer.SelectedIndex = 0;
            }
            catch (Exception) { }

            CBxProducts.Text = "اختر منتج";
            DGVSales.Rows.Clear();
            RBtnCustomerNow.Checked = true;
            TxtBarcode.Clear();
            TxtBarcode.Focus();
            TxtTotal.Clear();

        }


        private void RBtnCustomerNow_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CBxCustomer.Enabled = false;
                BtnCustomerrBrowse.Enabled = false;
                dateTimeReminder.Enabled = false;
                TxtBarcode.Clear();
                TxtBarcode.Focus();
            }
            catch { }
        }

        private void RBtnCustomerAagel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CBxCustomer.Enabled = true;
                BtnCustomerrBrowse.Enabled = true;
                dateTimeReminder.Enabled = true;
                TxtBarcode.Clear();
                TxtBarcode.Focus();
            }
            catch { }
        }

        private void BtnCustomerrBrowse_Click(object sender, EventArgs e)
        {
            FormClients frm = new FormClients();
            frm.ShowDialog();
        }

        private void BtnAddProducts_Click(object sender, EventArgs e)
        {
            if (CBxProducts.Text == "اختر منتج")
            {
                MessageBox.Show("من فضلك إختر منتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (CBxProducts.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل منتجات أولا", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable TblItems = new DataTable();
            TblItems.Clear();


            TblItems = db.LoadData("select * from Products where Pro_Id =" + CBxProducts.SelectedValue + " ");
            if (TblItems.Rows.Count >= 1)
            {
                try
                {

                    string Product_Id = TblItems.Rows[0][0].ToString();
                    string Product_Name = TblItems.Rows[0][1].ToString();
                    string Product_Qty = "1";
                    string Product_Price = TblItems.Rows[0][7].ToString();
                    decimal Discount = 0;
                    decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(TblItems.Rows[0][7]);

                    DGVSales.Rows.Add(1);
                    int rowindex = DGVSales.Rows.Count - 1;

                    DGVSales.Rows[rowindex].Cells[0].Value = Product_Id;
                    DGVSales.Rows[rowindex].Cells[1].Value = Product_Name;
                    DGVSales.Rows[rowindex].Cells[2].Value = Product_Qty;
                    DGVSales.Rows[rowindex].Cells[3].Value = Product_Price;
                    DGVSales.Rows[rowindex].Cells[4].Value = Discount;
                    DGVSales.Rows[rowindex].Cells[5].Value = total;
                }
                catch (Exception) { }

                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0; i <= DGVSales.Rows.Count - 1; i++)
                    {

                        TotalOrder += Convert.ToDecimal(DGVSales.Rows[i].Cells[5].Value);
                        DGVSales.ClearSelection();
                        DGVSales.FirstDisplayedScrollingRowIndex = DGVSales.Rows.Count - 1;
                        DGVSales.Rows[DGVSales.Rows.Count - 1].Selected = true;
                    }


                    TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                    LblProductsCount.Text = (DGVSales.Rows.Count).ToString();

                }
                catch (Exception) { }
                TxtBarcode.Clear();
                TxtBarcode.Focus();
            }
        }



        


        private void FormSales_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                BtnAddProducts_Click(null,null);
            } else if(e.KeyCode == Keys.F11)
            {
                UpdateQty();

                try
                {

                    int index = DGVSales.SelectedRows[0].Index;

                    DGVSales.Rows[index].Cells[2].Value = Properties.Settings.Default.Item_Qty;
                    DGVSales.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_SalePrice;
                    DGVSales.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_Discount;

                }
                catch (Exception) { }
            }
            else if (e.KeyCode == Keys.F12)
            {
                PayOrder();
            }
        }

        private void PayOrder()
        {

            if (DGVSales.Rows.Count >= 1)
            {
                string d = dTPDate.Value.ToString("dd/MM/yyyy");
                string dreminder = dateTimeReminder.Value.ToString("dd/MM/yyyy");
                string Cust_Name = "";
                if (RBtnCustomerAagel.Checked == true)
                { Cust_Name = CBxCustomer.Text; }
                else
                {
                    if (TxtCustomerNow.Text == "")
                    {
                        Cust_Name = "زبون عادي";
                    }
                    else if (TxtCustomerNow.Text != "")
                    {
                        Cust_Name = TxtCustomerNow.Text;
                    }
                }

                Properties.Settings.Default.PriceRequired = Convert.ToDecimal(TxtTotal.Text);
                Properties.Settings.Default.PricePaid = 0;
                Properties.Settings.Default.PriceRest = 0;
                Properties.Settings.Default.Save();

                if(RBtnCustomerAagel.Checked == true && RBtnCustomerNow.Checked == false)
                {
                    frm_PaySale frm = new frm_PaySale();
                    frm.ShowDialog();

                    //db.exceuteData("insert into Sale values (" + TxtID.Text + " , '" + d + "', '"+Cust_Name+"')", "");
                    if (Properties.Settings.Default.ChekButton == true)
                    {
                        try
                        {
                            db.InsertRecord("Sale", new SqlParameter[]
                                        {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Cust_Name", Cust_Name)
                                        });

                            for (int i = 0; i <= DGVSales.Rows.Count - 1; i++)
                            {
                                db.InsertRecord("Sale_Details", new SqlParameter[]
                                                {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Cust_Name", Cust_Name),
                                    new SqlParameter("@Pro_Id", DGVSales.Rows[i].Cells[0].Value),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Qty", DGVSales.Rows[i].Cells[2].Value),
                                    new SqlParameter("@User_Name", Properties.Settings.Default.UserName.ToString()),
                                    new SqlParameter("@Price", DGVSales.Rows[i].Cells[3].Value),
                                    new SqlParameter("@Discount", DGVSales.Rows[i].Cells[4].Value),
                                    new SqlParameter("@Total", DGVSales.Rows[i].Cells[5].Value),
                                    new SqlParameter("@Total_Order", Properties.Settings.Default.PriceRequired),
                                    new SqlParameter("@Price_Paid", Properties.Settings.Default.PricePaid),
                                    new SqlParameter("@Price_Rest", Properties.Settings.Default.PriceRest)
                                                });
                                db.exceuteData("update Products set Qty = Qty - " + DGVSales.Rows[i].Cells[2].Value + " where Pro_Id = " + DGVSales.Rows[i].Cells[0].Value + " ", "");


                                try
                                {
                                    decimal BuyPrice = 0;
                                    BuyPrice = Convert.ToDecimal(db.readData("select * from Products where Pro_Id = " + DGVSales.Rows[i].Cells[0].Value + "", "").Rows[0][3]);

                                    db.InsertRecord("Sales_Rb7h", new SqlParameter[]
                                                {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Cust_Name", Cust_Name),
                                    new SqlParameter("@Pro_Id", DGVSales.Rows[i].Cells[0].Value),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Qty", DGVSales.Rows[i].Cells[2].Value),
                                    new SqlParameter("@User_Name", Properties.Settings.Default.UserName.ToString()),
                                    new SqlParameter("@Price", DGVSales.Rows[i].Cells[3].Value),
                                    new SqlParameter("@Discount", DGVSales.Rows[i].Cells[4].Value),
                                    new SqlParameter("@Total", DGVSales.Rows[i].Cells[5].Value),
                                    new SqlParameter("@Total_Order", Properties.Settings.Default.PriceRequired),
                                    new SqlParameter("@Price_Paid", Properties.Settings.Default.PricePaid),
                                    new SqlParameter("@Price_Rest", Properties.Settings.Default.PriceRest),
                                    new SqlParameter("@BuyPrice", BuyPrice)
                                                });

                                }
                                catch (Exception) { }




                            }



                            if (RBtnCustomerNow.Checked == true)
                            {
                                db.InsertRecord("Customer_Report", new SqlParameter[]
                                {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Price", Properties.Settings.Default.PricePaid),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Cus_Name", Cust_Name)
                                });
                            }
                            else if (RBtnCustomerAagel.Checked == true)
                            {
                                db.InsertRecord("Customer_Money", new SqlParameter[]
                                {
                                            new SqlParameter("@Order_Id", TxtID.Text),
                                            new SqlParameter("@Cus_Name", Cust_Name),
                                            new SqlParameter("@Price", Properties.Settings.Default.PriceRest),
                                            new SqlParameter("@Order_Date", d),
                                            new SqlParameter("@Reminder_Date", dreminder)

                                });

                                if (Properties.Settings.Default.PricePaid >= 1)
                                {
                                    db.InsertRecord("Customer_Report", new SqlParameter[]
                                    {
                                        new SqlParameter("@Order_Id", TxtID.Text),
                                        new SqlParameter("@Price", Properties.Settings.Default.PricePaid),
                                        new SqlParameter("@Date", d),
                                        new SqlParameter("@Cus_Name", Cust_Name)
                                    });
                                }
                            }

                            if (Properties.Settings.Default.SalesPrint == true)
                            {
                                int data = 0;
                                if (Properties.Settings.Default.PrinterName == "")
                                { MessageBox.Show("من فضلك حدد إسم الطابعة من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                                try
                                {
                                    data = Convert.ToInt32(db.readData("select count(Name) from OrderPrintData", "").Rows[0][0]);
                                }
                                catch (Exception) { }

                                if (data <= 0)
                                { MessageBox.Show("من فضلك أدخل بيانات الفاتورة أولا في شاشة أعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                                for (int i = 0; i <= Properties.Settings.Default.SalePrintNum - 1; i++)
                                {
                                    Print();
                                }
                            }
                            AutoNumber();
                        }
                        catch { }
                    }


                }
                else if (RBtnCustomerNow.Checked == true && RBtnCustomerAagel.Checked == false)
                {
                    try
                    {
                        decimal required = Convert.ToDecimal(TxtTotal.Text);
                        decimal paid = Convert.ToDecimal(TxtTotal.Text);
                        decimal rest = 0;

                        db.InsertRecord("Sale", new SqlParameter[]
                                    {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Cust_Name", Cust_Name)
                                    });
                        
                        for (int i = 0; i <= DGVSales.Rows.Count - 1; i++)
                        {
                            db.InsertRecord("Sale_Details", new SqlParameter[]
                                            {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Cust_Name", Cust_Name),
                                    new SqlParameter("@Pro_Id", DGVSales.Rows[i].Cells[0].Value),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Qty", DGVSales.Rows[i].Cells[2].Value),
                                    new SqlParameter("@User_Name", Properties.Settings.Default.UserName.ToString()),
                                    new SqlParameter("@Price", DGVSales.Rows[i].Cells[3].Value),
                                    new SqlParameter("@Discount", DGVSales.Rows[i].Cells[4].Value),
                                    new SqlParameter("@Total", DGVSales.Rows[i].Cells[5].Value),
                                    new SqlParameter("@Total_Order", required),
                                    new SqlParameter("@Price_Paid", paid),
                                    new SqlParameter("@Price_Rest", rest)
                                            });
                            db.exceuteData("update Products set Qty = Qty - " + DGVSales.Rows[i].Cells[2].Value + " where Pro_Id = " + DGVSales.Rows[i].Cells[0].Value + " ", "");


                            try
                            {
                                decimal BuyPrice = 0;
                                BuyPrice = Convert.ToDecimal(db.readData("select * from Products where Pro_Id = " + DGVSales.Rows[i].Cells[0].Value + "", "").Rows[0][3]);

                                db.InsertRecord("Sales_Rb7h", new SqlParameter[]
                                            {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Cust_Name", Cust_Name),
                                    new SqlParameter("@Pro_Id", DGVSales.Rows[i].Cells[0].Value),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Qty", DGVSales.Rows[i].Cells[2].Value),
                                    new SqlParameter("@User_Name", Properties.Settings.Default.UserName.ToString()),
                                    new SqlParameter("@Price", DGVSales.Rows[i].Cells[3].Value),
                                    new SqlParameter("@Discount", DGVSales.Rows[i].Cells[4].Value),
                                    new SqlParameter("@Total", DGVSales.Rows[i].Cells[5].Value),
                                    new SqlParameter("@Total_Order", required),
                                    new SqlParameter("@Price_Paid", paid),
                                    new SqlParameter("@Price_Rest", rest),
                                    new SqlParameter("@BuyPrice", BuyPrice)
                                            });

                            }
                            catch (Exception) { }




                        }



                        if (RBtnCustomerNow.Checked == true)
                        {
                            db.InsertRecord("Customer_Report", new SqlParameter[]
                            {
                                    new SqlParameter("@Order_Id", TxtID.Text),
                                    new SqlParameter("@Price", paid),
                                    new SqlParameter("@Date", d),
                                    new SqlParameter("@Cus_Name", Cust_Name)
                            });
                        }
                        else if (RBtnCustomerAagel.Checked == true)
                        {
                            db.InsertRecord("Customer_Money", new SqlParameter[]
                            {
                                            new SqlParameter("@Order_Id", TxtID.Text),
                                            new SqlParameter("@Cus_Name", Cust_Name),
                                            new SqlParameter("@Price", rest),
                                            new SqlParameter("@Order_Date", d),
                                            new SqlParameter("@Reminder_Date", dreminder)

                            });

                            if (Properties.Settings.Default.PricePaid >= 1)
                            {
                                db.InsertRecord("Customer_Report", new SqlParameter[]
                                {
                                        new SqlParameter("@Order_Id", TxtID.Text),
                                        new SqlParameter("@Price", paid),
                                        new SqlParameter("@Date", d),
                                        new SqlParameter("@Cus_Name", Cust_Name)
                                });
                            }
                        }

                        if (Properties.Settings.Default.SalesPrint == true)
                        {
                            int data = 0;
                            if (Properties.Settings.Default.PrinterName == "")
                            { MessageBox.Show("من فضلك حدد إسم الطابعة من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                            try
                            {
                                data = Convert.ToInt32(db.readData("select count(Name) from OrderPrintData", "").Rows[0][0]);
                            }
                            catch (Exception) { }

                            if (data <= 0)
                            { MessageBox.Show("من فضلك أدخل بيانات الفاتورة أولا في شاشة أعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                            for (int i = 0; i <= Properties.Settings.Default.SalePrintNum - 1; i++)
                            {
                                Print();
                            }
                        }
                        AutoNumber();
                    }
                    catch { }
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

                TblRpt = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sale_Details].[Qty] as 'الكمية' ,[Price] as 'السعر' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sale_Details],Products where Products.Pro_Id = Sale_Details.Pro_Id and Order_Id = " + id + "", "");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();
                if (Properties.Settings.Default.SalePrintKind == "8CM")
                {
                    RptOrderSale rpt = new RptOrderSale();

                    rpt.SetDatabaseLogon("", "", ".\\SQLEXPRESS", "sales");
                    rpt.SetDataSource(TblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm1.crystalReportViewer1.ReportSource = rpt;
                    //frm1.Show();
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                    //frm1.crystalReportViewer1.ReportSource = rpt;
                }
                else if (Properties.Settings.Default.SalePrintKind == "A4")
                {
                    RptOrderSaleA4 rpt = new RptOrderSaleA4();

                    rpt.SetDatabaseLogon("", "", ".\\SQLEXPRESS", "sales");
                    rpt.SetDataSource(TblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm1.crystalReportViewer1.ReportSource = rpt;
                    //frm1.Show();
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                }




            }
            catch (Exception) { }
        }


        private void UpdateQty()
        {
            if (DGVSales.Rows.Count >= 1)
            {


                
                int index = DGVSales.SelectedRows[0].Index;

                

                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(DGVSales.Rows[index].Cells[2].Value);
                Properties.Settings.Default.Item_SalePrice = Convert.ToDecimal(DGVSales.Rows[index].Cells[3].Value);
                Properties.Settings.Default.Item_Discount = Convert.ToDecimal(DGVSales.Rows[index].Cells[4].Value);

                Properties.Settings.Default.Save();

                frm_SaleQty frm = new frm_SaleQty();
                frm.ShowDialog();

                


            }
        }

        

        private void BtnDeleteProducts_Click(object sender, EventArgs e)
        {
            if (DGVSales.Rows.Count >= 1)
            {
                int index = DGVSales.SelectedRows[0].Index;
                DGVSales.Rows.RemoveAt(index);
            }

            if (DGVSales.Rows.Count <= 0)
            {
                TxtTotal.Text = "0";
            }

            try
            {
                decimal TotalOrder = 0;
                for (int i = 0; i <= DGVSales.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDecimal(DGVSales.Rows[i].Cells[5].Value);
                    DGVSales.ClearSelection();
                    DGVSales.FirstDisplayedScrollingRowIndex = DGVSales.Rows.Count - 1;
                    DGVSales.Rows[DGVSales.Rows.Count - 1].Selected = true;
                }


                TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                LblProductsCount.Text = (DGVSales.Rows.Count).ToString();

            }
            catch (Exception) { }
            TxtBarcode.Clear();
            TxtBarcode.Focus();
        }

        private void DGVSales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal Item_Qty = 0, Item_SalePrice = 0, Item_Discount = 0;
            try
            {
                int index = DGVSales.SelectedRows[0].Index;

                Item_Qty = Convert.ToDecimal(DGVSales.Rows[index].Cells[2].Value);
                Item_SalePrice = Convert.ToDecimal(DGVSales.Rows[index].Cells[3].Value);
                Item_Discount = Convert.ToDecimal(DGVSales.Rows[index].Cells[4].Value);

                decimal Total = (Item_Qty * Item_SalePrice) - Item_Discount;

                DGVSales.Rows[index].Cells[5].Value = Total;
                decimal TotalOrder = 0;
                for (int i = 0; i <= DGVSales.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDecimal(DGVSales.Rows[i].Cells[5].Value);
                    /*DGVPurchases.ClearSelection();
                    DGVPurchases.FirstDisplayedScrollingRowIndex = DGVPurchases.Rows.Count - 1;
                    DGVPurchases.Rows[DGVPurchases.Rows.Count - 1].Selected = true;*/
                }


                TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                //LblProductsCount.Text = (DGVPurchases.Rows.Count).ToString();

            }
            catch { }
        }

        

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable TblItems = new DataTable();
                TblItems.Clear();


                TblItems = db.LoadData("select * from Products where Barcode ='" + TxtBarcode.Text + "' ");
                if (TblItems.Rows.Count >= 1)
                {
                    try
                    {

                        string Product_Id = TblItems.Rows[0][0].ToString();
                        string Product_Name = TblItems.Rows[0][1].ToString();
                        string Product_Qty = "1";
                        string Product_Price = TblItems.Rows[0][7].ToString();
                        decimal Discount = 0;
                        decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(TblItems.Rows[0][7]);

                        DGVSales.Rows.Add(1);
                        int rowindex = DGVSales.Rows.Count - 1;

                        DGVSales.Rows[rowindex].Cells[0].Value = Product_Id;
                        DGVSales.Rows[rowindex].Cells[1].Value = Product_Name;
                        DGVSales.Rows[rowindex].Cells[2].Value = Product_Qty;
                        DGVSales.Rows[rowindex].Cells[3].Value = Product_Price;
                        DGVSales.Rows[rowindex].Cells[4].Value = Discount;
                        DGVSales.Rows[rowindex].Cells[5].Value = total;
                    }
                    catch (Exception) { }

                    try
                    {
                        decimal TotalOrder = 0;
                        for (int i = 0; i <= DGVSales.Rows.Count - 1; i++)
                        {

                            TotalOrder += Convert.ToDecimal(DGVSales.Rows[i].Cells[5].Value);
                            DGVSales.ClearSelection();
                            DGVSales.FirstDisplayedScrollingRowIndex = DGVSales.Rows.Count - 1;
                            DGVSales.Rows[DGVSales.Rows.Count - 1].Selected = true;
                        }


                        TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                        LblProductsCount.Text = (DGVSales.Rows.Count).ToString();

                    }
                    catch (Exception) { }
                    TxtBarcode.Clear();
                    TxtBarcode.Focus();
                }
            }
        }

        private void dateTimeReminder_ValueChanged(object sender, EventArgs e)
        {
            TxtBarcode.Select();
        }

        private void TxtCustomerNow_Leave(object sender, EventArgs e)
        {
            //TxtBarcode.Focus();
        }
    }
}
