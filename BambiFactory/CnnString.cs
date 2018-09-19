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
        public static string GetConnectionString() {
            return ConfigurationManager.ConnectionStrings["BambiSQLServer"].ConnectionString;
        }
    }
}
