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
        void Insert(CountryModel model);
        void Update(CountryModel model);
        void Delete(CountryModel model);
        IEnumerable<CountryModel> GetAll();
    }
}
