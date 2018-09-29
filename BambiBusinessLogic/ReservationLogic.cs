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
        public bool Delete(ReservationModel reservation)
        {
            return _reservationRepository.Delete(reservation) > 0 ? true : false;
        }

        public IList<ReservationModel> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        public bool Insert(ReservationModel reservation)
        {
            return _reservationRepository.Insert(reservation) > 0 ? true : false;
        }

        public bool Update(ReservationModel reservation)
        {
            return _reservationRepository.Update(reservation) > 0 ? true : false;
        }
    }
}
