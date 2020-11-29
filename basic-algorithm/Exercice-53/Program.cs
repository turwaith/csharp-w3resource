/*
Write a C# Sharp program to check two given integers,
    each in the range 10..99. Return true if a digit
    appears in both numbers, such as the 3 in 13 and 33
*/
using System;

namespace Exercice_53
{
    class Program
    {
        public static bool CheckDigit(int a, int b)
        {
            int aFirst = a / 10,
                aLast  = a % 10,
                bFirst = b / 10,
                bLast  = b % 10;
            
            return aFirst == bFirst ||
                   aFirst == bLast  ||
                   aLast  == bFirst ||
                   aLast  == bLast;            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Write a C# Sharp program to check two given integers,
    each in the range 10..99. Return true if a digit
    appears in both numbers, such as the 3 in 13 and 33");

            Console.WriteLine(CheckDigit(11,21));
            Console.WriteLine(CheckDigit(11,20));
            Console.WriteLine(CheckDigit(10,10));
        }
    }
}
