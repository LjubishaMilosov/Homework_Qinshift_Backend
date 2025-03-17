
Console.WriteLine("Enter your birthday (yyyy-mm-dd):");
string input = Console.ReadLine();
if (DateTime.TryParse(input, out DateTime birthday))
{
    int age = AgeCalculator(birthday);
    Console.WriteLine($"Your age is: {age}");
}
else
{
    Console.WriteLine("Invalid date format.");
}


static int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;

    if (birthday.Date > today.AddYears(-age))
    {
        age--;
    }

    return age;
}




