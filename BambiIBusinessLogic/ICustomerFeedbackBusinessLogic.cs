using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface ICustomerFeedbackBusinessLogic
    {
        bool Insert(CustomerFeedbackModel customerFeedback);
        bool Update(CustomerFeedbackModel customerFeedback);
        bool Delete(CustomerFeedbackModel customerFeedback);
        IList<CustomerFeedbackModel> GetAll();
    }
}
