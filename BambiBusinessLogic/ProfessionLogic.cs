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
    /// Business logic class whose purpose is to handle 
    /// data access for Profession table. It implements
    /// IProfessionBusinessLogic interface.
    /// </summary>
    public class ProfessionLogic : IProfessionBusinessLogic
    {
        private readonly IProfessionRepository _professionRepository;

        /// <summary>
        /// Constructor whose purpose is to create
        /// a new ProfessionSQLServerDataAccess object.
        /// </summary>
        public ProfessionLogic()
            : this(new ProfessionSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is
        /// to set _professionRepository variable.
        /// </summary>
        /// <param name="professionRepository">
        /// Existing IProfessionRepository object.
        /// </param>
        public ProfessionLogic(IProfessionRepository professionRepository)
        {
            _professionRepository = professionRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete an existing
        /// profession record from the database
        /// </summary>
        /// <param name="profession">
        /// Existing ProfessionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(ProfessionModel profession)
        {
            return _professionRepository.Delete(profession) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// profession records from the database.
        /// </summary>
        /// <returns>
        /// Returns all profession objects as a IList
        /// of ProfessionModel objects.
        /// </returns>
        public IList<ProfessionModel> GetAll()
        {
            return _professionRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to 
        /// insert a new ProfessionModel record.
        /// </summary>
        /// <param name="profession">
        /// Newly created ProfessionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(ProfessionModel profession)
        {
            return _professionRepository.Insert(profession) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an existing
        /// ProfessionModel record.
        /// </summary>
        /// <param name="profession">
        /// Existing ProfessionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(ProfessionModel profession)
        {
            return _professionRepository.Update(profession) > 0 ? true : false;
        }
    }
}
