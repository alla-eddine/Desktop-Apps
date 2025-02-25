using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

public class DatabaseClass
{
    // Private static connection string field
    /*private static readonly string _connectionString = @"Server=localhost;Database=sales;Trusted_Connection=True;";*/
    private static readonly string _connectionString = @"Server=.\SQLEXPRESS;Database=sales;Trusted_Connection=True;";
    SqlConnection conn = new SqlConnection(_connectionString);
    SqlCommand cmd = new SqlCommand();
    // Constructor without parameters since the connection string is already defined
    public DatabaseClass()
    {
        // Optional: any initialization logic

    }

    // Method to establish and retrieve a database connection
    public SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }



    


    public DataTable readData(string stmt, string message)
    {
        DataTable tbl = new DataTable();
        try
        {
            cmd.Connection = conn;
            cmd.CommandText = stmt;
            conn.Open();
            //load data from database to tbl 
            tbl.Load(cmd.ExecuteReader());

            conn.Close();
            if (message != "")
            {
                MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }


        return tbl;
    }

    public bool exceuteData(string stmt, string message)
    {
        try
        {
            cmd.Connection = conn;
            cmd.CommandText = stmt;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            if (message != "")
            {
                MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            conn.Close();
        }

    }

    

    // Method to load data using a SELECT query with SQL parameters
    public DataTable LoadData(string query, SqlParameter[] parameters = null)
    {
        DataTable dataTable = new DataTable();
        using (SqlConnection connection = GetConnection())
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
        }
        return dataTable;
    }

    // Method to execute a non-query command (INSERT, UPDATE, DELETE) with SQL parameters
    public int ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        int rowsAffected;
        using (SqlConnection connection = GetConnection())
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            connection.Open();
            rowsAffected = command.ExecuteNonQuery();
        }
        return rowsAffected;
    }

    // Method to insert a new record with parameters
    public int InsertRecord(string tableName, SqlParameter[] parameters)
    {
        // Filter out parameters where the value is null or DBNull.Value
        var validParameters = parameters.Where(p => p.Value != null && p.Value != DBNull.Value).ToList();

        // Generate column names and parameter names
        string columnNames = string.Join(", ", validParameters.Select(p => p.ParameterName.Substring(1))); // Remove the '@'
        string parameterNames = string.Join(", ", validParameters.Select(p => p.ParameterName));

        // Construct the query
        string query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames})";

        // Execute the query with valid parameters
        return ExecuteQuery(query, validParameters.ToArray());

        
    }


    // Method to update a record with parameters
    public int UpdateRecord(string tableName, string condition, SqlParameter[] parameters, SqlParameter[] whereParameters)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            // Filter out parameters where the value is null or DBNull.Value
            var validParameters = parameters.Where(p => p.Value != null && p.Value != DBNull.Value).ToArray();

            // Generate the SET clause of the SQL statement
            string setClause = string.Join(", ", validParameters.Select(p => $"{p.ParameterName.Substring(1)} = {p.ParameterName}"));

            // Construct the SQL UPDATE statement
            string sql = $"UPDATE {tableName} SET {setClause} WHERE {condition}";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // Add parameters for the SET clause
                command.Parameters.AddRange(validParameters);

                // Add parameters for the WHERE clause
                if (whereParameters != null)
                    command.Parameters.AddRange(whereParameters);

                return command.ExecuteNonQuery();
            }
        }
    }




    // Method to delete a record with parameters
    public int DeleteRecord(string tableName, string whereClause, SqlParameter[] parameters = null)
    {
        string query = $"DELETE FROM {tableName} WHERE {whereClause}";
        return ExecuteQuery(query, parameters);
    }

    

    public int UpdateRecordMulltipleCondition( string tableName, SqlParameter[] parameters, Dictionary<string, object> conditions)
    {
        if (string.IsNullOrWhiteSpace(tableName))
            throw new ArgumentException("Table name cannot be null or empty.", nameof(tableName));

        if (parameters == null || parameters.Length == 0)
            throw new ArgumentException("No parameters provided for the update operation.", nameof(parameters));

        if (conditions == null || conditions.Count == 0)
            throw new ArgumentException("At least one condition is required.", nameof(conditions));

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            // Filter and validate parameters for the SET clause
            var validParameters = parameters
                .Where(p => p != null && p.ParameterName.StartsWith("@"))
                .ToArray();

            if (!validParameters.Any())
                throw new ArgumentException("No valid parameters provided for the update operation.");

            // Generate the SET clause
            string setClause = string.Join(", ", validParameters.Select(p => $"{p.ParameterName.Substring(1)} = {p.ParameterName}"));

            // Generate the WHERE clause from conditions
            var conditionParameters = conditions
                .Select((kvp, index) => new SqlParameter($"@cond{index}", kvp.Value))
                .ToArray();

            string whereClause = string.Join(" AND ", conditions.Keys.Select((key, index) => $"{key} = @cond{index}"));

            // Construct the SQL UPDATE statement
            string sql = $"UPDATE [{tableName}] SET {setClause} WHERE {whereClause}";

            try
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add parameters for the SET clause
                    command.Parameters.AddRange(validParameters);

                    // Add parameters for the WHERE clause
                    command.Parameters.AddRange(conditionParameters);

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new InvalidOperationException("An error occurred while updating the record.", ex);
            }
        }
    }


}


// Method to update a table with a multiple condition.
// 










/*using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseClass
{
    private readonly string _connectionString;

    // Constructor that accepts the connection string
    public DatabaseClass(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Method to establish and retrieve a database connection
    private SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }

    // Method to load data using a SELECT query with SQL parameters
    public DataTable LoadData(string query, SqlParameter[] parameters = null)
    {
        DataTable dataTable = new DataTable();
        using (SqlConnection connection = GetConnection())
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
        }
        return dataTable;
    }

    // Method to execute a non-query command (INSERT, UPDATE, DELETE) with SQL parameters
    public int ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        int rowsAffected;
        using (SqlConnection connection = GetConnection())
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            connection.Open();
            rowsAffected = command.ExecuteNonQuery();
        }
        return rowsAffected;
    }

    // Method to insert a new record with parameters
    public int InsertRecord(string tableName, SqlParameter[] parameters)
    {
        string query = $"INSERT INTO {tableName} VALUES ({string.Join(", ", parameters.Select(p => p.ParameterName))})";
        return ExecuteQuery(query, parameters);
    }

    // Method to update a record with parameters
    public int UpdateRecord(string tableName, string whereClause, SqlParameter[] parameters)
    {
        string setClause = string.Join(", ", parameters.Select(p => $"{p.ParameterName.Substring(1)} = {p.ParameterName}"));
        string query = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";
        return ExecuteQuery(query, parameters);
    }

    // Method to delete a record with parameters
    public int DeleteRecord(string tableName, string whereClause, SqlParameter[] parameters = null)
    {
        string query = $"DELETE FROM {tableName} WHERE {whereClause}";
        return ExecuteQuery(query, parameters);
    }
}
*/