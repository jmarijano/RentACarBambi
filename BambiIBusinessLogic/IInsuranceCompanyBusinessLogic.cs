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
    /// for InsuranceCompany table.
    /// </summary>
    public interface IInsuranceCompanyBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in InsuranceCompany table.
        /// </summary>
        /// <param name="insuranceCompany">
        /// Newly created InsuranceCompanyModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(InsuranceCompanyModel insuranceCompany);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in InsuranceCompany table.
        /// </summary>
        /// <param name="insuranceCompany">
        /// Existing InsuranceCompanyModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(InsuranceCompanyModel insuranceCompany);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in InsuranceCompany table.
        /// </summary>
        /// <param name="insuranceCompany">
        /// Existing InsuranceCompanyModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(InsuranceCompanyModel insuranceCompany);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from InsuranceCompany table.
        /// </summary>
        /// <returns>
        /// Returns all records from InsuranceCompany table as a 
        /// IList of InsuranceCompanyModel objects.
        /// </returns>
        IList<InsuranceCompanyModel> GetAll();
    }
}
