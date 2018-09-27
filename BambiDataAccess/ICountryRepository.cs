using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface ICountryRepository
    {
        int Insert(CountryModel model);
        int Update(CountryModel model);
        int Delete(CountryModel model);
        IList<CountryModel> GetAll();
    }
}
