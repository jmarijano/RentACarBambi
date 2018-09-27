using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IEngineTypeRepository
    {

        int Insert(EngineTypeModel model);
        int Update(EngineTypeModel model);
        int Delete(EngineTypeModel model);
        IList<EngineTypeModel> GetAll();
    }
}
