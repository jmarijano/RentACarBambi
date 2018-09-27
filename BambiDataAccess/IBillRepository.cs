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
        int Insert(BillModel model);
        int Update(BillModel model);
        int Delete(BillModel model);
        IList<BillModel> GetAll();

    }
}
