using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class CustomerModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string TownZipCode { get; set; }

        public string Address { get; set; }

        public int ProfessionId { get; set; }

        public int EducationTypeId { get; set; }

        public char Gender { get; set; }
    }
}
