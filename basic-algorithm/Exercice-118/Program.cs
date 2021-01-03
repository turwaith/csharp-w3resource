/*
Write a C# Sharp program to check if a given array of integers contains no 3 or a 5
*/
using System;
using System.Linq;

namespace Exercice_118
{
    class Program
    {
        public static bool IsInside(int[] numbers)
        {
            return !numbers.Contains(3) || !numbers.Contains(5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a given array of integers contains no 3 or a 5");

            Console.WriteLine(IsInside(new int[]{5,5,5,5,5}));
            Console.WriteLine(IsInside(new int[]{3,3,3,3}));
            Console.WriteLine(IsInside(new int[]{3,3,3,5,5,5}));
            Console.WriteLine(IsInside(new int[]{1,6,8,10}));
        }
    }
}
