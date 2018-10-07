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
    /// data access for RecordOfArrivalAtWork table. It implements
    /// IRecordOfArrivalAtWorkBusinessLogic interface.
    /// </summary>
    public class RecordOfArrivalAtWorkLogic : IRecordOfArrivalAtWorkBusinessLogic
    {
        private readonly IRecordOfArrivalAtWorkRepository _recordOfArrivalAtWorkRepository;

        public RecordOfArrivalAtWorkLogic()
            : this(new RecordOfArrivalAtWorkSQLServerDataAccess())
        {

        }
        public RecordOfArrivalAtWorkLogic(IRecordOfArrivalAtWorkRepository recordOfArrivalAtWorkRepository)
        {
            _recordOfArrivalAtWorkRepository = recordOfArrivalAtWorkRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordOfArrivalAtWork"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(RecordOfArrivalAtWorkModel recordOfArrivalAtWork)
        {
            return _recordOfArrivalAtWorkRepository.Delete(recordOfArrivalAtWork) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// records of arrival at work
        /// from the database.
        /// </summary>
        /// <returns>
        /// Returns all record of arrival at work objects as a IList
        /// of RecordOfArrivalAtWorkModel objects.
        /// </returns>
        public IList<RecordOfArrivalAtWorkModel> GetAll()
        {
            return _recordOfArrivalAtWorkRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordOfArrivalAtWork"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(RecordOfArrivalAtWorkModel recordOfArrivalAtWork)
        {
            return _recordOfArrivalAtWorkRepository.Insert(recordOfArrivalAtWork) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordOfArrivalAtWork"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(RecordOfArrivalAtWorkModel recordOfArrivalAtWork)
        {
            return _recordOfArrivalAtWorkRepository.Update(recordOfArrivalAtWork) > 0 ? true : false;
        }
    }
}
