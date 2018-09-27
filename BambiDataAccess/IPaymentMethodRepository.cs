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

        int Insert(PaymentMethodModel model);
        int Update(PaymentMethodModel model);
        int Delete(PaymentMethodModel model);
        IList<PaymentMethodModel> GetAll();
    }
}
