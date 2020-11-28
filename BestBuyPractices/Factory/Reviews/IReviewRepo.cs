using BestBuyPractices.Models;
using System.Collections.Generic;

namespace BestBuyPractices.Factory.Reviews
{
    interface IReviewRepo
    {
        //Read
        IEnumerable<ReviewProduct> GetReviews();
        //Create
        public void CreateReview(Review review);
        //Update
        public void UpdateReview(string comment);
        //Delete
        public void DeleteReview(int reviewID);

    }
}
