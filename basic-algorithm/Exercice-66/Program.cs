/*
Write a C# Sharp program to create a new string from two given string
    one is shorter and another is longer.
The format of the new string will be long string + short string + long string
*/
using System;

namespace Exercice_66
{
    class Program
    {
        public static string NewString(string stringOne, string stringTwo)
        {
            return stringOne.Length > stringTwo.Length ?
                   stringOne + stringTwo + stringOne :
                   stringTwo + stringOne + stringTwo;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string from two given string
    one is shorter and another is longer.
The format of the new string will be long string + short string + long string");

            Console.WriteLine(NewString("Hello", "Hi"));
            Console.WriteLine(NewString("JS", "Python"));
        }
    }
}
