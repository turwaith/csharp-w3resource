/*
Write a C# Sharp program that takes the radius of a circle as input
    and calculate the perimeter and area of the circle
*/
using System;

namespace Exercice_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;

            Console.WriteLine(@"Takes the radius of a circle as input
    and calculate the perimeter and area of the circle");

            Console.Write($"Enter the radius of the circle: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The area of circle with a radius of {radius}: {GetCircleArea(radius)}");
            Console.WriteLine($"The perimeter of circle with radius of {radius}: {GetCirclePerimeter(radius)}");
        }

        static double GetCircleArea(int radius)
        {
            return 2 * Math.PI * radius;
        }

        static double GetCirclePerimeter(int radius)
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
