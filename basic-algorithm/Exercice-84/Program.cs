/*
Write a C# Sharp program to create a new string from a given string.
If the two characters of the given string from its beginning
    and end are same return the given string without the first
    two characters otherwise return the original string
*/
using System;

namespace Exercice_84
{
    class Program
    {
        public static string NewString(string original)
        {
            return original[0..2] == original[^2..] ?
                original[2..] :
                original;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string from a given string.
If the two characters of the given string from its beginning
    and end are same return the given string without the first
    two characters otherwise return the original string");

            Console.WriteLine(NewString("abcab"));
            Console.WriteLine(NewString("Python"));
            Console.WriteLine(NewString("aaHelloaa"));
        }
    }
}
