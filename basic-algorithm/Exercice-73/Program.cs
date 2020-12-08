/*
Write a C# Sharp program to create a new string using the first
    and last n characters from a given string of length at least n
*/
using System;

namespace Exercice_73
{
    class Program
    {
        public static string NewString(string original, int number)
        {
            if(original.Length == 1) return original + original;
            return original[0..(number)] + original[^number..];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string using the first and last n\n" +
                              "characters from a given string of length at least n");

            Console.WriteLine(NewString("Hello", 1));
            Console.WriteLine(NewString("Python", 2));
            Console.WriteLine(NewString("on", 1));
            Console.WriteLine(NewString("o", 1));
        }
    }
}
