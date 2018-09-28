using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IManufacturerBusinessLogic
    {
        bool Insert(ManufacturerModel manufacturer);
        bool Update(ManufacturerModel manufacturer);
        bool Delete(ManufacturerModel manufacturer);
        IList<ManufacturerModel> GetAll();
    }
}
