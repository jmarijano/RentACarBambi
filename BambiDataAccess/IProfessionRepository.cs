using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface IProfessionRepository
    {

        void Insert(ProfessionModel model);
        void Update(ProfessionModel model);
        void Delete(ProfessionModel model);
        IEnumerable<ProfessionModel> GetAll();
    }
}
