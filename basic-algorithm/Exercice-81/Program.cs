/*
Write a C# Sharp program to check whether the first two characters and
    last two characters of a given string are same
 */
using System;

namespace Exercice_81
{
    class Program
    {
        public static bool StartEqualsEnd(string original)
        {            
            return original[0..2] == original[^2..];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check whether the first two characters and
    last two characters of a given string are same");

            Console.WriteLine(StartEqualsEnd("abab"));
            Console.WriteLine(StartEqualsEnd("abcdef"));
            Console.WriteLine(StartEqualsEnd("xyzsderxy"));            
        }
    }
}
