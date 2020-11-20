namespace BestBuyPractices.Models
{
    public class Review
    {
        public int ProductID { get; set; }
        public int Rating { get; set; }
        public int ReviewID { get; set; }
        public string Reviewer { get; set; }
        public string Comment { get; set; }
    }
}
