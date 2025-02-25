using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_bank_system.Db
{
    public abstract class DbConnection
    {

        private readonly string connectionString;

        public DbConnection()
        {
            //connectionString = @"Server=localhost;Database=bloodbanksystem;Trusted_Connection=True;";
            connectionString = @"Server=.\SQLEXPRESS;Database=bloodbanksystem;Trusted_Connection=True;";

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
     }
}
