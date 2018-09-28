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
    public class PaymentMethodSQLServerDataAccess : IPaymentMethodRepository
    {
        private readonly IDbConnection _connection;
        public PaymentMethodSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public PaymentMethodSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(PaymentMethodModel model)
        {
            string sqlDelete = "DELETE FROM PaymentMethod WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<PaymentMethodModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name FROM PaymentMethod";
            using (_connection)
            {
                return _connection.Query<PaymentMethodModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(PaymentMethodModel model)
        {
            string sqlInsert = "INSERT INTO PaymentMethod (Id, Name) Values (@Id, @Name)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(PaymentMethodModel model)
        {
            string sqlUpdate = "UPDATE PaymentMethod SET Name = @Name WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
