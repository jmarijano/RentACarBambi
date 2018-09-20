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
        void Insert(DiscountModel model);
        void Update(DiscountModel model);
        void Delete(DiscountModel model);
        IEnumerable<DiscountModel> GetAll();
    }
}
