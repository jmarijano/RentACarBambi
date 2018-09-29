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
    public class CustomerFeedbackLogic : ICustomerFeedbackBusinessLogic
    {
        private readonly ICustomerFeedbackRepository _customerFeedbackRepository;
        public CustomerFeedbackLogic()
            : this(new CustomerFeedbackSQLServerDataAccess())
        {

        }
        public CustomerFeedbackLogic(ICustomerFeedbackRepository customerFeedbackRepository)
        {
            _customerFeedbackRepository = customerFeedbackRepository;
        }
        public bool Delete(CustomerFeedbackModel customerFeedback)
        {
            return _customerFeedbackRepository.Delete(customerFeedback) > 0 ? true : false;
        }

        public IList<CustomerFeedbackModel> GetAll()
        {
            return _customerFeedbackRepository.GetAll();
        }

        public bool Insert(CustomerFeedbackModel customerFeedback)
        {
            return _customerFeedbackRepository.Insert(customerFeedback) > 0 ? true : false;
        }

        public bool Update(CustomerFeedbackModel customerFeedback)
        {
            return _customerFeedbackRepository.Update(customerFeedback) > 0 ? true : false;
        }
    }
}
