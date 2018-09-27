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
        int Insert(EmployeeTypeModel model);
        int Update(EmployeeTypeModel model);
        int Delete(EmployeeTypeModel model);
        IList<EmployeeTypeModel> GetAll();
    }
}
