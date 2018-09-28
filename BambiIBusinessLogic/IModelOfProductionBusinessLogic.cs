using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IModelOfProductionBusinessLogic
    {
        bool Insert(ModelOfProductionModel modelOfProduction);
        bool Update(ModelOfProductionModel modelOfProduction);
        bool Delete(ModelOfProductionModel modelOfProduction);
        IList<ModelOfProductionModel> GetAll();
    }
}
