using BambiDataAccess;
using BambiIBusinessLogic;
using BambiModels;
using BambiSQLServerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiBusinessLogic
{
    /// <summary>
    /// Business logic layer class whose purpose is
    /// to handle data access method calling.
    /// </summary>
    public class CustomerFeedbackLogic : ICustomerFeedbackBusinessLogic
    {
        /// <summary>
        /// Private readonly ICustomerFeedbackRepository variable
        /// whose purpose is to call data access methods for
        /// customer feedback.
        /// </summary>
        private readonly ICustomerFeedbackRepository _customerFeedbackRepository;

        /// <summary>
        /// Constructor whose purpose is to create a new
        /// CustomerFeedbackSQLServerDataAccess object
        /// for the next constructor.
        /// </summary>
        public CustomerFeedbackLogic()
            : this(new CustomerFeedbackSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set private
        /// readonly variable value. It is identical with the
        /// value of the passed parameter.
        /// </summary>
        /// <param name="customerFeedbackRepository">
        /// Existing ICustomerFeedbackRepository object.
        /// </param>
        public CustomerFeedbackLogic(ICustomerFeedbackRepository customerFeedbackRepository)
        {
            _customerFeedbackRepository = customerFeedbackRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete existing
        /// customer feedback record from the database.
        /// </summary>
        /// <param name="customerFeedback">
        /// Existing customer feedback model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Delete(CustomerFeedbackModel customerFeedback)
        {
            return _customerFeedbackRepository.Delete(customerFeedback) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to get all 
        /// customer feedback record from the database.
        /// </summary>
        /// <returns>
        /// Returns all customer feedback records
        /// from thed database as a IList of
        /// customer feedback model objects.
        /// </returns>
        public IList<CustomerFeedbackModel> GetAll()
        {
            return _customerFeedbackRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert
        /// a new customer feedback record into
        /// the database.
        /// </summary>
        /// <param name="customerFeedback">
        /// Newly created customer feedback
        /// model object.
        /// </param>
        /// <returns>Returns true if the query is
        /// successfully executed otherwise 
        /// returns false.
        /// </returns>
        public bool Insert(CustomerFeedbackModel customerFeedback)
        {
            return _customerFeedbackRepository.Insert(customerFeedback) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an
        /// existing customer feedback record
        /// from the database.
        /// </summary>
        /// <param name="customerFeedback">
        /// Existing customer feedback model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Update(CustomerFeedbackModel customerFeedback)
        {
            return _customerFeedbackRepository.Update(customerFeedback) > 0 ? true : false;
        }
    }
}
