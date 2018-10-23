using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{

    /// <summary>
    /// Represents abstract object whose purpose 
    /// is to call methods from data access layer classes
    /// for Car table.
    /// </summary>
    public interface ICarBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Car table.
        /// </summary>
        /// <param name="car">
        /// Newly created CarModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(CarModel car);

        /// <summary>
        /// Calls data access layer method which updates
        /// an existing record in Car table.
        /// </summary>
        /// <param name="car">
        /// Existing CarModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(CarModel car);

        /// <summary>
        /// Calls data access layer method which deletes
        /// an existing record in Car table.
        /// </summary>
        /// <param name="car">
        /// Existing CarModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(CarModel car);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from Car table.
        /// </summary>
        /// <returns>
        /// Returns all Car records as a IList of
        /// CarModel objects.
        /// </returns>
        IList<CarModel> GetAll();
    }
}
