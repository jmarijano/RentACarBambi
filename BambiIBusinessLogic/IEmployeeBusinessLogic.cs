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
    /// for Employee table.
    /// </summary>
    public interface IEmployeeBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Employee table.
        /// </summary>
        /// <param name="employee">
        /// Newly created EmployeeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(EmployeeModel employee);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in Employee table.
        /// </summary>
        /// <param name="employee">
        /// Existing EmployeeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(EmployeeModel employee);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in Employee table.
        /// </summary>
        /// <param name="employee">
        /// Existing EmployeeModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(EmployeeModel employee);

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in Employee table.
        /// </summary>
        /// <returns>
        /// Returns all records from Employee table as a
        /// IList of EmployeeModel objects.
        /// </returns>
        IList<EmployeeModel> GetAll();
    }
}
