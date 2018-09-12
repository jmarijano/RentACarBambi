using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class InsuranceCompanyModel
    {
        /// <summary>
        /// The unique identifier for the insurance company.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the insurance company.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The e - mail address of the insurance company.
        /// </summary>
        public string Email { get; set; }
    }
}
