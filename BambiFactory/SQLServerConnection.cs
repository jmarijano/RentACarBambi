using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace BambiFactory
{
    class SQLServerConnection : IDatabase
    {
        private readonly string connectionString;
        public SQLServerConnection()
        {
            connectionString = CnnString.GetConnectionString();
        }
        public IDbConnection CreateConnection()
        {
            IDbConnection output = new SqlConnection(connectionString);
            return output;
        }
    }
}
