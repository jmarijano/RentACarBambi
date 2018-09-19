using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class InsuranceCompanyLocationModel
    {
        /// <summary>
        /// The address of the insurance company.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The town on which insurancy company has building.
        /// 
        /// </summary>
        public string TownZipCode { get; set; }

        /// <summary>
        /// The insurance company.
        /// </summary>
        public int InsuranceCompanyId { get; set; }
    }
}
