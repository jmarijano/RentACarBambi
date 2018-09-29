using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BambiDataAccess;
using BambiIBusinessLogic;
using BambiModels;
using BambiSQLServerDataAccess;

namespace BambiBusinessLogic
{
    public class BillLogic : IBillBusinessLogic
    {
        private readonly IBillRepository _billBusinessLogic;

        public BillLogic()
            : this(new BillSQLServerDataAccess())
        {

        }
        public BillLogic(IBillRepository billBusinessLogic)
        {
            _billBusinessLogic = billBusinessLogic;
        }
        public bool Delete(BillModel bill)
        {
            return _billBusinessLogic.Delete(bill) > 0 ? true : false;
        }

        public IList<BillModel> GetAll()
        {
            return _billBusinessLogic.GetAll();
        }

        public bool Insert(BillModel bill)
        {
            return _billBusinessLogic.Insert(bill) > 0 ? true : false;
        }

        public bool Update(BillModel bill)
        {
            return _billBusinessLogic.Update(bill) > 0 ? true : false;
        }
    }
}
