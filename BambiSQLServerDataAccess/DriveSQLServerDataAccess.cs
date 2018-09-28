using BambiDataAccess;
using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using BambiFactory;
using System.Data;

namespace BambiSQLServerDataAccess
{
    public class DriveSQLServerDataAccess : IDriveRepository
    {
        private readonly IDbConnection _connection;

        public DriveSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public DriveSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(DriveModel model)
        {
            string sqlDelete = "DELETE FROM Drive WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<DriveModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name FROM Drive";
            using (_connection)
            {
                return _connection.Query<DriveModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(DriveModel model)
        {
            string sqlInsert = "INSERT INTO Drive (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(DriveModel model)
        {
            string sqlUpdate = "UPDATE Drive SET Name = @Name WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
