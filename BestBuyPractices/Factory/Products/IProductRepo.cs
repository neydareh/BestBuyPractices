using BestBuyPractices.Models;
using System.Collections.Generic;

namespace BestBuyPractices.Factory.Products
{
    interface IProductRepo
    {
        //Read
        IEnumerable<Product> GetAllProducts();
        //Create
        public void CreateProduct(Product product);
        //Update
        public void UpdateProduct(Product product);
        //Delete
        public void DeleteProduct(int productID);
    }
}
