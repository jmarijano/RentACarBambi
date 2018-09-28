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
    public class EducationTypeSQLServerDataAccess : IEducationTypeRepository
    {
        private readonly IDbConnection _connection;


        public EducationTypeSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public EducationTypeSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(EducationTypeModel model)
        {
            string sqlDelete = "DELETE FROM EducationType WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<EducationTypeModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name FROM EducationType";
            using (_connection)
            {
                return _connection.Query<EducationTypeModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(EducationTypeModel model)
        {
            string sqlInsert = "INSERT INTO EducationType (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(EducationTypeModel model)
        {
            string sqlUpdate = "UPDATE EducationType SET Name = @Name WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
