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
    public partial class frm_SalesReport : Form
    {
        public frm_SalesReport()
        {
            InitializeComponent();
        }

        DatabaseClass db = new DatabaseClass();
        DataTable tbl = new DataTable();

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;

            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");


            tbl.Clear();

            if (checkBoxOrderNBR.Checked == false)
            {
                tbl = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sale_Details].[Qty] as 'الكمية' ,[Price] as 'السعر' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sale_Details],Products where Products.Pro_Id = Sale_Details.Pro_Id and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'  ORDER BY Order_Id ASC ", "");
            }
            else if (checkBoxOrderNBR.Checked == true) 
            {
                tbl = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sale_Details].[Qty] as 'الكمية' ,[Price] as 'السعر' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sale_Details],Products where Products.Pro_Id = Sale_Details.Pro_Id and Order_Id = "+TxtOrderNBR.Text+" and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'  ORDER BY Order_Id ASC ", "");
            }
            DGVUsersReport.DataSource = tbl;

            decimal TotalPrice = 0;
            for (int i = 0; i <= DGVUsersReport.Rows.Count - 1; i++)
            {
                TotalPrice += Convert.ToDecimal(DGVUsersReport.Rows[i].Cells[6].Value);
            }
            TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();

        }








        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DGVUsersReport.Rows.Count >= 1)
            {
                string date1;
                string date2;

                date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
                date2 = DtpTo.Value.ToString("yyyy-MM-dd");
                if (MessageBox.Show("هل أنت متأكد من حذف هذه الفاتورة", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.exceuteData("delete from Sale where Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'", "تم مسح بيانات الفاتورة المحددة");
                    BtnSearchUser_Click(null, null);
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

                TblRpt = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sale_Details].[Qty] as 'الكمية' ,[Price] as 'السعر' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sale_Details],Products where Products.Pro_Id = Sale_Details.Pro_Id and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "' ORDER BY Order_Id ASC", "");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();


                if (Properties.Settings.Default.SalePrintKind == "A4")
                {
                    RptSaleReport rpt = new RptSaleReport();



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
                else if (Properties.Settings.Default.SalePrintKind == "8CM")
                {
                    MessageBox.Show("هذا التقرير لا يمكن طياعته في ورقة  صغيرة يرجي تغيير اعدادات الطباعة في شاشة الاعدادات الى ورقة (A4)", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



            }
            catch (Exception) { }
        }


        private void Print()
        {
            try
            {
                int id = Convert.ToInt32(DGVUsersReport.CurrentRow.Cells[0].Value);
                DataTable TblRpt = new DataTable();
                TblRpt.Clear();

                TblRpt = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sale_Details].[Qty] as 'الكمية' ,[Price] as 'السعر' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sale_Details],Products where Products.Pro_Id = Sale_Details.Pro_Id and Order_Id = " + id + "", "");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();
                if(Properties.Settings.Default.SalePrintKind == "8CM")
                {
                    RptOrderSale rpt = new RptOrderSale();



                    rpt.SetDatabaseLogon("", "", ".\\SQLEXPRESS", "sales");
                    rpt.SetDataSource(TblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm1.crystalReportViewer1.ReportSource = rpt;
                    //frm1.Show();
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                } else if (Properties.Settings.Default.SalePrintKind == "A4")
                {
                    MessageBox.Show("هذا التقرير لا يمكن طياعته في ورقة  كبيرة يطبع فقط في ورقة صغيرة 8 سم)", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //frm1.crystalReportViewer1.ReportSource = rpt;



            }
            catch (Exception) { }
        }

        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            if (DGVUsersReport.Rows.Count >= 1)
            {
                if (Properties.Settings.Default.SalesPrint == true)
                {
                    PrintAll();
                }
                else if (Properties.Settings.Default.SalesPrint == false)
                {
                    MessageBox.Show("الرجاء تفعيل طباعة فاتورات المبيعات من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void BtnPrintOrder_Click(object sender, EventArgs e)
        {
            if (DGVUsersReport.Rows.Count >= 1)
            {
                if (Properties.Settings.Default.SalesPrint == true)
                {
                    Print();
                } else if (Properties.Settings.Default.SalesPrint == false)
                {
                    MessageBox.Show("الرجاء تفعيل طباعة فاتورات المبيعات من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    return;
                }
            }
            
        }

        private void frm_SalesReport_Load(object sender, EventArgs e)
        {
            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
