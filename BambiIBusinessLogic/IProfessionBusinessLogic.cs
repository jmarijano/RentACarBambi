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
    /// for Profession table.
    /// </summary>
    public interface IProfessionBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Profession table.
        /// </summary>
        /// <param name="profession">
        /// Newly created ProfesionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(ProfessionModel profession);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in Profession table.
        /// </summary>
        /// <param name="profession">
        /// Existing ProfesionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(ProfessionModel profession);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Profession table.
        /// </summary>
        /// <param name="profession">
        /// Existing ProfesionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(ProfessionModel profession);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from Profession table.
        /// </summary>
        /// <returns>
        /// Returns all records from ProfessionM table as a 
        /// IList of ProfessionModel objects.
        /// </returns>
        IList<ProfessionModel> GetAll();
    }
}
