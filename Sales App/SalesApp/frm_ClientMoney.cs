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
    public partial class frm_ClientMoney : Form
    {
        public frm_ClientMoney()
        {
            InitializeComponent();
        }

        DatabaseClass db = new DatabaseClass();
        DataTable tbl = new DataTable();

        private void FullCustomer()
        {
            CBxCustomer.DataSource = db.LoadData("select * from Clients");
            CBxCustomer.DisplayMember = "Client_Name";
            CBxCustomer.ValueMember = "Client_Id";
        }

        private void frm_ClientMoney_Load(object sender, EventArgs e)
        {

            try
            {
                FullCustomer();
            }
            catch (Exception) { }

            DtpDate.Text = DateTime.Now.ToShortDateString();
            tbl.Clear();
            tbl = db.LoadData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cus_Name] as 'اسم العميل' , [Price] as 'المبلغ' , [Order_Date] as 'تاريخ الفاتورة' , [Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money]");

            DGVCustMoney.DataSource = tbl;

            decimal TotalPrice = 0;
            for (int i = 0; i <= DGVCustMoney.Rows.Count - 1; i++)
            {
                TotalPrice += Convert.ToDecimal(DGVCustMoney.Rows[i].Cells[2].Value);
            }
            TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();
            RBtnAllCust.Checked = true;
            NumPriceRestPaid.Value = 0;
        }


        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearchCust_Click(object sender, EventArgs e)
        {
            

            DtpDate.Text = DateTime.Now.ToShortDateString();
            tbl.Clear();
            if (RBtnAllCust.Checked == true)
            {
                tbl = db.LoadData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cus_Name] as 'اسم العميل' , [Price] as 'المبلغ' , [Order_Date] as 'تاريخ الفاتورة' , [Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money]");
            }
            else if (RBtnOneCust.Checked == true) 
            {
                tbl = db.LoadData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cus_Name] as 'اسم العميل' , [Price] as 'المبلغ' , [Order_Date] as 'تاريخ الفاتورة' , [Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money] where Cus_Name = '"+CBxCustomer.Text+"'");
            }
            
            DGVCustMoney.DataSource = tbl;

            decimal TotalPrice = 0;
            for (int i = 0; i <= DGVCustMoney.Rows.Count - 1; i++)
            {
                TotalPrice += Convert.ToDecimal(DGVCustMoney.Rows[i].Cells[2].Value);
            }
            TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();
        }

        private void BtnPaidRest_Click(object sender, EventArgs e)
        {
            if (DGVCustMoney.Rows.Count >= 1)
            {

                string d = DtpDate.Value.ToString("dd/MM/yyyy");

                if (RBtnPayAll.Checked == true)
                {
                    if (MessageBox.Show("هل أنت متأكد من تسديد المبلغ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (RBtnAllCust.Checked == true) { MessageBox.Show("من فضلك إختر عميل واحد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                        db.ExecuteQuery("delete from Customer_Money where Order_Id = " + DGVCustMoney.CurrentRow.Cells[0].Value + " and Price = " + DGVCustMoney.CurrentRow.Cells[2].Value + "");

                        db.InsertRecord("Customer_Report", new SqlParameter[]
                                                {
                                        new SqlParameter("@Order_Id", DGVCustMoney.CurrentRow.Cells[0].Value),
                                        new SqlParameter("@Price", DGVCustMoney.CurrentRow.Cells[2].Value),
                                        new SqlParameter("@Date", d),
                                        new SqlParameter("@Cus_Name", CBxCustomer.Text)
                                                });

                        frm_ClientMoney_Load(null, null);
                    }
                }
                else if (RBtnPayPart.Checked == true)
                {

                    if (MessageBox.Show("هل أنت متأكد من تسديد المبلغ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (RBtnAllCust.Checked == true) { MessageBox.Show("من فضلك إختر عميل واحد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                        decimal money = Convert.ToDecimal(DGVCustMoney.CurrentRow.Cells[2].Value) - NumPriceRestPaid.Value;
                        var parameters = new SqlParameter[]
                        {
                                new SqlParameter("@Price", money),

                        };

                        var conditions = new Dictionary<string, object>
                            {
                                { "Order_Id", DGVCustMoney.CurrentRow.Cells[0].Value },
                                { "Price", DGVCustMoney.CurrentRow.Cells[2].Value }
                            };

                        db.UpdateRecordMulltipleCondition("Customer_Money", parameters, conditions);

                        db.InsertRecord("Customer_Report", new SqlParameter[]
                                                {
                                            new SqlParameter("@Order_Id", DGVCustMoney.CurrentRow.Cells[0].Value),
                                            new SqlParameter("@Price", NumPriceRestPaid.Value),
                                            new SqlParameter("@Date", d),
                                            new SqlParameter("@Cus_Name", CBxCustomer.Text)
                                                });

                        frm_ClientMoney_Load(null, null);
                    }
                }
            }
        }



        private void PrintOneCust()
        {
            try
            {
                string Cust_Name = Convert.ToString(CBxCustomer.Text);
                DataTable TblRpt = new DataTable();
                TblRpt.Clear();

                TblRpt = db.readData("SELECT [Order_Id] as 'رقم الفاتورة' , [Cus_Name] as 'اسم العميل' , [Price] as 'المبلغ' , [Order_Date] as 'تاريخ الفاتورة' , [Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money] where Cus_Name = '"+Cust_Name+"'", "");

                Frm_Printing frm1 = new Frm_Printing();

                frm1.crystalReportViewer1.RefreshReport();
                if (Properties.Settings.Default.SalePrintKind == "8CM")
                {
                    RptCustomerMoney rpt = new RptCustomerMoney();



                rpt.SetDatabaseLogon("", "", ".\\SQLEXPRESS", "sales");
                rpt.SetDataSource(TblRpt);
                rpt.SetParameterValue("Name", Cust_Name);
                frm1.crystalReportViewer1.ReportSource = rpt;
                //frm1.Show();
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                rpt.PrintToPrinter(1, true, 0, 0);
                //frm1.crystalReportViewer1.ReportSource = rpt;
                }
                else if (Properties.Settings.Default.SalePrintKind == "A4")
                {
                    MessageBox.Show("لا يمكن طباعة هذا التقرير في ورقة A4 ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception) { }
        }



        private void BtnPrintCustMoney_Click(object sender, EventArgs e)
        {
            if (DGVCustMoney.Rows.Count >= 1)
            {
                if (RBtnOneCust.Checked == true)
                {

                    if (Properties.Settings.Default.SalesPrint == true)
                    {
                        PrintOneCust();
                    }
                    else if (Properties.Settings.Default.SalesPrint == false)
                    {
                        MessageBox.Show("الرجاء تفعيل طباعة فواتير المبيعات من شاشة اعدادات البرنامج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                }
            }
        }
    }
}
