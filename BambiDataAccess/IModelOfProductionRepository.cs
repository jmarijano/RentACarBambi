using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IModelOfProductionRepository
    {

        int Insert(ModelOfProductionModel model);
        int Update(ModelOfProductionModel model);
        int Delete(ModelOfProductionModel model);
        IList<ModelOfProductionModel> GetAll();
    }
}
