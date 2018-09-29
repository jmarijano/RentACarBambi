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
        public bool Delete(InsuranceCompanyModel insuranceCompany)
        {
            return _insuranceCompanyRepository.Delete(insuranceCompany) > 0 ? true : false;
        }

        public IList<InsuranceCompanyModel> GetAll()
        {
            return _insuranceCompanyRepository.GetAll();
        }

        public bool Insert(InsuranceCompanyModel insuranceCompany)
        {
            return _insuranceCompanyRepository.Insert(insuranceCompany) > 0 ? true : false;
        }

        public bool Update(InsuranceCompanyModel insuranceCompany)
        {
            return _insuranceCompanyRepository.Update(insuranceCompany) > 0 ? true : false;
        }
    }
}
