using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IEmployeeRepository
    {

        int Insert(EmployeeModel model);
        int Update(EmployeeModel model);
        int Delete(EmployeeModel model);
        IList<EmployeeModel> GetAll();
    }
}
