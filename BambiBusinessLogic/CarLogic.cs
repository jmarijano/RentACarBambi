using BambiDataAccess;
using BambiIBusinessLogic;
using BambiModels;
using BambiSQLServerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiBusinessLogic
{
    public class CarLogic : ICarBusinessLogic
    {
        private readonly ICarRepository _carRepository;

        public CarLogic()
            : this(new CarSQLServerDataAccess())
        {

        }
        public CarLogic(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public bool Delete(CarModel car)
        {
            return _carRepository.Delete(car) > 0 ? true : false;
        }

        public IList<CarModel> GetAll()
        {
            return _carRepository.GetAll();
        }

        public bool Insert(CarModel car)
        {
            return _carRepository.Insert(car) > 0 ? true : false;
        }

        public bool Update(CarModel car)
        {
            return _carRepository.Update(car) > 0 ? true : false;
        }
    }
}
