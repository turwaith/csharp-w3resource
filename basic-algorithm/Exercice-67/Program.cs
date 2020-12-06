/*
Write a C# Sharp program to concat two given string of length atleast 1,
    after removing their first character
*/
using System;

namespace Exercice_67
{
    class Program
    {
        public static string NewString(string stringOne, string stringTwo)
        {
            if(stringOne.Length < 2 && stringTwo.Length < 2) return stringOne + stringTwo;
            else if(stringOne.Length < 2) return stringOne + stringTwo[1..];
            else if(stringTwo.Length < 2) return stringOne[1..] + stringTwo;
            else return stringOne[1..] + stringTwo[1..];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Concat two given string of length atleast 1,\n" +
                              "after removing their first character");
        
            Console.WriteLine(NewString("Hello", "Hi"));
            Console.WriteLine(NewString("JS", "Python"));
            Console.WriteLine(NewString("Hello", "H"));
            Console.WriteLine(NewString("H", "Hello"));
        }
    }
}
