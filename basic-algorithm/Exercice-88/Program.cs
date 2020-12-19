/*
Write a C# Sharp program to check a given array of integers of length
    1 or more and return true if 10 appears as either first or last
    element in the given array
*/
using System;

namespace Exercice_88
{
    class Program
    {
        public static bool IsTenInside(int[] inputArray)
        {
            return inputArray[0] == 10 || inputArray[^1] == 10;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers of length
    1 or more and return true if 10 appears as either first or last
    element in the given array");

            Console.WriteLine(IsTenInside(new int[]{10,20,40,50}));
            Console.WriteLine(IsTenInside(new int[]{5,20,40,10}));
            Console.WriteLine(IsTenInside(new int[]{10,20,40,10}));
            Console.WriteLine(IsTenInside(new int[]{12,24,35,55}));
        }
    }
}
