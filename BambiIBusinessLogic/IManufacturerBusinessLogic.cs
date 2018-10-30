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
    /// for Manufacturer table.
    /// </summary>
    public interface IManufacturerBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Manufacturer table.
        /// </summary>
        /// <param name="manufacturer">
        /// Newly created ManufacturerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(ManufacturerModel manufacturer);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in Manufacturer table.
        /// </summary>
        /// <param name="manufacturer">
        /// Existing ManufacturerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(ManufacturerModel manufacturer);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Manufacturer table.
        /// </summary>
        /// <param name="manufacturer">
        /// Existing ManufacturerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(ManufacturerModel manufacturer);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from Manufacturer table.
        /// </summary>
        /// <returns>
        /// Returns all records from Manufacturer table as a 
        /// IList of ManufacturerModel objects.
        /// </returns>
        IList<ManufacturerModel> GetAll();
    }
}
