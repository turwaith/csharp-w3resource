/*
Write a C# Sharp program to compute the sum of values in a given array of
    integers except the number 17. Return 0 if the given array has no integer
*/
using System;
using System.Linq;

namespace Exercice_111
{
    class Program
    {
        public static int GetSum(int[] numbers)
        {
            Console.WriteLine($"Original array: {{{String.Join(",", numbers)}}}");
            return numbers.Sum(item => item != 17 ? item : 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the sum of values in a given array of
    integers except the number 17. Return 0 if the given array has no integer");

            Console.WriteLine($"Sum of values in the array of integers except the number 17: "+
                              $"{GetSum(new int[]{1, 5, 7, 9, 10, 17})}");
        }
    }
}
