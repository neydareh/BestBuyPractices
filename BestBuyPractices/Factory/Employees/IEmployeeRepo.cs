using BestBuyPractices.Models;
using System.Collections.Generic;

namespace BestBuyPractices.Factory.Employees
{
    interface IEmployeeRepo
    {
        //Read
        IEnumerable<Employee> GetEmployees();
        //Create
        public void CreateEmployee(Employee employee);
        //Update
        public void UpdateEmployee(Employee employee);
        //Delete
        public void DeleteEmployee(int employeeID);
    }
}
