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
    /// for InsuranceCompanyLocation table.
    /// </summary>
    public interface IInsuranceCompanyLocationBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in InsuranceCompanyLocation table.
        /// </summary>
        /// <param name="insuranceCompanyLocation">
        /// Newly created InsuranceCompanyLocationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(InsuranceCompanyLocationModel insuranceCompanyLocation);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in InsuranceCompanyLocation table.
        /// </summary>
        /// <param name="insuranceCompanyLocation">
        /// Existing InsuranceCompanyLocationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(InsuranceCompanyLocationModel insuranceCompanyLocation);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in InsuranceCompanyLocation table.
        /// </summary>
        /// <param name="insuranceCompanyLocation">
        /// Existing InsuranceCompanyLocationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(InsuranceCompanyLocationModel insuranceCompanyLocation);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from InsuranceCompanyLocation table.
        /// </summary>
        /// <returns>
        /// Returns all records from InsuranceCompanyLocation table as a 
        /// IList of InsuranceCompanyLocationModel objects.
        /// </returns>
        IList<InsuranceCompanyLocationModel> GetAll();
    }
}
