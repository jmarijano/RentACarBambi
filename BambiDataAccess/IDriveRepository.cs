using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IDriveRepository
    {

        int Insert(DriveModel model);
        int Update(DriveModel model);
        int Delete(DriveModel model);
        IList<DriveModel> GetAll();
    }
}
