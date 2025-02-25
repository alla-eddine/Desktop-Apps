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
    public partial class frm_SupplierMoney : Form
    {
        public frm_SupplierMoney()
        {
            InitializeComponent();
        }

        DatabaseClass db = new DatabaseClass();
        DataTable tbl = new DataTable();

        private void FullSupplier()
        {
            CBxSupplier.DataSource = db.LoadData("select * from Suppliers");
            CBxSupplier.DisplayMember = "Sup_Name";
            CBxSupplier.ValueMember = "Sup_Id";
        }

        private void frm_SupplierMoney_Load(object sender, EventArgs e)
        {
            try
            {
                FullSupplier();
            }
            catch (Exception){ }

            DtpDate.Text = DateTime.Now.ToShortDateString();
            tbl.Clear();
            tbl = db.LoadData("SELECT [Order_Id] AS 'رقم الفاتورة' ,Suppliers.Sup_Name AS 'إسم المورد' ,[Price] AS 'المبلغ' ,[Order_Date] AS 'تاريخ الفاتورة' ,[Reminder_Date] AS 'تاريخ التسديد' FROM [dbo].[Supplier_Money], Suppliers WHERE  Suppliers.Sup_Id = [Supplier_Money].Sup_Id");

            DGVSuppMoney.DataSource = tbl;

            decimal TotalPrice = 0;
            for(int i =0; i <= DGVSuppMoney.Rows.Count-1; i++){
                TotalPrice += Convert.ToDecimal(DGVSuppMoney.Rows[i].Cells[2].Value);
            }
            TxtTotal.Text = Math.Round(TotalPrice,2).ToString();
            RBtnAllSupp.Checked = true;
            NumPriceRestPaid.Value = 0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearchSupp_Click(object sender, EventArgs e)
        {
            tbl.Clear();

            if (RBtnAllSupp.Checked == true) 
            {
                tbl = db.LoadData("SELECT [Order_Id] AS 'رقم الفاتورة' ,Suppliers.Sup_Name AS 'إسم المورد' ,[Price] AS 'المبلغ' ,[Order_Date] AS 'تاريخ الفاتورة' ,[Reminder_Date] AS 'تاريخ التسديد' FROM [dbo].[Supplier_Money], Suppliers WHERE  Suppliers.Sup_Id = [Supplier_Money].Sup_Id");
            }
            else if(RBtnOneSupp.Checked == true)
            {
                tbl = db.LoadData("SELECT [Order_Id] AS 'رقم الفاتورة' ,Suppliers.Sup_Name AS 'إسم المورد' ,[Price] AS 'المبلغ' ,[Order_Date] AS 'تاريخ الفاتورة' ,[Reminder_Date] AS 'تاريخ التسديد' FROM [dbo].[Supplier_Money], Suppliers WHERE  Suppliers.Sup_Id = [Supplier_Money].Sup_Id AND Suppliers.Sup_Id = "+CBxSupplier.SelectedValue+"");
            }

            DGVSuppMoney.DataSource = tbl;

            decimal TotalPrice = 0;
            for (int i = 0; i <= DGVSuppMoney.Rows.Count - 1; i++)
            {
                TotalPrice += Convert.ToDecimal(DGVSuppMoney.Rows[i].Cells[2].Value);
            }
            TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();
        }

        private void BtnPaidRest_Click(object sender, EventArgs e)
        {
            if (DGVSuppMoney.Rows.Count >=1)
            {

                string d = DtpDate.Value.ToString("dd/MM/yyyy");

                if(RBtnPayAll.Checked == true)
                {
                    if (MessageBox.Show("هل أنت متأكد من تسديد المبلغ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (RBtnAllSupp.Checked == true) { MessageBox.Show("من فضلك إختر مورد واحد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                        db.ExecuteQuery("delete from Supplier_Money where Order_Id = " + DGVSuppMoney.CurrentRow.Cells[0].Value + " and Price = " + DGVSuppMoney.CurrentRow.Cells[2].Value + "");

                        db.InsertRecord("Supplier_Report", new SqlParameter[]
                                                {
                                        new SqlParameter("@Order_Id", DGVSuppMoney.CurrentRow.Cells[0].Value),
                                        new SqlParameter("@Price", DGVSuppMoney.CurrentRow.Cells[2].Value),
                                        new SqlParameter("@Date", d),
                                        new SqlParameter("@Sup_Id", CBxSupplier.SelectedValue)
                                                });

                        frm_SupplierMoney_Load(null, null);
                    }
                } else if(RBtnPayPart.Checked == true)
                {

                    if (MessageBox.Show("هل أنت متأكد من تسديد المبلغ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (RBtnAllSupp.Checked == true) { MessageBox.Show("من فضلك إختر مورد واحد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                            decimal money = Convert.ToDecimal(DGVSuppMoney.CurrentRow.Cells[2].Value) - NumPriceRestPaid.Value;
                            var parameters = new SqlParameter[]
                            {
                                new SqlParameter("@Price", money),

                            };

                            var conditions = new Dictionary<string, object>
                            {
                                { "Order_Id", DGVSuppMoney.CurrentRow.Cells[0].Value },
                                { "Price", DGVSuppMoney.CurrentRow.Cells[2].Value }
                            };

                            db.UpdateRecordMulltipleCondition("Supplier_Money", parameters, conditions);

                            db.InsertRecord("Supplier_Report", new SqlParameter[]
                                                    {
                                            new SqlParameter("@Order_Id", DGVSuppMoney.CurrentRow.Cells[0].Value),
                                            new SqlParameter("@Price", NumPriceRestPaid.Value),
                                            new SqlParameter("@Date", d),
                                            new SqlParameter("@Sup_Id", CBxSupplier.SelectedValue)
                                                    });

                            frm_SupplierMoney_Load(null, null);
                    }
                }
            }
        }


        private void PrintOneSup()
        {
            try
            {
                int id = Convert.ToInt32(CBxSupplier.SelectedValue);
                DataTable TblRpt = new DataTable();
                TblRpt.Clear();

                TblRpt = db.readData("SELECT [Order_Id] AS 'رقم الفاتورة' ,Suppliers.Sup_Id AS 'رقم المورد' ,Suppliers.Sup_Name AS 'إسم المورد' ,[Price] AS 'المبلغ' ,[Order_Date] AS 'تاريخ الفاتورة' ,[Reminder_Date] AS 'تاريخ التسديد' FROM [dbo].[Supplier_Money], Suppliers WHERE  Suppliers.Sup_Id = [Supplier_Money].Sup_Id and Suppliers.Sup_Id = " + id + "", "");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();

                if (Properties.Settings.Default.BuyPrintKind == "8CM")
                {
                    RptSupplierMoney rpt = new RptSupplierMoney();

                    rpt.SetDatabaseLogon("", "", ".\\SQLEXPRESS", "sales");
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
                    MessageBox.Show("لا يمكن طباعة هذا التقرير في ورقة A4 ","تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }




            }
            catch (Exception) { }
        }

        private void BtnPrintSuppMoney_Click(object sender, EventArgs e)
        {
            if (DGVSuppMoney.Rows.Count >= 1)
            {
                if (RBtnOneSupp.Checked == true)
                {

                    if (Properties.Settings.Default.BuyPrint == true)
                    {
                        PrintOneSup();
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
}
