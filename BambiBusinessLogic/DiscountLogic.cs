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
    public class DiscountLogic : IDiscountBusinessLogic
    {
        private readonly IDiscountRepository _discountRepository;

        public DiscountLogic()
            : this(new DiscountSQLServerDataAccess())
        {

        }
        public DiscountLogic(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }
        public bool Delete(DiscountModel discount)
        {
            return _discountRepository.Delete(discount) > 0 ? true : false;
        }

        public IList<DiscountModel> GetAll()
        {
            return _discountRepository.GetAll();
        }

        public bool Insert(DiscountModel discount)
        {
            return _discountRepository.Insert(discount) > 0 ? true : false;
        }

        public bool Update(DiscountModel discount)
        {
            return _discountRepository.Update(discount) > 0 ? true : false;
        }
    }
}
