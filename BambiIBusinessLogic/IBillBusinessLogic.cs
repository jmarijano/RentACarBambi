using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IBillBusinessLogic
    {
        bool Insert(BillModel bill);
        bool Update(BillModel bill);
        bool Delete(BillModel bill);
        IList<BillModel> GetAll();
    }
}
