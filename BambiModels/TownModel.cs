using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class TownModel
    {
        /// <summary>
        /// The unique identifier for the town.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// The name of the town.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the unique identifier
        /// of the country where the city
        /// is located.
        /// </summary>
        public int CountryId { get; set; }

    }
}
