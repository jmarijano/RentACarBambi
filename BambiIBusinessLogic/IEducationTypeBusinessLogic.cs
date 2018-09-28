using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IEducationTypeBusinessLogic
    {
        bool Insert(EducationTypeModel educationType);
        bool Update(EducationTypeModel educationType);
        bool Delete(EducationTypeModel educationType);
        IList<EducationTypeModel> GetAll();
    }
}
