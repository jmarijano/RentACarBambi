using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IReservationBusinessLogic
    {
        bool Insert(ReservationModel reservation);
        bool Update(ReservationModel reservation);
        bool Delete(ReservationModel reservation);
        IList<ReservationModel> GetAll();
    }
}
