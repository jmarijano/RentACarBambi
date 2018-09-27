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

        int Insert(ManufacturerModel model);
        int Update(ManufacturerModel model);
        int Delete(ManufacturerModel model);
        IList<ManufacturerModel> GetAll();
    }
}
