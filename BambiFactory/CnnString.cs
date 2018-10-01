using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BambiFactory
{
    public static class CnnString
    {
        /// <summary>
        /// Static method which returns the
        /// database connection string.
        /// </summary>
        /// <returns>Returns the connection string 
        /// of the database</returns>
        public static string GetConnectionString() {
            return ConfigurationManager.ConnectionStrings["BambiSQLServer"].ConnectionString;
        }
    }
}
