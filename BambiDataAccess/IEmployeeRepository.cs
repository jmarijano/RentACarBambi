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

        void Insert(EmployeeModel model);
        void Update(EmployeeModel model);
        void Delete(EmployeeModel model);
        IEnumerable<EmployeeModel> GetAll();
    }
}
