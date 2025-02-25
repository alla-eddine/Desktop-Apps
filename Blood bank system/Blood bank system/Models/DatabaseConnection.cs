using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_bank_system.Db;

namespace Blood_bank_system.Models
{
    public class DatabaseConnection : DbConnection
    {
        public SqlConnection CreateConnection()
        {
            return GetConnection(); 
        }
    }
}

