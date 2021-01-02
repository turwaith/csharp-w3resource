/*
Write a C# Sharp program to check whether a given array of integers contains 5's and 7's
*/
using System;
using System.Linq;

namespace Exercice_114
{
    class Program
    {
        public static bool FiveOrSevenInside(int[] numbers)
        {
            return numbers.Contains(5) || numbers.Contains(7);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check whether a given array of integers contains 5's and 7's");

            Console.WriteLine(FiveOrSevenInside(new int[]{1,5,6,9,10,17}));
            Console.WriteLine(FiveOrSevenInside(new int[]{1,4,7,9,10,17}));
            Console.WriteLine(FiveOrSevenInside(new int[]{1,1,2,9,10,17}));
        }
    }
}
