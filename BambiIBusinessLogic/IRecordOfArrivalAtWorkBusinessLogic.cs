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
    /// for RecordOfArrivalAtWork table.
    /// </summary>
    public interface IRecordOfArrivalAtWorkBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in RecordOfArrivalAtWork table.
        /// </summary>
        /// <param name="recordOfArrivalAtWork">
        /// Newly created RecordOfArrivalAtWorkModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(RecordOfArrivalAtWorkModel recordOfArrivalAtWork);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in RecordOfArrivalAtWork table.
        /// </summary>
        /// <param name="recordOfArrivalAtWork">
        /// Existing RecordOfArrivalAtWorkModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(RecordOfArrivalAtWorkModel recordOfArrivalAtWork);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in RecordOfArrivalAtWork table.
        /// </summary>
        /// <param name="recordOfArrivalAtWork">
        /// Existing RecordOfArrivalAtWorkModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(RecordOfArrivalAtWorkModel recordOfArrivalAtWork);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from RecordOfArrivalAtWorkModel table.
        /// </summary>
        /// <returns>
        /// Returns all records from RecordOfArrivalAtWork table as a 
        /// IList of RecordOfArrivalAtWorkModel objects.
        /// </returns>
        IList<RecordOfArrivalAtWorkModel> GetAll();
    }
}
