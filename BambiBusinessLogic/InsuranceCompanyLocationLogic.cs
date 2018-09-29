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
        public bool Delete(InsuranceCompanyLocationModel insuranceCompanyLocation)
        {
            return _insuranceCompanyLocationRepository.Delete(insuranceCompanyLocation) > 0 ? true : false;
        }

        public IList<InsuranceCompanyLocationModel> GetAll()
        {
            return _insuranceCompanyLocationRepository.GetAll();
        }

        public bool Insert(InsuranceCompanyLocationModel insuranceCompanyLocation)
        {
            return _insuranceCompanyLocationRepository.Insert(insuranceCompanyLocation) > 0 ? true : false;
        }

        public bool Update(InsuranceCompanyLocationModel insuranceCompanyLocation)
        {
            return _insuranceCompanyLocationRepository.Update(insuranceCompanyLocation) > 0 ? true : false;
        }
    }
}
