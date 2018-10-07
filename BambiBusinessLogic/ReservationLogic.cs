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
        public ReservationLogic()
            : this(new ReservationSQLServerDataAccess())
        {

        }
        public ReservationLogic(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
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
        /// 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(ReservationModel reservation)
        {
            return _reservationRepository.Insert(reservation) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
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
