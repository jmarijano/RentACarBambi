using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface ICustomerFeedbackRepository
    {
        void Insert(CustomerFeedbackModel model);
        void Update(CustomerFeedbackModel model);
        void Delete(CustomerFeedbackModel model);
        IEnumerable<CustomerFeedbackModel> GetAll();
    }
}
