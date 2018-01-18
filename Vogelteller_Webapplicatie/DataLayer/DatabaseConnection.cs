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
        private const string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi365095;Persist Security Info=True;User ID=dbi365095;Password=Blyker887";

        public SqlConnection Connect
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);

                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    connection.Close();
                }
                return connection;
            }
            set
            {
                Connect = value;
            }
        }
    }
}
