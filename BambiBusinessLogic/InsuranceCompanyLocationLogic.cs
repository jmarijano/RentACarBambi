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
    /// data access for InsuranceCompanyLocation table. It implements
    /// IInsuranceCompanyLocationBusinessLogic interface.
    /// </summary>
    public class InsuranceCompanyLocationLogic : IInsuranceCompanyLocationBusinessLogic
    {
        private readonly IInsuranceCompanyLocationRepository _insuranceCompanyLocationRepository;

        public InsuranceCompanyLocationLogic()
            : this(new InsuranceCompanyLocationSQLServerDataAccess())
        {

        }
        public InsuranceCompanyLocationLogic(IInsuranceCompanyLocationRepository insuranceCompanyLocationRepository)
        {
            _insuranceCompanyLocationRepository = insuranceCompanyLocationRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insuranceCompanyLocation"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(InsuranceCompanyLocationModel insuranceCompanyLocation)
        {
            return _insuranceCompanyLocationRepository.Delete(insuranceCompanyLocation) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// insurance company location
        /// records from the database.
        /// </summary>
        /// <returns>
        /// Returns all insurance complany location objects as a IList
        /// of InsuranceCompanyLocationModel objects.
        /// </returns>
        public IList<InsuranceCompanyLocationModel> GetAll()
        {
            return _insuranceCompanyLocationRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insuranceCompanyLocation"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(InsuranceCompanyLocationModel insuranceCompanyLocation)
        {
            return _insuranceCompanyLocationRepository.Insert(insuranceCompanyLocation) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insuranceCompanyLocation"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(InsuranceCompanyLocationModel insuranceCompanyLocation)
        {
            return _insuranceCompanyLocationRepository.Update(insuranceCompanyLocation) > 0 ? true : false;
        }
    }
}
