using BambiDataAccess;
using BambiIBusinessLogic;
using BambiModels;
using BambiSQLServerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiBusinessLogic
{
    public class EngineTypeLogic : IEngineTypeBusinessLogic
    {
        private readonly IEngineTypeRepository _engineTypeRepository;
        public EngineTypeLogic()
            : this(new EngineTypeSQLServerDataAccess())
        {

        }
        public EngineTypeLogic(IEngineTypeRepository engineTypeRepository)
        {
            _engineTypeRepository = engineTypeRepository;
        }
        public bool Delete(EngineTypeModel engineType)
        {
            return _engineTypeRepository.Delete(engineType) > 0 ? true : false;
        }

        public IList<EngineTypeModel> GetAll()
        {
            return _engineTypeRepository.GetAll();
        }

        public bool Insert(EngineTypeModel engineType)
        {
            return _engineTypeRepository.Insert(engineType) > 0 ? true : false;
        }

        public bool Update(EngineTypeModel engineType)
        {
            return _engineTypeRepository.Update(engineType) > 0 ? true : false;
        }
    }
}
