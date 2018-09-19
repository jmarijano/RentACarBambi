using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class CarModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public float Consumption { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public int ModelOfProductionId { get; set; }

        public int ClassId { get; set; }

        public int InsuranceId { get; set; }

        public int DriveId { get; set; }

        public int DistanceDriven { get; set; }

        public int NumberOfseats { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public int EngineTypeId { get; set; }

        public int Power { get; set; }

        public decimal PriceParDay { get; set; }
    }
}
