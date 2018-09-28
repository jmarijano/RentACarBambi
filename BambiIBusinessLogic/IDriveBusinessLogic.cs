using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IDriveBusinessLogic
    {
        bool Insert(DriveModel drive);
        bool Update(DriveModel drive);
        bool Delete(DriveModel drive);
        IList<DriveModel> GetAll();
    }
}
