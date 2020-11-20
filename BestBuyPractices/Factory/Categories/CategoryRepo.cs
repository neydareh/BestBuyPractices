using BestBuyPractices.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace BestBuyPractices.Factory.Categories
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly IDbConnection _connection;

        public CategoryRepo(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _connection.Query<Category>("SELECT * FROM categories");
        }
        public void CreateCategory(Category category)
        {
            _connection.Execute("INSERT INTO categories (Name, DepartmentID) VALUES (@catName, @departmentID)", 
                new { 
                    catName = category.Name,
                    departmentID = category.DepartmentID
                });
        }
        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
