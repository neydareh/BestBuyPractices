using BestBuyPractices.Factory;

namespace BestBuyPractices.Models
{
    public class Category: ICallable
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public int ID => CategoryID;

    }
}
