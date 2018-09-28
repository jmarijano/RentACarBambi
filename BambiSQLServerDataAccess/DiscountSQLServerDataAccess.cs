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
    public class DiscountSQLServerDataAccess : IDiscountRepository
    {
        private readonly IDbConnection _connection;

        public DiscountSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public DiscountSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(DiscountModel model)
        {
            string sqlDelete = "DELETE FROM Discount WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete);
            }
        }

        public IList<DiscountModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name, BeginningDate, EndDate, Percentage, CarId FROM Discount";
            using (_connection)
            {
                return _connection.Query<DiscountModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(DiscountModel model)
        {
            string sqlInsert = "INSERT INTO Discount (Id, Name, BeginningDate, EndDate, Percentage, CarId)" +
                " Values (@Id, @Name, @BeginningDate, @EndDate, @Percentage, @CarId)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(DiscountModel model)
        {
            string sqlUpdate = "UPDATE Discount SET Name = @Name, BeginningDate = @BeginningDate, EndDate = @EndDate, Percentage = @Percentage, CarId = @CarId WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
