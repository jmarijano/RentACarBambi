using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IDiscountRepository
    {
        int Insert(DiscountModel model);
        int Update(DiscountModel model);
        int Delete(DiscountModel model);
        IList<DiscountModel> GetAll();
    }
}
