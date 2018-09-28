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
    public class EmployeeTypeSQLServerDataAccess : IEmployeeTypeRepository
    {
        private readonly IDbConnection _connection;

        public EmployeeTypeSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public EmployeeTypeSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(EmployeeTypeModel model)
        {
            string sqlDelete = "DELETE FROM EmployeeType WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<EmployeeTypeModel> GetAll()
        {
            string sqlGelAll = "SELECT Id, Name FROM EmployeeType";
            using (_connection)
            {
                return _connection.Query<EmployeeTypeModel>(sqlGelAll).ToList();
            }
        }

        public int Insert(EmployeeTypeModel model)
        {
            string sqlInsert = "INSERT INTO EmployeeType (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(EmployeeTypeModel model)
        {
            string sqlUpdate = "UPDATE EmployeeType SET Name = @Name Where Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
