/*
Write a C# Sharp program to check if a given array of integers and length 2, contains 15 or 20
*/
using System;
using System.Linq;

namespace Exercice_97
{
    class Program
    {
        public static bool IsNumberInside(int[] numbers, int a = 15, int b = 20)
        {
            return numbers.Contains(a) || numbers.Contains(b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a given array of integers and length 2, contains 15 or 20");

            Console.WriteLine(IsNumberInside(new int[] {12,20}));
            Console.WriteLine(IsNumberInside(new int[] {14,15}));
            Console.WriteLine(IsNumberInside(new int[] {11,21}));
        }
    }
}
