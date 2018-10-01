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
    public class SQLServerConnection : IDatabase
    {
        /// <summary>
        /// Private readonly variable in 
        /// which the connection string
        /// is stored.
        /// </summary>
        private readonly string connectionString;

        /// <summary>
        /// Constructor whose purpose is to set 
        /// the private readonly variable value.
        /// </summary>
        public SQLServerConnection()
        {
            connectionString = CnnString.GetConnectionString();
        }

        /// <summary>
        /// Implementation of IDatabase inteface 
        /// method CreateConnection. 
        /// </summary>
        /// <returns>Returns new SQL Server 
        /// IDbConnection object.</returns>
        public IDbConnection CreateConnection()
        {
            IDbConnection output = new SqlConnection(connectionString);
            return output;
        }
    }
}
