using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IInsuranceCompanyBusinessLogic
    {
        bool Insert(InsuranceCompanyModel insuranceCompany);
        bool Update(InsuranceCompanyModel insuranceCompany);
        bool Delete(InsuranceCompanyModel insuranceCompany);
        IList<InsuranceCompanyModel> GetAll();
    }
}
