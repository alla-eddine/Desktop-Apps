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
    public partial class Frm_PurchasesReport : Form
    {
        public Frm_PurchasesReport()
        {
            InitializeComponent();
        }

        DatabaseClass db = new DatabaseClass();
        DataTable tbl = new DataTable();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FillSupplier()
        {
            CBxSupplier.DataSource = db.LoadData("select * from Suppliers");
            CBxSupplier.DisplayMember = "Sup_Name";
            CBxSupplier.ValueMember = "Sup_Id";
        }

        private void Frm_PurchasesReport_Load(object sender, EventArgs e)
        {
            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
            FillSupplier();
        }

        private void BtnSearchSupp_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;

            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            

            tbl.Clear();

            if (RBtnAllSupp.Checked == true)
            {
                if(checkBoxOrderNBR.Checked == false)
                {
                    tbl = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' ,Suppliers.Sup_Name as 'إسم المورد' ,Products.Pro_Name as 'إسم المنتج' ,[Date] as 'تاريخ الفاتورة' ,[Buy_Detail].[Qty] as 'الكمية' ,[Price] as 'سعر الشراء' ,[Discount] as 'الخصم' ,[Total] as 'الإجمالي' ,[Total_Order] as 'إجمالي الفاتورة' ,[Price_Paid] as 'المبلغ المدفوع' ,[Price_Rest] as 'المبلغ المتبقي' ,[User_Name] as 'إسم المستخدم' FROM [dbo].[Buy_Detail],Suppliers,Products where [Buy_Detail].Sup_Id = Suppliers.Sup_Id and [Buy_Detail].Pro_Id = Products.Pro_Id and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'  ORDER BY Order_Id ASC ", "");
                } else if (checkBoxOrderNBR.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' ,Suppliers.Sup_Name as 'إسم المورد' ,Products.Pro_Name as 'إسم المنتج' ,[Date] as 'تاريخ الفاتورة' ,[Buy_Detail].[Qty] as 'الكمية' ,[Price] as 'سعر الشراء' ,[Discount] as 'الخصم' ,[Total] as 'الإجمالي' ,[Total_Order] as 'إجمالي الفاتورة' ,[Price_Paid] as 'المبلغ المدفوع' ,[Price_Rest] as 'المبلغ المتبقي' ,[User_Name] as 'إسم المستخدم' FROM [dbo].[Buy_Detail],Suppliers,Products where [Buy_Detail].Sup_Id = Suppliers.Sup_Id and [Buy_Detail].Pro_Id = Products.Pro_Id and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "' and Order_Id = "+TxtOrderNBR.Text+ "  ORDER BY Order_Id ASC ", "");
                }
            } else if(RBtnOneSupp.Checked == true)
            {
                if (checkBoxOrderNBR.Checked == false)
                {
                    tbl = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' ,Suppliers.Sup_Name as 'إسم المورد' ,Products.Pro_Name as 'إسم المنتج' ,[Date] as 'تاريخ الفاتورة' ,[Buy_Detail].[Qty] as 'الكمية' ,[Price] as 'سعر الشراء' ,[Discount] as 'الخصم' ,[Total] as 'الإجمالي' ,[Total_Order] as 'إجمالي الفاتورة' ,[Price_Paid] as 'المبلغ المدفوع' ,[Price_Rest] as 'المبلغ المتبقي' ,[User_Name] as 'إسم المستخدم' FROM [dbo].[Buy_Detail],Suppliers,Products where [Buy_Detail].Sup_Id = Suppliers.Sup_Id and [Buy_Detail].Pro_Id = Products.Pro_Id and [Buy_Detail].Sup_Id = " + CBxSupplier.SelectedValue + " and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'  ORDER BY Order_Id ASC ", "");
                }
                else if (checkBoxOrderNBR.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' ,Suppliers.Sup_Name as 'إسم المورد' ,Products.Pro_Name as 'إسم المنتج' ,[Date] as 'تاريخ الفاتورة' ,[Buy_Detail].[Qty] as 'الكمية' ,[Price] as 'سعر الشراء' ,[Discount] as 'الخصم' ,[Total] as 'الإجمالي' ,[Total_Order] as 'إجمالي الفاتورة' ,[Price_Paid] as 'المبلغ المدفوع' ,[Price_Rest] as 'المبلغ المتبقي' ,[User_Name] as 'إسم المستخدم' FROM [dbo].[Buy_Detail],Suppliers,Products where [Buy_Detail].Sup_Id = Suppliers.Sup_Id and [Buy_Detail].Pro_Id = Products.Pro_Id and [Buy_Detail].Sup_Id = " + CBxSupplier.SelectedValue + " and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "' and Order_Id = "+TxtOrderNBR.Text+ "  ORDER BY Order_Id ASC ", "");
                }
            }
            DGVSupplierReport.DataSource = tbl;

            decimal TotalPrice = 0;
            for (int i = 0; i <= DGVSupplierReport.Rows.Count - 1; i++)
            {
                TotalPrice += Convert.ToDecimal(DGVSupplierReport.Rows[i].Cells[7].Value);
            }
            TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();
        }



        private void Print()
        { //DGVSupplierReport.CurrentRow.Cells[0].Value
            try
            {
                int id = Convert.ToInt32(DGVSupplierReport.CurrentRow.Cells[0].Value);
                DataTable TblRpt = new DataTable();
                TblRpt.Clear();

                TblRpt = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' ,Suppliers.Sup_Name as 'اسم المورد' ,Products.Pro_Name as 'اسم المنتج' ,[Date] as 'تاريخ الفاتورة' ,[Buy_Detail].[Qty] as 'الكمية' ,[User_Name] as 'اسم المستخدم' ,[Price] as 'سعر الشراء' ,[Discount] as 'الخصم' ,[Total] as 'اجمالي المنتج' ,[Total_Order] as 'الاجمالي الكلي' ,[Price_Paid] as 'المبلغ المدفوع' ,[Price_Rest] as 'المبلغ المتبقي' FROM [dbo].[Buy_Detail],Suppliers,Products where Suppliers.Sup_Id = [Buy_Detail].Sup_Id and Products.Pro_Id = [Buy_Detail].Pro_Id and Order_Id = " + id + "", "");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();

                if (Properties.Settings.Default.BuyPrintKind == "8CM")
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



        private void BtnPrintOrder_Click(object sender, EventArgs e)
        {
            if(DGVSupplierReport.Rows.Count >= 1)
            {
                if (Properties.Settings.Default.BuyPrint == true)
                {
                    Print();
                }
                else if (Properties.Settings.Default.BuyPrint == false)
                {
                    MessageBox.Show("الرجاء تفعيل طباعة فواتير المشتريات من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من حذف هذه الفاتورة", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DGVSupplierReport.Rows.Count >= 1)
                {
                    db.exceuteData("delete from Buy where Order_Id = " + DGVSupplierReport.CurrentRow.Cells[0].Value + "", "تم مسح بيانات الفاتورة المحددة");
                    BtnSearchSupp_Click(null,null);
                }
            }
        }



        private void PrintAll()
        {
            try
            {
                string date1;
                string date2;

                date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
                date2 = DtpTo.Value.ToString("yyyy-MM-dd");

                
                DataTable TblRpt = new DataTable();
                TblRpt.Clear();

                TblRpt = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' ,Suppliers.Sup_Name as 'إسم المورد' ,Products.Pro_Name as 'إسم المنتج' ,[Date] as 'تاريخ الفاتورة' ,[Buy_Detail].[Qty] as 'الكمية' ,[Price] as 'سعر الشراء' ,[Discount] as 'الخصم' ,[Total] as 'الإجمالي' ,[Total_Order] as 'إجمالي الفاتورة' ,[Price_Paid] as 'المبلغ المدفوع' ,[Price_Rest] as 'المبلغ المتبقي' ,[User_Name] as 'إسم المستخدم' FROM [dbo].[Buy_Detail],Suppliers,Products where [Buy_Detail].Sup_Id = Suppliers.Sup_Id and [Buy_Detail].Pro_Id = Products.Pro_Id and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "' ORDER BY Order_Id ASC", "");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();

                if (Properties.Settings.Default.BuyPrintKind == "A4")
                {
                    RptBuyReport rpt = new RptBuyReport();



                    rpt.SetDatabaseLogon("", "", ".\\SQLEXPRESS", "sales");
                    rpt.SetDataSource(TblRpt);
                    rpt.SetParameterValue("From", date1);
                    rpt.SetParameterValue("To", date2);
                    frm1.crystalReportViewer1.ReportSource = rpt;

                    //frm1.Show();
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                    //frm1.crystalReportViewer1.ReportSource = rpt;
                }
                else if (Properties.Settings.Default.BuyPrintKind == "8CM")
                {
                    MessageBox.Show("هذا التقرير لا يمكن طياعته في ورقة 8 سم صغيرة ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception) { }
        }

        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            if (DGVSupplierReport.Rows.Count >= 1)
            {
                if (Properties.Settings.Default.BuyPrint == true)
                {
                    PrintAll();
                }
                else if (Properties.Settings.Default.BuyPrint == false)
                {
                    MessageBox.Show("الرجاء تفعيل طباعة فواتير المشتريات من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            }
        }

        
    }
}
