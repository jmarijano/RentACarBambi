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
    /// <summary>
    /// Car business logic layer class
    /// which implements ICarBusinessLogic
    /// interface.
    /// </summary>
    public class CarLogic : ICarBusinessLogic
    {
        /// <summary>
        /// Private readonly ICarRepository variable 
        /// which represents the abstraction of the
        /// data access layer.
        /// </summary>
        private readonly ICarRepository _carRepository;

        /// <summary>
        /// Constructor whose purpose is to create
        /// new CarSQLServerDataAccess object for
        /// the next constructor.
        /// </summary>
        public CarLogic()
            : this(new CarSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set
        /// private readonly variable value with
        /// the passed parameter.
        /// </summary>
        /// <param name="carRepository">Existing
        /// ICarRepository object</param>
        public CarLogic(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// the passed car model object
        /// from the database.
        /// </summary>
        /// <param name="car">
        /// Existing car model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Delete(CarModel car)
        {

            return _carRepository.Delete(car) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to get
        /// all car objects from 
        /// the database.
        /// </summary>
        /// <returns>
        /// Returns true if the query is 
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public IList<CarModel> GetAll()
        {
            return _carRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert new
        /// car model object into the database.
        /// </summary>
        /// <param name="car">
        /// Newly created car model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is 
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Insert(CarModel car)
        {
            return _carRepository.Insert(car) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update
        /// existing car model object from 
        /// the database.
        /// </summary>
        /// <param name="car">
        /// Existing car model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is 
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Update(CarModel car)
        {
            return _carRepository.Update(car) > 0 ? true : false;
        }
    }
}
