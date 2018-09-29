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
    public class EmployeeLogic : IEmployeeBusinessLogic
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeLogic()
            : this(new EmployeeSQLServerDataAccess())
        {

        }
        public EmployeeLogic(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public bool Delete(EmployeeModel employee)
        {
            return _employeeRepository.Delete(employee) > 0 ? true : false;
        }

        public IList<EmployeeModel> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public bool Insert(EmployeeModel employee)
        {
            return _employeeRepository.Insert(employee) > 0 ? true : false;
        }

        public bool Update(EmployeeModel employee)
        {
            return _employeeRepository.Update(employee) > 0 ? true : false;
        }
    }
}
