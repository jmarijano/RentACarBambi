using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IRecordOfArrivalAtWorkRepository
    {

        void Insert(RecordOfArrivalAtWorkModel model);
        void Update(RecordOfArrivalAtWorkModel model);
        void Delete(RecordOfArrivalAtWorkModel model);
        IEnumerable<RecordOfArrivalAtWorkModel> GetAll();
    }
}
