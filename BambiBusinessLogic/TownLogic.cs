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
    /// data access for Town table. It implements
    /// ITownBusinessLogic interface.
    /// </summary>
    public class TownLogic : ITownBusinessLogic
    {
        private readonly ITownRepository _townRepository;

        /// <summary>
        /// Constructor whose purpose is to create a new
        /// TownSQLServerDataAccess for the next constructor.
        /// </summary>
        public TownLogic()
            : this(new TownSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is 
        /// to set _townRepository variable.
        /// </summary>
        /// <param name="townRepository">
        /// Existing ITownRepository object.
        /// </param>
        public TownLogic(ITownRepository townRepository)
        {
            _townRepository = townRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete an existing
        /// town from the database.
        /// </summary>
        /// <param name="town">
        /// Existing TownModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(TownModel town)
        {
            return _townRepository.Delete(town) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// town records from the database.
        /// </summary>
        /// <returns>
        /// Returns all town objects as a IList
        /// of TownModel objects.
        /// </returns>
        public IList<TownModel> GetAll()
        {
            return _townRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert a 
        /// new town in the database.
        /// </summary>
        /// <param name="town">
        /// Newly created TownModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(TownModel town)
        {
            return _townRepository.Insert(town) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an existing
        /// town in the database.
        /// </summary>
        /// <param name="town">
        /// Existing TownModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(TownModel town)
        {
            return _townRepository.Update(town) > 0 ? true : false;
        }
    }
}
