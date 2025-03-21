using Domain.Enums;

namespace Domain.Models
{

// EXERCISE 1
//Create a class library project and in it create all classes
//● Create a class called Employee with the following
//properties:
//▹ FirstName
//▹ LastName
//▹ Role - Enum(Sales, Manager, Other )
//▹ Salary - protected, double
//● Create two methods:
//▹ PrintInfo - Prints FirstName, LastName and Salary
//▹ GetSalary - returns the salary


    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        protected double Salary { get; set; }
        public Employee() { }
        public Employee(string firstname, string lastName, RoleEnum role, double salary)
        {
            FirstName = firstname;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
