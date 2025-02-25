using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Web;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace SalesApp
{
    public partial class FormSetting : Form
    {
        public DatabaseClass model;
        public FormSetting()
        {
            InitializeComponent();

            model = new DatabaseClass();

            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBarText.Text = "0%";

            progressBar.Visible = false;
            progressBarText.Visible = false;


        }













        private async void ExpDbBtn_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBarText.Text = "0%";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                saveFileDialog.Title = "Save Database Backup";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = saveFileDialog.FileName;

                    var progress = new Progress<int>(value =>
                    {
                        progressBar.Visible = true;
                        progressBarText.Visible = true;
                        progressBar.Value = value;
                        progressBarText.Text = $"{value}% ";
                        if (value == 100)
                            progressBarText.Text += "تم الحفظ بنجاح";
                    });
                    await Task.Run(() => SaveDatabaseBackup(backupPath, progress));
                }
            }
        }

        private void SaveDatabaseBackup(string backupPath, IProgress<int> progress)
        {
            string databaseName = "sales";
            string query = $@"
                BACKUP DATABASE [{databaseName}] 
                TO DISK = @backupPath
                WITH FORMAT, INIT, NAME = '{databaseName} Backup'";

            using (SqlConnection connection = model.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@backupPath", backupPath);

                    try
                    {
                        progress?.Report(10);
                        connection.Open();
                        progress?.Report(50);
                        command.ExecuteNonQuery();
                        progress?.Report(100);
                    }
                    catch (Exception ex)
                    {
                        progress?.Report(0);
                        progressBar.Invoke((MethodInvoker)(() =>
                        {
                            progressBar.Text = $"Error: {ex.Message}";
                        }));
                    }
                }
            }
        }

        private async void ImpDbBtn_Click(object sender, EventArgs e)
        {
            
            

            progressBar.Value = 0;
            progressBarText.Text = "0%";



            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                openFileDialog.Title = "Select Database Backup";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = openFileDialog.FileName;

                    var progress = new Progress<int>(value =>
                    {

                        progressBar.Visible = true;
                        progressBarText.Visible = true;

                        progressBar.Value = value;
                        progressBarText.Text = $"{value}% ";
                        if (value == 100)
                            progressBarText.Text += "تم التحميل بنجاح";
                    });
                    await Task.Run(() => LoadDatabaseBackup(backupPath, progress));
                }
            }
        }

        private void LoadDatabaseBackup(string backupPath, IProgress<int> progress)
        {
            string databaseName = "sales";
            string restoreQuery = $@"
                USE master;
                ALTER DATABASE [{databaseName}]
                SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

                RESTORE DATABASE [{databaseName}]
                FROM DISK = @backupPath
                WITH REPLACE;

                ALTER DATABASE [{databaseName}]
                SET MULTI_USER;
            ";

            using (SqlConnection connection = model.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                {
                    command.Parameters.AddWithValue("@backupPath", backupPath);

                    try
                    {
                        progress?.Report(10);
                        connection.Open();
                        progress?.Report(50);
                        command.ExecuteNonQuery();
                        progress?.Report(100);
                    }
                    catch (Exception ex)
                    {
                        progress?.Report(0);
                        progressBar.Invoke((MethodInvoker)(() =>
                        {
                            progressBar.Text = $"Error: {ex.Message}";
                        }));
                    }
                }
            }
        }



        /*private async void EmptyDbBtn_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Text = "0%";

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir vider la base des donnes ?",
                                        "Confirmer la suppression des informations",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var progress = new Progress<int>(value =>
                {
                    progressBar.Value = value;
                    progressBar.Text = $"{value}%\n";
                    if (value == 100)
                        progressBar.Text += "DB vidée\navec\nsuccès!";
                });
                await Task.Run(() => EmptyDatabase(progress));
            }
        }

        private void EmptyDatabase(IProgress<int> progress)
        {
            using (SqlConnection connection = model.CreateConnection())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM donors", connection))
                {
                    try
                    {
                        progress?.Report(10);
                        connection.Open();
                        progress?.Report(50);
                        command.ExecuteNonQuery();
                        progress?.Report(100);
                    }
                    catch (Exception ex)
                    {
                        progress?.Report(0);
                        progressBar.Invoke((MethodInvoker)(() =>
                        {
                            progressBar.Text = $"Error: {ex.Message}";
                        }));
                    }
                }
            }
        }*/
















        DatabaseClass db = new DatabaseClass();
        string printerName = "";

        private void FormSetting_Load(object sender, EventArgs e)
        {
            try
            {
                showPrinters();
            }
            catch (Exception) { }
            try
            {
                showOrderData();
            }
            catch (Exception) { }
            try
            {
                showGeneralSetting();
            }
            catch(Exception) { }
        }

        private void btnSavePrinter_Click(object sender, EventArgs e)
        {
            if(cbxPrinter.Text == "")
            {
                MessageBox.Show("من فضلك اختر طابعة معينة", "تأكيد");
                return;
            }
            else
            {
                Properties.Settings.Default.PrinterName = cbxPrinter.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("تم الحفظ بنجاح", "تأكيد");
            }
        }
        private void showPrinters()
        {
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                printerName = PrinterSettings.InstalledPrinters[i];
                cbxPrinter.Items.Add(printerName);
            }

            if (Properties.Settings.Default.PrinterName == "")
            {
                cbxPrinter.SelectedIndex = 0;
            }
            else
            {
                cbxPrinter.Text = Properties.Settings.Default.PrinterName;
            }
        }


        private void showOrderData()
        {
            tbl.Clear();
            tbl = db.readData("select * from OrderPrintData", "");

            if (tbl.Rows.Count >= 1)
            {
                txtNameStore.Text = tbl.Rows[0][1].ToString();
                txtAdressStore.Text = tbl.Rows[0][2].ToString();
                txtDesciption.Text = tbl.Rows[0][3].ToString();
                txtPhone.Text = tbl.Rows[0][4].ToString();
               
            }

            try
            {
                //retrive image from DB
                Byte[] byteimage = new Byte[0];
                byteimage = (Byte[])(tbl.Rows[0][0]);
                MemoryStream memoryStream = new MemoryStream(byteimage);
                pictureLogo.BackgroundImageLayout = ImageLayout.Stretch;

                pictureLogo.BackgroundImage = Image.FromStream(memoryStream);

            }
            catch (Exception)
            {

            }
        }


        string imagePath = "";
        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*) | *.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName.ToString();
                pictureLogo.Image = null;
                pictureLogo.ImageLocation = imagePath;
            }

        }

        private void BtnDeleteImage_Click(object sender, EventArgs e)
        {
            pictureLogo.BackgroundImage = null;
            pictureLogo.Image = null;
            imagePath = "";
        }
        private void saveImage(string stmt, string parameterName,string message)
        {
            SqlConnection conn = new SqlConnection(@"Server=ALLAEDDINE\SQLEXPRESS;Database=sales;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand(stmt, conn);

            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);

            byte[] bytestream = new byte[fileStream.Length];

            fileStream.Read(bytestream, 0, bytestream.Length);
            fileStream.Close();

            SqlParameter parameter = new SqlParameter(parameterName, SqlDbType.VarBinary, bytestream.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream);

            cmd.Parameters.Add(parameter);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            if (message != null) 
            {
                MessageBox.Show(message,"تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        DataTable tbl = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {

            if(imagePath == "")
            {
                MessageBox.Show("من فضلك اختر شعار للمحل");
                return;
            }
            tbl.Clear();
            tbl = db.readData("select * from OrderPrintData","");

            if(tbl.Rows.Count >= 1)
            {
                saveImage("update OrderPrintData set Logo = @Logo, Name =  N'" + txtNameStore.Text + "' , Address = N'" + txtAdressStore.Text + "', Description = '" + txtDesciption.Text + "', Phone = '" + txtPhone.Text + "' ", "@Logo", "تم الحفظ بنجاح");
            }
            else
            {
                saveImage("insert into OrderPrintData values (@Logo, N'" + txtNameStore.Text + "' ,N'" + txtAdressStore.Text + "', '" + txtDesciption.Text + "', '" + txtPhone.Text + "') ", "@Logo", "تم الحفظ بنجاح");

            }
            imagePath = "";

        }

        private void btnSaveGenral_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SalePrintNum = Convert.ToInt32(NudSaleNumber.Value);
            Properties.Settings.Default.BuyPrintNum= Convert.ToInt32(NudBuyNumber.Value);

            

            if (checkSalePrint.Checked == true)
                Properties.Settings.Default.SalesPrint = true;
            else
                Properties.Settings.Default.SalesPrint = false;

            if (checkBuyPrint.Checked == true)
                Properties.Settings.Default.BuyPrint = true;
            else
                Properties.Settings.Default.BuyPrint = false;

            if (rbtn8cmSales.Checked == true)
            {
                Properties.Settings.Default.SalePrintKind = "8CM";
            }
            else if (rbtnA4Sales.Checked == true)
            {
                Properties.Settings.Default.SalePrintKind = "A4";
            }

            if (rbtn8cmBuy.Checked == true)
            {
                Properties.Settings.Default.BuyPrintKind = "8CM";
            }
            else if (rbtnA4Buy.Checked == true)
            {
                Properties.Settings.Default.BuyPrintKind = "A4";
            }


            Properties.Settings.Default.Save();

            MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void showGeneralSetting()
        {
            


            NudSaleNumber.Value = Properties.Settings.Default.SalePrintNum;
            NudBuyNumber.Value = Properties.Settings.Default.BuyPrintNum;

            

            

            if (Properties.Settings.Default.SalesPrint == true)
                checkSalePrint.Checked = true;
            else
                checkSalePrint.Checked = false;

            if (Properties.Settings.Default.BuyPrint == true)
                checkBuyPrint.Checked = true;
            else
                checkBuyPrint.Checked = false;

            if (Properties.Settings.Default.SalePrintKind == "8CM")
            {
                rbtn8cmSales.Checked = true;
            }
            else if (Properties.Settings.Default.SalePrintKind == "A4")
            {
                rbtnA4Sales.Checked = true;
            }

            if (Properties.Settings.Default.BuyPrintKind == "8CM")
            {
                rbtn8cmBuy.Checked = true;
            }
            else if (Properties.Settings.Default.BuyPrintKind == "A4")
            {
                rbtnA4Buy.Checked = true;
            }
        }


    }
}
