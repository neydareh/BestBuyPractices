using BestBuyPractices.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace BestBuyPractices.Factory.Products
{
    class ProductRepo : IProductRepo
    {
        private readonly IDbConnection _connection;
        public ProductRepo(IDbConnection connection)
        {
            _connection = connection;
        }
        public void CreateProduct(Product product)
        {
           _connection.Execute("" +
               "INSERT INTO products (Name, Price, CategoryID, OnSale, StockLevel) " +
               "VALUES (@pName, @pPrice, @pCatID, @pOnSale, @pStockLevel)", 
                new { 
                    pName = product.Name,
                    pPrice = product.Price,
                    pCatID = product.CategoryID,
                    pOnSale = product.OnSale,
                    pStockLevel = product.StockLevel
                });
        }
        public void DeleteProduct(int productID)
        {
            _connection.Execute("DELETE FROM products WHERE ProductID = (@prodID)", 
                new { 
                    prodID = productID
                });
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("bestbuy.ShowProducts", commandType: CommandType.StoredProcedure);
        }

        void IProductRepo.UpdateProductName(string name, int id)
        {
            _connection.Execute("UPDATE products SET Name = @pName WHERE ProductID = @pID", 
                new {
                    @pName = name,
                    @pID = id
                });
        }

        void IProductRepo.UpdateProductPrice(double price, int id)
        {
            _connection.Execute("UPDATE products SET Price = @pPrice WHERE ProductID = @pID", new { @pPrice = price, @pID = id });
        }

        void IProductRepo.UpdateProductStockLevel(int stockLevel, int id)
        {
            _connection.Execute("UPDATE products SET StockLevel = @pStockLevel WHERE ProductID = @pID", 
                new { @pStockLevel = stockLevel, @pID = id });
        }
    }
}
