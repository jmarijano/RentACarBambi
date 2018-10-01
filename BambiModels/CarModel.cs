using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class CarModel
    {
        /// <summary>
        /// The unique identifier of the car.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name for the car.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Color of the car.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Represents car consumption in liters
        /// </summary>
        public float Consumption { get; set; }

        /// <summary>
        /// Represents the day when the car was purchased.
        /// </summary>
        public DateTime DateOfPurchase { get; set; }

        /// <summary>
        /// Represents the unique identifier of the model
        /// that belongs to te car.
        /// </summary>
        public int ModelOfProductionId { get; set; }

        /// <summary>
        /// Represents the uniqu identifier of the class 
        /// to which the car belongs.
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// Represents the unique identifier of the insurance
        /// company to which the car belongs.
        /// </summary>
        public int InsuranceId { get; set; }

        /// <summary>
        /// Represents the unique drive identifier 
        /// to which the car belongs.
        /// </summary>
        public int DriveId { get; set; }

        /// <summary>
        /// Represents the car mileage. If no value is given
        /// then 0 is saved in the database.
        /// </summary>
        public int DistanceDriven { get; set; } = 0;

        /// <summary>
        /// Represents the number of seats in the car.
        /// </summary>
        public int NumberOfseats { get; set; }

        /// <summary>
        /// Represents the year of production of the car.
        /// </summary>
        public DateTime YearOfManufacture { get; set; }

        /// <summary>
        /// Represents the unique engine type identifier 
        /// to which the car belongs.
        /// </summary>
        public int EngineTypeId { get; set; }

        /// <summary>
        /// Represents the horsepower of the car.
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// Represents the daily rental price 
        /// of the car.
        /// </summary>
        public decimal PriceParDay { get; set; }
    }
}
