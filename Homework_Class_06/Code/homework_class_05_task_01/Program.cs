using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Reflection;
using System;
using homework_class_05_task_01;

//Make a class Driver. Add properties: Name, Skill
//Make a class Car. Add properties: Model, Speed and Driver
//Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.
//Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
//Make 4 car objects and 4 driver objects.
//Ask the user to select a two cars and two drivers for the cars.Add the drivers to the cars and call the RaceCars() methods
//Test Data:
//Choose a car no.1:
//Hyundai
//Mazda
//Ferrari
//Porsche
//Choose Driver:
//Bob
//Greg
//Jill
//Anne
//Choose a car no.2:
//Hyundai
//Mazda
//Ferrari
//Porsche
//Choose Driver:
//Bob
//Greg
//Jill
//Anne
//Expected Output:
//Car no. 2 was faster.
//BONUS 1: If a user chooses option one for the first care, eliminate that option when the user picks car two.

//BONUS 2: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.

//BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.

Car[] cars = new Car[]
{
    new Car { Model = "Hyundai", Speed = 120 },
    new Car { Model = "Mazda", Speed = 200 },
    new Car { Model = "Ferrari", Speed = 120 },
    new Car { Model = "Porsche", Speed = 240 }
};

Driver[] drivers = new Driver[]
{
    new Driver { Name = "Bob", Skill = 10 },
    new Driver { Name = "Greg", Skill = 15 },
    new Driver { Name = "Jill", Skill = 20 },
    new Driver { Name = "Anne", Skill = 25 }
};

while (true)
{
    int car1Index = GetValidCarIndex("Choose a car no.1:", cars);
    Car car1 = cars[car1Index];

    int driver1Index = GetValidDriverIndex("Choose Driver for car no.1:", drivers);
    car1.Driver = drivers[driver1Index];

    int car2Index = GetValidCarIndex("Choose a car no.2:", cars, car1Index);
    Car car2 = cars[car2Index];

    int driver2Index = GetValidDriverIndex("Choose Driver for car no.2:", drivers);
    car2.Driver = drivers[driver2Index];

    RaceCars(car1, car2);

    Console.WriteLine("Press any key to try again or X to exit!");
    if (Console.ReadLine().ToUpper() == "X")
    {
        break;
    }
}

int GetValidCarIndex(string prompt, Car[] cars, int excludeIndex = -1)
{
    int index;
    bool isValid;
    do
    {
        Console.WriteLine(prompt);
        for (int i = 0; i < cars.Length; i++)
        {
            if (i != excludeIndex)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
        }
        isValid = int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= cars.Length && index - 1 != excludeIndex;
        if (!isValid)
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    } while (!isValid);
    return index - 1;
}

int GetValidDriverIndex(string prompt, Driver[] drivers)
{
    int index;
    bool isValid;
    do
    {
        Console.WriteLine(prompt);
        for (int i = 0; i < drivers.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {drivers[i].Name}");
        }
        isValid = int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= drivers.Length;
        if (!isValid)
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    } while (!isValid);
    return index - 1;
}

void RaceCars(Car car1, Car car2)
{
    int car1Speed = car1.CalculateSpeed();
    int car2Speed = car2.CalculateSpeed();

    if (car1Speed > car2Speed)
    {
        Console.WriteLine($"Car no. 1 ({car1.Model}) was faster. Speed: {car1Speed}, Driver: {car1.Driver.Name}");
    }
    else if (car2Speed > car1Speed)
    {
        Console.WriteLine($"Car no. 2 ({car2.Model}) was faster. Speed: {car2Speed}, Driver: {car2.Driver.Name}");
    }
    else
    {
        Console.WriteLine("Both cars are equally fast.");
    }
}