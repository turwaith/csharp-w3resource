/*
Write a C# Sharp program to create a new string without 
    he first and last character of a given string of any length
*/
using System;

namespace Exercice_70
{
    class Program
    {
        public static string NewString(string original)
        {
            return original.Length <= 2 ? "String too short" : original[1..^1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string without the first and\n" +
                              "last character of a given string of any length");
        
            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Js"));
            Console.WriteLine(NewString(""));
        }
    }
}
