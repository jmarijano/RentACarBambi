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
        public ProfessionLogic()
            : this(new ProfessionSQLServerDataAccess())
        {

        }
        public ProfessionLogic(IProfessionRepository professionRepository)
        {
            _professionRepository = professionRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="profession"></param>
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
        /// 
        /// </summary>
        /// <param name="profession"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(ProfessionModel profession)
        {
            return _professionRepository.Insert(profession) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="profession"></param>
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
