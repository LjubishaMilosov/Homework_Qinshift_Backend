//Make a new class CEO that inherits from Employee that will have a property Employees ( an array of Employees),
//Shares property ( int ), SharesPrice ( double )
//The SharesPrice should not be accessed from outside of the class
//There should be a method called AddSharesPrice() that will accept a double number and it will change the SharesPrice.
//This is the only way to change SharesPrice
//The CEO should have a method called PrintEmployees() that will print all employees that work for his company.
//The CEO should override the GetSalary method to return Salary + Shares * SharesPrice
using Domain.Enums;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstname, string lastname, double salary, int shares, Employee[] employees)
            : base(firstname, lastname, RoleEnum.Other, salary)
        {
            Shares = shares;
            Employees = employees;
        }

        public void AddSharesPrice(double price)
        {
            SharesPrice = price;
        }
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}