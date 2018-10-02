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
    /// <summary>
    /// Business logic class whose purpose is to
    /// handle data access layer classes. It implements
    /// ICountryBusinessLogic interface.
    /// </summary>
    public class CountryLogic : ICountryBusinessLogic
    {
        /// <summary>
        /// Private readonly ICountryRepository variable
        /// whose purpose is to call data access methods.
        /// </summary>
        private readonly ICountryRepository _countryRepository;

        /// <summary>
        /// Constructor whose purpose is to create a new
        /// CountrySQLServerDataAccess object for the
        /// next constructor.
        /// </summary>
        public CountryLogic()
            : this(new CountrySQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set private
        /// readonly variable value. It's value is identical
        /// to the value of passed parameter.
        /// </summary>
        /// <param name="countryRepository">
        /// Existing ICountryRepository object.
        /// </param>
        public CountryLogic(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// existing country record from the
        /// database.
        /// </summary>
        /// <param name="country">
        /// Existing country model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Delete(CountryModel country)
        {
            return _countryRepository.Delete(country) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to get
        /// all country records from 
        /// the database.
        /// </summary>
        /// <returns>
        /// Returns all country records from
        /// the database as IList of 
        /// CountryModel objects.
        /// </returns>
        public IList<CountryModel> GetAll()
        {
            return _countryRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert
        /// a new country record in the database.
        /// </summary>
        /// <param name="country">
        /// Newly created country model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is 
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Insert(CountryModel country)
        {
            return _countryRepository.Insert(country) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update
        /// an existing country record from
        /// the database.
        /// </summary>
        /// <param name="country">
        /// Existing country model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is 
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Update(CountryModel country)
        {
            return _countryRepository.Update(country) > 0 ? true : false;
        }
    }
}
