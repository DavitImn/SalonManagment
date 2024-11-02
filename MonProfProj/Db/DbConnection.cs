using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProfProj.Db
{
    public class DbConnection
    {
        private readonly string _connectionString;
        public DbConnection()
        {
            _connectionString = @"Data Source=WIN-GJRGE8N8QQF;Initial Catalog=SalonDb;Integrated Security=True;";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }



    }
}