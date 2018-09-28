using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface ICarBusinessLogic
    {
        bool Insert(CarModel car);
        bool Update(CarModel car);
        bool Delete(CarModel car);
        IList<CarModel> GetAll();
    }
}
