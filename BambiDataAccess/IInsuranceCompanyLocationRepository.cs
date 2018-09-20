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

        void Insert(InsuranceCompanyLocationModel model);
        void Update(InsuranceCompanyLocationModel model);
        void Delete(InsuranceCompanyLocationModel model);
        IEnumerable<InsuranceCompanyLocationModel> GetAll();
    }
}
