/*
Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
Test Data:
    Enter first number - 5
    Enter second number - 6
    Enter third number - 7
Expected Output:
    Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
*/
using System;

namespace Exercice_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Enter the first number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number : ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result of specified numbers {x}, {y}, {z}. (x+y).z is {(x+y)*z} and x.y + y+z is {(x*y) + (y*z)}");
        }
    }
}
