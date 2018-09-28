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
    public class CustomerSQLServerDataAccess : ICustomerRepository
    {
        private readonly IDbConnection _connection;

        public CustomerSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public CustomerSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(CustomerModel model)
        {
            string sqlDelete = "DELETE FROM Customer WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<CustomerModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, FirstName, LastName, Email," +
                "PhoneNumber, TownZipCode, Address, ProfessionId, EducationTypeId, Gender FROM Customer";
            using (_connection)
            {
                return _connection.Query<CustomerModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(CustomerModel model)
        {
            string sqlInsert = "INSERT INTO Customer (Id, FirstName, LastName, Email, PhoneNumber, TownZipCode, Address, ProfessionId, EducationTypeId, Gender)" +
                "Values (@Id, @FirstName, @LastName, @Email, @PhoneNumber, @TownZipCode, @Address, @ProfessionId, @EducationTypeId, @Gender)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(CustomerModel model)
        {
            string sqlUpdate = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, Email = @Email, " +
                "PhoneNumber = @PhoneNumber, TownZipCode = @TownZipCode, Address = @Address, ProfessionId = @ProfessionId, " +
                "EducationTypeId = @EducationTypeId, Gender = @Gender WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
