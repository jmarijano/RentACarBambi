using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IBillRepository
    {
        void Insert(BillModel model);
        void Update(BillModel model);
        void Delete(BillModel model);
        IEnumerable<BillModel> GetAll();

    }
}
