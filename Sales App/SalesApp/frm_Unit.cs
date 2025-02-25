using CrystalDecisions.CrystalReports.ViewerObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesApp
{
    public partial class frm_Unit : Form
    {
        public frm_Unit()
        {
            InitializeComponent();
        }

        DatabaseClass db = new DatabaseClass();
        DataTable tblUnit = new DataTable();
        DataTable tbl = new DataTable();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AutoNumber()
        {
            tblUnit.Clear();
            tblUnit = db.readData("select Unit_Id as 'رقم الوحدة' ,Unit_Name as 'اسم الوحدة' from Unit", "");
            DgvSearch.DataSource = tblUnit;
            tbl.Clear();
            tbl = db.readData("select max (Unit_Id) from Unit", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }

            txtName.Clear();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;

        }

        private void frm_Unit_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        int row;
        private void Show()
        {
            tblUnit.Clear();
            tblUnit = db.readData("select * from Unit", "");

            if (tblUnit.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشه");
            }
            else
            {
                txtID.Text = tblUnit.Rows[row][0].ToString();
                txtName.Text = tblUnit.Rows[row][1].ToString();
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الوحدة");
                return;
            }
            db.exceuteData("insert into Unit Values (" + txtID.Text + " ,N'" + txtName.Text + "')", "تم الادخال بنجاح");

            AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الوحدة");
                return;
            }
            db.readData("update Unit set Unit_Name=N'" + txtName.Text + "'  where Unit_Id=" + txtID.Text + "", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Unit where Unit_Id=" + txtID.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Unit ", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }



        

        

        

        

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tblUnit.Clear();
                tblUnit = db.readData("select count(Unit_Id) from Unit", "");
                row = Convert.ToInt32(tblUnit.Rows[0][0]) - 1;
                Show();
            }
            else
            {


                row--;
                Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblUnit.Clear();
            tblUnit = db.readData("select count(Unit_Id) from Unit", "");
            if (Convert.ToInt32(tblUnit.Rows[0][0]) - 1 == row)
            {
                row = 0;
                Show();
            }
            else
            {
                row++;
                Show();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblUnit.Clear();
            tblUnit = db.readData("select count(Unit_Id) from Unit", "");
            row = Convert.ToInt32(tblUnit.Rows[0][0]) - 1;
            Show();
        }

        private void DgvSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (DgvSearch.Rows.Count >= 1)
                {
                    DataTable tblShow = new DataTable();
                    tblShow.Clear();
                    tblShow = db.readData("select * from Unit where Unit_Id=" + DgvSearch.CurrentRow.Cells[0].Value + "", "");

                    txtID.Text = tblShow.Rows[0][0].ToString();
                    txtName.Text = tblShow.Rows[0][1].ToString();

                    btnAdd.Enabled = false;
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                    btnSave.Enabled = true;
                }

            }
            catch (Exception) { }
        }
    }
}
