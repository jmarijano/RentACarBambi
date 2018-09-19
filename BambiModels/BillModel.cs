using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class BillModel
    {
        /// <summary>
        /// The unique identifier for the bill.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The issue date of the bill.
        /// </summary>
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// The reservation id for which the bill is.
        /// </summary>
        public int ReservationId { get; set; }

        /// <summary>
        /// The discount id for which the bill is.
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// The employee id which issued the bill.
        /// </summary>
        public string EmployeeId { get; set; }
    }
}
