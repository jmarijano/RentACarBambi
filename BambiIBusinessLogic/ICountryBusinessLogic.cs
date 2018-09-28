using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface ICountryBusinessLogic
    {
        bool Insert(CountryModel country);
        bool Update(CountryModel country);
        bool Delete(CountryModel country);
        IList<CountryModel> GetAll();
    }
}
