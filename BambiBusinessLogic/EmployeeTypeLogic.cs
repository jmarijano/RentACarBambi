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
    /// <summary>
    /// Business logic class whose purpose is to handle 
    /// data access for Employee table. It implements
    /// IEmployeeTypeBusinessLogic interface.
    /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeType"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(EmployeeTypeModel employeeType)
        {
            return _employeeTypeRepository.Delete(employeeType) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// employee type records from the database.
        /// </summary>
        /// <returns>
        /// Returns all employee type objects as a IList
        /// of EmployeeTypeModel objects.
        /// </returns>
        public IList<EmployeeTypeModel> GetAll()
        {
            return _employeeTypeRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeType"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(EmployeeTypeModel employeeType)
        {
            return _employeeTypeRepository.Insert(employeeType) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeType"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(EmployeeTypeModel employeeType)
        {
            return _employeeTypeRepository.Update(employeeType) > 0 ? true : false;
        }
    }
}
