using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IInsuranceCompanyLocationRepository
    {

        int Insert(InsuranceCompanyLocationModel model);
        int Update(InsuranceCompanyLocationModel model);
        int Delete(InsuranceCompanyLocationModel model);
        IList<InsuranceCompanyLocationModel> GetAll();
    }
}
