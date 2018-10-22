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
    /// data access for EngineType table. It implements
    /// IEngineTypeBusinessLogic interface.
    /// </summary>
    public class EngineTypeLogic : IEngineTypeBusinessLogic
    {
        private readonly IEngineTypeRepository _engineTypeRepository;

        /// <summary>
        /// Constructor whose purpose is to create
        /// a new EngineTypeSQLServerDataAccess object.
        /// </summary>
        public EngineTypeLogic()
            : this(new EngineTypeSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set 
        /// _engineTypeRepository variable.
        /// </summary>
        /// <param name="engineTypeRepository">
        /// Existing IEngineTypeRepository object.
        /// </param>
        public EngineTypeLogic(IEngineTypeRepository engineTypeRepository)
        {
            _engineTypeRepository = engineTypeRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// and existing EngineType object.
        /// </summary>
        /// <param name="engineType">
        /// Existing EngineTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(EngineTypeModel engineType)
        {
            return _engineTypeRepository.Delete(engineType) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// engine type records from the database.
        /// </summary>
        /// <returns>
        /// Returns all engine type objects as a IList
        /// of EngineTypeModel objects.
        /// </returns>
        public IList<EngineTypeModel> GetAll()
        {
            return _engineTypeRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert
        /// a new EngineType record.
        /// </summary>
        /// <param name="engineType">
        /// Newly created EngineTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(EngineTypeModel engineType)
        {
            return _engineTypeRepository.Insert(engineType) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update
        /// an existing EngineType record.
        /// </summary>
        /// <param name="engineType">
        /// Existing EngineTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(EngineTypeModel engineType)
        {
            return _engineTypeRepository.Update(engineType) > 0 ? true : false;
        }
    }
}
