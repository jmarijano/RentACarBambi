using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BambiFactory
{
    public interface IDatabase
    {
        /// <summary>
        /// Interface method that creates
        /// a connection to the database.
        /// </summary>
        /// <returns></returns>
        IDbConnection CreateConnection();
    }
}
