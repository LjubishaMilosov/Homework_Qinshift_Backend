//Task 1
//Create new console application called“RealCalculator” that takes two numbers from the input
//and asks what operation would the user want to be done ( +, - , * , / ).
//Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25



Console.WriteLine("Enter the First number: ");
bool firstSuccess = double.TryParse(Console.ReadLine(), out double firstNumber);

Console.WriteLine("Enter the Second number: ");
bool secondSuccess = double.TryParse(Console.ReadLine(), out double secondNumber);


Console.WriteLine("Enter the Operation(+, -, *, /); ");
string operation = Console.ReadLine();

double result = 0;
bool validOperation = true;

if(firstSuccess && secondSuccess)
{
    switch(operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;
        case "-":
            result = firstNumber - secondNumber;
            break;
        case "*":
            result = firstNumber * secondNumber;
            break;
        case "/":
            if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                validOperation = false;
            }
            break;
        default:
            Console.WriteLine("Invalid operation.");
            validOperation = false;
            break;
    }
    if (validOperation)
    {
        Console.WriteLine($"The result is: {result}");
    }
}
else
{
    Console.WriteLine("Invalid input for the first or second number.");
}