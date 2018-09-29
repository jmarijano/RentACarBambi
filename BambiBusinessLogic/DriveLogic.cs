using BambiDataAccess;
using BambiIBusinessLogic;
using BambiModels;
using BambiSQLServerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiBusinessLogic
{
    public class DriveLogic : IDriveBusinessLogic
    {
        private readonly IDriveRepository _driveRepository;
        public DriveLogic()
            : this(new DriveSQLServerDataAccess())
        {

        }
        public DriveLogic(IDriveRepository driveRepository)
        {
            _driveRepository = driveRepository;
        }
        public bool Delete(DriveModel drive)
        {
            return _driveRepository.Delete(drive) > 0 ? true : false;
        }

        public IList<DriveModel> GetAll()
        {
            return _driveRepository.GetAll();
        }

        public bool Insert(DriveModel drive)
        {
            return _driveRepository.Insert(drive) > 0 ? true : false;
        }

        public bool Update(DriveModel drive)
        {
            return _driveRepository.Update(drive) > 0 ? true : false;
        }
    }
}
