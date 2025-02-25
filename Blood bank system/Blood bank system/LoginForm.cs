using System;
using System.Collections.Generic;
using System.ComponentModel;
using Blood_bank_system.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Blood_bank_system
{
    public partial class LoginForm : Form
    {
        private DonorsClass model;
        public LoginForm()
        {
            InitializeComponent();
            RadioUser.Checked = true;
            model = new DonorsClass();
        }
       
        private void Connect_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string user_type;
            if (RadioAdmin.Checked == true)
            {
                user_type = "adminstrateur";
                string Command = "select * from users where user_name = '" + UserName.Text + "' " +
                    " and user_password = '" + Password.Text + "' and user_type = '" + user_type + "'";
                dt = model.LoadDataTable(Command);
                if (dt.Rows.Count >= 1)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Veuillez entrer les informations correctement.");

                }
            }


            else if (RadioUser.Checked == true)
            {
                user_type = "utilisateur";
                string Command = "select * from users where user_name = '" + UserName.Text + "' " +
                    " and user_password = '" + Password.Text + "' and user_type = '" + user_type + "'";
                dt = model.LoadDataTable(Command);
                if (dt.Rows.Count >= 1)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Usersbtn.Visible = false;
                    frm.SettingsBtn.Visible = false;
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Veuillez entrer les informations correctement.");

                }
            }

        }



        private bool checkDatabase()
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True"))
                
                using (SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE name = 'bloodbanksystem'", Conn))
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
                    string filePath = Path.Combine(Application.StartupPath, "bloodbanksystem.sql");
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



        private void LoginForm_Load(object sender, EventArgs e)
        {
            CreateDatabase();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 
                Connect_Click(this, EventArgs.Empty);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
