using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class RecordOfArrivalAtWork
    {
        /// <summary>
        /// The unique identifier for the record
        /// of arrival at work.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The arrival date and time of the record.
        /// </summary>
        public DateTime DateAndTimeOfArrival { get; set; }

        /// <summary>
        /// The depart time and time of the record.
        /// </summary>
        public DateTime DateAndTimeOfDepart { get; set; }

        /// <summary>
        /// The employee for which the record is created.
        /// </summary>
        public Employee Employee { get; set; }
    }
}
