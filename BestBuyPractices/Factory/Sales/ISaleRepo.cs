using BestBuyPractices.Models;
using System.Collections.Generic;

namespace BestBuyPractices.Factory.Sales
{
    interface ISaleRepo
    {
        //Read
        IEnumerable<Sale> GetAllSale();
        //Create
        public void CreateSale(Sale sale);
        //Update
        public void DeleteSale(int salesID);
    }
}
