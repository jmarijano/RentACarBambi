using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IInsuranceCompanyLocationBusinessLogic
    {
        bool Insert(InsuranceCompanyLocationModel insuranceCompanyLocation);
        bool Update(InsuranceCompanyLocationModel insuranceCompanyLocation);
        bool Delete(InsuranceCompanyLocationModel insuranceCompanyLocation);
        IList<InsuranceCompanyLocationModel> GetAll();
    }
}
