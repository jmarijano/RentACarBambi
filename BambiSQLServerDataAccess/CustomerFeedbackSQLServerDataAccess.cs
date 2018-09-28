using BambiDataAccess;
using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BambiFactory;
using Dapper;

namespace BambiSQLServerDataAccess
{
    public class CustomerFeedbackSQLServerDataAccess : ICustomerFeedbackRepository
    {
        private readonly IDbConnection _connection;

        public CustomerFeedbackSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public CustomerFeedbackSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(CustomerFeedbackModel model)
        {
            string sqlDelete = "DELETE FROM CustomerFeedback WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<CustomerFeedbackModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Grade, Description, CustomerId, CarId FROM CustomerFeedback";
            using (_connection)
            {
                return _connection.Query<CustomerFeedbackModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(CustomerFeedbackModel model)
        {
            string sqlInsert = "INSERT INTO CustomerFeedback (Id, Grade, Description, CustomerId, CarId)" +
                "Values (@Id, @Grade, @Description, @CustomerId, @CarId)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(CustomerFeedbackModel model)
        {
            string sqlUpdate = "UPDATE CustomerFeedback SET Grade = @Grade, Description = @Description," +
                " CustomerId = @CustomerId, CarId = @CarId WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
