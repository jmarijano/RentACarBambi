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
    /// for Reservation table.
    /// </summary>
    public interface IReservationBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Reservation table.
        /// </summary>
        /// <param name="reservation">
        /// Newly created ReservationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(ReservationModel reservation);

        /// <summary>
        /// Calls data access layer method which updates an
        /// exsiting record in Reservation table.
        /// </summary>
        /// <param name="reservation">
        /// Existing ReservationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(ReservationModel reservation);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Reservation table.
        /// </summary>
        /// <param name="reservation">
        /// Existing ReservationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(ReservationModel reservation);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from Reservation table.
        /// </summary>
        /// <returns>
        /// Returns all records from Reservation table as a 
        /// IList of ReservationModel objects.
        /// </returns>
        IList<ReservationModel> GetAll();
    }
}
