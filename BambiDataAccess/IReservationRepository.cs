using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IReservationRepository
    {

        void Insert(ReservationModel model);
        void Update(ReservationModel model);
        void Delete(ReservationModel model);
        IEnumerable<ReservationModel> GetAll();
    }
}
