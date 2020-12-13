/*
Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'.
If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz'
    otherwise return the empty string
*/
using System;

namespace Exercice_80
{
    class Program
    {
        public static string StartWith(string original, string startOne = "abc", string startTwo = "xyz")
        {         
            return original.StartsWith(startOne) ? startOne : original.StartsWith(startTwo) ? startTwo : "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check if a given string begins with 'abc' or 'xyz'.
If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz'
    otherwise return the empty string");

            Console.WriteLine(StartWith("abc"));
            Console.WriteLine(StartWith("abcdef"));
            Console.WriteLine(StartWith("C"));
            Console.WriteLine(StartWith("xyz"));
            Console.WriteLine(StartWith("xyzsder"));
        }
    }
}
