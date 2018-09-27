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

        public int Delete(ManufacturerModel manufacturer)
        {
            string sqlDelete = "DELETE FROM Manufacturer WHERE Id = @Id";
            using (_connection)
            {
               return _connection.Execute(sqlDelete, manufacturer);
            }
        }

        public IList<ManufacturerModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name FROM Manufacturer";
            using (_connection)
            {
                return _connection.Query<ManufacturerModel>(sqlGetAll).ToList();
                
            }
        }

        public int Insert(ManufacturerModel manufacturer)
        {
            string sqlInsert = "INSERT INTO Manufacturer (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert,manufacturer);
            }
        }

        public int Update(ManufacturerModel manufacturer)
        {
            string sqlUpdate = "UPDATE Manufacturer SET Name = @Name WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, manufacturer);
            }
        }
    }
}
