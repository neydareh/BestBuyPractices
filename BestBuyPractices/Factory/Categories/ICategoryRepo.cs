using BestBuyPractices.Models;
using System.Collections.Generic;

namespace BestBuyPractices.Factory.Categories
{
    interface ICategoryRepo
    {
        //Read
        IEnumerable<Category> GetCategories();
        //Create
        public void CreateCategory(Category category);
        //Update
        public void UpdateCategory(Category category);
    }
}
