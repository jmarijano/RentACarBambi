using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IClassRepository
    {
        int Insert(ClassModel model);
        int Update(ClassModel model);
        int Delete(ClassModel model);
        IList<ClassModel> GetAll();
        ClassModel GetClass(int Id);
    }
}
 