using SalesApp.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesApp
{
    public partial class FormProduct : Form
    {

        
        private DatabaseClass model;

        public static DataGridViewRow SelectedRow { get; set; }

        private Image previousImage = null;

        public FormProduct()
        {
            InitializeComponent();
            model = new DatabaseClass();
            
            Refresh_DataGrid();   
        }




        private void FormProduct_Load(object sender, EventArgs e)
        {
            CBxCategorie.DataSource = model.LoadData("select * from Products_Group");
            CBxCategorie.DisplayMember = "Group_Name";
            CBxCategorie.ValueMember = "Group_Id";

            CBxCategorieEdit.DataSource = model.LoadData("select * from Products_Group");
            CBxCategorieEdit.DisplayMember = "Group_Name";
            CBxCategorieEdit.ValueMember = "Group_Id";
        }

        private void BtnProShow_Click(object sender, EventArgs e)
        {
            tabProduct.SelectTab(tabProductShow);
        }

        //----------------------------------------------insert new product---------------------------------------------------
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            tabProduct.SelectTab(tabProductAdd);
        }

        private void BtnProSave_Click(object sender, EventArgs e)
        {
            Insert_Product();
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        //-----------------------------------------------delete product----------------------------------------------------
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row, not the header
            {
                SelectedRow = dataGridViewProduct.Rows[e.RowIndex];
                TxtEditProName.Text = SelectedRow.Cells["إسم المنتج"].Value.ToString();
                TxtEditProQty.Text = SelectedRow.Cells["الكمية"].Value.ToString();
                TxtEditProMinQty.Text = SelectedRow.Cells["الكمية الصغرى"].Value.ToString();
                TxtProBuyPriceEdit.Text = SelectedRow.Cells["سعر الشراء"].Value.ToString();
                TxtProPriceRetailsEdit.Text = SelectedRow.Cells["سعر البيع بالتجزئة"].Value.ToString();
                txtProPriceShowEdit.Text = SelectedRow.Cells["سعر العرض"].Value.ToString();

                TxtProDiscountEdit.Text = SelectedRow.Cells["التخفيض"].Value.ToString();
                TxtProBarcodeEdit.Text = SelectedRow.Cells["الباركود"].Value.ToString();
                
                CBxCategorieEdit.DisplayMember = SelectedRow.Cells["التصنيف"].Value.ToString();

                int productId = Convert.ToInt32(SelectedRow.Cells["Pro_Id"].Value);

                byte[] imageData = GetProductImageById(productId);


                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    ms.Position = 0;
                    ImageEdit.Image = Image.FromStream(ms);
                    previousImage = ImageEdit.Image;  
                }

            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (tabProduct.SelectedTab == tabProductShow)
            {
                if (dataGridViewProduct.SelectedRows.Count == 0 || SelectedRow == null)
                {
                    MessageBox.Show("يجب عليك اختيار البيانات التي تريد حذفها.",
                                    "لم يتم اختيار البيانات",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    var pro_id = SelectedRow.Cells["Pro_Id"].Value.ToString();

                    DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذه البيانات",
                                                            "تأكيد الحذف",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        model.DeleteRecord("Products", "Pro_Id = @ProId", new SqlParameter[]
                            {
                            new SqlParameter("@ProId", pro_id)
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

        //--------------------------------------------------edit product ---------------------------------------------
        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("يجب عليك اختيار البيانات التي تريد تعديلها.",
                                "تحذير",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabProduct.SelectTab(tabProductEdit);
            }
        }

        private void LoadImageEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageEdit.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void BtnProEdit_Click(object sender, EventArgs e)
        {
            Update_Product();
        }

        //---------------------------------------------search product----------------------------------------------
        private void TxtProductSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchText = TxtProductSearch.Text;
            string Command = @"
                                SELECT 
                                    p.Pro_Id, 
                                    p.Pro_Name AS [إسم المنتج], 
                                    p.Qty AS [الكمية], 
                                    p.Buy_Price AS [سعر الشراء], 
                                    p.Barcode AS [الباركود], 
                                    p.Retail_Price AS [سعر البيع بالتجزئة], 
                                    p.PriceShow AS [سعر العرض],
                                    p.MaxDiscount AS [التخفيض],
                                    p.MinQty AS [الكمية الصغرى], 
                                    c.Group_Name AS [التصنيف]
                                FROM Products p
                                INNER JOIN Products_Group c ON p.IdCategorie = c.Group_Id
                                WHERE 
                                    p.Pro_Name LIKE @Search_value OR
                                    p.Barcode LIKE @Search_value OR
                                    c.Group_Name LIKE @Search_value
                                ORDER BY p.Pro_Id";

            SqlParameter[] LikeParameters = new SqlParameter[]
            {
                new SqlParameter("@Search_value", $"%{SearchText}%")
            };

            dataGridViewProduct.DataSource = model.LoadData(Command, LikeParameters);
            dataGridViewProduct.Columns["Pro_Id"].Visible = false;
            dataGridViewProduct.Refresh();
        }

        //---------------------------------------------auxailiry functions------------------------------------------------
        public void Refresh_DataGrid()
        {
            string Command = "SELECT p.Pro_Id, p.Pro_Name AS [إسم المنتج], p.Qty AS [الكمية], " +
                      "p.Buy_Price AS [سعر الشراء], " +
                      "p.Barcode AS [الباركود], p.Retail_Price AS [سعر البيع بالتجزئة],  p.PriceShow AS [سعر العرض]," +
                      "p.MaxDiscount AS [التخفيض], p.MinQty AS [الكمية الصغرى], " +
                      "c.Group_Name AS [التصنيف] " +
                      "FROM Products p " +
                      "INNER JOIN Products_Group c ON p.IdCategorie = c.Group_Id " +
                      "ORDER BY p.Pro_Id";

            FormUtilities.RefreshDataGrid(dataGridViewProduct, model.LoadData(Command, null), "Pro_Id");
            FormUtilities.ClearFields(this);
        }


        public void Insert_Product()
        {
            if (TxtProName.Text == "" || TxtProBuyPrice.Text == "" || TxtProPriceRetails.Text == ""
                || TxtProQty.Text == "" || txtProPriceShow.Text == ""
               || TxtProDiscount.Text == "" || TxtProMinQty.Text == "")
            {
                MessageBox.Show("يجب عليك ملئ جميع الحقول.",
                                "تحذير أحد الحقول فارغة",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            MemoryStream stream = new MemoryStream();
            byte[] pic = null;

            ProPicture.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic = stream.ToArray();

            model.InsertRecord("Products", new SqlParameter[]
            {
                    new SqlParameter("@Pro_Name", TxtProName.Text),
                    new SqlParameter("@Buy_Price", TxtProBuyPrice.Text),
                    new SqlParameter("@Retail_Price", TxtProPriceRetails.Text),
                    new SqlParameter("@Wholesell_Price", "0"),
                    new SqlParameter("@Profit", "0"),
                    new SqlParameter("@Qty", TxtProQty.Text),
                    new SqlParameter("@MaxDiscount", TxtProDiscount.Text),
                    new SqlParameter("@MinQty", TxtProMinQty.Text),
                    new SqlParameter("@Barcode", brc),
                    new SqlParameter("@Pro_Image", pic),
                    new SqlParameter("@IdCategorie", CBxCategorie.SelectedValue),
                    new SqlParameter("@PriceShow", txtProPriceShow.Text)

            });
            
            Refresh_DataGrid();
            ProPicture.Image = Properties.Resources.EmptyImage;
            tabProduct.SelectTab(tabProductShow);
            
        }

        public void Update_Product()
        {
            if (TxtEditProName.Text == "" || TxtProBuyPriceEdit.Text == "" || TxtProPriceRetailsEdit.Text == ""
                || TxtEditProQty.Text == "" || txtProPriceShowEdit.Text == ""
                || TxtProDiscountEdit.Text == "" || TxtEditProMinQty.Text == "" )
            {
                MessageBox.Show("يجب عليك ملئ جميع الحقول.",
                                "تحذير أحد الحقول فارغة",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pro_id = SelectedRow.Cells["Pro_Id"].Value.ToString();
            byte[] pic = null;

            List<SqlParameter> updateParameters = new List<SqlParameter>
            {
                new SqlParameter("@Pro_Name", TxtEditProName.Text),
                new SqlParameter("@Buy_Price", TxtProBuyPriceEdit.Text),
                new SqlParameter("@Retail_Price", TxtProPriceRetailsEdit.Text),
                new SqlParameter("@Wholesell_Price", "0"),
                new SqlParameter("@Profit", "0"),
                new SqlParameter("@Qty", TxtEditProQty.Text),
                new SqlParameter("@MaxDiscount", TxtProDiscountEdit.Text),
                new SqlParameter("@MinQty", TxtEditProMinQty.Text),
                new SqlParameter("@Barcode", brc_edit),
                new SqlParameter("@IdCategorie", CBxCategorieEdit.SelectedValue),
                new SqlParameter("@PriceShow", txtProPriceShowEdit.Text)
            };

            if (ImageEdit.Image != null && !ImageEdit.Image.Equals(previousImage))
            {
                using (MemoryStream stream = new MemoryStream())
                {

                    ImageEdit.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    pic = stream.ToArray();
                    updateParameters.Add(new SqlParameter("@Pro_Image", pic));

                }
            }

            SqlParameter[] whereParameters = new SqlParameter[] {
                new SqlParameter("@ProId", pro_id)
            };

            model.UpdateRecord("Products", "Pro_Id = @ProId", updateParameters.ToArray(), whereParameters);
            Refresh_DataGrid();
            ImageEdit.Image = Properties.Resources.EmptyImage;
            tabProduct.SelectTab(tabProductShow);
            
        }

        private byte[] GetProductImageById(int productId)
        {
            string query = "SELECT Pro_Image FROM Products WHERE Pro_Id = @Pro_Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Pro_Id", productId)
            };

            DataTable result = model.LoadData(query, parameters);

            if (result.Rows.Count > 0 && result.Rows[0]["Pro_Image"] != DBNull.Value)
            {
                byte[] imageData = (byte[])result.Rows[0]["Pro_Image"];
                return imageData;
            }

            return null;
        }

        string brc, brc_edit;
        private void tabProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (tabProduct.SelectedTab == tabProductAdd)
                {
                    Insert_Product();
                }
                else if (tabProduct.SelectedTab == tabProductEdit)
                {
                    Update_Product();
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BtnUnitPro_Click(object sender, EventArgs e)
        {
            frm_Unit frm = new frm_Unit();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Store frm = new frm_Store();
            frm.ShowDialog();
        }

        private void BtnGroups_Click(object sender, EventArgs e)
        {
            frm_ProductGroup frm = new frm_ProductGroup();  
            frm.ShowDialog();
        }

        private void BtnBarCode_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.Rows.Count >= 1) 
            {

                Properties.Settings.Default.Pro_Name = TxtEditProName.Text ;
                Properties.Settings.Default.Pro_Price= Convert.ToDecimal(TxtProPriceRetailsEdit.Text) ;
                Properties.Settings.Default.Pro_Barcode = TxtProBarcodeEdit.Text ;
                Properties.Settings.Default.Save();
                frm_BarcodePrinting frm = new frm_BarcodePrinting();
                frm.ShowDialog();

                

            }
            
        }

        private void TxtProBarcodeEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                brc_edit = TxtProBarcodeEdit.Text.Trim();
            }
        }

     

        private void TxtProBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                brc = TxtProBarcode.Text.Trim();
            }
        }
    }
}
