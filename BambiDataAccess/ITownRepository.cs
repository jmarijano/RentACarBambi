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

        void Insert(TownModel model);
        void Update(TownModel model);
        void Delete(TownModel model);
        IEnumerable<TownModel> GetAll();
    }
}
