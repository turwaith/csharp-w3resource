/*
Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
    Test Data:
    Array1: [1, 2, 5, 7, 8]
    Highest value between first and last values of the said array: 8
*/
using System;
using System.Linq;

namespace Exercice_51
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 5, 7, 8};

            Console.WriteLine("Get the larger value between first and last element of an array (length 3) of integers.");
            Console.WriteLine($"Array: [{string.Join(",", nums)}]cl");

            Console.WriteLine($"Highest value between first and last values of the said array: {nums.Max()}");
        }
    }
}
