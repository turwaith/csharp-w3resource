/*
Write a C# Sharp program to create a new string of the first half of a given string of even length
*/
using System;

namespace Exercice_64
{
    class Program
    {
        public static string NewString(string originalString)
        {
            bool isLengthEven = originalString.Length  % 2 == 0;
            return isLengthEven ? originalString[0..(originalString.Length /2)] : originalString[0..((originalString.Length - 1) /2)];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string of the first half of a given string of even length");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Hi"));
            Console.WriteLine(NewString("Nicolas"));
            Console.WriteLine(NewString("Turwaith"));
        }
    }
}
