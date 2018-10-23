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
    /// for Bill table.
    /// </summary>
    public interface IBillBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Bill table.
        /// </summary>
        /// <param name="bill">
        /// Newly created BillModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(BillModel bill);

        /// <summary>
        /// Calls data access layer method which updates
        /// existing record in Bill table.
        /// </summary>
        /// <param name="bill"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(BillModel bill);

        /// <summary>
        /// Calls data access layer method which deletes
        /// existing record in Bill table.
        /// </summary>
        /// <param name="bill"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(BillModel bill);

        /// <summary>
        /// Calls data access layer method which returns all
        /// records from Bill table.
        /// </summary>
        /// <returns>
        /// Returns all Bill records from the database as a IList
        /// of BillModel objects.
        /// </returns>
        IList<BillModel> GetAll();
    }
}
