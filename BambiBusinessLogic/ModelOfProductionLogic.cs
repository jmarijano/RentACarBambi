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
    public class ModelOfProductionLogic : IModelOfProductionBusinessLogic
    {
        private readonly IModelOfProductionRepository _modelOfProductionRepository;
        public ModelOfProductionLogic()
            : this(new ModelOfProductionSQLServerDataAccess())
        {

        }
        public ModelOfProductionLogic(IModelOfProductionRepository modelOfProductionRepository)
        {
            _modelOfProductionRepository = modelOfProductionRepository;
        }
        public bool Delete(ModelOfProductionModel modelOfProduction)
        {
            return _modelOfProductionRepository.Delete(modelOfProduction) > 0 ? true : false;
        }

        public IList<ModelOfProductionModel> GetAll()
        {
            return _modelOfProductionRepository.GetAll();
        }

        public bool Insert(ModelOfProductionModel modelOfProduction)
        {
            return _modelOfProductionRepository.Insert(modelOfProduction) > 0 ? true : false;
        }

        public bool Update(ModelOfProductionModel modelOfProduction)
        {
            return _modelOfProductionRepository.Update(modelOfProduction) > 0 ? true : false;
        }
    }
}
