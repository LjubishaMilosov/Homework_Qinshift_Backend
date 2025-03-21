//Task 1
//Extend the exercise for Employees with two more Employees.
//Add a class called Contractor that inherits from Employee.
//The employee should have properties: WorkHours(double), PayPerHour(int) and Responsible(Manager (object )).
//The GetSalary method should be overridden to return WorkHours * PayPerHour and also change the Salary property to that amount
//A new method called CurrentPosition should return the department of the manager that is responsible for this Contractor

using Domain.Enums;
namespace Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager ResponsibleManager { get; set; }

        public Contractor(
            string firstname,
            string lastName,
           // RoleEnum role,
           // double salary,
            double workHours,
            int payPerHour,
            Manager responsibleManager
            )
               : base(firstname, lastName, RoleEnum.Other, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            ResponsibleManager = responsibleManager;
        }
        public override double GetSalary()
        {
            //return Salary += WorkHours * PayPerHour;
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        // CurrentPosition() method returns the department of the manager that is responsible for this Contractor
        //  => renamed to managersCurrentDepartment() to avoid confusion
        public string managersCurrentDepartment()
        {
            return ResponsibleManager?.Department;
        }
    }
}
