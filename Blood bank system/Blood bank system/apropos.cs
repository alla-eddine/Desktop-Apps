using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Blood_bank_system.Models;
using Blood_bank_system.Db;
using System.Data.Odbc;

namespace Blood_bank_system
{
    public partial class apropos : UserControl
    {
        public DatabaseConnection model;
        public apropos()
        {
            InitializeComponent();
            model = new DatabaseConnection();
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Text = "0%";
        }

        private void GmailBox_Click(object sender, EventArgs e)
        {
            string email = "mailto:damani.alaaeddine@gmail.com";
            Process.Start(new ProcessStartInfo(email) 
            { 
                UseShellExecute = true
            });
        }

        private void GithubBox_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.github.com/alla-eddine") 
            {
                UseShellExecute = true 
            });
        }

        private void TwitterBox_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://twitter.com/d_allaeddine")
            {
                UseShellExecute = true
            });
        }

        private void ResearchGateBox_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.researchgate.net/profile/Allaeddine-Damani")
            {
                UseShellExecute = true
            });
        }




        private async void ExpDbBtn_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Text = "0%";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                saveFileDialog.Title = "Save Database Backup";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = saveFileDialog.FileName;

                    var progress = new Progress<int>(value =>
                    {
                        progressBar.Value = value;
                        progressBar.Text = $"{value}%\n";
                        if (value == 100)
                            progressBar.Text += "DB exporté\navec\nsuccès!";
                    });
                    await Task.Run(() => SaveDatabaseBackup(backupPath, progress));
                }
            }
        }

        private void SaveDatabaseBackup(string backupPath, IProgress<int> progress)
        {
            string databaseName = "bloodbanksystem";
            string query = $@"
                BACKUP DATABASE [{databaseName}] 
                TO DISK = @backupPath
                WITH FORMAT, INIT, NAME = '{databaseName} Backup'";

            using (SqlConnection connection = model.CreateConnection())
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
            progressBar.Text = "0%";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                openFileDialog.Title = "Select Database Backup";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = openFileDialog.FileName;
                    var progress = new Progress<int>(value =>
                    {
                        progressBar.Value = value;
                        progressBar.Text = $"{value}%\n";
                        if (value == 100)
                            progressBar.Text += "DB importé\navec\nsuccès!";
                    });
                    await Task.Run(() => LoadDatabaseBackup(backupPath, progress));
                }
            }
        }

        private void LoadDatabaseBackup(string backupPath, IProgress<int> progress)
        {
            string databaseName = "bloodbanksystem";
            string restoreQuery = $@"
                USE master;
                ALTER DATABASE [{databaseName}]
                SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

                RESTORE DATABASE [{databaseName}]
                FROM DISK = @backupPath
                WITH REPLACE;

                ALTER DATABASE [{databaseName}]
                SET MULTI_USER;";

            using (SqlConnection connection = model.CreateConnection())
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

        private async void EmptyDbBtn_Click(object sender, EventArgs e)
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
        }





    }

}


