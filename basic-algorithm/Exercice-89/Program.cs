/*
Write a C# Sharp program to check a given array of integers of length
    1 or more and return true if the first element and the
    last element are equal in the given array
*/
using System;

namespace Exercice_89
{
    class Program
    {
        public static bool IsStartEndEqual(int[] numbers)
        {
            return numbers[0] == numbers[^1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers of length
    1 or more and return true if the first element and the
    last element are equal in the given array");
        
        Console.WriteLine(IsStartEndEqual(new int[]{10,20,40,50}));
        Console.WriteLine(IsStartEndEqual(new int[]{10,20,40,10}));
        Console.WriteLine(IsStartEndEqual(new int[]{12,24,35,55}));
        }
    }
}
