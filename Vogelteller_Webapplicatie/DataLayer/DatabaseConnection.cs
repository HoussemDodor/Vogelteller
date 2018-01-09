using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DatabaseConnection
    {
        private const string connectionString = "";

        public SqlConnection Connect()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn;
            }
        }
    }
}
