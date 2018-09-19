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
        void Insert(ClassModel model);
        void Update(ClassModel model);
        void Delete(ClassModel model);
        IEnumerable<ClassModel> GetAll();
        ClassModel GetClass(int Id);
    }
}
 