using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IEngineTypeBusinessLogic
    {
        bool Insert(EngineTypeModel engineType);
        bool Update(EngineTypeModel engineType);
        bool Delete(EngineTypeModel engineType);
        IList<EngineTypeModel> GetAll();
    }
}
