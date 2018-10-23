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
    
    /// <summary>
    /// Represents an apstract object whose purpose
    /// is to establish database connection.
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Interface method that creates
        /// a connection to the database.
        /// </summary>
        /// <returns>
        /// Returns IDbConnection object.
        /// </returns>
        IDbConnection CreateConnection();
    }
}
