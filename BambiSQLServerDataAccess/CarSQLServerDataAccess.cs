using BambiDataAccess;
using BambiFactory;
using BambiModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BambiSQLServerDataAccess
{
    public class CarSQLServerDataAccess : ICarRepository
    {
        private readonly IDbConnection _connection;
        public CarSQLServerDataAccess()
            : this(new SQLServerConnection())
        {

        }
        public CarSQLServerDataAccess(IDatabase connection)
        {
            _connection = connection.CreateConnection();
        }
        public int Delete(CarModel model)
        {
            string sqlDelete = "DELETE FROM Car WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlDelete, model);
            }
        }

        public IList<CarModel> GetAll()
        {
            string sqlGetAll = "SELECT Id, Name, Color, Consumption, DateOfPurchase, Image, ModelOfProductionId, ClassId, " +
                "InsuranceCompanyId, DriveId, DistanceDriven, NumberOfSeats, YearOfManufacture, EngineTypeId, Power, " +
                "PricePerDay FROM Car";
            using (_connection)
            {
                return _connection.Query<CarModel>(sqlGetAll).ToList();
            }
        }

        public int Insert(CarModel model)
        {
            string sqlInsert = "INSERT INTO Car (Id, Name, Color, Consumption, DateOfPurchase, Image, ModelOfProductionId," +
                " ClassId, InsuranceCompanyId, DriveId, DistanceDriven, NumberOfSeats, YearOfManufacture, EngineTypeId, " +
                "Power, PricePerDay) Values (@Id, @Name, @Color, @Consumption, @DateOfPurchase, @Image, @ModelOfProductionId, " +
                "@ClassId, @InsuranceCompanyId, @DriveId, @DistanceDriven, @NumberOfSeats, @YearOfManufacture," +
                " @EngineTypeId, @Power, @PricePerDay)";
            using (_connection)
            {
                return _connection.Execute(sqlInsert, model);
            }
        }

        public int Update(CarModel model)
        {
            string sqlUpdate = "UPDATE Car SET Name = @Name, Color = @Color, Consumption = @Consumption, DateOfPurchase = " +
                "@DateOfPurchase, Image = @Image, ModelOfProductionId = @ModelOfProductionId," +
                " ClassId = @ClassId, InsuranceCompanyId = @InsuranceCompanyId, DriveId = @DriveId, " +
                "DistanceDriven = @DistanceDriven, NumberOfSeats = @NumberOfSeats, YearOfManufacture = @YearOfManufacture, " +
                "EngineTypeId = @EngineTypeId, " +
                "Power = @Power, PricePerDay = @PricePerDay WHERE Id = @Id";
            using (_connection)
            {
                return _connection.Execute(sqlUpdate, model);
            }
        }
    }
}
