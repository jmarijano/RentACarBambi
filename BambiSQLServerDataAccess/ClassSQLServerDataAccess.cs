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
    public class ClassSQLServerDataAccess : IClassRepository
    {
        private readonly IDbConnection _connection;
        public ClassSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public ClassSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(ClassModel model)
        {
            string sqlDelete = "DELETE FROM Class WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<ClassModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, name FROM Class";
            using (_connection)
            {
                return _connection.Query<ClassModel>(sqlGetAll).ToList();
            }
        }

        public ClassModel GetClass(int Id)
        {
            string sqlGetClass = "SELECT Id, Name FROM Class WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Query<ClassModel>(sqlGetClass, Id).SingleOrDefault();
            }
        }

        public int Insert(ClassModel model)
        {
            string sqlInsert = "INSERT INTO Class (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(ClassModel model)
        {
            string sqlUpdate = "UPDATE Class SET Name = @Name WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
