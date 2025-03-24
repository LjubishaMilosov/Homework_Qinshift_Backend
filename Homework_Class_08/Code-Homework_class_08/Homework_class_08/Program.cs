//Give the user an option to input numbers
//After inputing each number ask them if they want to input another with a Y/N question
//Store all numbers in a QUEUE
//When the user is done adding numbers print the number in the order
//that the user entered them from the QUEUE


Queue<int> numbers = new Queue<int>();

bool exit = false;
while (!exit)
{
    Console.WriteLine("Please enter a number: ");
    bool isCorrectInput = int.TryParse(Console.ReadLine(), out int input);
 
    if (isCorrectInput)
    {
        numbers.Enqueue(input);
        Console.WriteLine(input + " has been added to the queue.");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    {
       
    Console.WriteLine("Press any key to try again or X to exit!");
        if (Console.ReadLine().ToUpper() == "X")
        {
            exit = true;
        }
    }

}
Console.WriteLine("The numbers, in the order you have entered, are: ");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}