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
    public class PaymentMethodLogic : IPaymentMethodBusinessLogic
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        public PaymentMethodLogic()
            : this(new PaymentMethodSQLServerDataAccess())
        {

        }
        public PaymentMethodLogic(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
        }
        public bool Delete(PaymentMethodModel paymentMethod)
        {
            return _paymentMethodRepository.Delete(paymentMethod) > 0 ? true : false;
        }

        public IList<PaymentMethodModel> GetAll()
        {
            return _paymentMethodRepository.GetAll();
        }

        public bool Insert(PaymentMethodModel paymentMethod)
        {
            return _paymentMethodRepository.Insert(paymentMethod) > 0 ? true : false;
        }

        public bool Update(PaymentMethodModel paymentMethod)
        {
            return _paymentMethodRepository.Update(paymentMethod) > 0 ? true : false;
        }
    }
}
