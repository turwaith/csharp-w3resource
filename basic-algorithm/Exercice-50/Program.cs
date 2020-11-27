/*
Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit
*/
using System;

namespace Exercice_50
{
    class Program
    {
        public static bool RightMost(int a, int b, int c)
        {
            return a%10 == b%10 || a%10 == c%10 || b%10 == c%10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if two or more non-negative given integers have the same rightmost digit");

            Console.WriteLine(RightMost(11,21,31));
            Console.WriteLine(RightMost(11,22,31));
            Console.WriteLine(RightMost(11,22,33));
        }
    }
}
