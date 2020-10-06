/*
Write a C# program to compute the sum of all the elements of an array of integers.
    Test Data:
    Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
    Sample Output
    Sum: 69
*/
using System;
using System.Linq;

namespace Exercice_47
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};

            Console.WriteLine("Compute the sum of all the elements of an array of integers.");
            Console.WriteLine($"[{string.Join(",", nums)}]");
            Console.WriteLine($"{nums.Sum()}");
        }
    }
}
