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
    /// data access for Manufacturer table. It implements
    /// IManufacturerBusinessLogic interface.
    /// </summary>
    public class ManufacturerLogic : IManufacturerBusinessLogic
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        /// <summary>
        /// Constructor whose purpose is to create
        /// a ManufacturerSQLServerDataAccess object.
        /// </summary>
        public ManufacturerLogic()
            : this(new ManufacturerSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to
        /// set _manufacturerRepository variable.
        /// </summary>
        /// <param name="manufacturerRepository">
        /// Existing IManufacturerRepository object.
        /// </param>
        public ManufacturerLogic(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// an existing Manufacturer record.
        /// </summary>
        /// <param name="manufacturer">
        /// Existing ManufacturerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(ManufacturerModel manufacturer)
        {
            return _manufacturerRepository.Delete(manufacturer) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// manufacturer records from the database.
        /// </summary>
        /// <returns>
        /// Returns all manufacturer objects as a IList
        /// of ManufacturerModel objects.
        /// </returns>
        public IList<ManufacturerModel> GetAll()
        {
            return _manufacturerRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert a 
        /// new Manufacturer record.
        /// </summary>
        /// <param name="manufacturer">
        /// Newly created ManufacturerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(ManufacturerModel manufacturer)
        {
            return _manufacturerRepository.Insert(manufacturer) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to 
        /// update an existing Manufacturer record.
        /// </summary>
        /// <param name="manufacturer">
        /// Existing ManufacturerModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(ManufacturerModel manufacturer)
        {
            return _manufacturerRepository.Update(manufacturer) > 0 ? true : false;
        }
    }
}
