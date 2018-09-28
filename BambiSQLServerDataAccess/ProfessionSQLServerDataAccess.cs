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
    public class ProfessionSQLServerDataAccess : IProfessionRepository
    {
        private readonly IDbConnection _connection;

        public ProfessionSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public ProfessionSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(ProfessionModel model)
        {
            string sqlDelete = "DELETE FROM Profession WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<ProfessionModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name FROM Profession";
            using (_connection)
            {
                return _connection.Query<ProfessionModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(ProfessionModel model)
        {
            string sqlInsert = "INSERT INTO Profession (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(ProfessionModel model)
        {
            string sqlUpdate = "UPDATE Profession SET Name = @Name WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
