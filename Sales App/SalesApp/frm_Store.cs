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
    public partial class frm_Store : Form
    {
        public frm_Store()
        {
            InitializeComponent();
        }


        DatabaseClass db = new DatabaseClass();
        DataTable tblUnit = new DataTable();
        DataTable tbl = new DataTable();

        

        private void AutoNumber()
        {
            tblUnit.Clear();
            tblUnit = db.readData("select Store_Id as 'رقم المخزن' ,Store_Name as 'اسم المخزن' from Store", "");
            DgvSearch.DataSource = tblUnit;
            tbl.Clear();
            tbl = db.readData("select max (Store_Id) from Store", "");

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

        

        int row;
        private void Show()
        {
            tblUnit.Clear();
            tblUnit = db.readData("select * from Store", "");

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

      
        private void frm_Store_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المخزن");
                return;
            }
            db.exceuteData("insert into Store Values (" + txtID.Text + " ,N'" + txtName.Text + "')", "تم الادخال بنجاح");

            AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المخزن");
                return;
            }
            db.readData("update Store set Store_Name=N'" + txtName.Text + "'  where Store_Id=" + txtID.Text + "", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Store where Store_Id=" + txtID.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Store ", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            row = 0;
            Show();
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tblUnit.Clear();
                tblUnit = db.readData("select count(Store_Id) from Store", "");
                row = Convert.ToInt32(tblUnit.Rows[0][0]) - 1;
                Show();
            }
            else
            {


                row--;
                Show();
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            tblUnit.Clear();
            tblUnit = db.readData("select count(Store_Id) from Store", "");
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

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            tblUnit.Clear();
            tblUnit = db.readData("select count(Store_Id) from Store", "");
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
                    tblShow = db.readData("select * from Store where Store_Id=" + DgvSearch.CurrentRow.Cells[0].Value + "", "");

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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
