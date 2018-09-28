using BambiDataAccess;
using BambiFactory;
using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace BambiSQLServerDataAccess
{
    public class BillSQLServerDataAccess : IBillRepository
    {
        private readonly IDbConnection _connection;

        public BillSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public BillSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(BillModel model)
        {
            string sqlDelete = "DELETE FROM Bill WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<BillModel> GetAll()
        {
            string sqlGetAll = "Select Id, DateOfIssue, ReservationId, PaymentMethodId, DiscountId, EmployeeId FROM Bill";
            using (_connection)
            {
                return _connection.Query<BillModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(BillModel model)
        {
            string sqlInsert = "INSERT INTO Bill (Id,DateOfIssue, ReservationId, PaymentMethodId, DiscountId, EmployeeId) " +
                "Values (@Id, @DateOfIssue, @ReservationId, @PaymentMethodId, @DiscountId, @EmployeeId)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(BillModel model)
        {
            string sqlUpdate = "UPDATE Bill SET DateOfIssue = @DateOfIssue, ReservationId = @ReservationId, " +
                "PaymentMethodId = @PaymentMethodId, DiscountId = @DiscountId, EmployeeId= @EmployeeId WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
