//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today


//while (true)
//{
//    Console.WriteLine("Enter your birthday (yyyy-mm-dd):");
//    string input = Console.ReadLine();
//    if (DateTime.TryParse(input, out DateTime birthday))
//    {
//        if (birthday > DateTime.Today)
//        {
//            Console.WriteLine("The date entered is in the future. Please enter a valid date.");
//        }
//        else
//        {
//            int age = AgeCalculator(birthday);
//            Console.WriteLine($"Your age is: {age}");
//            break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid date format. Please try again.");
//    }
//}


//static int AgeCalculator(DateTime birthday)
//{
//    DateTime today = DateTime.Today;
//    int age = today.Year - birthday.Year;

//    if (birthday.Date > today.AddYears(-age))
//    {
//        age--;
//    }

//    return age;
//}


// another way:

     bool ageCalculatorInterface()
{
    Console.WriteLine("Enter your birthday (yyyy-mm-dd):");
    string input = Console.ReadLine();
    if (DateTime.TryParse(input, out DateTime birthday))
    {
        if (birthday > DateTime.Today)
        {
            Console.WriteLine("The date entered is in the future. Please enter a valid date.");
            return false;
        }
        else
        {
            int age = AgeCalculator(birthday);
            Console.WriteLine($"Your age is: {age}");
            return true;
        }
    }
    else
    {
        Console.WriteLine("Invalid date format. Please try again.");
        return false;
    }
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

while (!ageCalculatorInterface());
Console.ReadLine(); 




