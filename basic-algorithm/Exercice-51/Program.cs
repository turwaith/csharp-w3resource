/*
Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others
*/
using System;
using System.Linq;

namespace Exercice_51
{
    class Program
    {
        public static bool IsLess(int a, int b, int c, int d = 20 )
        {
            int[] numbers = {a,b,c};
            return numbers.Min() + d <= numbers.Max();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check three given integers and return true if one of them is 20 or more less than one of the others");

            Console.WriteLine(IsLess(11,21,31));
            Console.WriteLine(IsLess(11,22,31));
            Console.WriteLine(IsLess(10,20,15));
            Console.WriteLine(IsLess(20,25,0));
        }
    }
}