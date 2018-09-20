using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IPaymentMethodRepository
    {

        void Insert(PaymentMethodModel model);
        void Update(PaymentMethodModel model);
        void Delete(PaymentMethodModel model);
        IEnumerable<PaymentMethodModel> GetAll();
    }
}
