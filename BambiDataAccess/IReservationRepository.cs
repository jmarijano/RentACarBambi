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

        int Insert(ReservationModel model);
        int Update(ReservationModel model);
        int Delete(ReservationModel model);
        IList<ReservationModel> GetAll();
    }
}
