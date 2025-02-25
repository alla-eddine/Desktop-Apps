using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FormUsers : Form
    {
        private DatabaseClass model;
        
        public static DataGridViewRow SelectedRow { get; set; }
        public FormUsers()
        {
            InitializeComponent(); 
            model = new DatabaseClass();
            Refresh_DataGrid();
            DataTable tbl = new DataTable();
        }

        private void BtnUsersShow_Click(object sender, EventArgs e)
        {
            tabUsers.SelectTab(tabUsersShow);
        }
        //--------------------------------------------insert user--------------------------------------------------------
        private void BtnUsersAdd_Click(object sender, EventArgs e)
        {
            tabUsers.SelectTab(tabUsersAdd);
        }
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            Insert_User();
        }
        //--------------------------------------------delete user----------------------------------------------------------
        private void BtnUsersDelete_Click(object sender, EventArgs e)
        {
            if (tabUsers.SelectedTab == tabUsersShow)
            {
                if (DgvUsers.SelectedRows.Count == 0 || SelectedRow == null)
                {
                    MessageBox.Show("يجب عليك اختيار البيانات التي تريد حذفها.",
                                    "تحذير",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    var user_id = SelectedRow.Cells["User_Id"].Value.ToString();

                    DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذه البيانات",
                                                            "تأكيد الحذف",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        model.DeleteRecord("Users", "User_Id = @UserId", new SqlParameter[]
                            {
                            new SqlParameter("@UserId", user_id)
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
        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row, not the header
            {
                SelectedRow = DgvUsers.Rows[e.RowIndex];
                TxtUserNameEdit.Text = SelectedRow.Cells["إسم المستخدم"].Value.ToString();
                TxtPasswordEdit.Text = SelectedRow.Cells["كلمة السر"].Value.ToString();
                string UserType = SelectedRow.Cells["نوع المستخدم"].Value.ToString();
                if (UserType == "admin")
                {
                    RBAdminEdit.Checked = true;
                }
                else
                {
                    RBUserEdit.Checked = true;
                }
            }
        }
        //----------------------------------------------update user--------------------------------------------
        private void BtnUsersUpdate_Click(object sender, EventArgs e)
        {
            if (DgvUsers.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("يجب عليك اختيار البيانات التي تريد تعديلها.",
                                "تحذير",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabUsers.SelectTab(tabUsersEdit);
            }
        }
        private void BtnUsersEdit_Click(object sender, EventArgs e)
        {
            Update_User();
        }
        //---------------------------------------------Serarch user------------------------------------------------------
        private void TxtUserSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchText = TxtUserSearch.Text;
            string Command = "SELECT User_Id, User_Name AS [إسم المستخدم], User_Password AS [كلمة السر]," +
                " User_Type AS [نوع المستخدم] from Users WHERE User_Name LIKE @Search_value";

            SqlParameter[] LikeParameters = new SqlParameter[]
            {
                new SqlParameter("@Search_value", $"%{SearchText}%")
            };

            DgvUsers.DataSource = model.LoadData(Command, LikeParameters);
            DgvUsers.Columns["User_Id"].Visible = false;
            

            DgvUsers.Refresh();
        }
        //---------------------------------------------auxailiry functions------------------------------------------------
        private void Refresh_DataGrid()
        {
            string Command = "SELECT User_Id, User_Name AS [إسم المستخدم], User_Password AS [كلمة السر]," +
                " User_Type AS [نوع المستخدم] from Users";

            FormUtilities.RefreshDataGrid(DgvUsers, model.LoadData(Command, null), "User_Id");
            FormUtilities.ClearFields(this);
        }
        
        public void Insert_User()
        {

            if (TxtUserName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("يجب عليك ملئ جميع الحقول.",
                                "تحذير أحد الحقول فارغة",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!RBAdmin.Checked && !RBUser.Checked)
            {
                MessageBox.Show("عليك تحديد نوع المستخدم", 
                                "تحذير",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string UserType = RBAdmin.Checked ? "admin" : "user";

            model.InsertRecord("Users", new SqlParameter[]
            {
                    new SqlParameter("@User_Name", TxtUserName.Text),
                    new SqlParameter("@User_Password", TxtPassword.Text),
                    new SqlParameter("@User_Type", UserType)
            });

            tbl.Clear();
            // get the last user save on DB
            tbl = model.readData("select max (User_ID) from Users", "");

            if ( tbl == null)
            {
                MessageBox.Show("لا يوجد أي مستخدم في قاعدة البيانات","تحذير",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int UserAccessId = Convert.ToInt32(tbl.Rows[0][0]);
                model.InsertRecord("UserAccess", new SqlParameter[]
            {
                    new SqlParameter("@User_ID", UserAccessId),
                    new SqlParameter("@User_Sales", "true"),
                    new SqlParameter("@User_Purchase", "false"),
                    new SqlParameter("@User_Products", "false"),
                    new SqlParameter("@User_Expances", "false"),
                    new SqlParameter("@User_Returns", "true"),
                    new SqlParameter("@User_Clients", "true"),
                    new SqlParameter("@User_Setting", "true"),
                    new SqlParameter("@User_Users", "false"),
                    new SqlParameter("@User_Supplier", "false"),
                    new SqlParameter("@User_SalesReport", "false"),
                    new SqlParameter("@User_PurchaseReport", "false"),
                    new SqlParameter("@User_SalesRebh", "false"),
                    new SqlParameter("@User_TopProduct", "true")
                    
            });
                MessageBox.Show("تم إضافة المستخدم الجديد مع إضافة صلاحيات له يمكن تعديلها عن طريقة تعديل سلاحيات المستخدم", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Refresh_DataGrid();
            tabUsers.SelectTab(tabUsersShow);

        }

        public void Update_User()
        {

            if (TxtUserNameEdit.Text == "" || TxtPasswordEdit.Text == "")
            {
                MessageBox.Show("يجب عليك ملئ جميع الحقول.",
                                "تحذير أحد الحقول فارغة",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!RBAdminEdit.Checked && !RBUserEdit.Checked)
            {
                MessageBox.Show("عليك تحديد نوع المستخدم",
                                "تحذير",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string UserType = RBAdminEdit.Checked ? "admin" : "user";

            var User_Id = SelectedRow.Cells["User_Id"].Value.ToString();

            List<SqlParameter> updateParameters = new List<SqlParameter>
            {
                    new SqlParameter("@User_Name", TxtUserNameEdit.Text),
                    new SqlParameter("@User_Password", TxtPasswordEdit.Text),
                    new SqlParameter("@User_Type", UserType)
            };

            SqlParameter[] whereParameters = new SqlParameter[] {
                new SqlParameter("@UserId", User_Id)
            };

            model.UpdateRecord("Users", "User_Id = @UserId", updateParameters.ToArray(), whereParameters);
            Refresh_DataGrid();
            tabUsers.SelectTab(tabUsersShow);
            
        }
        private void tabUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tabUsers.SelectedTab == tabUsersAdd)
                {
                    Insert_User();
                }
                else if (tabUsers.SelectedTab == tabUsersEdit)
                {
                    Update_User();
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        DataTable tbl = new DataTable();
        private void BtnAccessUsers_Click(object sender, EventArgs e)
        {
            if (DgvUsers.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("يجب عليك اختيار المستخدم الذي تريد تعديل صلاحياته.",
                                "تحذير",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabUsers.SelectTab(tabUsersAccess);
                var User_Id = Convert.ToInt32(SelectedRow.Cells["User_Id"].Value.ToString());
                
                var User_Name = SelectedRow.Cells["إسم المستخدم"].Value.ToString();
                labelUserNAme.Text = User_Name;
                tbl.Clear();
                tbl = model.readData("select * from UserAccess where User_ID = "+User_Id+"","");
                
                    if (tbl.Rows[0][1].ToString() == "true")
                        checkSales.Checked = true;
                    else if (tbl.Rows[0][1].ToString() == "false")
                        checkSales.Checked = false;

                    if (tbl.Rows[0][2].ToString() == "true")
                        checkPurchase.Checked = true;
                    else if (tbl.Rows[0][2].ToString() == "false")
                        checkPurchase.Checked = false;

                    if (tbl.Rows[0][3].ToString() == "true")
                        checkProducts.Checked = true;
                    else if (tbl.Rows[0][3].ToString() == "false")
                        checkProducts.Checked = false;

                    if (tbl.Rows[0][4].ToString() == "true")
                        checkExpences.Checked = true;
                    else if (tbl.Rows[0][4].ToString() == "false")
                        checkExpences.Checked = false;

                    if (tbl.Rows[0][5].ToString() == "true")
                        checkReturns.Checked = true;
                    else if (tbl.Rows[0][5].ToString() == "false")
                        checkReturns.Checked = false;

                    if (tbl.Rows[0][6].ToString() == "true")
                        checkClients.Checked = true;
                    else if (tbl.Rows[0][6].ToString() == "false")
                        checkClients.Checked = false;

                    if (tbl.Rows[0][7].ToString() == "true")
                        checkSetting.Checked = true;
                    else if (tbl.Rows[0][7].ToString() == "false")
                        checkSetting.Checked = false;

                    if (tbl.Rows[0][8].ToString() == "true")
                        checkUsers.Checked = true;
                    else if (tbl.Rows[0][8].ToString() == "false")
                        checkUsers.Checked = false;

                    if (tbl.Rows[0][9].ToString() == "true")
                        checkSuppliers.Checked = true;
                    else if (tbl.Rows[0][9].ToString() == "false")
                        checkSuppliers.Checked = false;

                    if (tbl.Rows[0][10].ToString() == "true")
                        checkSalesReport.Checked = true;
                    else if (tbl.Rows[0][10].ToString() == "false")
                        checkSalesReport.Checked = false;

                    if (tbl.Rows[0][11].ToString() == "true")
                        checkPurchasReport.Checked = true;
                    else if (tbl.Rows[0][11].ToString() == "false")
                        checkPurchasReport.Checked = false;

                    if (tbl.Rows[0][12].ToString() == "true")
                        checkSalesRebh.Checked = true;
                    else if (tbl.Rows[0][12].ToString() == "false")
                        checkSalesRebh.Checked = false;

                    if (tbl.Rows[0][13].ToString() == "true")
                        checkTopProducts.Checked = true;
                    else if (tbl.Rows[0][13].ToString() == "false")
                        checkTopProducts.Checked = false;

                
                
            }
        }
        string chSales, chPurchas, chProducts, chExpences, chReturns, chClients, chSetting, chUsers, chSuppliers, chSalesReport, chPurchasReport, chSalesRebh, chTopProducts;
        
        private void BtnSaveAccessUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var User_Id = SelectedRow.Cells["User_Id"].Value.ToString();
                
                if (checkSales.Checked == true)
                    chSales = "true";
                else if (checkSales.Checked == false)
                    chSales = "false";

                if (checkPurchase.Checked == true)
                    chPurchas = "true";
                else if (checkPurchase.Checked == false) 
                    chPurchas = "false";

                if (checkProducts.Checked == true)
                    chProducts = "true";
                else if (checkProducts.Checked == false)
                    chProducts = "false";

                if (checkExpences.Checked == true)
                    chExpences = "true";
                else if (checkExpences.Checked == false)
                    chExpences = "false";

                if (checkReturns.Checked == true)
                    chReturns = "true";
                else if (checkReturns.Checked == false)
                    chReturns = "false";

                if (checkClients.Checked == true)
                    chClients = "true";
                else if (checkClients.Checked == false)
                    chClients = "false";

                if (checkSetting.Checked == true)
                    chSetting = "true";
                else if (checkSetting.Checked == false)
                    chSetting = "false";

                if (checkUsers.Checked == true)
                    chUsers = "true";
                else if (checkUsers.Checked == false)
                    chUsers = "false";

                if (checkSuppliers.Checked == true)
                    chSuppliers = "true";
                else if (checkSuppliers.Checked == false)
                    chSuppliers = "false";

                if (checkSalesReport.Checked == true)
                    chSalesReport = "true";
                else if (checkSalesReport.Checked == false)
                    chSalesReport = "false";

                if (checkPurchasReport.Checked == true)
                    chPurchasReport = "true";
                else if (checkPurchasReport.Checked == false)
                    chPurchasReport = "false";

                if (checkSalesRebh.Checked == true)
                    chSalesRebh = "true";
                else if (checkSalesRebh.Checked == false)
                    chSalesRebh = "false";

                if (checkTopProducts.Checked == true)
                    chTopProducts = "true";
                else if (checkTopProducts.Checked == false)
                    chTopProducts = "false";

                

                

                model.exceuteData("update UserAccess set User_Sales = N'"+chSales+ "',User_Purchase = N'"+chPurchas+ "',User_Products = N'"+chProducts+"',User_Expances = N'"+chExpences+"',User_Returns = N'"+chReturns+"',User_Clients = N'"+chClients+"',User_Setting = N'"+chSetting+"',User_Users = N'"+chUsers+"',User_Supplier = N'"+chSuppliers+"',User_SalesReport = N'"+chSalesReport+"',User_PurchaseReport = N'"+chPurchasReport+"',User_SalesRebh = N'"+chSalesRebh+"',User_TopProduct = N'"+chTopProducts+"' where User_ID = " + Convert.ToInt32(User_Id) +"","");
                
                MessageBox.Show("تم تعديل صلاحيات المستخدم بنجاح","تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //Refresh_DataGrid();
                    //tabUsers.SelectTab(tabUsersShow);

            }
            catch (Exception) { }
         
        }
    }
}
