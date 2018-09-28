using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface IProfessionBusinessLogic
    {
        bool Insert(ProfessionModel profession);
        bool Update(ProfessionModel profession);
        bool Delete(ProfessionModel profession);
        IList<ProfessionModel> GetAll();
    }
}
