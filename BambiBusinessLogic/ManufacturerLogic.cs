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
    public class ManufacturerLogic : IManufacturerBusinessLogic
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerLogic()
            : this(new ManufacturerSQLServerDataAccess())
        {

        }
        public ManufacturerLogic(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }
        public bool Delete(ManufacturerModel manufacturer)
        {
            return _manufacturerRepository.Delete(manufacturer) > 0 ? true : false;
        }

        public IList<ManufacturerModel> GetAll()
        {
            return _manufacturerRepository.GetAll();
        }

        public bool Insert(ManufacturerModel manufacturer)
        {
            return _manufacturerRepository.Insert(manufacturer) > 0 ? true : false;
        }

        public bool Update(ManufacturerModel manufacturer)
        {
            return _manufacturerRepository.Update(manufacturer) > 0 ? true : false;
        }
    }
}
