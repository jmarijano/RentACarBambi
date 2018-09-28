using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IRecordOfArrivalAtWorkBusinessLogic
    {
        bool Insert(RecordOfArrivalAtWorkModel recordOfArrivalAtWork);
        bool Update(RecordOfArrivalAtWorkModel recordOfArrivalAtWork);
        bool Delete(RecordOfArrivalAtWorkModel recordOfArrivalAtWork);
        IList<RecordOfArrivalAtWorkModel> GetAll();
    }
}
