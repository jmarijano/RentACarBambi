using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class CustomerFeedbackModel
    {
        public int Id { get; set; }

        public int Grade { get; set; }

        public string Description { get; set; }

        public string CustomerId { get; set; }

        public int CarId { get; set; }
    }
}
