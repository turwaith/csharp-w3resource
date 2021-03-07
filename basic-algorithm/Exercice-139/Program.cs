/*
Write a C# Sharp program to check a positive integer and return true if it contains a number 2
*/
using System;

namespace Exercice_139
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a positive integer and return true if it contains a number 2");

            Console.WriteLine(123.ContainsNumber(2));
            Console.WriteLine(13.ContainsNumber(2));
            Console.WriteLine(222.ContainsNumber(2));
        }

    }
    public static class Extension
    {
        public static bool ContainsNumber(this int numbers, int number)
        {
            string nb = numbers.ToString();

            Console.Write($"{nb} -> ");
            
            return nb.Contains(number.ToString());
        }
    }
}
