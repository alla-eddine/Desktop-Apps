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
    public partial class FormClients : Form
    {
        private DatabaseClass model;
        public static DataGridViewRow SelectedRow { get; set; }
        public FormClients()
        {
            InitializeComponent();
            model = new DatabaseClass();
            Refresh_DataGrid();
        }

        private void BtnClientShow_Click(object sender, EventArgs e)
        {
            tabClients.SelectTab(tabClientShow);
        }
        //--------------------------------- insert client--------------------------------------------
        private void BtnClientAdd_Click(object sender, EventArgs e)
        {
            tabClients.SelectTab(tabClientAdd);
        }
        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            Insert_Client();
        }
        //-------------------------------------delete client----------------------------------
        private void BtnClientDelete_Click(object sender, EventArgs e)
        {
            if (tabClients.SelectedTab == tabClientShow)
            {
                if (DgvClients.SelectedRows.Count == 0 || SelectedRow == null)
                {
                    MessageBox.Show("يجب عليك اختيار البيانات التي تريد حذفها.",
                                    "تحذير",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    var client_id = SelectedRow.Cells["Client_Id"].Value.ToString();

                    DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذه البيانات",
                                                            "تأكيد الحذف",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        model.DeleteRecord("Clients", "Client_Id = @ClientId", new SqlParameter[]
                            {
                            new SqlParameter("@ClientId", client_id)
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
        private void DgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row, not the header
            {
                SelectedRow = DgvClients.Rows[e.RowIndex];
                TxtClientNameEdit.Text = SelectedRow.Cells["إسم العميل"].Value.ToString();
                TxtClientPhoneEdit.Text = SelectedRow.Cells["رقم الهاتف"].Value.ToString();
                TxtClientAdressEdit.Text = SelectedRow.Cells["عنوان العميل"].Value.ToString();
                TxtClientNoteEdit.Text = SelectedRow.Cells["الملاحظة"].Value.ToString();
            }
        }

        //------------------------------------- Update Client ------------------------------------
        private void BtnClientUpdate_Click(object sender, EventArgs e)
        {
            if (DgvClients.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("يجب عليك اختيار البيانات التي تريد تعديلها.",
                                "تحذير",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabClients.SelectTab(tabClientEdit);
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Client();
        }

        //------------------------------------ search client ---------------------------------------------
        private void TxtClientSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchText = TxtClientSearch.Text;
            string Command = "SELECT Client_Id, Client_Name AS [إسم العميل], Client_Adress AS [عنوان العميل]," +
                " Client_Phone AS [رقم الهاتف], Client_Notes AS [الملاحظة] from Clients" +
                " WHERE Client_Name LIKE @Search_value";

            SqlParameter[] LikeParameters = new SqlParameter[]
            {
                new SqlParameter("@Search_value", $"%{SearchText}%")
            };

            DgvClients.DataSource = model.LoadData(Command, LikeParameters);
            DgvClients.Columns["Client_Id"].Visible = false;
            DgvClients.Refresh();
        }

        //---------------------------------------------auxailiry functions------------------------------------------------
        private void Refresh_DataGrid()
        {
            string Command = "SELECT Client_Id, Client_Name AS [إسم العميل], Client_Adress AS [عنوان العميل]," +
                " Client_Phone AS [رقم الهاتف], Client_Notes AS [الملاحظة] from Clients";

            FormUtilities.RefreshDataGrid(DgvClients, model.LoadData(Command, null), "Client_Id");
            FormUtilities.ClearFields(this);
        }
        public void Insert_Client()
        {

            if (TxtClientName.Text == "" || TxtClientPhone.Text == "")
            {
                MessageBox.Show("يجب عليك ملئ جميع الحقول.",
                                "تحذير أحد الحقول فارغة",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            model.InsertRecord("Clients", new SqlParameter[]
            {
                    new SqlParameter("@Client_Name", TxtClientName.Text),
                    new SqlParameter("@Client_Phone", TxtClientPhone.Text),
                    new SqlParameter("@Client_Adress", TxtClientAdresse.Text),
                    new SqlParameter("@Client_Notes", TxtClientNote.Text)
            });

            Refresh_DataGrid();
            tabClients.SelectTab(tabClientShow);

        }

        public void Update_Client()
        {

            if (TxtClientNameEdit.Text == "" || TxtClientPhoneEdit.Text == "")
            {
                MessageBox.Show("يجب عليك ملئ جميع الحقول.",
                                "تحذير أحد الحقول فارغة",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Client_Id = SelectedRow.Cells["Client_Id"].Value.ToString();

            List<SqlParameter> updateParameters = new List<SqlParameter>
            {
                    new SqlParameter("@Client_Name", TxtClientNameEdit.Text),
                    new SqlParameter("@Client_Phone", TxtClientPhoneEdit.Text),
                    new SqlParameter("@Client_Adress", TxtClientAdressEdit.Text),
                    new SqlParameter("@Client_Notes", TxtClientNoteEdit.Text)
            };

            SqlParameter[] whereParameters = new SqlParameter[] {
                new SqlParameter("@ClientId", Client_Id)
            };

            model.UpdateRecord("Clients", "Client_Id = @ClientId", updateParameters.ToArray(), whereParameters);
            Refresh_DataGrid();
            tabClients.SelectTab(tabClientShow);

        }

        private void tabClients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tabClients.SelectedTab == tabClientAdd)
                {
                    Insert_Client();
                }
                else if (tabClients.SelectedTab == tabClientEdit)
                {
                    Update_Client();
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FormSales.GetFormSales.FillCustomer();
            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ClientMoney frm = new frm_ClientMoney();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_ClientReport frm = new frm_ClientReport();
            frm.ShowDialog();
        }
    }
}
