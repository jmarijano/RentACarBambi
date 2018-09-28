using BambiDataAccess;
using BambiModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using BambiFactory;

namespace BambiSQLServerDataAccess
{
    public class CountrySQLServerDataAccess : ICountryRepository
    {
        private readonly IDbConnection _connection;

        public CountrySQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public CountrySQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(CountryModel model)
        {
            string sqlDelete = "DELETE FROM Country WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<CountryModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name FROM Country";
            using (_connection)
            {
                return _connection.Query<CountryModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(CountryModel model)
        {
            string sqlInsert = "INSERT INTO Country (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(CountryModel model)
        {
            string sqlUpdate = "UPDATE Country SET Name = @Name WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
