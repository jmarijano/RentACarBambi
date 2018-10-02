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
    /// Business logic layer class whose purpose is to
    /// handle data access layer classes. It implements
    /// ICustomerBusinessLogic interface.
    /// </summary>
    public class CustomerLogic : ICustomerBusinessLogic
    {
        /// <summary>
        /// Private readonly ICustomerRepository variable whose purpose is
        /// to execute data access methods.
        /// </summary>
        private readonly ICustomerRepository _customerRepository;

        /// <summary>
        /// Constructor whose purpose is to create a nex
        /// CustomerSQLServerDataAccess object for the
        /// next constructor.
        /// </summary>
        public CustomerLogic()
            : this(new CustomerSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set 
        /// private readonly variable value. It's value
        /// is identical to value of passed parameter.
        /// </summary>
        /// <param name="customerRepository">
        /// Existing ICustomerRepository object.
        /// </param>
        public CustomerLogic(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete an
        /// existing customer record from the database.
        /// </summary>
        /// <param name="customer">
        /// Existing customer model object.
        /// </param>
        /// <returns>
        /// Returns false if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Delete(CustomerModel customer)
        {
            return _customerRepository.Delete(customer) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to get all
        /// customer records from the database.
        /// </summary>
        /// <returns>
        /// Returns all customer records from the database
        /// as a IList of customer model objects.
        /// </returns>
        public IList<CustomerModel> GetAll()
        {
            return _customerRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert
        /// a new customer record into the
        /// database.
        /// </summary>
        /// <param name="customer">
        /// Newly created customer model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Insert(CustomerModel customer)
        {
            return _customerRepository.Insert(customer) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update
        /// an existing customer record from
        /// the database.
        /// </summary>
        /// <param name="customer">
        /// Existing customer model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Update(CustomerModel customer)
        {
            return _customerRepository.Update(customer) > 0 ? true : false;
        }
    }
}
