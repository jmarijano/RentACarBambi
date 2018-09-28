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
    public class ReservationSQLServerDataAccess : IReservationRepository
    {
        private readonly IDbConnection _connection;
        public ReservationSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public ReservationSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }

        public int Delete(ReservationModel model)
        {
            string sqlDelete = "DELETE FROM Reservation WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<ReservationModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, DateOfBooking, BeginningDate, EndDate, CarId," +
                " CustomerId, DistanceDriven, EmployeeId FROM Reservation";
            using (_connection)
            {
                return _connection.Query<ReservationModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(ReservationModel model)
        {
            string sqlInsert = "INSERT INTO Reservation (Id, DateOfBooking, BeginningDate," +
                " EndDate, CarId, CustomerId, DistanceDriven, EmployeeId) Values (@Id," +
                " @DateOfBooking, @BeginningDate, @EndDate, @CarId, @CustomerId, @DistanceDriven, @EmployeeId)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(ReservationModel model)
        {
            string sqlUpdate = "UPDATE Reservation SET DateOfBooking = @DateOfBooking," +
                " BeginningDate = @BeginningDate, EndDate = @EndDate, CarId = @CarId," +
                " CustomerId = @CustomerId, DistanceDriven = @DistanceDriven," +
                " EmployeeId = @EmployeeId WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
