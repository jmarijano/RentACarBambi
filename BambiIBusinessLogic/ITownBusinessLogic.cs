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
    /// for Town table.
    /// </summary>
    public interface ITownBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Town table.
        /// </summary>
        /// <param name="town">
        /// Newly created TownModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(TownModel town);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in Town table.
        /// </summary>
        /// <param name="town">
        /// Existing TownModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(TownModel town);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Town table.
        /// </summary>
        /// <param name="town">
        /// Existing TownModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(TownModel town);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from Town table.
        /// </summary>
        /// <returns>
        /// Returns all records from Town table as a 
        /// IList of TownModel objects.
        /// </returns>
        IList<TownModel> GetAll();
    }
}
