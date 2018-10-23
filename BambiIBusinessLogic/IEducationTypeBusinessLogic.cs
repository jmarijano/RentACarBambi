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
    /// for EducationType table.
    /// </summary>
    public interface IEducationTypeBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in EducationType table.
        /// </summary>
        /// <param name="educationType">
        /// Newly created EducationType object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(EducationTypeModel educationType);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in EducationType table.
        /// </summary>
        /// <param name="educationType">
        /// Existing EducationType object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(EducationTypeModel educationType);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in EducationType table.
        /// </summary>
        /// <param name="educationType">
        /// Existing EducationType object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(EducationTypeModel educationType);

        /// <summary>
        /// Calls data access layer method which returns all
        /// records from EducationType table.
        /// </summary>
        /// <returns>
        /// Returns all records from EducationType table as a IList
        /// of EducationTypeModel objects.
        /// </returns>
        IList<EducationTypeModel> GetAll();
    }
}
