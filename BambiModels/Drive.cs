using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiModels
{
    public class Drive
    {
        private int _id;
        private string _name;

        /// <summary>
        /// The unique identifier for the drive.
        /// </summary>
        public int Id { get => _id; set => _id = value; }

        /// <summary>
        /// The name of the drive.
        /// </summary>
        public string Name { get => _name; set => _name = value; }
    }
}
