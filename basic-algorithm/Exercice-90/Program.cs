/*
Write a C# Sharp program to check two given arrays of integers of
    length 1 or more and return true if they have the same first
    element or they have the same last element
*/
using System;

namespace Exercice_90
{
    class Program
    {
        public static bool IsStartEndEqual(int[] numbersOne, int[] numbersTwo)
        {
            return numbersOne[0] == numbersTwo[0] ||
                   numbersOne[^1] == numbersTwo[^1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check two given arrays of integers of
    length 1 or more and return true if they have the same first
    element or they have the same last element");

            Console.WriteLine(IsStartEndEqual(new int[]{10,20,40,50 },new int[]{10,20,40,50}));
            Console.WriteLine(IsStartEndEqual(new int[]{10,20,40,50 },new int[]{10,20,40,5}));
            Console.WriteLine(IsStartEndEqual(new int[]{10,20,40,50 },new int[]{1,20,40,5}));
        }
    }
}
