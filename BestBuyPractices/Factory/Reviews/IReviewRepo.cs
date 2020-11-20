using BestBuyPractices.Models;
using System.Collections.Generic;

namespace BestBuyPractices.Factory.Reviews
{
    interface IReviewRepo
    {
        //Read
        IEnumerable<Review> GetReviews();
        //Create
        public void CreateReview(Review review);
        //Update
        public void UpdateReview(Review review);
        //Delete
        public void DeleteReview(int reviewID);

    }
}
