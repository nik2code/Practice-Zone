using System;
using System.Web;

namespace MVC_StepByStep.ViewModels
{
    public class EmpViewModel
    {
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public string SalaryColor { get; set; }


        public EmpViewModel() { }

        public EmpViewModel(string empName, int sal, string salColor, string userName)
        {
            EmployeeName = empName;
            Salary = sal;
            SalaryColor = salColor;

        }
    }
}
