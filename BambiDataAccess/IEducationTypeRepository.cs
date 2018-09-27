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

        int Insert(EducationTypeModel model);
        int Update(EducationTypeModel model);
        int Delete(EducationTypeModel model);
        IList<EducationTypeModel> GetAll();
    }
}
