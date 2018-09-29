using BambiDataAccess;
using BambiIBusinessLogic;
using BambiModels;
using BambiSQLServerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiBusinessLogic
{
    public class TownLogic : ITownBusinessLogic
    {
        private readonly ITownRepository _townRepository;
        public TownLogic()
            : this(new TownSQLServerDataAccess())
        {

        }
        public TownLogic(ITownRepository townRepository)
        {
            _townRepository = townRepository;
        }
        public bool Delete(TownModel town)
        {
            return _townRepository.Delete(town) > 0 ? true : false;
        }

        public IList<TownModel> GetAll()
        {
            return _townRepository.GetAll();
        }

        public bool Insert(TownModel town)
        {
            return _townRepository.Insert(town) > 0 ? true : false;
        }

        public bool Update(TownModel town)
        {
            return _townRepository.Update(town) > 0 ? true : false;
        }
    }
}
