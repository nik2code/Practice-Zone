using System;
using System.Web;

namespace MVC_StepByStep.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Employee() { }

        public Employee(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
    }
}


