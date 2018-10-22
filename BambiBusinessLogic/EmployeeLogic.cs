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
    /// IEmployeeBusinessLogic interface.
    /// </summary>
    public class EmployeeLogic : IEmployeeBusinessLogic
    {
        private readonly IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Constructor whose purpose is to create a new
        /// EmployeeSQLServerDataAccess object.
        /// </summary>
        public EmployeeLogic()
            : this(new EmployeeSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set
        /// IEmployeeRepository variable
        /// </summary>
        /// <param name="employeeRepository">
        /// Existing IEmployeeRepository object.
        /// </param>
        public EmployeeLogic(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// an existing Employee record.
        /// </summary>
        /// <param name="employee">
        /// Existing EmployeeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(EmployeeModel employee)
        {
            return _employeeRepository.Delete(employee) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// employee records from the database.
        /// </summary>
        /// <returns>
        /// Returns all employee objects as a IList
        /// of EmployeeModel objects.
        /// </returns>
        public IList<EmployeeModel> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to inser a new
        /// Employee record.
        /// </summary>
        /// <param name="employee">
        /// Newly created EmployeeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(EmployeeModel employee)
        {
            return _employeeRepository.Insert(employee) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an existing
        /// Employee record.
        /// </summary>
        /// <param name="employee">
        /// Existing EmployeeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(EmployeeModel employee)
        {
            return _employeeRepository.Update(employee) > 0 ? true : false;
        }
    }
}
