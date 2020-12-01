/*
Write a C# Sharp program to compute the sum of three given integers.
If the two values are same return the third value
*/
using System;

namespace Exercice_55
{
    class Program
    {
        public static int GetSum(int a, int b, int c)
        {
            if(a == b) return c;
            if(b == c) return a;
            if(a == c) return b;
            return a == b ? c : a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the sum of three given integers.
If the two values are same return the third value");
        
            Console.WriteLine(GetSum(4,5,7));
            Console.WriteLine(GetSum(7,4,12));
            Console.WriteLine(GetSum(10,10,12));
            Console.WriteLine(GetSum(12,12,18));
            Console.WriteLine(GetSum(12,10,12));
            Console.WriteLine(GetSum(1,12,12));
        }
    }
}
