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
    public class EmployeeSQLServerDataAccess : IEmployeeRepository
    {
        private readonly IDbConnection _connection;

        public EmployeeSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public EmployeeSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(EmployeeModel model)
        {
            string sqlDelete = "DELETE FROM Employee WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<EmployeeModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, FirstName, LastName, Gender, Salary, Email, EducationTypeId," +
                " ProffesionId, BirthDate, HireDate, PhoneNumber, TownZipCode, Address, HourlyRate," +
                " LengthOfEmployment, EmployeeTypeId, Username, Password FROM Employee";
            using (_connection)
            {
                return _connection.Query<EmployeeModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(EmployeeModel model)
        {
            string sqlInsert = "INSERT INTO Employee (Id, FirstName, LastName, Gender, Salary, Email," +
                " EducationTypeId, ProffesionId, BirthDate, HireDate, PhoneNumber, TownZipCode, Address," +
                " HourlyRate, LengthOfEmployment, EmployeeTypeId, Username, Password)" +
                " Values (@Id, @FirstName, @LastName, @Gender, @Salary, @Email, @EducationTypeId," +
                " @ProffesionId, @BirthDate, @HireDate, @PhoneNumber, @TownZipCode, @Address," +
                " @HourlyRate, @LengthOfEmployment, @EmployeeTypeId, @Username, @Password)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(EmployeeModel model)
        {
            string sqlUpdate = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName," +
                " Gender = @Gender, Salary = @Salary, Email = @Email, EducationTypeId = @EducationTypeId," +
                " ProffesionId = @ProffesionId, BirthDate = @BirthDate, HireDate = @HireDate," +
                " PhoneNumber = @PhoneNumber, TownZipCode = @TownZipCode, Address = @Address," +
                " HourlyRate = @HourlyRate, LengthOfEmployment = @LengthOfEmployment," +
                " EmployeeTypeId = @EmployeeTypeId, Username = @Username, Password = @Password WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
