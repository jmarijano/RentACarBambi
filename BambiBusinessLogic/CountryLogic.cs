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
    public class CountryLogic : ICountryBusinessLogic
    {
        private readonly ICountryRepository _countryRepository;
        public CountryLogic()
            : this(new CountrySQLServerDataAccess())
        {

        }
        public CountryLogic(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public bool Delete(CountryModel country)
        {
            return _countryRepository.Delete(country) > 0 ? true : false;
        }

        public IList<CountryModel> GetAll()
        {
            return _countryRepository.GetAll();
        }

        public bool Insert(CountryModel country)
        {
            return _countryRepository.Insert(country) > 0 ? true : false;
        }

        public bool Update(CountryModel country)
        {
            return _countryRepository.Update(country) > 0 ? true : false;
        }
    }
}
