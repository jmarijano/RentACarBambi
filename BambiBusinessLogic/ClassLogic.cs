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
    /// Business logic layer class that handles
    /// data access for class table in the 
    /// database.
    /// </summary>
    public class ClassLogic : IClassBusinessLogic
    {
        /// <summary>
        /// Private readonly IClassRepository variable
        /// whose purpose is to call data access layer
        /// methods.
        /// </summary>
        private readonly IClassRepository _classRepository;

        /// <summary>
        /// Constructor whose purpose is to create
        /// a new ClassSQLServerDataAccess object
        /// for the next constructor.
        /// </summary>
        public ClassLogic()
            : this(new ClassSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set
        /// private readonly variable value with
        /// the passed parameter.
        /// </summary>
        /// <param name="classRepository">
        /// Existing IClassRepository object.
        /// </param>
        public ClassLogic(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        /// <summary>
        /// Method whose purpose is to delete
        /// existing class model object from
        /// the database.
        /// </summary>
        /// <param name="class">
        /// Existing class model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Delete(ClassModel @class)
        {
            return _classRepository.Delete(@class) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to get
        /// all class records from the database
        /// and save them to a list.
        /// </summary>
        /// <returns>
        /// Returns a list of all class 
        /// record from the database as
        /// IList ClassModel
        /// </returns>
        public IList<ClassModel> GetAll()
        {
            return _classRepository.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert
        /// a newly created class model
        /// object into the database.
        /// </summary>
        /// <param name="class">
        /// Newly created class model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Insert(ClassModel @class)
        {
            return _classRepository.Insert(@class) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update
        /// existing database record.
        /// </summary>
        /// <param name="class">
        /// Existing class model object.
        /// </param>
        /// <returns>
        /// Returns true if the query is
        /// successfully executed otherwise
        /// returns false.
        /// </returns>
        public bool Update(ClassModel @class)
        {
            return _classRepository.Update(@class) > 0 ? true : false;
        }
    }
}
