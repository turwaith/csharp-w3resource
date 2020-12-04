/*
Write a C# Sharp program to check three given integers
    (small, medium and large) and return true if the difference between
    small and medium and the difference between medium and large is same
*/
using System;

namespace Exercice_59
{
    class Program
    {
        public static bool CheckDifference(int a, int b, int c)
        {
            return (b-a) == (c-b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check three given integers (small, medium and large)
    and return true if the difference between small and medium and the difference
    between medium and large is same");
        
            Console.WriteLine(CheckDifference(4,5,6));
            Console.WriteLine(CheckDifference(7,12,13));
            Console.WriteLine(CheckDifference(-1,0,1));
        }
    }
}
