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

        void Insert(EngineTypeModel model);
        void Update(EngineTypeModel model);
        void Delete(EngineTypeModel model);
        IEnumerable<EngineTypeModel> GetAll();
    }
}
