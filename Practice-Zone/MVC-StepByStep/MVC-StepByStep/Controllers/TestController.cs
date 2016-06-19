using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_StepByStep.Models;
using MVC_StepByStep.ViewModels;
namespace MVC_StepByStep.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public override string ToString()
        {
            return this.CustomerName + "|" + this.CustomerAddress;
        }
    }

    public class TestController : Controller
    {

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Nitesh Kumar";
            c.CustomerAddress = "Thane";
            return c;
        }

        public ActionResult GetView()
        {
            EmpListViewModel empList = new EmpListViewModel();

            blEmployee empBal = new blEmployee();
            List<Employee> employees = empBal.GetEmployees();

            List<EmpViewModel> empViewModels = new List<EmpViewModel>();
            foreach (Employee item in employees)
            {
                EmpViewModel empViewModel = new EmpViewModel();
                empViewModel.EmployeeName = item.FirstName + " " + item.LastName;
                empViewModel.Salary = item.Salary;
                if (item.Salary > 15000)
                    empViewModel.SalaryColor = "yellow";
                else
                    empViewModel.SalaryColor = "green";
                empViewModels.Add(empViewModel);
            }

            empList.Employees = empViewModels;
            empList.UserName = "Admin";

            return View("MyView", empList);
        }
    }
}