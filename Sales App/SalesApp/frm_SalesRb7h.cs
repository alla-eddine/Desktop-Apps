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
    public partial class frm_SalesRb7h : Form
    {
        public frm_SalesRb7h()
        {
            InitializeComponent();
        }


        DatabaseClass db = new DatabaseClass();
        DataTable tbl = new DataTable();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_SalesRb7h_Load(object sender, EventArgs e)
        {
            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;

            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");


            tbl.Clear();

            if (checkBoxOrderNBR.Checked == false)
            {
                tbl = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sales_Rb7h].[Qty] as 'الكمية' , [BuyPrice] as 'سعر الشراء' ,[Price] as 'سعر البيع' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,(Price - BuyPrice) * (Sales_Rb7h.Qty) as 'إجمالي الربح',[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sales_Rb7h],Products where Products.Pro_Id = Sales_Rb7h.Pro_Id and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'  ORDER BY Order_Id ASC ", "");
            }
            else if (checkBoxOrderNBR.Checked == true)
            {
                tbl = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sales_Rb7h].[Qty] as 'الكمية' , [BuyPrice] as 'سعر الشراء' ,[Price] as 'سعر البيع' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,(Price - BuyPrice) * (Sales_Rb7h.Qty) as 'إجمالي الربح',[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sales_Rb7h],Products where Products.Pro_Id = Sales_Rb7h.Pro_Id and Order_Id = " + TxtOrderNBR.Text + " and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'  ORDER BY Order_Id ASC ", "");
            }
            DGVSalesRb7hReport.DataSource = tbl;

            decimal TotalOrder = 0, TotalRb7h = 0;
            for (int i = 0; i <= DGVSalesRb7hReport.Rows.Count - 1; i++)
            {
                TotalOrder += Convert.ToDecimal(DGVSalesRb7hReport.Rows[i].Cells[7].Value);
                TotalRb7h += Convert.ToDecimal(DGVSalesRb7hReport.Rows[i].Cells[8].Value);

            }
            TxtTotal.Text = Math.Round(TotalOrder, 2).ToString();
            TxtTotalRb7h.Text = Math.Round(TotalRb7h, 2).ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DGVSalesRb7hReport.Rows.Count >= 1)
            {
                string date1;
                string date2;

                date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
                date2 = DtpTo.Value.ToString("yyyy-MM-dd");
                if (MessageBox.Show("هل أنت متأكد من حذف هذه الفاتورة", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.exceuteData("delete from Sales_Rb7h where Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "'", "تم مسح بيانات الفاتورة المحددة");
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

                TblRpt = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cust_Name] as 'العميل' , Products.Pro_Name as 'المنتج' , [Sales_Rb7h].[Qty] as 'الكمية' , [BuyPrice] as 'سعر الشراء' ,[Price] as 'سعر البيع' ,[Discount] as 'الخصم' ,[Total] as 'الاجمالي' ,(Price - BuyPrice) * (Sales_Rb7h.Qty) as 'إجمالي الربح',[Total_Order] as 'اجمالي الفاتورة' ,[Price_Paid] as 'مبلغ المدفوع' ,[Price_Rest] as 'المتبقي' ,[User_Name] as 'المستخدم' , [Date] as 'التاريخ' FROM [dbo].[Sales_Rb7h],Products where Products.Pro_Id = Sales_Rb7h.Pro_Id and Convert(date,Date,105) between '" + date1 + "' and '" + date2 + "' ORDER BY Order_Id ASC", "");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();
                if (Properties.Settings.Default.SalePrintKind == "A4")
                {
                    RptSalesRb7h rpt = new RptSalesRb7h();



                    rpt.SetDatabaseLogon("", "", ".\\SQLEXPRESS", "sales");
                    rpt.SetDataSource(TblRpt);
                    rpt.SetParameterValue("From", date1);
                    rpt.SetParameterValue("To", date2);
                    frm1.crystalReportViewer1.ReportSource = rpt;

                    //frm1.Show();
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                    //frm1.crystalReportViewer1.ReportSource = rpt;
                }
                else if (Properties.Settings.Default.SalePrintKind == "8CM")
                {
                    MessageBox.Show("هذا التقرير لا يمكن طياعته في ورقة 8 سم صغيرة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



            }
            catch (Exception) { }
        }


        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            if (DGVSalesRb7hReport.Rows.Count >= 1)
            {
                if (Properties.Settings.Default.SalesPrint == true)
                {
                    PrintAll();
                }
                else if (Properties.Settings.Default.SalesPrint == false)
                {
                    MessageBox.Show("الرجاء تفعيل طباعة فواتير المبيعات من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void BtnPrintOrder_Click(object sender, EventArgs e)
        {

        }

        
    }
}
