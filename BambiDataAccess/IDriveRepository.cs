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

        void Insert(DriveModel model);
        void Update(DriveModel model);
        void Delete(DriveModel model);
        IEnumerable<DriveModel> GetAll();
    }
}
