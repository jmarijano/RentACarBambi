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
    public class EmployeeTypeLogic : IEmployeeTypeBusinessLogic
    {
        private readonly IEmployeeTypeRepository _employeeTypeRepository;
        public EmployeeTypeLogic()
            : this(new EmployeeTypeSQLServerDataAccess())
        {

        }
        public EmployeeTypeLogic(IEmployeeTypeRepository employeeTypeRepository)
        {
            _employeeTypeRepository = employeeTypeRepository;
        }
        public bool Delete(EmployeeTypeModel employeeType)
        {
            return _employeeTypeRepository.Delete(employeeType) > 0 ? true : false;
        }

        public IList<EmployeeTypeModel> GetAll()
        {
            return _employeeTypeRepository.GetAll();
        }

        public bool Insert(EmployeeTypeModel employeeType)
        {
            return _employeeTypeRepository.Insert(employeeType) > 0 ? true : false;
        }

        public bool Update(EmployeeTypeModel employeeType)
        {
            return _employeeTypeRepository.Update(employeeType) > 0 ? true : false;
        }
    }
}
