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

        /// <summary>
        /// Constructor whose purpose is to create a 
        /// new ModelOfProductionSQLServerDataAccess object.
        /// </summary>
        public ModelOfProductionLogic()
            : this(new ModelOfProductionSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set
        /// _modelOfProductionRepository variable.
        /// </summary>
        /// <param name="modelOfProductionRepository">
        /// Existing IModelOfProductionRepository object.
        /// </param>
        public ModelOfProductionLogic(IModelOfProductionRepository modelOfProductionRepository)
        {
            _modelOfProductionRepository = modelOfProductionRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// an existing ModelOfProduction object.
        /// </summary>
        /// <param name="modelOfProduction">
        /// Existing ModelOfProductionModel object.
        /// </param>
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
        /// Method whose purpose is to insert
        /// a new ModelOfProduction record.
        /// </summary>
        /// <param name="modelOfProduction">
        /// Newly created ModelOfProductionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(ModelOfProductionModel modelOfProduction)
        {
            return _modelOfProductionRepository.Insert(modelOfProduction) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update
        /// an existing ModelOfProduction record.
        /// </summary>
        /// <param name="modelOfProduction">
        /// Existing ModelOfProductionModel object.
        /// </param>
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
