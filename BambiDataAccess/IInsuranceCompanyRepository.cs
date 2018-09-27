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

        int Insert(InsuranceCompanyModel model);
        int Update(InsuranceCompanyModel model);
        int Delete(InsuranceCompanyModel model);
        IList<InsuranceCompanyModel> GetAll();
    }
}
