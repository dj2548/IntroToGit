using System;
using System.Runtime.CompilerServices;

bool run = true;

while (true)
{

    Console.WriteLine(" Please input the radius of a circle");
    string input = Console.ReadLine();
    double radius = double.Parse(input);

    Console.WriteLine(" Radius: " + radius);

    double area = Math.PI * radius * radius;

    Console.WriteLine(" Area " + area);

    Console.WriteLine("\n");
    Console.WriteLine(" Would you like to measuse another circle?");
    input = Console.ReadLine();
    if (input == "y" || input == "yes")
    { 
    } else {
        Console.WriteLine("Goodbye");
        }
}