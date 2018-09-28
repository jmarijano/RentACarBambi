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
    public class InsuranceCompanyLocationSQLServerDataAccess : IInsuranceCompanyLocationRepository
    {
        private readonly IDbConnection _connection;

        public InsuranceCompanyLocationSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public InsuranceCompanyLocationSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(InsuranceCompanyLocationModel model)
        {
            string sqlDelete = "DELETE FROM InsuranceCompanyLocation WHERE Address = @Address AND " +
                " TownZipCode = @TownZipCode AND InsuranceCompanyId = @InsuranceCompanyId";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<InsuranceCompanyLocationModel> GetAll()
        {
            string sqlGetAll = "SELECT Address, TownZipCode, InsuranceCompanyId FROM InsuranceCompanyLocation";
            using (_connection)
            {
                return _connection.Query<InsuranceCompanyLocationModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(InsuranceCompanyLocationModel model)
        {
            string sqlInsert = "INSERT INTO InsuranceCompanyLocation (Address, TownZipCode, InsuranceCompanyId) " +
                " Values (@Address, @TownZipCode, @InsuranceCompanyId)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(InsuranceCompanyLocationModel model)
        {
            //TODO - Update Query 
            string sqlUpdate = "";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
