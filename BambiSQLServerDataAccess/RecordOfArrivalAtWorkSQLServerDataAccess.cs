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
    public class RecordOfArrivalAtWorkSQLServerDataAccess : IRecordOfArrivalAtWorkRepository
    {
        private readonly IDbConnection _connection;

        public RecordOfArrivalAtWorkSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public RecordOfArrivalAtWorkSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(RecordOfArrivalAtWorkModel model)
        {
            string sqlDelete = "DELETE FROM RecordOfArrivalAtWork WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<RecordOfArrivalAtWorkModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, DateAndTimeOfArrival, DateAndTimeOfDeparture, EmployeeId FROM RecordOfArrivalAtWork";
            using (_connection)
            {
                return _connection.Query<RecordOfArrivalAtWorkModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(RecordOfArrivalAtWorkModel model)
        {
            string sqlInsert = "INSERT INTO RecordOfArrivalAtWork (Id, DateAndTimeOfArrival, DateAndTimeOfDeparture, EmployeeId)" +
                " Values (@Id, @DateAndTimeOfArrival, @DateAndTimeOfDeparture, @EmployeeId)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(RecordOfArrivalAtWorkModel model)
        {
            string sqlUpdate = "UPDATE RecordOfArrivalAtWork SET DateAndTimeOfArrival = @DateAndTimeOfArrival," +
                " DateAndTimeOfDeparture = @DateAndTimeOfDeparture, EmployeeId = @EmployeeId WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
