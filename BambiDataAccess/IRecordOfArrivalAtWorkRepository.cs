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

        int Insert(RecordOfArrivalAtWorkModel model);
        int Update(RecordOfArrivalAtWorkModel model);
        int Delete(RecordOfArrivalAtWorkModel model);
        IList<RecordOfArrivalAtWorkModel> GetAll();
    }
}
