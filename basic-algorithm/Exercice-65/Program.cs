/*
Write a C# Sharp program to create a new string without the first and last character of a given string of length atleast two
*/
using System;

namespace Exercice_65
{
    class Program
    {
        public static string NewString(string originalString)
        {
            if(originalString.Length < 2) return "The string lenght must be atleast of two";
            if(originalString.Length == 2) return "";
            return originalString[1..^1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string without the first and last character of a given string of length atleast two");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Hi"));
            Console.WriteLine(NewString("Python"));
            Console.WriteLine(NewString("I"));            
        }
    }
}
