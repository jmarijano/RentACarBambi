using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class CustomerFeedbackModel
    {
        /// <summary>
        /// Represents the unique identifier 
        /// for the customer feedback.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents a rating the customer
        /// has provided.
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// Represents the description the 
        /// customer left.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Represents the unique identifier
        /// of the customer which has
        /// left the feedback.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Represents the unique vehicle 
        /// identifier for which the user 
        /// left the feedback.
        /// </summary>
        public int CarId { get; set; }
    }
}
