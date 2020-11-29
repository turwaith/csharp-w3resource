/*
Write a C# Sharp program to find the larger from two given integers.
However if the two integers have the same remainder when divided by 7,
    then the return the smaller integer.
If the two integers are the same, return 0
 */
using System;

namespace Exercice_52
{
    class Program
    {
        public static int GetLarger(int a, int b)
        {
            if(a == b) return 0;
            else if(a%7 == b%7) return a < b ? a : b;
            else return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Find the larger from two given integers.
However if the two integers have the same remainder when divided by 7,
    then the return the smaller integer.
If the two integers are the same, return 0");

            Console.WriteLine(GetLarger(10,21));
            Console.WriteLine(GetLarger(10,20));
            Console.WriteLine(GetLarger(10,10));
            Console.WriteLine(GetLarger(10,24));
            Console.WriteLine(GetLarger(24,10));
        }
    }
}
