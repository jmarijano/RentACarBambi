using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{
    public interface ITownBusinessLogic
    {
        bool Insert(TownModel town);
        bool Update(TownModel town);
        bool Delete(TownModel town);
        IList<TownModel> GetAll();
    }
}
