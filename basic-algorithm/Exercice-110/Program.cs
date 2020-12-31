/*
Write a C# Sharp program to compute the difference between the largest and
    smallest values in a given array of integers and length one or more
*/
using System;
using System.Linq;

namespace Exercice_110
{
    class Program
    {
        public static int GetDifference(int[] numbers)
        {
            Console.WriteLine($"Original array: {{{String.Join(",", numbers)}}}");
            return numbers.Max() - numbers.Min();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the difference between the largest and
    smallest values in a given array of integers and length one or more");

            Console.WriteLine($"Difference between the largest and smallest values: {GetDifference(new int[]{1, 5, 7, 9, 10, 12})}");
        }
    }
}
