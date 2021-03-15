/*
Write a C# Sharp program to display certain values of the function
    x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5)
*/
using System;

namespace Exercice_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Display certain values of the function x = y2 + 2y + 1
(using integer numbers for y , ranging from -5 to +5)");

            Console.WriteLine("x = y² - 2y + 1");

            for(int i = -5, max = 5; i <= max; i++)
                Console.WriteLine($"[y:{i}] -> {i}*{i} - 2*{i} + 1 -> x:{((i*i) - (2*i) + 1)}");
        }
    }
}
