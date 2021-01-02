/*
Write a C# Sharp program to check if the sum of all 5' in the array exactly 15 in a given array of integers
*/
using System;
using System.Linq;

namespace Exercice_115
{
    class Program
    {
        public static bool IsSumEqual(int[] numbers, int numToTest = 5, int totalToTest = 15)
        {
            return numbers.Count(item => item == 5) * numToTest == totalToTest;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if the sum of all 5' in the array exactly 15 in a given array of integers");

            Console.WriteLine(IsSumEqual(new int[]{1,5,6,9,10,17}));
            Console.WriteLine(IsSumEqual(new int[]{1,5,5,5,10,17}));
            Console.WriteLine(IsSumEqual(new int[]{1,1,5,5,5,5}));
        }
    }
}
