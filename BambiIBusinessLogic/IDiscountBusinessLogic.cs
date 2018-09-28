using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IDiscountBusinessLogic
    {
        bool Insert(DiscountModel discount);
        bool Update(DiscountModel discount);
        bool Delete(DiscountModel discount);
        IList<DiscountModel> GetAll();
    }
}
