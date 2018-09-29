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
    public class EducationTypeLogic : IEducationTypeBusinessLogic
    {
        private readonly IEducationTypeRepository _educationTypeRepository;

        public EducationTypeLogic()
            : this(new EducationTypeSQLServerDataAccess())
        {

        }
        public EducationTypeLogic(IEducationTypeRepository educationTypeRepository)
        {
            _educationTypeRepository = educationTypeRepository;
        }
        public bool Delete(EducationTypeModel educationType)
        {
            return _educationTypeRepository.Delete(educationType) > 0 ? true : false;
        }

        public IList<EducationTypeModel> GetAll()
        {
            return _educationTypeRepository.GetAll();
        }

        public bool Insert(EducationTypeModel educationType)
        {
            return _educationTypeRepository.Insert(educationType) > 0 ? true : false;
        }

        public bool Update(EducationTypeModel educationType)
        {
            return _educationTypeRepository.Update(educationType) > 0 ? true : false;
        }
    }
}
