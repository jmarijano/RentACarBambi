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
    public class ClassLogic : IClassBusinessLogic
    {
        private readonly IClassRepository _classRepository;
        public ClassLogic()
            : this(new ClassSQLServerDataAccess())
        {

        }
        public ClassLogic(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public bool Delete(ClassModel @class)
        {
            return _classRepository.Delete(@class) > 0 ? true : false;
        }

        public IList<ClassModel> GetAll()
        {
            return _classRepository.GetAll();
        }

        public bool Insert(ClassModel @class)
        {
            return _classRepository.Insert(@class) > 0 ? true : false;
        }

        public bool Update(ClassModel @class)
        {
            return _classRepository.Update(@class) > 0 ? true : false;
        }
    }
}
