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
    /// <summary>
    /// Business logic class whose purpose is to handle 
    /// data access for ModelOfProduction table. It implements
    /// IModelOfProductionBusinessLogic interface.
    /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelOfProduction"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(ModelOfProductionModel modelOfProduction)
        {
            return _modelOfProductionRepository.Delete(modelOfProduction) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// model of production records from the database.
        /// </summary>
        /// <returns>
        /// Returns all model of production objects as a IList
        /// of ModelOfProductionModel objects.
        /// </returns>
        public IList<ModelOfProductionModel> GetAll()
        {
            return _modelOfProductionRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelOfProduction"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(ModelOfProductionModel modelOfProduction)
        {
            return _modelOfProductionRepository.Insert(modelOfProduction) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelOfProduction"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(ModelOfProductionModel modelOfProduction)
        {
            return _modelOfProductionRepository.Update(modelOfProduction) > 0 ? true : false;
        }
    }
}
