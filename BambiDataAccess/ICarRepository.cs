using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface ICarRepository
    {
        int Insert(CarModel model);
        int Update(CarModel model);
        int Delete(CarModel model);
        IList<CarModel> GetAll();
    }
}
