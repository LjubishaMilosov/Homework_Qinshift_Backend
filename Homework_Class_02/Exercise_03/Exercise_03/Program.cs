using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;

//Task 3:
//Create new console application called “SwapNumbers”.
//Input 2 numbers from the console and then swap the values of the variables
//so that the first variable has the second value and the second variable the first value.
//Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

Console.Write("Input the First Number: ");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.Write("Input the Second Number: ");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.WriteLine("Before Swapping:");
Console.WriteLine($"First Number: {firstNumber}");
Console.WriteLine($"Second Number: {secondNumber}");

int temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine("After Swapping:");
Console.WriteLine($"First Number: {firstNumber}");
Console.WriteLine($"Second Number: {secondNumber}");