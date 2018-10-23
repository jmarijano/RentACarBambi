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
    /// for Class table.
    /// </summary>
    public interface IClassBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Class table.
        /// </summary>
        /// <param name="class">
        /// Newly created ClassModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(ClassModel @class);

        /// <summary>
        /// Calls data access layer method which updates
        /// an existing record in Class table.
        /// </summary>
        /// <param name="class">
        /// Existing ClassModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(ClassModel @class);

        /// <summary>
        /// Calls data access layer method which deletes
        /// an existing record in Class table.
        /// </summary>
        /// <param name="class">
        /// Existing ClassModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(ClassModel @class);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from Class table.
        /// </summary>
        /// <returns>
        /// Returns all records from Class table as a 
        /// IList of ClassModel objects.
        /// </returns>
        IList<ClassModel> GetAll();
    }
}
