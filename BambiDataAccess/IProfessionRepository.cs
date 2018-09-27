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

        int Insert(ProfessionModel model);
        int Update(ProfessionModel model);
        int Delete(ProfessionModel model);
        IList<ProfessionModel> GetAll();
    }
}
