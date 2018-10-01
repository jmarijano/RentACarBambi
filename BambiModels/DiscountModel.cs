using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class DiscountModel
    {
        /// <summary>
        /// The unique identifier for the discount.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of the discount.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the date on which the discount
        /// starts to be valid.
        /// </summary>
        public DateTime BeginningDate { get; set; }

        /// <summary>
        /// Represent the date on which the discount
        /// ends to be valid.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Represent the amount of discount
        /// in percentages.
        /// </summary>
        public int Percentage { get; set; }

        /// <summary>
        /// Represents the unique car identifier
        /// for which the disount is valid.
        /// </summary>
        public int CarId { get; set; }
    }
}
