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
    /// <summary>
    /// Business logic layer class whose purpose is to 
    /// handle data access layer classes. It implements
    /// IDriveBusinessLogic interface.
    /// </summary>
    public class DriveLogic : IDriveBusinessLogic
    {
        private readonly IDriveRepository _driveRepository;

        /// <summary>
        /// Constructor whose purpose is to create a new
        /// DriveSQLServerDataAccess object for the
        /// next constructor.
        /// </summary>
        public DriveLogic()
            : this(new DriveSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set private readonly 
        /// variable value. It's value is the same as the value
        /// of passed parameter.
        /// </summary>
        /// <param name="driveRepository">
        /// Existing IDriveRepository object.
        /// </param>
        public DriveLogic(IDriveRepository driveRepository)
        {
            _driveRepository = driveRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete an existing
        /// drive record from the database.
        /// </summary>
        /// <param name="drive">
        /// Existing drive model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Delete(DriveModel drive)
        {
            return _driveRepository.Delete(drive) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to get all
        /// drive records from the database.
        /// </summary>
        /// <returns>
        /// Returns all drive records from the database
        /// as a IList of drive model objects.
        /// </returns>
        public IList<DriveModel> GetAll()
        {
            return _driveRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert a
        /// new drive record into the database.
        /// </summary>
        /// <param name="drive">
        /// Newly created drive model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Insert(DriveModel drive)
        {
            return _driveRepository.Insert(drive) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update an
        /// existing drive record from the database.
        /// </summary>
        /// <param name="drive">
        /// Existing drive model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully
        /// executed otherwise returns false.
        /// </returns>
        public bool Update(DriveModel drive)
        {
            return _driveRepository.Update(drive) > 0 ? true : false;
        }
    }
}
