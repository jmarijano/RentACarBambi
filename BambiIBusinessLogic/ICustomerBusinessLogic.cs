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
    /// for Customer table.
    /// </summary>
    public interface ICustomerBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Customer table.
        /// </summary>
        /// <param name="customer">
        /// Newly created CustomerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(CustomerModel customer);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in Customer table.
        /// </summary>
        /// <param name="customer">
        /// Existing CustomerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(CustomerModel customer);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Customer table.
        /// </summary>
        /// <param name="customer">
        /// Existing CustomerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(CustomerModel customer);

        /// <summary>
        /// Calls data access layer method which returns all
        /// records from Customer table.
        /// </summary>
        /// <returns>
        /// Returns all Customer records as a
        /// IList of CustomerModel objects.
        /// </returns>
        IList<CustomerModel> GetAll();
    }
}
