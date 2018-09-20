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

        void Insert(ModelOfProductionModel model);
        void Update(ModelOfProductionModel model);
        void Delete(ModelOfProductionModel model);
        IEnumerable<ModelOfProductionModel> GetAll();
    }
}
