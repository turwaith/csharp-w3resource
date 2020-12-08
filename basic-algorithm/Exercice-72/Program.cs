/*
Write a C# Sharp program to check if a given string ends with "on"
*/
using System;

namespace Exercice_72
{
    class Program
    {
        public static bool EndsWithOn(string stringToVerify)
        {
            return stringToVerify.EndsWith("on");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a given string ends with \"on\"");

            Console.WriteLine(EndsWithOn("Hello"));
            Console.WriteLine(EndsWithOn("Python"));
            Console.WriteLine(EndsWithOn("on"));
            Console.WriteLine(EndsWithOn("o"));
        }
    }
}
