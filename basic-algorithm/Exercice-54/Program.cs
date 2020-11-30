/*
Write a C# Sharp program to compute the sum of two given non-negative integers
    x and y as long as the sum has the same number of digits as x.
If the sum has more digits than x then return x without y
 */
using System;

namespace Exercice_54
{
    class Program
    {
        public static int GetSum(int a, int b)
        {
            return a.ToString().Length == (a+b).ToString().Length ? a + b : a;
        }
        public static int GetNumberOfDigit(int a)
        {
            int number = 1;
            while((a/10) != 0)
            {
                a /= 10;
                number++;
            }
            return number;
        }
        public static int GetSumBis(int a, int b)
        {
            return GetNumberOfDigit(a+b) == GetNumberOfDigit(a) ? a + b : a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the sum of two given non-negative integers
    x and y as long as the sum has the same number of digits as x.
If the sum has more digits than x then return x without y");

            Console.WriteLine(GetSum(4,5));
            Console.WriteLine(GetSum(7,4));
            Console.WriteLine(GetSum(10,10));
            Console.WriteLine(GetSum(999,5));
            Console.WriteLine($"{GetSumBis(88,11)}  // GetSumBis");
            Console.WriteLine($"{GetSumBis(88,12)}  // GetSumBis");
        }
    }
}
