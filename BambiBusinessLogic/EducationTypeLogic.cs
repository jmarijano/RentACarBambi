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
    /// Business logic class whose purpose is to handle
    /// data access layer for education type table from
    /// the database. It implements IEducationTypeBusinessLogic
    /// interface.
    /// </summary>
    public class EducationTypeLogic : IEducationTypeBusinessLogic
    {
        private readonly IEducationTypeRepository _educationTypeRepository;

        /// <summary>
        /// Constructor whose purpose is to create a new
        /// EducationTypeSQLServerDataAccess object
        /// for the next constructor.
        /// </summary>
        public EducationTypeLogic()
            : this(new EducationTypeSQLServerDataAccess())
        {

        }
        
        /// <summary>
        /// Constructor whose purpose is to set
        /// private readonly variable value. The value is
        /// the same as the value of the passed parameter.
        /// </summary>
        /// <param name="educationTypeRepository">
        /// Existing IEducationTypeRepository object.
        /// </param>
        public EducationTypeLogic(IEducationTypeRepository educationTypeRepository)
        {
            _educationTypeRepository = educationTypeRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete existing object
        /// from the database
        /// </summary>
        /// <param name="educationType">
        /// Existing education type model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Delete(EducationTypeModel educationType)
        {
            return _educationTypeRepository.Delete(educationType) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to return all
        /// education type records from the database.
        /// </summary>
        /// <returns>
        /// Returns all education type objects as a IList
        /// of EducationTypeModel objects.
        /// </returns>
        public IList<EducationTypeModel> GetAll()
        {
            return _educationTypeRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="educationType"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Insert(EducationTypeModel educationType)
        {
            return _educationTypeRepository.Insert(educationType) > 0 ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="educationType"></param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        public bool Update(EducationTypeModel educationType)
        {
            return _educationTypeRepository.Update(educationType) > 0 ? true : false;
        }
    }
}
