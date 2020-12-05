/*
Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two
*/
using System;

namespace Exercice_62
{
    class Program
    {
        public static string NewString(string originalString)
        {
            return originalString.Length >= 2 ? originalString[^2..] + originalString[^2..] + originalString[^2..] : originalString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string using three copies of the last two character of a given string of length atleast two");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Hi"));     
            Console.WriteLine(NewString("Nicolas"));       
        }
    }
}
