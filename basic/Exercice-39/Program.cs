/*
Write a C# program to find the largest and lowest values from three integer values.
    Test Data:
    Input first integer:
    15
    Input second integer:
    25
    Input third integer:
    30
    Sample Output
    Largest of three: 30
    Lowest of three: 15
*/
using System;

namespace Exercice_39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[3];

            Console.Write("Input first integer: ");
            values[0] =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            values[1] =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third integer: ");
            values[2] =  Convert.ToInt32(Console.ReadLine());

            Array.Sort(values);
            Console.WriteLine($"Largest of three: {values[2]}");
            Console.WriteLine($"Lowest of three: {values[0]}");                     
        }
    }
}
