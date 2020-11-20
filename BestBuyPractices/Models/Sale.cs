using System;

namespace BestBuyPractices.Models
{
    public class Sale
    {
        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
    }
}
