using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Blood_bank_system.Db;
using System.Data;
using System.Windows.Forms;

namespace Blood_bank_system.Models
{
    public class DonorsClass : DbConnection
    {
        // Load data with an optional parameterized query
        public DataTable LoadDataTable(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Database Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        // Execute a command with an optional parameterized query
        public bool ExecuteData(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Database Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
