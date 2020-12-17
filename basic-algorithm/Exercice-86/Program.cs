/*
Write a C# Sharp program to create a new string from a given string
    without the first and last character if the first or last
    characters are 'a' otherwise return the original given string
*/
using System;

namespace Exercice_86
{
    class Program
    {
        public static string NewString(string original)
        {
            string firstLetter = original.Substring(0,1),
                   lastLetter = original.Substring(original.Length-1,1),
                   middle = original.Substring(1,original.Length-2);
            return (firstLetter == "a" ? "" : firstLetter) +
                   middle +
                   (lastLetter == "a" ? "" : lastLetter);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string from a given string
    without the first and last character if the first or last
    characters are 'a' otherwise return the original given string");

            Console.WriteLine(NewString("abcab"));
            Console.WriteLine(NewString("python"));
            Console.WriteLine(NewString("abcda"));
            Console.WriteLine(NewString("jython"));
        }
    }
}
