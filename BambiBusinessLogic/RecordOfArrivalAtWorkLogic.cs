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
        public bool Delete(RecordOfArrivalAtWorkModel recordOfArrivalAtWork)
        {
            return _recordOfArrivalAtWorkRepository.Delete(recordOfArrivalAtWork) > 0 ? true : false;
        }

        public IList<RecordOfArrivalAtWorkModel> GetAll()
        {
            return _recordOfArrivalAtWorkRepository.GetAll();
        }

        public bool Insert(RecordOfArrivalAtWorkModel recordOfArrivalAtWork)
        {
            return _recordOfArrivalAtWorkRepository.Insert(recordOfArrivalAtWork) > 0 ? true : false;
        }

        public bool Update(RecordOfArrivalAtWorkModel recordOfArrivalAtWork)
        {
            return _recordOfArrivalAtWorkRepository.Update(recordOfArrivalAtWork) > 0 ? true : false;
        }
    }
}
