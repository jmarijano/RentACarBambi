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
    /// IDiscountBusinessLogic interface.
    /// </summary>
    public class DiscountLogic : IDiscountBusinessLogic
    {
        private readonly IDiscountRepository _discountRepository;

        /// <summary>
        /// Constructor whose purpose is to create a new
        /// DiscountSQLServerDataAccess object for the
        /// next constructor.
        /// </summary>
        public DiscountLogic()
            : this(new DiscountSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set private readonly
        /// variable value. It's value will be the same as the 
        /// value of the passed parameter.
        /// </summary>
        /// <param name="discountRepository">
        /// Existing IDiscountRepository object.
        /// </param>
        public DiscountLogic(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete an
        /// existing discount record from the database.
        /// </summary>
        /// <param name="discount">
        /// Existind discount model object.
        /// </param>
        /// <returns>
        /// Returns false if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Delete(DiscountModel discount)
        {
            return _discountRepository.Delete(discount) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to get all
        /// discount model records from the database.
        /// </summary>
        /// <returns></returns>
        public IList<DiscountModel> GetAll()
        {
            return _discountRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert
        /// a new discount record into the database.
        /// </summary>
        /// <param name="discount">
        /// Newly created discount model object.
        /// </param>
        /// <returns>
        /// Returns false if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Insert(DiscountModel discount)
        {
            return _discountRepository.Insert(discount) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an
        /// existing discount record from the database.
        /// </summary>
        /// <param name="discount">
        /// Existing discount model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Update(DiscountModel discount)
        {
            return _discountRepository.Update(discount) > 0 ? true : false;
        }
    }
}
