using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
   public class Employee
    {
        /// <summary>
        /// The unique identifier for the employee.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the employee.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The gender of the employee.
        /// </summary>
        public char Gender { get; set; }

        /// <summary>
        /// The salary that employee has.
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// The e - mail adress of the employee.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The education type that employee has.
        /// </summary>
        public EducationType EducationType { get; set; }

        /// <summary>
        /// The profession that employee has.
        /// </summary>
        public Profession Profession { get; set; }

        /// <summary>
        /// The birth date of the employee.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The hire date of the employee.
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// The phone number of the employee.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The town in which employee lives.
        /// </summary>
        public Town Town { get; set; }

        /// <summary>
        /// The address of employees home.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The hourly rate of employee.
        /// </summary>
        public decimal HourlyRate { get; set; }

        /// <summary>
        /// The length of employment of the employee.
        /// </summary>
        public int LengthOfEmployment { get; set; }

        /// <summary>
        /// The type of employee.
        /// </summary>
        public EmployeeType EmployeeType { get; set; }

        /// <summary>
        /// The username for the employee.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password for the employee.
        /// </summary>
        public string Password { get; set; }
    }
}
