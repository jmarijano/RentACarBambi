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
        /// <summary>
        /// Private readonly IBillRepository variable 
        /// which represents the abstraction of the
        /// data access layer.
        /// </summary>
        private readonly IBillRepository _billBusinessLogic;

        /// <summary>
        /// Constructor  that creates a new 
        /// BillSQlServerDataAccess object for the 
        /// next constructor.
        /// </summary>
        public BillLogic()
            : this(new BillSQLServerDataAccess())
        {

        }

        /// <summary>
        /// Constructor whose purpose is to set the 
        /// private readonly variable value with 
        /// the passed parameter.
        /// </summary>
        /// <param name="billBusinessLogic">Existing 
        /// IBillRepository object.</param>
        public BillLogic(IBillRepository billBusinessLogic)
        {
            _billBusinessLogic = billBusinessLogic;
        }
        /// <summary>
        /// Method whose purpose is to delete passed
        /// bill object in the database.
        /// </summary>
        /// <param name="bill">Existing bill model object.</param>
        /// <returns>Returns true if the query is successfully
        /// executed otherwise returns false.</returns>
        public bool Delete(BillModel bill)
        {
            return _billBusinessLogic.Delete(bill) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to get all bill
        /// records from the database.
        /// </summary>
        /// <returns>Return all bill records from database
        /// as list of type IList<BillModel>.</returns>
        /// 
        public IList<BillModel> GetAll()
        {
            return _billBusinessLogic.GetAll();
        }

        /// <summary>
        /// Method whose purpose is to insert passed
        /// bill object in the database.
        /// </summary>
        /// <param name="bill">Newly created bill model object.</param>
        /// <returns>Returns true if the query is successfully
        /// executed otherwise returns false.</returns>
        public bool Insert(BillModel bill)
        {
            return _billBusinessLogic.Insert(bill) > 0 ? true : false;
        }

        /// <summary>
        /// Method whose purpose is to update passed
        /// bill object in the database.
        /// </summary>
        /// <param name="bill">Existing bill model object.</param>
        /// <returns>Returs true if the query is successfully
        /// executed otherwise returns false.</returns>
        public bool Update(BillModel bill)
        {
            return _billBusinessLogic.Update(bill) > 0 ? true : false;
        }
    }
}
