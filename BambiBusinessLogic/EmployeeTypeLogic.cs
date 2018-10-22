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

        /// <summary>
        /// Constructor whose purpose is to create
        /// a new EmployeeTypeSQLServerDataAccess object.
        /// </summary>
        public EmployeeTypeLogic()
            : this(new EmployeeTypeSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Method whose purpose is to set 
        /// _employeeTypeRepository variable.
        /// </summary>
        /// <param name="employeeTypeRepository">
        /// Existing IEmployeeTypeRepository object.
        /// </param>
        public EmployeeTypeLogic(IEmployeeTypeRepository employeeTypeRepository)
        {
            _employeeTypeRepository = employeeTypeRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// an existing EmployeeType record.
        /// </summary>
        /// <param name="employeeType">
        /// Existing EmployeeTypeModel object.
        /// </param>
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
        /// Method whose purpose is to insert a
        /// new EmployeeType record.
        /// </summary>
        /// <param name="employeeType">
        /// Existing EmployeeTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(EmployeeTypeModel employeeType)
        {
            return _employeeTypeRepository.Insert(employeeType) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an
        /// existing EmployeeType record.
        /// </summary>
        /// <param name="employeeType">
        /// Existing EmployeeTypeModel object.
        /// </param>
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
