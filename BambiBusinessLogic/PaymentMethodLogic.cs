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
    /// Business logic class whose purpose is to handle 
    /// data access for PaymenthMethod table. It implements
    /// IPaymenthMethodBusinessLogic interface.
    /// </summary>
    public class PaymentMethodLogic : IPaymentMethodBusinessLogic
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;

        /// <summary>
        /// Constructor whose purpose is to create a 
        /// new PaymentMethodSQLServerDataAccess object.
        /// </summary>
        public PaymentMethodLogic()
            : this(new PaymentMethodSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to
        /// set _paymentMethodRepository variable.
        /// </summary>
        /// <param name="paymentMethodRepository">
        /// Existing IPaymentMethodRepository object.
        /// </param>
        public PaymentMethodLogic(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// an existing PaymentMethod record.
        /// </summary>
        /// <param name="paymentMethod">
        /// Existing PaymentMethodModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(PaymentMethodModel paymentMethod)
        {
            return _paymentMethodRepository.Delete(paymentMethod) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// paymenth method records from the database.
        /// </summary>
        /// <returns>
        /// Returns all payment method objects as a IList
        /// of PaymentMethodModel objects.
        /// </returns>
        public IList<PaymentMethodModel> GetAll()
        {
            return _paymentMethodRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert
        /// a new PaymentMethod record.
        /// </summary>
        /// <param name="paymentMethod">
        /// Newly created PaymentMethodModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(PaymentMethodModel paymentMethod)
        {
            return _paymentMethodRepository.Insert(paymentMethod) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an
        /// existing PaymentMethod record.
        /// </summary>
        /// <param name="paymentMethod">
        /// Existing PaymentMethodModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(PaymentMethodModel paymentMethod)
        {
            return _paymentMethodRepository.Update(paymentMethod) > 0 ? true : false;
        }
    }
}
