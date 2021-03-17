/*
Write a C# Sharp program that takes the radius of a sphere as input and
calculate and display the surface and volume of the sphere
*/
using System;

namespace Exercice_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Takes the radius of a sphere as input and
calculate and display the surface and volume of the sphere");

            double radius = GetNumber("Input the radius of the sphere: ");

            Console.WriteLine($"The surface of the sphere: {(4*Math.PI*Math.Pow(radius,2)), -6:##.###}");
            Console.WriteLine($"The volume of the sphere:  {((4d/3)*Math.PI*Math.Pow(radius,3)), -6:##.###}");
        }

        static double GetNumber(string msg)
        {
            double userInput;

            do
            {
                Console.Write(msg);
            } while (!Double.TryParse(Console.ReadLine(),out userInput));

            return userInput;
        }
    }
}
