using BambiDataAccess;
using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using BambiFactory;

namespace BambiSQLServerDataAccess
{
    public class TownSQLServerDataAccess : ITownRepository
    {
        private readonly IDbConnection _connection;

        public TownSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public TownSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(TownModel model)
        {
            string sqlDelete = "DELETE FROM Town WHERE ZipCode = @ZipCode";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<TownModel> GetAll()
        {
            string sqlGetAll = "SELECT ZipCode, Name, CountryId  FROM Town";
            using (_connection)
            {
                return _connection.Query<TownModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(TownModel model)
        {
            string sqlInsert = "INSERT INTO Town (ZipCode, Name, CountryId)" +
                " Values (@ZipCode, @Name, @CountryId)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(TownModel model)
        {
            string sqlUpdate = "UPDATE Town SET Name = @Name, CountryId = @CountryId WHERE ZipCode = @ZipCode";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
