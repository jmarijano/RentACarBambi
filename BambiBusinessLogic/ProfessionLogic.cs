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
    public class ProfessionLogic : IProfessionBusinessLogic
    {
        private readonly IProfessionRepository _professionRepository;
        public ProfessionLogic()
            : this(new ProfessionSQLServerDataAccess())
        {

        }
        public ProfessionLogic(IProfessionRepository professionRepository)
        {
            _professionRepository = professionRepository;
        }
        public bool Delete(ProfessionModel profession)
        {
            return _professionRepository.Delete(profession) > 0 ? true : false;
        }

        public IList<ProfessionModel> GetAll()
        {
            return _professionRepository.GetAll();
        }

        public bool Insert(ProfessionModel profession)
        {
            return _professionRepository.Insert(profession) > 0 ? true : false;
        }

        public bool Update(ProfessionModel profession)
        {
            return _professionRepository.Update(profession) > 0 ? true : false;
        }
    }
}
