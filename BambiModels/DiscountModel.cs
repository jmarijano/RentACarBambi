using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class DiscountModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BeginningDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Percentage { get; set; }

        public int CarId { get; set; }
    }
}
