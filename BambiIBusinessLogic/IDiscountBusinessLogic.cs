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
    /// for Discount table.
    /// </summary>
    public interface IDiscountBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Discount table.
        /// </summary>
        /// <param name="discount">
        /// Newly created DiscountModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(DiscountModel discount);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in Discount table.
        /// </summary>
        /// <param name="discount">
        /// Existing DiscountModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(DiscountModel discount);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Discount table.
        /// </summary>
        /// <param name="discount">
        /// Existing DiscountModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(DiscountModel discount);

        /// <summary>
        /// Calls data access layer method which returns all
        /// records from Discount table.
        /// </summary>
        /// <returns>
        /// Returns all Discount records as a
        /// IList of DiscountModel objects.
        /// </returns>
        IList<DiscountModel> GetAll();
    }
}
