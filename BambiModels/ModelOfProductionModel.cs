using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class ModelOfProductionModel
    {
        /// <summary>
        /// The unique identifier for the model of production.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the model of production.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The manufacturer that builded model of production.
        /// </summary>
        public ManufacturerModel Manufacturer { get; set; }
    }
}
