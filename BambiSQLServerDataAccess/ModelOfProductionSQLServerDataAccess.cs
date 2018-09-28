using BambiDataAccess;
using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BambiFactory;
using Dapper;
using System.Data;

namespace BambiSQLServerDataAccess
{
    public class ModelOfProductionSQLServerDataAccess : IModelOfProductionRepository
    {
        private readonly IDbConnection _connection;

        public ModelOfProductionSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public ModelOfProductionSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(ModelOfProductionModel model)
        {
            string sqlDelete = "DELETE FROM ModelOfProduction WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<ModelOfProductionModel> GetAll()
        {
            string sql = "SELECT Id, Name, ManufacturerId FROM ModelOfProduction";
            using (_connection)
            {
                return _connection.Query<ModelOfProductionModel>(sql).ToList();
            }
        }

        public int Insert(ModelOfProductionModel model)
        {
            string sqlInsert = "INSERT INTO ModelOfProduction (Id, Name, ManufacturerId)" +
                " Values (@Id, @Name, @ManufacturerId)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(ModelOfProductionModel model)
        {
            string sqlUpdate = "UPDATE ModelOfProduction SET Name = @Name," +
                " ManufacturerId = @ManufacturerId WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
