/*
Write a C# Sharp program to create a new string using 3 copies of the first 2
    characters of a given string.
If the length of the given string is less than 2 use the whole string
 */
using System;

namespace Exercice_83
{
    class Program
    {
        public static string NewString(string original)
        {
            return original.Length <= 2 ?
                original + original + original :
                original[0..2] + original[0..2] + original[0..2];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string using 3 copies of the first 2
    characters of a given string.
If the length of the given string is less than 2 use the whole string");

            Console.WriteLine(NewString("abc"));
            Console.WriteLine(NewString("Python"));
            Console.WriteLine(NewString("J"));
        }
    }
}
