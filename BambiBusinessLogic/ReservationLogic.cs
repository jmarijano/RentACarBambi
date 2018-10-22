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
    /// data access for Reservation table. It implements
    /// IReservationBusinessLogic interface.
    /// </summary>
    public class ReservationLogic : IReservationBusinessLogic
    {
        private readonly IReservationRepository _reservationRepository;

        /// <summary>
        /// Constructor whose purpose is to create a new
        /// ReservationSQLServerDataAccess object.
        /// </summary>
        public ReservationLogic()
            : this(new ReservationSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is 
        /// to set _reservationRepository variable. 
        /// </summary>
        /// <param name="reservationRepository">
        /// Existing IReservationRepository object.
        /// </param>
        public ReservationLogic(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete an existing
        /// reservation from the database
        /// </summary>
        /// <param name="reservation">
        /// Existing ReservationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(ReservationModel reservation)
        {
            return _reservationRepository.Delete(reservation) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// reservation records from the database.
        /// </summary>
        /// <returns>
        /// Returns all reservation objects as a IList
        /// of ReservationModel objects.
        /// </returns>
        public IList<ReservationModel> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert
        /// a new reservation in the database.
        /// </summary>
        /// <param name="reservation">
        /// Newly created ReservationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(ReservationModel reservation)
        {
            return _reservationRepository.Insert(reservation) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an existing
        /// ReservationModel object.
        /// </summary>
        /// <param name="reservation">
        /// Existing ReservationModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(ReservationModel reservation)
        {
            return _reservationRepository.Update(reservation) > 0 ? true : false;
        }
    }
}
