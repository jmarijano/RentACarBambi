using BambiDataAccess;
using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using BambiFactory;

namespace BambiSQLServerDataAccess
{
    public class EngineTypeSQLServerDataAccess : IEngineTypeRepository
    {
        private readonly IDbConnection _connection;
        public EngineTypeSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public EngineTypeSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(EngineTypeModel model)
        {
            string sqlDelete = "DELETE FROM EngineType WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<EngineTypeModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name FROM EngineType";
            using (_connection)
            {
                return _connection.Query<EngineTypeModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(EngineTypeModel model)
        {
            string sqlInsert = "INSERT INTO EngineType (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(EngineTypeModel model)
        {
            string sqlUpdate = "UPDATE EngineType SET Name = @Name WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
