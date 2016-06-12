using System;
using System.Web;
using System.Collections.Generic;
namespace MVC_StepByStep.Models
{
    public class blEmployee
    {
            public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee emp = new Employee();

            emp.FirstName = "Nitesh";
            emp.LastName = "Kumar";
            emp.Salary = 14000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "Vishal";
            emp.LastName = "Kumar";
            emp.Salary = 20000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "Amit";
            emp.LastName = "Singh";
            emp.Salary = 25000;
            employees.Add(emp);

            return employees;
        }

    }
}
