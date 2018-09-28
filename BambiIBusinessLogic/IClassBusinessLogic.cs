using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IClassBusinessLogic
    {
        bool Insert(ClassModel @class);
        bool Update(ClassModel @class);
        bool Delete(ClassModel @class);
        IList<ClassModel> GetAll();
    }
}
