using System;
using System.Web;
using System.Collections.Generic;
using MVC_StepByStep.DAL;
using System.Linq;

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

        public List<Employee> GetDAEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }

        public void DeleteEmployee(int id)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            Employee e = salesDal.Employees.Find(id);
            salesDal.Employees.Remove(e);
            salesDal.SaveChanges();
            //return e;
        }
    }
}
