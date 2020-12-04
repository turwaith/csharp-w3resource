/*
Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1
*/
using System;

namespace Exercice_60
{
    class Program
    {
        public static string NewString(string stringOne, string stringTwo)
        {
            return stringOne+stringTwo+stringTwo+stringOne;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string using two given strings s1, s2," +
                              "the format of the new string will be s1s2s2s1");

            Console.WriteLine(NewString("Hi", "Hello"));
            Console.WriteLine(NewString("whats", "app"));
        }
    }
}
