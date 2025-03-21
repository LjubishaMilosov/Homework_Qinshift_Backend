//EXERCISE 3
//Add class Manager that inherits from Employee and
//has a new property called Bonus - double, private
//● Create a constructor that sets all properties except
//Bonus
//● Create a method called AddBonus that adds bonus to
//the Bonus property
//● Override the method GetSalary to return the Salary + Bonus

using Domain.Enums;

namespace Domain.Models
{
    public class Manager : Employee
    {
        private double _Bonus { get; set; }
        public string Department { get; set; }

        public Manager(string firstname, string lastname, double salary, string department)
            : base(firstname, lastname, RoleEnum.Manager, salary)
        {
            _Bonus = 0;
            Department = department;
        }
        public void AddBonus(double amount)
        {
            _Bonus += amount;
        }
        public override double GetSalary()
        {
            return Salary + _Bonus;
            //  return base.GetSalary() + _Bonus;
        }
    }
}
