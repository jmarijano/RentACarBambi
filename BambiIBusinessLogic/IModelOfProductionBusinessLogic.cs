using BambiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambiIBusinessLogic
{

    /// <summary>
    /// Represents abstract object whose purpose 
    /// is to call methods from data access layer classes
    /// for ModelOfProduction table.
    /// </summary>
    public interface IModelOfProductionBusinessLogic
    {

        /// <summary>
        /// Calls data access layer method which inserts
        /// new record in ModelOfProduction table.
        /// </summary>
        /// <param name="modelOfProduction">
        /// Newly created ModelOfProductionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Insert(ModelOfProductionModel modelOfProduction);

        /// <summary>
        /// Calls data access layer method which updates an
        /// existing record in ModelOfProduction table.
        /// </summary>
        /// <param name="modelOfProduction">
        /// Existing ModelOfProductionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Update(ModelOfProductionModel modelOfProduction);

        /// <summary>
        /// Calls data access layer method which deletes an
        /// existing record in ModelOfProduction table.
        /// </summary>
        /// <param name="modelOfProduction">
        /// Existing ModelOfProductionModel object.
        /// </param>
        /// <returns>
        /// Returns true if the query is successfully executed
        /// otherwise returns false.
        /// </returns>
        bool Delete(ModelOfProductionModel modelOfProduction);

        /// <summary>
        /// Calls data access layer method which returns
        /// all records from ModelOfProduction table.
        /// </summary>
        /// <returns>
        /// Returns all records from ModelOfProduction table as a 
        /// IList of ModelOfProductionModel objects.
        /// </returns>
        IList<ModelOfProductionModel> GetAll();
    }
}
