//Task 2
//Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

Console.WriteLine("Enter the First number:");
bool firstSucces = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Enter the Second number:");
bool secondSucces = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.WriteLine("Enter the third number:");
bool thirdSucces = int.TryParse(Console.ReadLine(), out int thirdNumber);

Console.WriteLine("Enter the fourth number:");
bool fourthSucces = int.TryParse(Console.ReadLine(), out int fourthNumber);

if(firstSucces && secondSucces && thirdSucces && fourthSucces)
{
    double average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
    Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is: {average}");
} else
{
    Console.WriteLine("Invalid input!");
    return;
}




