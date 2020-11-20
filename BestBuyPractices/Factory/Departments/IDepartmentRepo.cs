using BestBuyPractices.Models;
using System.Collections.Generic;

namespace BestBuyPractices.Factory.Departments
{
    interface IDepartmentRepo
    {
        //Read
        IEnumerable<Department> GetDepartments();
        //Create
        public void CreateDepartment(Department department);
        //Update
        public void UpdateDepartment(Department department);
        //Delete
        public void DeleteDepartment(int departmentID);
    }
}
