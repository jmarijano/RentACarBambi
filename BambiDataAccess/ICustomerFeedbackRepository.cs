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
        int Insert(CustomerFeedbackModel model);
        int Update(CustomerFeedbackModel model);
        int Delete(CustomerFeedbackModel model);
        IList<CustomerFeedbackModel> GetAll();
    }
}
