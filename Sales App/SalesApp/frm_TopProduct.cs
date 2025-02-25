using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class frm_TopProduct : Form
    {
        public frm_TopProduct()
        {
            InitializeComponent();
        }

        DatabaseClass db = new DatabaseClass();
        DataTable tbl = new DataTable();

        private void BtnShowTopProduct_Click(object sender, EventArgs e)
        {
            int nbrPro;
            string date1;
            string date2;

            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            
            tbl.Clear();
            if (checkBoxNBR.Checked == false)
            {
                tbl = db.readData("SELECT  p.Pro_Id as 'رقم المنتج', p.Pro_Name as 'المنتج الأكثر مبيعا', SUM(s.Qty) AS  QTY FROM Sale_Details s, Products p where s.Pro_Id = p.Pro_Id and Convert(date, s.Date, 105) between '" + date1 + "' and '" + date2 + "' GROUP BY p.Pro_Id, p.Pro_Name  ORDER BY QTY DESC", "");
            }
            else if (checkBoxNBR.Checked == true)
            {
                if (TxtOrderNBR.Text == "")
                {
                    MessageBox.Show("الرجاء كتابة عدد النتجات التي تود اظهارها","تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    nbrPro = Convert.ToInt32(TxtOrderNBR.Text);
                    tbl = db.readData("SELECT TOP(" + nbrPro + ") p.Pro_Id as 'رقم المنتج', p.Pro_Name as 'المنتج الأكثر مبيعا', SUM(s.Qty) AS  QTY FROM Sale_Details s, Products p where s.Pro_Id = p.Pro_Id and Convert(date, s.Date, 105) between '" + date1 + "' and '" + date2 + "' GROUP BY p.Pro_Id, p.Pro_Name  ORDER BY QTY DESC", "");
                }
            }
            DGVTopProducts.DataSource = tbl;
        }

        private void frm_TopProduct_Load(object sender, EventArgs e)
        {
            
            tbl.Clear();

            tbl = db.readData("SELECT  p.Pro_Id as 'رقم المنتج', p.Pro_Name  as 'المنتج الأكثر مبيعا', SUM(s.Qty) AS  QTY FROM Sale_Details s ,Products p where s.Pro_Id = p.Pro_Id  GROUP BY p.Pro_Id, p.Pro_Name  ORDER BY QTY DESC", "");
            DGVTopProducts.DataSource = tbl;

            BtnShowMinProduct_Click(null, null);
        }
        DataTable tblMin = new DataTable();
        private void BtnShowMinProduct_Click(object sender, EventArgs e)
        {


            tblMin.Clear();
            
            tblMin = db.readData("SELECT Pro_Id as 'رقم المنتج', Pro_Name as 'المنتج الذي سينتهي قريبا', Qty as 'الكمية المتبقية', MinQty as 'اقل كمية يجب ان توجد' FROM Products WHERE Qty <= MinQty", "");
            DGVMinProducts.DataSource = tblMin;
        }
    }
}
