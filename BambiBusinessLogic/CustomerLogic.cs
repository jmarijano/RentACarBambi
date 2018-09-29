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
    public class CustomerLogic : ICustomerBusinessLogic
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerLogic()
            : this(new CustomerSQLServerDataAccess())
        {

        }
        public CustomerLogic(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public bool Delete(CustomerModel customer)
        {
            return _customerRepository.Delete(customer) > 0 ? true : false;
        }

        public IList<CustomerModel> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public bool Insert(CustomerModel customer)
        {
            return _customerRepository.Insert(customer) > 0 ? true : false;
        }

        public bool Update(CustomerModel customer)
        {
            return _customerRepository.Update(customer) > 0 ? true : false;
        }
    }
}
