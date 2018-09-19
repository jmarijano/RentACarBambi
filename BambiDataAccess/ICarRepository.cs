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
        void Insert(CarModel model);
        void Update(CarModel model);
        void Delete(CarModel model);
        IEnumerable<CarModel> GetAll();
    }
}
