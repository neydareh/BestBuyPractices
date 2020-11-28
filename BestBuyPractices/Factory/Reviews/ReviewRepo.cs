using BestBuyPractices.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BestBuyPractices.Factory.Reviews
{
    public class ReviewRepo : IReviewRepo
    {
        private readonly IDbConnection _connection;
        public ReviewRepo(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<ReviewProduct> GetReviews()
        {
            var sql = "bestbuy.ShowCompleteReview";
            //return _connection.Query<Review>("SELECT * from reviews");
            return _connection.Query<ReviewProduct>(sql, commandType: CommandType.StoredProcedure);
        }
        public void CreateReview(Review review)
        {
            _connection.Execute("INSERT INTO reviews (ProductID, Reviewer, Rating, Comment) " +
                "VALUES(@pID, @rReviewer, @rRating, @rComment)",
                new
                {
                    @pID = review.ProductID,
                    @rReviewer = review.Reviewer,
                    @rRating = review.Rating,
                    @rComment = review.Comment
                });
        }

        public void DeleteReview(int reviewID)
        {
            _connection.Execute("DELETE from reviews WHERE ReviewID = @rID", new { @rID = reviewID });
        }


        public void UpdateReview(string comment)
        {
            throw new NotImplementedException();
        }

    }
}
