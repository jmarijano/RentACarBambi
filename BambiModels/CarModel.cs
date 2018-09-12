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

        public int MyProperty { get; set; }

        public ModelOfProductionModel ModelOfProduction { get; set; }

        public ClassModel Class { get; set; }

        public InsuranceCompanyModel Insurance { get; set; }

        public DriveModel Drive { get; set; }

        public int DistanceDriven { get; set; }

        public int NumberOfseats { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public EngineTypeModel EngineType { get; set; }

        public int Power { get; set; }

        public decimal PriceParDay { get; set; }
    }
}
