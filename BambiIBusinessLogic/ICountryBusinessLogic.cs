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
    /// for Country table.
    /// </summary>
    public interface ICountryBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Country table.
        /// </summary>
        /// <param name="country">
        /// Newly created CountryModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(CountryModel country);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in Country table.
        /// </summary>
        /// <param name="country">
        /// Existing CountryModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(CountryModel country);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Country table.
        /// </summary>
        /// <param name="country">
        /// Existing CountryModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(CountryModel country);

        /// <summary>
        /// Calls data access layer method which returns all
        /// records from Country table.
        /// </summary>
        /// <returns>
        /// Returns all Country record as a IList
        /// of CountryModel objects.
        /// </returns>
        IList<CountryModel> GetAll();
    }
}
