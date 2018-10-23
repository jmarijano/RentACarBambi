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
    /// for CustomerFeedback table.
    /// </summary>
    public interface ICustomerFeedbackBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in CustomerFeedback table.
        /// </summary>
        /// <param name="customerFeedback">
        /// Newly created CustomerFeedbackModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(CustomerFeedbackModel customerFeedback);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in CustomerFeedback table.
        /// </summary>
        /// <param name="customerFeedback">
        /// Existing CustomerFeedbackModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(CustomerFeedbackModel customerFeedback);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in CustomerFeedback table.
        /// </summary>
        /// <param name="customerFeedback">
        /// Existing CustomerFeedbackModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(CustomerFeedbackModel customerFeedback);

        /// <summary>
        /// Calls data access layer method which returns all
        /// records from CustomerFeedback table.
        /// </summary>
        /// <returns>
        /// Returns all records from CustomerFeedback table as a
        /// IList of CustomerFeedbackModel objects.
        /// </returns>
        IList<CustomerFeedbackModel> GetAll();
    }
}
