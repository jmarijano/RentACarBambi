using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{

    /// <summary>
    /// Represents abstract object whose purpose 
    /// is to call methods from data access layer classes
    /// for EmployeeType table.
    /// </summary>
    public interface IEmployeeTypeBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in EmployeeType table.
        /// </summary>
        /// <param name="employeeType">
        /// Newly created EmployeeTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(EmployeeTypeModel employeeType);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in EmployeeType table.
        /// </summary>
        /// <param name="employeeType">
        /// Existing EmployeeTypeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(EmployeeTypeModel employeeType);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in EmployeeTypeModel table.
        /// </summary>
        /// <param name="employeeType">
        /// Existing EmployeeType object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(EmployeeTypeModel employeeType);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from EmployeeType table.
        /// </summary>
        /// <returns>
        /// Returns all records from EmployeeType table as a
        /// IList of EmployeeTypeModel objects.
        /// </returns>
        IList<EmployeeTypeModel> GetAll();
    }
}
