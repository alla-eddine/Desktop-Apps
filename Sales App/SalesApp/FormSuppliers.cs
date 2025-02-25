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
    public partial class FormSuppliers : Form
    {
        private DatabaseClass model;
        public static DataGridViewRow SelectedRow { get; set; }
        public FormSuppliers()
        {
            InitializeComponent();
            model = new DatabaseClass();
            Refresh_DataGrid();
        }

        private void BtnSuppShow_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectTab(tabSupplierShow);
        }
        //-----------------------------------------------Insert Supplier----------------------------
        private void BtnSuppAdd_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectTab(tabSupplierAdd);
        }

        private void BtnSaveSuppliers_Click(object sender, EventArgs e)
        {
            Insert_Supplier();
        }

        //--------------------------------------------delete user----------------------------------------------------------
        private void BtnSuppDelete_Click(object sender, EventArgs e)
        {
            if (tabSupplier.SelectedTab == tabSupplierShow)
            {
                if (DgvSuppliers.SelectedRows.Count == 0 || SelectedRow == null)
                {
                    MessageBox.Show("يجب عليك اختيار البيانات التي تريد حذفها.",
                                    "تحذير",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    var sup_id = SelectedRow.Cells["Sup_Id"].Value.ToString();

                    DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذه البيانات",
                                                            "تأكيد الحذف",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        model.DeleteRecord("Suppliers", "Sup_Id = @SupplierId", new SqlParameter[]
                            {
                            new SqlParameter("@SupplierId", sup_id)
                            });
                        Refresh_DataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("عليك العودة أن تعود إلى قائمة العرض أولا",
                                "تحذير",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //-------------------------------------Cell click----------------------------------
        private void DgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row, not the header
            {
                SelectedRow = DgvSuppliers.Rows[e.RowIndex];
                TxtSuppNameEdit.Text = SelectedRow.Cells["إسم المورد"].Value.ToString();
                TxtSuppPhoneEdit.Text = SelectedRow.Cells["رقم الهاتف"].Value.ToString();
                TxtSuppAdressEdit.Text = SelectedRow.Cells["عنوان المورد"].Value.ToString();
                TxtSuppNoteEdit.Text = SelectedRow.Cells["الملاحظة"].Value.ToString();
            }
        }
        //---------------------------------------------update supplier---------------------------------------------------
        private void BtnSuppUpdate_Click(object sender, EventArgs e)
        {
            if (DgvSuppliers.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("يجب عليك اختيار البيانات التي تريد تعديلها.",
                                "تحذير",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabSupplier.SelectTab(tabSupplierUpdate);
            }
        }

        private void BtnSuppEdit_Click(object sender, EventArgs e)
        {
            Update_Supplier();
        }

        //---------------------------------------------Serarch supplier------------------------------------------------------
        private void TxtSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchText = TxtSupplierSearch.Text;
            string Command = "SELECT Sup_Id, Sup_Name AS [إسم المورد], Sup_Adress AS [عنوان المورد]," +
                " Sup_Phone AS [رقم الهاتف], Sup_Notes AS [الملاحظة] from Suppliers" +
                " WHERE Sup_Name LIKE @Search_value";

            SqlParameter[] LikeParameters = new SqlParameter[]
            {
                new SqlParameter("@Search_value", $"%{SearchText}%")
            };

            DgvSuppliers.DataSource = model.LoadData(Command, LikeParameters);
            DgvSuppliers.Columns["Sup_Id"].Visible = false;
            DgvSuppliers.Refresh();
        }

        //---------------------------------------------auxailiry functions------------------------------------------------
        private void Refresh_DataGrid()
        {
            string Command = "SELECT Sup_Id, Sup_Name AS [إسم المورد], Sup_Adress AS [عنوان المورد]," +
                " Sup_Phone AS [رقم الهاتف], Sup_Notes AS [الملاحظة] from Suppliers";

            FormUtilities.RefreshDataGrid(DgvSuppliers, model.LoadData(Command, null), "Sup_Id");
            FormUtilities.ClearFields(this);
        }

        public void Insert_Supplier()
        {

            if (TxtSuppName.Text == "" || TxtSuppPhone.Text == "")
            {
                MessageBox.Show("يجب عليك ملئ جميع الحقول.",
                                "تحذير أحد الحقول فارغة",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            model.InsertRecord("Suppliers", new SqlParameter[]
            {
                    new SqlParameter("@Sup_Name", TxtSuppName.Text),
                    new SqlParameter("@Sup_Phone", TxtSuppPhone.Text),
                    new SqlParameter("@Sup_Adress", TxtSuppAdresse.Text),
                    new SqlParameter("@Sup_Notes", TxtSuppNote.Text)
            });

            Refresh_DataGrid();
            tabSupplier.SelectTab(tabSupplierShow);

        }
        public void Update_Supplier()
        {

            if (TxtSuppNameEdit.Text == "" || TxtSuppPhoneEdit.Text == "")
            {
                MessageBox.Show("يجب عليك ملئ جميع الحقول.",
                                "تحذير أحد الحقول فارغة",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Sup_Id = SelectedRow.Cells["Sup_Id"].Value.ToString();

            List<SqlParameter> updateParameters = new List<SqlParameter>
            {
                    new SqlParameter("@Sup_Name", TxtSuppNameEdit.Text),
                    new SqlParameter("@Sup_Phone", TxtSuppPhoneEdit.Text),
                    new SqlParameter("@Sup_Adress", TxtSuppAdressEdit.Text),
                    new SqlParameter("@Sup_Notes", TxtSuppNoteEdit.Text)
            };

            SqlParameter[] whereParameters = new SqlParameter[] {
                new SqlParameter("@SupId", Sup_Id)
            };

            model.UpdateRecord("Suppliers", "Sup_Id = @SupId", updateParameters.ToArray(), whereParameters);
            Refresh_DataGrid();
            tabSupplier.SelectTab(tabSupplierShow);

        }
        private void tabSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tabSupplier.SelectedTab == tabSupplierAdd)
                {
                    Insert_Supplier();
                }
                else if (tabSupplier.SelectedTab == tabSupplierUpdate)
                {
                    Update_Supplier();
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void FormSuppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            try 
            {
                /*FormPurchases.GetFormPurchases.FillProducts();*/
                FormPurchases.GetFormPurchases.FillSupplier();
            }
            catch (Exception)
            {

            }
        }

        private void BtnShowSuppMoney_Click(object sender, EventArgs e)
        {
            frm_SupplierMoney frm = new frm_SupplierMoney();
            frm.ShowDialog();
        }

        private void BtnSuppReport_Click(object sender, EventArgs e)
        {
            frm_SupplierReport frm = new frm_SupplierReport();
            frm.ShowDialog();
        }
    }
}
