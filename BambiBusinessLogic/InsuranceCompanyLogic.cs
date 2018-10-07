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
    /// data access for InsuranceCompany table. It implements
    /// IInsuranceCompanyBusinessLogic interface.
    /// </summary>
    public class InsuranceCompanyLogic : IInsuranceCompanyBusinessLogic
    {
        private readonly IInsuranceCompanyRepository _insuranceCompanyRepository;

        public InsuranceCompanyLogic()
            : this(new InsuranceCompanySQLServerDataAccess())
        {

        }
        public InsuranceCompanyLogic(IInsuranceCompanyRepository insuranceCompanyRepository)
        {
            _insuranceCompanyRepository = insuranceCompanyRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insuranceCompany"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(InsuranceCompanyModel insuranceCompany)
        {
            return _insuranceCompanyRepository.Delete(insuranceCompany) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// insurance company records from the database.
        /// </summary>
        /// <returns>
        /// Returns all insurance company objects as a IList
        /// of InsuranceCompanyModel objects.
        /// </returns>
        public IList<InsuranceCompanyModel> GetAll()
        {
            return _insuranceCompanyRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insuranceCompany"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(InsuranceCompanyModel insuranceCompany)
        {
            return _insuranceCompanyRepository.Insert(insuranceCompany) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insuranceCompany"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(InsuranceCompanyModel insuranceCompany)
        {
            return _insuranceCompanyRepository.Update(insuranceCompany) > 0 ? true : false;
        }
    }
}
