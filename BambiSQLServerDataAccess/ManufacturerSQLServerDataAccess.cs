using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BambiDataAccess;
using BambiModels;
using Dapper;
using BambiFactory;
using System.Data.SqlClient;
using System.Data;

namespace BambiSQLServerDataAccess
{
    public class ManufacturerSQLServerDataAccess : IManufacturerRepository
    {
        private IDbConnection _connection;
        
        
        public ManufacturerSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public void Insert(ManufacturerModel manufacturer)
        {
            using (_connection)
            {
                _connection.Query<ManufacturerModel>("SELECT * FROM Manufacturer");
            }
        }
    }
}
