/*
Write a C# Sharp program to create a new string of length 2,
    using first two characters of a given string.
If the given string length is less than 2 use '#'
    as missing characters
*/
using System;

namespace Exercice_76
{
    class Program
    {
        public static string NewString(string original)
        {
            return original.Length > 2 ?
                original[0..2] :
                original + new string('#',(2 - original.Length));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string of length 2,
    using first two characters of a given string.
If the given string length is less than 2 use '#'
    as missing characters");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Python"));
            Console.WriteLine(NewString("a"));
            Console.WriteLine(NewString(""));
        }
    }
}
