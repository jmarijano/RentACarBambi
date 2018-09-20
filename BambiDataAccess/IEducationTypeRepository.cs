using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IEducationTypeRepository
    {

        void Insert(EducationTypeModel model);
        void Update(EducationTypeModel model);
        void Delete(EducationTypeModel model);
        IEnumerable<EducationTypeModel> GetAll();
    }
}
