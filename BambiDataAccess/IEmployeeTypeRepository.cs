using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IEmployeeTypeRepository
    {
        void Insert(EmployeeTypeModel model);
        void Update(EmployeeTypeModel model);
        void Delete(EmployeeTypeModel model);
        IEnumerable<EmployeeTypeModel> GetAll();
    }
}
