using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiDataAccess
{
    public interface ITownRepository
    {

        int Insert(TownModel model);
        int Update(TownModel model);
        int Delete(TownModel model);
        IList<TownModel> GetAll();
    }
}
