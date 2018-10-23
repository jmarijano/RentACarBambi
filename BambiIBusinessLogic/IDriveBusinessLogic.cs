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
    /// for Drive table.
    /// </summary>
    public interface IDriveBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Drive table.
        /// </summary>
        /// <param name="drive">
        /// Newly created DriveModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(DriveModel drive);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in Drive table.
        /// </summary>
        /// <param name="drive">
        /// Existing DriveModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(DriveModel drive);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Drive table.
        /// </summary>
        /// <param name="drive">
        /// Existing DriveModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(DriveModel drive);

        /// <summary>
        /// Calls data access layer method which returns all
        /// records from Drive table.
        /// </summary>
        /// <returns>
        /// Returns all Drive records as a 
        /// IList of DriveModel objects.
        /// </returns>
        IList<DriveModel> GetAll();
    }
}
