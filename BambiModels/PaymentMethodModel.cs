using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class PaymentMethodModel
    {
        /// <summary>
        /// The unique identifier for the 
        /// payment method.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of the 
        /// payment method.
        /// </summary>
        public string Name { get; set; }
    }
}
