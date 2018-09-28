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
    public class InsuranceCompanySQLServerDataAccess : IInsuranceCompanyRepository
    {
        private readonly IDbConnection _connection;

        public InsuranceCompanySQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public InsuranceCompanySQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(InsuranceCompanyModel model)
        {
            string sqlDelete = "DELETE FROM InsuranceCompany WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<InsuranceCompanyModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name, Email FROM InsuranceCompany";
            using (_connection)
            {
                return _connection.Query<InsuranceCompanyModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(InsuranceCompanyModel model)
        {
            string sqlInsert = "INSERT INTO InsuranceCompany (Id, Name, Email) " +
                " Values (@Id, @Name, @Email)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(InsuranceCompanyModel model)
        {
            string sqlUpdate = "UPDATE InsuranceCompany SET Name = @Name, Email = @Email WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
