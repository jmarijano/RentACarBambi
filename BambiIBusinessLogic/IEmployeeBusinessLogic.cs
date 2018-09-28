using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IEmployeeBusinessLogic
    {
        bool Insert(EmployeeModel employee);
        bool Update(EmployeeModel employee);
        bool Delete(EmployeeModel employee);
        IList<EmployeeModel> GetAll();
    }
}
