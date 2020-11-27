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
        public void UpdateProductName(string name, int id);
        public void UpdateProductPrice(double price, int id);
        public void UpdateProductStockLevel(int stockLevel, int id);
        //Delete
        public void DeleteProduct(int productID);
    }
}
