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

        public ManufacturerLogic()
            : this(new ManufacturerSQLServerDataAccess())
        {

        }
        public ManufacturerLogic(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturer"></param>
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
        /// 
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(ManufacturerModel manufacturer)
        {
            return _manufacturerRepository.Insert(manufacturer) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturer"></param>
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
