using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface ICustomerRepository
    {
        void Insert(CustomerModel model);
        void Update(CustomerModel model);
        void Delete(CustomerModel model);
        IEnumerable<CustomerModel> GetAll();
    }
}
