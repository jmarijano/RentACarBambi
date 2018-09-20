using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IInsuranceCompanyRepository
    {

        void Insert(InsuranceCompanyModel model);
        void Update(InsuranceCompanyModel model);
        void Delete(InsuranceCompanyModel model);
        IEnumerable<InsuranceCompanyModel> GetAll();
    }
}
