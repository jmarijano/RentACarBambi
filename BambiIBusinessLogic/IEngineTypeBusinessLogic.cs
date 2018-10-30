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
    /// for EngineType table.
    /// </summary>
    public interface IEngineTypeBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in EngineType table.
        /// </summary>
        /// <param name="engineType">
        /// Newly created EngineTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(EngineTypeModel engineType);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in EngineType table.
        /// </summary>
        /// <param name="engineType">
        /// Existing EngineTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(EngineTypeModel engineType);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in EngineType table.
        /// </summary>
        /// <param name="engineType">
        /// Existing EngineTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(EngineTypeModel engineType);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from EngineType table.
        /// </summary>
        /// <returns>
        /// Returns all records from EngineType table as a
        /// IList of EngineTypeModel objects.
        /// </returns>
        IList<EngineTypeModel> GetAll();
    }
}
