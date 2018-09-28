using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IPaymentMethodBusinessLogic
    {
        bool Insert(PaymentMethodModel paymentMethod);
        bool Update(PaymentMethodModel paymentMethod);
        bool Delete(PaymentMethodModel paymentMethod);
        IList<PaymentMethodModel> GetAll();
    }
}
