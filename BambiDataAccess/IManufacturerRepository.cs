using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BambiModels;

namespace BambiDataAccess
{
    public interface IManufacturerRepository
    {
        void Insert(ManufacturerModel manufacturer);
    }
}
