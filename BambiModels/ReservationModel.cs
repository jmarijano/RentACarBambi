using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class ReservationModel
    {
        /// <summary>
        /// The unique identifier for
        /// the reservation.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the date on which the 
        /// reservation was confirmed.
        /// </summary>
        public DateTime DateOfBooking { get; set; }

        /// <summary>
        /// Represents the beginning date
        /// of the reservation.
        /// </summary>
        public DateTime BeginningDate{ get; set; }

        /// <summary>
        /// Represents the ending date
        /// of the reservation.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Represents the unique identifier
        /// of the rented car.
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// Represents the unique customer identifier
        /// who rents the car.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Represents the distance travelled in 
        /// kilometers in the reservation time.
        /// </summary>
        public int DistanceDriven { get; set; }

        /// <summary>
        /// Represents the unique identifier of the
        /// employee who issued the reservation.
        /// </summary>
        public string EmployeeId { get; set; }
    }
}
