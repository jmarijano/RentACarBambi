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
        int Insert(CustomerModel model);
        int Update(CustomerModel model);
        int Delete(CustomerModel model);
        IList<CustomerModel> GetAll();
    }
}
