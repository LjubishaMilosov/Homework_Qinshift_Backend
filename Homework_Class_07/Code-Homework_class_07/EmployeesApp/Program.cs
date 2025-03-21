using System.Runtime.ConstrainedExecution;
using Domain.Enums;
using Domain.Models;

//testing code:
//Employee employee = new Employee("Petko", "Petkovski", RoleEnum.Other, 600);
//employee.PrintInfo();
//Console.WriteLine(employee.GetSalary());

//SalesPerson salesPerson = new SalesPerson("Stefan", "Stefanovski", 0);
//salesPerson.PrintInfo();
//salesPerson.AddSuccessRevenue(2500);
//Console.WriteLine(salesPerson.GetSalary());

//Manager manager = new Manager("Manager", "Managerovski", 600, "Management");
//manager.PrintInfo();
//manager.AddBonus(100);
//Console.WriteLine(manager.GetSalary());
//manager.AddBonus(150);
//Console.WriteLine(manager.GetSalary());

//Contractor contractor = new Contractor("Contractor", "Contractorovski", 40, 10, manager);
//contractor.PrintInfo();
//Console.WriteLine(contractor.GetSalary());
//Console.WriteLine("The current position of the contractor's manager is: " + contractor.managersCurrentDepartment()); //managersCurrentDepartment


Manager manager1 = new Manager("Mona", "Monalisa", 600, "Middle Management");
Manager manager2 = new Manager("Bob", "Bobert", 700, "Upper Management");

Contractor contractor1 = new Contractor("Igor", "Igorsky", 40, 10, manager1);
Contractor contractor2 = new Contractor("Lea", "Leova", 40, 20, manager2);

SalesPerson salesPerson1 = new SalesPerson("Rick", "Rickert", 2500);

Employee[] Company = new Employee[]
{
    contractor1,
    contractor2,
    manager1,
    manager2,
    salesPerson1
};


//Create a new instance of CEO and call:
//ceoName.PrintInfo(),
//ceoName.PrintEmployees()
//and ceoName.GetSalary() to check if everything is working.


CEO ceo = new CEO("Ron", "Ronsky", 1500, 100, Company);
ceo.PrintInfo();
ceo.PrintEmployees();
ceo.AddSharesPrice(14);
Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");


//  Bonus, print information about all employees in the Company array
Console.WriteLine("S=================Bonus========================");
foreach (var emp in Company)
{
    emp.PrintInfo();
    Console.WriteLine(emp.GetSalary());
    if (emp is Contractor contr)
    {
        Console.WriteLine("The current position of the contractor's manager is: " + contr.managersCurrentDepartment());
    }
}