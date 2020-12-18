/*
Write a C# Sharp program to create a new string from a given string.
If the first or first two characters is 'a', return the string without
    those 'a' characters otherwise return the original given string.
*/
using System;

namespace Exercice_87
{
    class Program
    {
        public static string NewString(string original)
        {
            return original.Substring(0,2).Replace('a','\0') +
                original.Substring(2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string from a given string.
If the first or first two characters is 'a', return the string without
    those 'a' characters otherwise return the original given string.");

            Console.WriteLine(NewString("abcab"));
            Console.WriteLine(NewString("python"));
            Console.WriteLine(NewString("aacda"));
            Console.WriteLine(NewString("jython"));
            Console.WriteLine(NewString("bacab"));
        }
    }
}
