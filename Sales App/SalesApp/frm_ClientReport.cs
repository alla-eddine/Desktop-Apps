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
    public partial class frm_ClientReport : Form
    {
        public frm_ClientReport()
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

        private void frm_ClientReport_Load(object sender, EventArgs e)
        {
            try
            {
                FullCustomer();
                DtpDate.Text = DateTime.Now.ToShortDateString();

                tbl.Clear();
                tbl = db.LoadData("SELECT [Order_Id] as 'رقم الفاتورة' , [Price] as 'المبلغ المدفوع' , [Date] as 'تاريخ الدفع' , [Cus_Name] as 'اسم العميل' FROM [dbo].[Customer_Report]");

                DGVCustReport.DataSource = tbl;

                decimal TotalPrice = 0;
                for (int i = 0; i <= DGVCustReport.Rows.Count - 1; i++)
                {
                    TotalPrice += Convert.ToDecimal(DGVCustReport.Rows[i].Cells[1].Value);
                }
                TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();
            }
            catch (Exception ex) { }
        }

        private void BtnSearchCust_Click(object sender, EventArgs e)
        {
            DtpDate.Text = DateTime.Now.ToShortDateString();

            tbl.Clear();
            if (RBtnAllCust.Checked == true)
            {
                tbl = db.LoadData("SELECT [Order_Id] as 'رقم الفاتورة' , [Price] as 'المبلغ المدفوع' , [Date] as 'تاريخ الدفع' , [Cus_Name] as 'اسم العميل' FROM [dbo].[Customer_Report]");
            }
            else
            {
                tbl = db.LoadData("SELECT [Order_Id] as 'رقم الفاتورة' , [Price] as 'المبلغ المدفوع' , [Date] as 'تاريخ الدفع' , [Cus_Name] as 'اسم العميل' FROM [dbo].[Customer_Report] where Cus_Name = '"+ CBxCustomer.Text +"'");
            }
            DGVCustReport.DataSource = tbl;

            decimal TotalPrice = 0;
            for (int i = 0; i <= DGVCustReport.Rows.Count - 1; i++)
            {
                TotalPrice += Convert.ToDecimal(DGVCustReport.Rows[i].Cells[1].Value);
            }
            TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DGVCustReport.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل أنت متأكد من حذف الدفعات الخاصة بهذا المورد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (RBtnOneCust.Checked == true)
                    {
                        db.ExecuteQuery("delete from Customer_Report where Cus_Name = '" + CBxCustomer.Text + "'");
                        frm_ClientReport_Load(null, null);
                        MessageBox.Show("تم الحذف بنجاح", "تأكيد");
                    }
                    else { MessageBox.Show("من فضلك حددة عميل أولا", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
