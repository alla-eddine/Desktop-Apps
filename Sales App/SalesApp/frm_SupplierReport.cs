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
    public partial class frm_SupplierReport : Form
    {
        public frm_SupplierReport()
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


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_SupplierReport_Load(object sender, EventArgs e)
        {
            try
            {
                FullSupplier();
                DtpDate.Text = DateTime.Now.ToShortDateString();

                tbl.Clear();
                tbl = db.LoadData("SELECT [Order_Id] AS 'رقم الفاتورة' ,[Price] AS 'المبالغ المسددة' ,[Date] AS 'تاريخ التسديد' ,Suppliers.Sup_Name AS 'اسم المورد' FROM [dbo].[Supplier_Report],Suppliers WHERE Suppliers.Sup_Id = Supplier_Report.Sup_Id \r\n");

                DGVSuppReport.DataSource = tbl;

                decimal TotalPrice = 0;
                for (int i = 0; i <= DGVSuppReport.Rows.Count - 1; i++)
                {
                    TotalPrice += Convert.ToDecimal(DGVSuppReport.Rows[i].Cells[1].Value);
                }
                TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();
            }
            catch (Exception ex) { }
        }
        
        private void BtnSearchSupp_Click(object sender, EventArgs e)
        {
            try
            {
                

                tbl.Clear();

                if (RBtnAllSupp.Checked == true)
                {
                    tbl = db.LoadData("SELECT [Order_Id] AS 'رقم الفاتورة' ,[Price] AS 'المبالغ المسددة' ,[Date] AS 'تاريخ التسديد' ,Suppliers.Sup_Name AS 'اسم المورد' FROM [dbo].[Supplier_Report],Suppliers WHERE Suppliers.Sup_Id = Supplier_Report.Sup_Id ");

                }else if (RBtnOneSupp.Checked == true)
                {
                    tbl = db.LoadData("SELECT [Order_Id] AS 'رقم الفاتورة' ,[Price] AS 'المبالغ المسددة' ,[Date] AS 'تاريخ التسديد' ,Suppliers.Sup_Name AS 'اسم المورد' FROM [dbo].[Supplier_Report],Suppliers WHERE Suppliers.Sup_Id = Supplier_Report.Sup_Id AND Suppliers.Sup_Id = " + CBxSupplier.SelectedValue+"");
                }

                DGVSuppReport.DataSource = tbl;

                decimal TotalPrice = 0;
                for (int i = 0; i <= DGVSuppReport.Rows.Count - 1; i++)
                {
                    TotalPrice += Convert.ToDecimal(DGVSuppReport.Rows[i].Cells[1].Value);
                }
                TxtTotal.Text = Math.Round(TotalPrice, 2).ToString();
            }
            catch (Exception ex) { }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DGVSuppReport.Rows.Count >=1)
            {
                if(MessageBox.Show("هل أنت متأكد من حذف الدفعات الخاصة بهذا المورد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (RBtnOneSupp.Checked == true)
                    {
                        db.ExecuteQuery("delete from Supplier_Report where Sup_Id = "+CBxSupplier.SelectedValue+"");
                        frm_SupplierReport_Load(null, null);
                        MessageBox.Show("تم الحذف بنجاح","تأكيد");
                    }else { MessageBox.Show("من فضلك حددة مورد أولا","تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Information); return; }
                }
            }
        }
    }
}
