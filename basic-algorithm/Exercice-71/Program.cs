/*
Write a C# Sharp program to create a new string using the two middle
    characters of a given string of even length (at least 2)
*/
using System;

namespace Exercice_71
{
    class Program
    {
        public static string NewString(string original)
        {
            return original.Length >= 2 ?
                original.Substring((original.Length - 1) / 2, 2) :
                original;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string using the two middle\n" +
                              "characters of a given string of even length (at least 2)");
        
            Console.WriteLine(NewString("Hell"));
            Console.WriteLine(NewString("JS"));
            Console.WriteLine(NewString("String"));
        }
    }
}
