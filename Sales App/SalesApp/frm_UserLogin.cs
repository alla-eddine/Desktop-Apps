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
    public partial class frm_UserLogin : Form
    {
        DatabaseClass db = new DatabaseClass();
        public frm_UserLogin()
        {
            InitializeComponent();
            txtUserName.Select();
        }
        
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string utype = cbxUsers.Text;
            Properties.Settings.Default.USerType = utype;

            if (AuthenticateUser(username, password, utype))
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Properties.Settings.Default.UserName = txtUserName.Text.Trim();
                Properties.Settings.Default.Save();
                Form1 mainForm = new Form1(); 
                mainForm.Show();
            }
            else
            {
                lblMessage.Text = "اسم مستخدم او كلمة السر خاطئة";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool AuthenticateUser(string Username, string Password, string userType)
        {
            using (SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=sales;Trusted_Connection=True;"))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE User_Name = @Username AND User_Password = @Password" +
                               " And User_Type = @User_Type";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@User_Type", userType);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool checkDatabase()
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True"))

                using (SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE name = 'sales'", Conn))
                {
                    Conn.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking database: " + ex.Message, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void CreateDatabase()
        {
            if (!checkDatabase())
            {
                try
                {
                    string filePath = Path.Combine(Application.StartupPath, "SalesApp.sql");
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("SQL script file not found at: " + filePath, "File Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var fileContent = File.ReadAllText(filePath);
                    var sqlQueries = fileContent.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                    using (var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True"))
                    {
                        con.Open();
                        foreach (var query in sqlQueries)
                        {
                            using (var cmd = new SqlCommand(query, con))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Database created successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating database: " + ex.Message, "Database Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_UserLogin_Load(object sender, EventArgs e)
        {
            CreateDatabase();
            txtUserName.Focus();
        }

        private void frm_UserLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogIn_Click(this, EventArgs.Empty);
            }
        }

    }
}
