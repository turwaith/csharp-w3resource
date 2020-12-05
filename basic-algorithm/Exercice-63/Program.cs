/*
Write a C# Sharp program to create a new string using first two characters 
    of a given string.
If the string length is less than 2 then return the original string.
*/
using System;

namespace Exercice_63
{
    class Program
    {
        public static string NewString(string originalString)
        {
            return originalString.Length >= 2 ? originalString[0..2] : originalString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string using first two characters 
    of a given string.
If the string length is less than 2 then return the original string.");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Hi"));
            Console.WriteLine(NewString("H"));
            Console.WriteLine(NewString(""));
        }
    }
}