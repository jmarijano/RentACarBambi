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
    /// for PaymentMethod table.
    /// </summary>
    public interface IPaymentMethodBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in PaymentMethod table.
        /// </summary>
        /// <param name="paymentMethod">
        /// Newly created PaymentMethodModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(PaymentMethodModel paymentMethod);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in PaymentMethod table.
        /// </summary>
        /// <param name="paymentMethod">
        /// Existing PaymentMethodModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(PaymentMethodModel paymentMethod);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in PaymentMethod table.
        /// </summary>
        /// <param name="paymentMethod">
        /// Existing PaymentMethodModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(PaymentMethodModel paymentMethod);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from PaymentMethod table.
        /// </summary>
        /// <returns>
        /// Returns all records from PaymentMethod table as a 
        /// IList of PaymentMethodModel objects.
        /// </returns>
        IList<PaymentMethodModel> GetAll();
    }
}
