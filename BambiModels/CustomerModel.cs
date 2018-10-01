using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class CustomerModel
    {
        /// <summary>
        /// The unique identifier for the customer.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Represents the customer first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the customer last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represent the customer e - mail address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Represent the customer phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Represents the zip code of the city
        /// where the customer lives.
        /// </summary>
        public string TownZipCode { get; set; }

        /// <summary>
        /// Represents customer living address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Represents customers profession.
        /// </summary>
        public int ProfessionId { get; set; }

        /// <summary>
        /// Represents customers professional
        /// qualification.
        /// </summary>
        public int EducationTypeId { get; set; }

        /// <summary>
        /// Represents customers gender.
        /// </summary>
        public char Gender { get; set; }
    }
}
