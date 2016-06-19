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

    public class EmployeeController : Controller
    {

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Nitesh Kumar";
            c.CustomerAddress = "Thane";
            return c;
        }

        public ActionResult Index()
        {
            EmpListViewModel empList = new EmpListViewModel();

            blEmployee empBal = new blEmployee();
            List<Employee> employees = empBal.GetDAEmployees();//.GetEmployees();

            List<EmpViewModel> empViewModels = new List<EmpViewModel>();
            foreach (Employee item in employees)
            {
                EmpViewModel empViewModel = new EmpViewModel();
                empViewModel.EmployeeId = item.EmployeeId;
                empViewModel.EmployeeName = item.FirstName + " " + item.LastName;
                empViewModel.Salary = item.Salary;
                if (item.Salary > 15000)
                    empViewModel.SalaryColor = "yellow";
                else
                    empViewModel.SalaryColor = "green";
                empViewModels.Add(empViewModel);
            }

            empList.Employees = empViewModels;
            //empList.UserName = "Admin";

            return View("Index", empList);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    // return Content(e.FirstName + " | " + e.LastName + " | " + e.Salary);
                    blEmployee empbl = new blEmployee();
                    empbl.SaveEmployee(e);
                    return RedirectToAction("Index");
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }

        public ActionResult DeleteEmployee(int id)
        {
            blEmployee empbl = new blEmployee();
            empbl.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}