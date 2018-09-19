using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class ReservationModel
    {

        public int Id { get; set; }

        public DateTime DateOfBooking { get; set; }

        public DateTime BeginningDate{ get; set; }

        public DateTime EndDate { get; set; }

        public int CarId { get; set; }

        public string CustomerId { get; set; }

        public int DistanceDriven { get; set; }

        public string EmployeeId { get; set; }
    }
}
