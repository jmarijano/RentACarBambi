using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface ICustomerBusinessLogic
    {
        bool Insert(CustomerModel customer);
        bool Update(CustomerModel customer);
        bool Delete(CustomerModel customer);
        IList<CustomerModel> GetAll();
    }
}
